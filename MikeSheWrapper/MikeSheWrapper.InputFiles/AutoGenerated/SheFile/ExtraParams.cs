using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class ExtraParams: PFSMapper
  {

    private List<ExtraParam_1> _extraParam_1s = new List<ExtraParam_1>();

    internal ExtraParams(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
          default:
            if (sub.Name.Substring(0,6).Equals("ExtraP"))
            {
              _extraParam_1s.Add(new ExtraParam_1(sub));
              break;
            }
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public List<ExtraParam_1> ExtraParam_1s
   {
     get { return _extraParam_1s; }
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

    public int MzSEPfsListItemCount
    {
      get
      {
        return _pfsHandle.GetKeyword("MzSEPfsListItemCount", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("MzSEPfsListItemCount", 1).GetParameter(1).Value = value;
      }
    }

    public int NoOfParams
    {
      get
      {
        return _pfsHandle.GetKeyword("NoOfParams", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("NoOfParams", 1).GetParameter(1).Value = value;
      }
    }

  }
}
