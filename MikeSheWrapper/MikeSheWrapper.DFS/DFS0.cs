﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MikeSheWrapper.DFS
{
  public class DFS0 : DFSBase
  {
    public DFS0(string DFSFileName)
      : base(DFSFileName)
    {

    }

    /// <summary>
    /// Gets the value for the Time step and Item
    /// </summary>
    /// <param name="TimeStep"></param>
    /// <param name="Item"></param>
    /// <returns></returns>
    public double GetData(int TimeStep, int Item)
    {
      ReadItemTimeStep(TimeStep, Item);
      return dfsdata[0];
    }

    /// <summary>
    /// Gets the value for the Time step and Item
    /// </summary>
    /// <param name="TimeStep"></param>
    /// <param name="Item"></param>
    /// <returns></returns>
    public double GetData(DateTime TimeStep, int Item)
    {
      return GetData(GetTimeStep(TimeStep), Item);
    }
  }
}
