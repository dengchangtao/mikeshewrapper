using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class OutputModflow: PFSMapper
  {

    private OutputDates _outputDates;
    private OutputDates _outputTimesteps;
    private PackagesOutput _packagesOutput;

    internal OutputModflow(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
        case "OutputDates":
          _outputDates = new OutputDates(sub);
          break;
        case "OutputTimesteps":
          _outputTimesteps = new OutputDates(sub);
          break;
        case "PackagesOutput":
          _packagesOutput = new PackagesOutput(sub);
          break;
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public OutputDates OutputDates
    {
     get { return _outputDates; }
    }

    public OutputDates OutputTimesteps
    {
     get { return _outputTimesteps; }
    }

    public PackagesOutput PackagesOutput
    {
     get { return _packagesOutput; }
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

    public int OutputControlOption
    {
      get
      {
        return _pfsHandle.GetKeyword("OutputControlOption", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("OutputControlOption", 1).GetParameter(1).Value = value;
      }
    }

    public int StoringTimeStep
    {
      get
      {
        return _pfsHandle.GetKeyword("StoringTimeStep", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("StoringTimeStep", 1).GetParameter(1).Value = value;
      }
    }

    public int StoringTimeStepHours
    {
      get
      {
        return _pfsHandle.GetKeyword("StoringTimeStepHours", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("StoringTimeStepHours", 1).GetParameter(1).Value = value;
      }
    }

    public int ModPath
    {
      get
      {
        return _pfsHandle.GetKeyword("ModPath", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("ModPath", 1).GetParameter(1).Value = value;
      }
    }

  }
}
