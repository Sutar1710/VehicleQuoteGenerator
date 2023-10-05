using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleQuote.Shared
{
 public class VehiclesIDV
  {
    private string _vehicleType;
    private string _make;
    private string _model;
    private int _idv;
    public VehiclesIDV(string vehicleType, string make, string model, int idv)
    {
      this._vehicleType = vehicleType;
      this._make = make;
      this._model = model;
      this._idv = idv;

    }



    public string vehicleType
    {
      get => this._vehicleType;
      set => this._vehicleType = value;

    }
    public string Make
    {
      get => this._make;
      set => this._make = value;

    }
    public string Model
    {
      get => this._model;
      set => this._model = value;

    }
    public int IDV
    {
      get => this._idv;
      set => this._idv = value;

    }


  }
}
