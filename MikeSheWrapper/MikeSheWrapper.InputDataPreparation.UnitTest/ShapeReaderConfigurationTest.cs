﻿using System;
using System.IO;
using System.Xml.Serialization;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MikeSheWrapper.InputDataPreparation;

namespace MikeSheWrapper.InputDataPreparation.UnitTest
{
  [TestFixture]
  public class ShapeReaderConfigurationTest
  {
    [Test]
    public void CreateXml()
    {
      ShapeReaderConfiguration SRC = new ShapeReaderConfiguration();

      SRC.XHeader = "XUTM";
      SRC.YHeader = "YUTM";
      SRC.WellIDHeader = "NOVANAID";
      SRC.TOPHeader = "INTAKMIDK";

      XmlSerializer x = new XmlSerializer(typeof(ShapeReaderConfiguration));
      using (FileStream fs = new FileStream(@"..\..\..\ThirdpartyBinaries\Config.xml", FileMode.Create ))
      {
        x.Serialize(fs,SRC);
      }

      ShapeReaderConfiguration SRC2;

      using (FileStream fs = new FileStream(@"..\..\..\ThirdpartyBinaries\Config.xml", FileMode.Open))
      {
        SRC2 = (ShapeReaderConfiguration)x.Deserialize(fs);
      }

      Assert.AreEqual(SRC.XHeader, SRC2.XHeader);
      Assert.AreEqual(SRC.YHeader, SRC2.YHeader);
      Assert.AreEqual(SRC.WellIDHeader, SRC2.WellIDHeader);
      Assert.AreEqual(SRC.TOPHeader, SRC2.TOPHeader);
      

    }
  }
}
