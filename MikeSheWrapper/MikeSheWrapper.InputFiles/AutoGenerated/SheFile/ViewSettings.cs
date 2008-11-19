using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class ViewSettings: PFSMapper
  {


    internal ViewSettings(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public int Touched
    {
      get
      {
        return _pfsHandle.GetKeyword("Touched", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Touched", 1).GetParameter(1).Value = value;
      }
    }

    public int IsDataUsedInSetup
    {
      get
      {
        return _pfsHandle.GetKeyword("IsDataUsedInSetup", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("IsDataUsedInSetup", 1).GetParameter(1).Value = value;
      }
    }

    public int ShowValidationIcons
    {
      get
      {
        return _pfsHandle.GetKeyword("ShowValidationIcons", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("ShowValidationIcons", 1).GetParameter(1).Value = value;
      }
    }

    public int DefaultZoomDataAreaUndefined
    {
      get
      {
        return _pfsHandle.GetKeyword("DefaultZoomDataAreaUndefined", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DefaultZoomDataAreaUndefined", 1).GetParameter(1).Value = value;
      }
    }

    public int DefaultZoomDataArea_X0
    {
      get
      {
        return _pfsHandle.GetKeyword("DefaultZoomDataArea_X0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DefaultZoomDataArea_X0", 1).GetParameter(1).Value = value;
      }
    }

    public int DefaultZoomDataArea_Y0
    {
      get
      {
        return _pfsHandle.GetKeyword("DefaultZoomDataArea_Y0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DefaultZoomDataArea_Y0", 1).GetParameter(1).Value = value;
      }
    }

    public int DefaultZoomDataArea_X1
    {
      get
      {
        return _pfsHandle.GetKeyword("DefaultZoomDataArea_X1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DefaultZoomDataArea_X1", 1).GetParameter(1).Value = value;
      }
    }

    public int DefaultZoomDataArea_Y1
    {
      get
      {
        return _pfsHandle.GetKeyword("DefaultZoomDataArea_Y1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DefaultZoomDataArea_Y1", 1).GetParameter(1).Value = value;
      }
    }

    public int MaxZoomDataAreaUndefined
    {
      get
      {
        return _pfsHandle.GetKeyword("MaxZoomDataAreaUndefined", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MaxZoomDataAreaUndefined", 1).GetParameter(1).Value = value;
      }
    }

    public int MaxZoomDataArea_X0
    {
      get
      {
        return _pfsHandle.GetKeyword("MaxZoomDataArea_X0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MaxZoomDataArea_X0", 1).GetParameter(1).Value = value;
      }
    }

    public int MaxZoomDataArea_Y0
    {
      get
      {
        return _pfsHandle.GetKeyword("MaxZoomDataArea_Y0", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MaxZoomDataArea_Y0", 1).GetParameter(1).Value = value;
      }
    }

    public int MaxZoomDataArea_X1
    {
      get
      {
        return _pfsHandle.GetKeyword("MaxZoomDataArea_X1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MaxZoomDataArea_X1", 1).GetParameter(1).Value = value;
      }
    }

    public int MaxZoomDataArea_Y1
    {
      get
      {
        return _pfsHandle.GetKeyword("MaxZoomDataArea_Y1", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MaxZoomDataArea_Y1", 1).GetParameter(1).Value = value;
      }
    }

  }
}
