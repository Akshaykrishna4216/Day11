using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HatchBack : Car
{
    private bool _powerWindowsEnabled;

    public bool PowerWindowsEnabled
    {
        get { return _powerWindowsEnabled; }
        set { _powerWindowsEnabled = value; }
    }
    private bool _automaticGear;

    public bool AutomaticGear
    {
        get { return _automaticGear; }
        set { _automaticGear = value; }
    }
    public HatchBack() { }
    public HatchBack(long id, string name, bool powerWindowsEnabled, bool automaticGear)
        : base(id, name)
    {
        this._powerWindowsEnabled = powerWindowsEnabled;
        this._automaticGear = automaticGear;
    }
    public override double CalculateDriveCost(double dist)
    {
        double cost;
        if (AutomaticGear == true)
        {
            cost = 12 * dist;
        }
        else
        {
            cost = 10 * dist;
        }
        return cost;
    }

}
