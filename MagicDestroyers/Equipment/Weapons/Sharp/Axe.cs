using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Axe
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >= 0)
                {
                    this.damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage value should be a positive number");
                }
            }
        }

        public Axe()
        {

        }

        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
