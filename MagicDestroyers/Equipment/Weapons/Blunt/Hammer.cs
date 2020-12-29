using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer
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

        public Hammer()
        {

        }

        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
