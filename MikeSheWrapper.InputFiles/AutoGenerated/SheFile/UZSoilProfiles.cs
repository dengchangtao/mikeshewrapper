using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class UZSoilProfiles: PFSMapper
  {

    private DFS_2D_DATA_FILE _dFS_2D_DATA_FILE;
    private SHAPE_FILE _sHAPE_FILE;
    private UZSoilProfileProp _uZSoilProfileProp;

    internal UZSoilProfiles(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
        case "DFS_2D_DATA_FILE":
          _dFS_2D_DATA_FILE = new DFS_2D_DATA_FILE(sub);
          break;
        case "SHAPE_FILE":
          _sHAPE_FILE = new SHAPE_FILE(sub);
          break;
        case "UZSoilProfileProp":
          _uZSoilProfileProp = new UZSoilProfileProp(sub);
          break;
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public DFS_2D_DATA_FILE DFS_2D_DATA_FILE
    {
     get { return _dFS_2D_DATA_FILE; }
    }

    public SHAPE_FILE SHAPE_FILE
    {
     get { return _sHAPE_FILE; }
    }

    public UZSoilProfileProp UZSoilProfileProp
    {
     get { return _uZSoilProfileProp; }
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

    public int DistributionType
    {
      get
      {
        return _pfsHandle.GetKeyword("DistributionType", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("DistributionType", 1).GetParameter(1).Value = value;
      }
    }

    public int Type
    {
      get
      {
        return _pfsHandle.GetKeyword("Type", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Type", 1).GetParameter(1).Value = value;
      }
    }

    public int ShapeAxisUnit
    {
      get
      {
        return _pfsHandle.GetKeyword("ShapeAxisUnit", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("ShapeAxisUnit", 1).GetParameter(1).Value = value;
      }
    }

    public string ShapeGapFillName
    {
      get
      {
        return _pfsHandle.GetKeyword("ShapeGapFillName", 1).GetParameter(1).ToString();
      }
      set
      {
        _pfsHandle.GetKeyword("ShapeGapFillName", 1).GetParameter(1).Value = value;
      }
    }

    public int NO_SOIL_PROFILES
    {
      get
      {
        return _pfsHandle.GetKeyword("NO_SOIL_PROFILES", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("NO_SOIL_PROFILES", 1).GetParameter(1).Value = value;
      }
    }

  }
}
