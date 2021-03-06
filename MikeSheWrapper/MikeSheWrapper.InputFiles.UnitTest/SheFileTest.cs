﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace MikeSheWrapper.InputFiles.UnitTest
{
  [TestFixture]
  public class SheFileTest
  {

    private SheFile _she;

    [SetUp]
    public void ConstructTest()
    {
      _she = new SheFile(@"..\..\..\TestData\TestModel.she");
    }


    [Test]
    public void ReadDetailedTSTest()
    {
      Assert.AreEqual(2, _she.MIKESHE_FLOWMODEL.StoringOfResults.DetailedTimeseriesOutput.Item_1s.Count);
    }


    [Test]
    public void ReadTest()
    {
      Assert.AreEqual(1, _she.MIKESHE_FLOWMODEL.SimSpec.ModelComp.WM);

      Assert.AreEqual(Path.GetFullPath(@"..\..\..\TestData\Model Domain and Grid.dfs2"), _she.MIKESHE_FLOWMODEL.Catchment.DFS_2D_DATA_FILE.FILE_NAME);

      Assert.AreEqual(4, _she.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1.Count);
      Assert.AreEqual("140", _she.MIKESHE_FLOWMODEL.LandUse.CommandAreas.CommandAreas1[0].AreaName);

      Assert.AreEqual(new DateTime(2000, 1, 1, 0, 0, 0), _she.MIKESHE_FLOWMODEL.SimSpec.SimulationPeriod.StartTime);
      Assert.AreEqual(new DateTime(2000, 2, 1, 0, 0, 0), _she.MIKESHE_FLOWMODEL.SimSpec.SimulationPeriod.EndTime );

    }

    [Test]
    public void ModifyTest()
    {

      _she.MIKESHE_FLOWMODEL.LandUse.CommandAreas.AddNewCommandArea();

      _she.MIKESHE_FLOWMODEL.SimSpec.SimulationPeriod.EndTime = DateTime.Now;
      _she.MIKESHE_FLOWMODEL.SimSpec.SimulationPeriod.StartTime  = DateTime.Now;
      _she.SaveAs(@"..\..\..\TestData\TestModel_changed.she");

    }

    [Test]
    public void WriteTest()
    {
      _she.MIKESHE_FLOWMODEL.SimSpec.ModelComp.WM = 0;
      _she.SaveAs(@"..\..\..\TestData\TestModel_changed.she");
    }

  }
}
