using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class Item_11: PFSMapper
  {

    private DFS_2D_DATA_FILE _tIME_SERIES_FILE;

    internal Item_11(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
        case "TIME_SERIES_FILE":
          _tIME_SERIES_FILE = new DFS_2D_DATA_FILE(sub);
          break;
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public DFS_2D_DATA_FILE TIME_SERIES_FILE
    {
     get { return _tIME_SERIES_FILE; }
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

    public string Name
    {
      get
      {
        return _pfsHandle.GetKeyword("Name", 1).GetParameter(1).ToString();
      }
      set
      {
        _pfsHandle.GetKeyword("Name", 1).GetParameter(1).Value = value;
      }
    }

    public int HydrComp
    {
      get
      {
        return _pfsHandle.GetKeyword("HydrComp", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("HydrComp", 1).GetParameter(1).Value = value;
      }
    }

    public int Group
    {
      get
      {
        return _pfsHandle.GetKeyword("Group", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Group", 1).GetParameter(1).Value = value;
      }
    }

    public int X
    {
      get
      {
        return _pfsHandle.GetKeyword("X", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("X", 1).GetParameter(1).Value = value;
      }
    }

    public int Y
    {
      get
      {
        return _pfsHandle.GetKeyword("Y", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("Y", 1).GetParameter(1).Value = value;
      }
    }

    public double Z
    {
      get
      {
        return _pfsHandle.GetKeyword("Z", 1).GetParameter(1).ToDouble();
      }
      set
      {
        _pfsHandle.GetKeyword("Z", 1).GetParameter(1).Value = value;
      }
    }

    public int InclObserved
    {
      get
      {
        return _pfsHandle.GetKeyword("InclObserved", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("InclObserved", 1).GetParameter(1).Value = value;
      }
    }

  }
}
