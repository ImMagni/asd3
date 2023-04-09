using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Students_Manager.StudentsManager;

namespace Students_Manager.Forms
{
    public partial class FormRandomizer : Form
    {

        private string[] randomized;
        public FormRandomizer()
        {
            InitializeComponent();
        }

        public static void Shuffle<T>(T[] array)
        {
            Random random = new Random();
            for (int i = array.Length; i > 1; i--)
            {
                int j = random.Next(i);
                T tmp = array[j];
                array[j] = array[i - 1];
                array[i - 1] = tmp;
            }
        }
        private void btnRandomizer_Click(object sender, EventArgs e)
        {
            randomized = GlobalVariables.Students;
            if (randomized != null)
            {
                Shuffle(randomized);

                int laptops;
                int pcs;
                int nn;

                laptops = Int32.Parse(LapTextBox.Text);
                pcs = Int32.Parse(PcsTextBox.Text);
                nn = laptops + pcs;

                string[] laptopsG = new string[nn];

                for (int i = 0; i < nn; i++)
                {
                    laptopsG[i] = "";
                }

                for (int i = 0; i < laptops; i++)
                {
                    if (i >= GlobalVariables.Students.Length)
                    {
                        string St = string.Format("Laptop{0}: No asignado", i + 1);
                        laptopsG[i] = St;
                    }
                    else
                    {
                        string St = string.Format("Laptop{0}: {1}", i + 1, randomized[0]);
                        laptopsG[i] = St;
                        randomized = randomized.Skip(1).ToArray();
                    }
                }

                for (int i = laptops; i < nn; i++)
                {
                    if (i >= laptops + pcs)
                    {
                        string St = string.Format("Pc{0}: No asignado, No asignado", i + 1);
                        laptopsG[i] = St;
                    }
                    else
                    {
                        if (randomized.Length >= 2)
                        {
                            string St1 = randomized[0];
                            randomized = randomized.Skip(1).ToArray();
                            string St2 = randomized[0];
                            randomized = randomized.Skip(1).ToArray();

                            string St = string.Format("Pc{0}: {1},    {2}", i + 1, St1, St2);
                            laptopsG[i] = St;
                        }
                        else if (randomized.Length == 1)
                        {
                            string St1 = randomized[0];
                            randomized = randomized.Skip(1).ToArray();

                            string St = string.Format("Pc{0}: {1},    No asignado", i + 1, St1);
                            laptopsG[i] = St;
                        }
                        else
                        {
                            string St = string.Format("Pc{0}: No asignado, No asignado", i + 1);
                            laptopsG[i] = St;
                        }
                    }
                }

                if (laptopsG != null)
                {
                    textBox1.Text = string.Join(Environment.NewLine, laptopsG.Select(s => s.Replace("\r", "").Replace("\n", "")));
                }
            }
            else
            {

            }

        }
    }
}
