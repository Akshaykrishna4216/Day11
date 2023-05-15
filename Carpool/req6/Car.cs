using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Car
{
    private long _id;

    public long Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private string _model;

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    private Int32 _makeYear;

    public Int32 MakeYear
    {
        get { return _makeYear; }
        set { _makeYear = value; }
    }
    private string _company;

    public string Company
    {
        get { return _company; }
        set { _company = value; }
    }
    private Int32 _comfortLevel;

    public Int32 ComfortLevel
    {
        get { return _comfortLevel; }
        set { _comfortLevel = value; }
    }
    public Car()
    {
    }
    public Car(long id, string name, string model, Int32 makeYear, string company, Int32 comfortLevel)
    {
        this._id = id;
        this._name = name;
        this._model = model;
        this._makeYear = makeYear;
        this._company = company;
        this._comfortLevel = comfortLevel;
    }

}