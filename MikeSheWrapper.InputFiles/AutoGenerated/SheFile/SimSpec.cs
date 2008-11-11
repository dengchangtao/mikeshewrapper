using System;
using System.Collections.Generic;
using DHI.Generic.MikeZero;

namespace MikeSheWrapper.InputFiles
{
  /// <summary>
  /// This is an autogenerated class. Do not edit. 
  /// If you want to add methods create a new partial class in another file
  /// </summary>
  public partial class SimSpec: PFSMapper
  {

    private ModelComp _modelComp;
    private ModModelComp _modModelComp;
    private SimTitle _simTitle;
    private SimulationPeriod _simulationPeriod;
    private STRESSPERIODS _sTRESSPERIODS;
    private CompControlParaTimeStep _compControlParaTimeStep;
    private CompControlParaOL _compControlParaOL;
    private CompControlParaUZ _compControlParaUZ;
    private CompControlParaSZ _compControlParaSZ;
    private CompControlParaModPackage _compControlParaModPackage;
    private AirFlowSimulationParametersMod _airFlowSimulationParametersMod;
    private CompControlParaModSZ _compControlParaModSZ;

    internal SimSpec(PFSSection Section)
    {
      _pfsHandle = Section;

      for (int i = 1; i <= Section.GetSectionsNo(); i++)
      {
        PFSSection sub = Section.GetSection(i);
        switch (sub.Name)
        {
        case "ModelComp":
          _modelComp = new ModelComp(sub);
          break;
        case "ModModelComp":
          _modModelComp = new ModModelComp(sub);
          break;
        case "SimTitle":
          _simTitle = new SimTitle(sub);
          break;
        case "SimulationPeriod":
          _simulationPeriod = new SimulationPeriod(sub);
          break;
        case "STRESSPERIODS":
          _sTRESSPERIODS = new STRESSPERIODS(sub);
          break;
        case "CompControlParaTimeStep":
          _compControlParaTimeStep = new CompControlParaTimeStep(sub);
          break;
        case "CompControlParaOL":
          _compControlParaOL = new CompControlParaOL(sub);
          break;
        case "CompControlParaUZ":
          _compControlParaUZ = new CompControlParaUZ(sub);
          break;
        case "CompControlParaSZ":
          _compControlParaSZ = new CompControlParaSZ(sub);
          break;
        case "CompControlParaModPackage":
          _compControlParaModPackage = new CompControlParaModPackage(sub);
          break;
        case "AirFlowSimulationParametersMod":
          _airFlowSimulationParametersMod = new AirFlowSimulationParametersMod(sub);
          break;
        case "CompControlParaModSZ":
          _compControlParaModSZ = new CompControlParaModSZ(sub);
          break;
          default:
            _unMappedSections.Add(sub.Name);
          break;
        }
      }
    }

    public ModelComp ModelComp
    {
     get { return _modelComp; }
    }

    public ModModelComp ModModelComp
    {
     get { return _modModelComp; }
    }

    public SimTitle SimTitle
    {
     get { return _simTitle; }
    }

    public SimulationPeriod SimulationPeriod
    {
     get { return _simulationPeriod; }
    }

    public STRESSPERIODS STRESSPERIODS
    {
     get { return _sTRESSPERIODS; }
    }

    public CompControlParaTimeStep CompControlParaTimeStep
    {
     get { return _compControlParaTimeStep; }
    }

    public CompControlParaOL CompControlParaOL
    {
     get { return _compControlParaOL; }
    }

    public CompControlParaUZ CompControlParaUZ
    {
     get { return _compControlParaUZ; }
    }

    public CompControlParaSZ CompControlParaSZ
    {
     get { return _compControlParaSZ; }
    }

    public CompControlParaModPackage CompControlParaModPackage
    {
     get { return _compControlParaModPackage; }
    }

    public AirFlowSimulationParametersMod AirFlowSimulationParametersMod
    {
     get { return _airFlowSimulationParametersMod; }
    }

    public CompControlParaModSZ CompControlParaModSZ
    {
     get { return _compControlParaModSZ; }
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

    public int ModelType
    {
      get
      {
        return _pfsHandle.GetKeyword("ModelType", 1).GetParameter(1).ToInt();
      }
      set
      {
        _pfsHandle.GetKeyword("ModelType", 1).GetParameter(1).Value = value;
      }
    }

  }
}
