﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MikeSheWrapper;
using MikeSheWrapper.Tools;
using MikeSheWrapper.InputFiles;

namespace MikeSheWrapper.Irrigation
{
  public class Controller
  {
    private Model _she;
    private Configuration _config;
    private List<IrrigationWell> _wells = new List<IrrigationWell>();


    public Controller(Configuration Config)
    {
      _config = Config;
      _she = new Model(_config.SheFile);

    }
    /// <summary>
    /// Reads in wells from the shape, adds them to the model and rund the model.
    /// </summary>
    public void Run()
    {
      ReadWellsFromShape();
      InsertIrrigationWells();

      //Make sure that i both preprocesses and runs
      _she.Input.MIKESHE_FLOWMODEL.ExecuteEngineFlagsPfs.PP = 1;
      _she.Input.MIKESHE_FLOWMODEL.ExecuteEngineFlagsPfs.WM = 1;

      SaveAs(_config.SheFile);
      MSheLauncher.PreprocessAndRun(_config.SheFile, true);
      if (_config.DeleteWellsAfterRun)
      {
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.ClearCommandAreas();
        SaveAs(_config.SheFile);
      }
      _she.Dispose();
    }

    /// <summary>
    /// Gets or sets a boolean to see if irrigation is enabled
    /// </summary>
    public bool IrrigationEnabled
    {
      get
      {
        return _she.Input.MIKESHE_FLOWMODEL.LandUse.Irrigation == 1;
      }
      set
      {
        if (value)
          _she.Input.MIKESHE_FLOWMODEL.LandUse.Irrigation = 1;
        else
          _she.Input.MIKESHE_FLOWMODEL.LandUse.Irrigation = 0;
      }
    }

    public void ReadWellsFromShape()
    {
      PointShapeReader SR = new PointShapeReader(_config.WellShapeFile);
      DataTable _wellData = SR.Data.Read();
      SR.Dispose();
      
      foreach (DataRow dr in _wellData.Rows)
      {
        IrrigationWell IW = new IrrigationWell(dr[_config.IdHeader].ToString());
          IW.X =  Convert.ToDouble(dr[_config.XHeader]);
          IW.Y = Convert.ToDouble(dr[_config.YHeader]);

        IIntake I = IW.AddNewIntake(1);

        IW.MaxDepth = Convert.ToDouble(dr[_config.MaxDepthHeader]);
        IW.MaxRate = Convert.ToDouble(dr[_config.MaxRateHeader]);

        Screen CurrentScreen = new Screen(I);
        CurrentScreen.DepthToBottom =  Convert.ToDouble(dr[_config.BottomHeader]);
        CurrentScreen.DepthToTop = Convert.ToDouble(dr[_config.TopHeader]);
        _wells.Add(IW);
      }
      _wellData.Dispose();
    }

    public void InsertIrrigationWells()
    {
      //Include irrigation
      IrrigationEnabled = true;
      
      //Clear all commandareas.
      _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.ClearCommandAreas();

 
      //Note. It is assumed that the wells are ordered in the same way as the shapes
      for (int i = 0; i < _wells.Count; i++) 
      {
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.AddNewSingleWellCommandArea();

        int AreaCode;
        if (int.TryParse(_wells[i].ID, out AreaCode))
          _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].AreaCode = AreaCode;
        else
          _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].AreaCode = 0;

        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].AreaCodeID = _wells[i].ID;
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].AreaName  = _wells[i].ID;
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].Sources.Source1.WellXposSIWS = _wells[i].X;
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].Sources.Source1.WellYposSIWS = _wells[i].Y;

        //Use this if top and bottom are in m.a.s.l.
        //double Topo = _she.GridInfo.SurfaceTopography.GetData(_wells[i].X, _wells[i].Y);

        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].Sources.Source1.ScreenTopDepthSIWS  = _wells[i].Intakes.First().Screens[0].DepthToTop;
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].Sources.Source1.ScreenBottomDepthSIWS = _wells[i].Intakes.First().Screens[0].DepthToBottom;
        _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[i].Sources.Source1.ThresholdDepthSIWS = _wells[i].Intakes.First().Screens[0].DepthToBottom;

      }
      _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.Type = 2;
      _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.SHAPE_FILE.FILE_NAME = _config.WellShapeFile;
      _she.Input.MIKESHE_FLOWMODEL.LandUse.CommandAreas.SHAPE_FILE.ITEM_NUMBERS = _config.IdHeader;


    }

    public void SaveAs(string FileName)
    {
      _she.Input.SaveAs(FileName);
    }

  }
}
