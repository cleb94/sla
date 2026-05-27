using DbdPerksRoullet.Enums.PerksColors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbdPerksRoullet.Enums {
    internal class PerksEnum {

        public PerksEnum() { }

        public bool VazioRoxo(List<string> Perks) {
            int x = 0;
            if(Azul(Perks) == true) { x = 1; }
            if(Vermelho(Perks) == true) { x = 2; }
            if(Roxo(Perks) == true) { x = 3; }

            return x > 0;
        }



        private static bool Azul(List<string> Perks) {  //static: pertence apenas a classe, nao da para usar fora.

            int x = 0;
            foreach (string perk in Perks) {
                foreach (BlueEnums value in Enum.GetValues(typeof(BlueEnums))) {

                    string XD = value + ".png";

                    if (perk.ToString() == XD) {
                        x++;
                    }
                }
            }
            return x == 4;
        }

        private static bool Vermelho(List<string> Perks) {

            int x = 0;
            foreach (string perk in Perks) {
                foreach (RedEnum value in Enum.GetValues(typeof(RedEnum))) {

                    string XD = value + ".png";

                    if (perk.ToString() == XD) {
                        x++;
                    }
                }
            }
            return x == 4;
        }

        private static bool Roxo(List<string> Perks) {

            int x = 0;
            foreach (string perk in Perks) {
                foreach (PurpleEnum value in Enum.GetValues(typeof(PurpleEnum))) {

                    string XD = value + ".png";

                    if (perk.ToString() == XD) {
                        x++;
                    }
                }
            }
            return x == 4;
        }

    }
}
