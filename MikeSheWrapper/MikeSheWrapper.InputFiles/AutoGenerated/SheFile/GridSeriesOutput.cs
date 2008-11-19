using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class GridSeriesOutput: PFSMapper
  {

    private List<Item_13> _item_1s = new List<Item_13>();

    internal GridSeriesOutput(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
          default:
            if (sub.Name.Substring(0,6).Equals("Item_1"))
            {
              _item_1s.Add(new Item_13(sub));
              break;
            }
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public List<Item_13> Item_1s
   {
     get { return _item_1s; }
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

    public int NumberOfItems
    {
      get
      {
        return _pfsHandle.GetKeyword("NumberOfItems", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("NumberOfItems", 1).GetParameter(1).Value = value;
      }
    }

  }
}
