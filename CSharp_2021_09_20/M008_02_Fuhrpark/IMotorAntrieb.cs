using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M008_02_Fuhrpark
{
    public interface IMotor
    {
        int ReichweiteMitEinerTankfüllung { get; set; }
        int PS { get; set; }
    }


    public interface IBenzinMotor : IMotor
    {
        OctavenTypen BenzinTyp { get; set; }
    }


    public interface IElectroMotor : IMotor
    {
        int AkkuLaufzeut { get; set;  }
    }


    public enum OctavenTypen { Benzin, Super, SuperBleifrei }
}
