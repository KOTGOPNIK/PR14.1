using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class AEROFLOT
    {
        private string Place;
        private byte rais;
        private string AirSpaceShip;
    
        public string place
        {
            get { return Place; }//возвращает значение поля
            set { Place = value; } //устанавливает значение поля
        }
        public byte Reais
        {
            get { return rais; }
            set { rais = value; }
        }
        public string EirSpaceShip
        {
            get { return AirSpaceShip; }
            set { AirSpaceShip = value; }
        }
        public AEROFLOT()
        {
            Place = "Moscow";
            rais = 2;
            AirSpaceShip = "G630";

        }
        public AEROFLOT(string p, byte r, string a)
        {
            Place = p;
            rais = r;
            AirSpaceShip = a;
        }
        public string PrintToScreen()
        {
            string line = ($"Самолет {AirSpaceShip} + \"\\n\" по рейсу№{rais} + \"\\n\" отправляется в пунк назначения {Place}" + "\n");
        }
        public void SaveToFile(string filename)
        {
            StreamWriter stream = new StreamWriter(filename);
            stream.WriteLine("Данные о самолете");
            stream.WriteLine($"Пунк назначения {Place}");
            stream.WriteLine($"по рейсу №{rais}");
            stream.WriteLine($"модель {AirSpaceShip}");
                stream.Close();
        }
        public void GetFromKeyboard()
        {

        }
        public void SaveToFile


    }
}