﻿using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace MikeSheWrapper.Tools
{
  public class PointShapeReader:Shape
  {
    private DBFReader _data;

    public PointShapeReader(string FileName)
    {
      _fileName = FileName;
      if (!File.Exists(FileName))
        throw new FileNotFoundException("Could not find the file: " + FileName);
      _data = new DBFReader(FileName);

      // Open shapefile
      _shapePointer = ShapeLib.SHPOpen(FileName, "rb");
    }

    /// <summary>
    /// Reads next shape and increments counter
    /// </summary>
    /// <param name="X"></param>
    /// <param name="Y"></param>
    public void ReadNext(out double X, out double Y)
    {
      IntPtr pShape = ShapeLib.SHPReadObject(_shapePointer, _recordPointer);
      ShapeLib.SHPObject shpObject = new ShapeLib.SHPObject();
      Marshal.PtrToStructure(pShape, shpObject);
      double[] x = new double[shpObject.nVertices];
      Marshal.Copy(shpObject.padfX, x, 0, x.Length);
      double[] y = new double[shpObject.nVertices];
      Marshal.Copy(shpObject.padfX, y, 0, y.Length);

      X= x[0];
      ShapeLib.SHPDestroyObject(pShape);
      Y = y[0];
      _recordPointer++;

    }


    /// <summary>
    /// Disposes the shapefile
    /// </summary>
    public override void Dispose()
    {
      _data.Dispose();
      base.Dispose();
    }

    public DBFReader Data
    {
      get { return _data; }
    }

  }
}
