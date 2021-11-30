using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gachinator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int min = 5;
            int max = 9;
            int k = 0;
            string str = InputTextBox.Text;
            string output = "";
            string wrd = "";

            Random rand = new Random();
            string tstr = "";
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ',' || str[i] == '.' || str[i] == '!' || str[i] == '"')
                    tstr += ' ';
                else
                    tstr += str[i];


            while (k < tstr.Length)
            {
                wrd = "";
                for (int i = k; i < tstr.Length && tstr[i] != ' '; i++)
                {
                    wrd += tstr[i];
                }
                k += wrd.Length + 1;
                int r = rand.Next(0, 10);

                if (wrd == "фантазия")
                    wrd = "♂deep dark fantasies♂";
                else
                if (wrd.Length > 3 && min <= r && r <= max)
                {
                    r = rand.Next(0, 10);

                    int l = wrd.Length - 1;
                    if (l > 0)
                        switch (wrd[l])//окончания
                        {
                            case 'г':
                                if (r > min && r < max)
                                    wrd = "♂spanking♂";
                                else
                                    wrd = "♂gym♂";
                                break;

                            case 'е':
                                if (r > min && r < max)
                                    wrd = "♂slave♂";
                                else
                                    wrd = "♂wee wee♂";
                                break;

                            case 'м':
                                wrd = "♂cum♂";
                                break;

                            case 'в':
                                wrd = "♂latex glove♂";
                                break;

                            case 'н':
                                if (r > min && r < max)
                                    wrd = "♂semen♂";
                                else
                                    wrd = "♂lether man♂";
                                break;

                            case 'п':
                                wrd = "♂fucking deep";
                                break;

                            case 'к':
                                wrd = "♂dick♂";
                                break;

                            case 'й':
                                if (r > min && r < max)
                                    wrd = "♂fucking♂";
                                else
                                    wrd = "♂fisting♂";
                                break;

                            case 'р':
                                if (r > min && r < max)
                                    wrd = "♂boy next door♂";
                                else
                                    wrd = "♂dungeon master♂";
                                break;

                            case 'б':
                                wrd = "♂boss of the gym♂";
                                break;

                            case 'ю':
                                wrd = "♂fuck you♂";
                                break;

                            case 'и':
                                if (r > min && r < max)
                                    wrd = "♂jabroni♂";
                                else
                                    wrd = "♂Billy♂";
                                break;

                            case 'c':
                                if (r > min && r < max)
                                    wrd = "♂6 hot loads♂";
                                else
                                    wrd = "♂300$♂";
                                break;

                                //default:
                                //    switch (wrd[0])//первая буква
                                //    {
                                //        case 'с':
                                //            wrd = "♂semen♂";
                                //            break;

                                //        case 'а':
                                //            wrd = "♂ass♂";
                                //            break;

                                //        case 'б':
                                //            wrd = "♂boy next door♂";
                                //            break;

                                //        case 'ф':
                                //            wrd = "♂fucking deep";
                                //            break;

                                //        case 'д':
                                //            if (r > min && r < max)
                                //                wrd = "♂dick♂";
                                //            else
                                //                wrd = "♂dungeon master♂";
                                //            break;

                                //        case 'т':
                                //            wrd = "♂300$♂";
                                //            break;
                                //    }
                                //    break;
                        }


                }

                output += wrd + " ";

            }




            InputTextBox.Text = output;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
