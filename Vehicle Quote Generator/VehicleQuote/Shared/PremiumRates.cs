using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleQuote.Shared
{
  public class PremiumRates
  {

    private string _vehicleType;
    private double _comprehensiveCoverage;
    private int _limitedlibality;
    public PremiumRates(string vehicleType, double comprehensiveCoverage, int limitedlibality)
    {
      this._vehicleType = vehicleType;
      this._comprehensiveCoverage = comprehensiveCoverage;
      this._limitedlibality = limitedlibality;
    }
    public string VehicleType
    {

      get { return this._vehicleType; }   // get method
      set { this._vehicleType = value; }  // set method

    }
    public int Limitedlibality
    {

      get { return this._limitedlibality; }   // get method
      set { this._limitedlibality = value; }  // set method

    }
    public double comprehensiveCoverage
    {

      get { return this._comprehensiveCoverage; }   // get method
      set { this._comprehensiveCoverage = value; }  // set method
    }

  }
}
