﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MikeSheWrapper.Tools;

namespace MikeSheWrapper.JupiterTools
{
  /// <summary>
  /// A class representing a water production plant. Holds the historical pumping time series and the associated wells
  /// </summary>
  public class Plant:IComparable<Plant>
  {

    #region Properties

    /// <summary>
    /// Unique ID number
    /// </summary>
    public int IDNumber { get; private set; }

    /// <summary>
    /// Timeseries with extraction rates. 
    /// </summary>
    public List<TimeSeriesEntry> Extractions { get; private set; }
    
    /// <summary>
    /// Time series with extraction from surface water.
    /// </summary>
    public List<TimeSeriesEntry> SurfaceWaterExtrations { get; private set; }
    
    /// <summary>
    /// The intakes associated to this plant
    /// </summary>
    public BindingList<PumpingIntake> PumpingIntakes { get; private set; }
    private bool PumpingIntakesChanged = true;
    private List<IWell> wells;

    public List<IWell> PumpingWells
    {
      get
      {
        if (PumpingIntakesChanged)
        {
          wells = new List<IWell>();
          foreach (PumpingIntake PI in PumpingIntakes)
            if (!wells.Contains(PI.Intake.well))
              wells.Add(PI.Intake.well);
        }
        return wells;
      }
    }

    public List<Plant> SubPlants { get; private set; }

    /// <summary>
    /// The name of the plant
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The street where the plant is located
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// The postal code
    /// </summary>
    public int PostalCode { get; set; }

    /// <summary>
    /// The permit was given at this date
    /// </summary>
    public DateTime PermitDate { get; set; }

    /// <summary>
    /// The date at which this permit expires
    /// </summary>
    public DateTime PermitExpiryDate { get; set; }

    /// <summary>
    /// The yearly permit in m3
    /// </summary>
    public double Permit { get; set; }

    #endregion

    public Plant(int IDNumber)
    {
      Extractions = new List<TimeSeriesEntry>();
      PumpingIntakes = new BindingList<PumpingIntake>();

      PumpingIntakes.ListChanged += new ListChangedEventHandler(PumpingIntakes_ListChanged);
      
      SurfaceWaterExtrations = new List<TimeSeriesEntry>();
      SubPlants = new List<Plant>();
      this.IDNumber = IDNumber;
    }

    void PumpingIntakes_ListChanged(object sender, ListChangedEventArgs e)
    {
      PumpingIntakesChanged = true;
    }


    public override string ToString()
    {
      if (Name != null)
        return Name;
      else
        return IDNumber.ToString();
    }

    #region IComparable<Plant> Members

    /// <summary>
    /// Compares the name
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public int CompareTo(Plant other)
    {
      return Name.CompareTo(other.Name);
    }

    #endregion
  }
}
