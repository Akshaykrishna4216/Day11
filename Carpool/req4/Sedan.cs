using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

class Sedan : Car
{
    private bool _absEnabled;

    public bool AbsEnabled
    {
        get { return _absEnabled; }
        set { _absEnabled = value; }
    }
    private Int32 _bootSpace;

    public Int32 BootSpace
    {
        get { return _bootSpace; }
        set { _bootSpace = value; }
    }
    public Sedan() { }
    public Sedan(long id, string name, bool absEnabled, Int32 bootSpace)
        : base(id, name)
    {
        this._absEnabled = absEnabled;
        this._bootSpace = bootSpace;
    }
    public override double CalculateDriveCost(double dist)
    {
        double cost;
        if (BootSpace > 600)
        {
            cost = 15 * dist;
            cost = cost + (((double)20 / (double)100) * cost);
        }
        else
        {
            cost = 15 * dist;
        }
        return cost;
    }
}
