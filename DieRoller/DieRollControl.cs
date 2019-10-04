using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DieRoller
{
    public partial class DieRollControl : UserControl
    {
        public String DefaultInputText
        {
            get
            {
                return this.textBoxInput.Text;
            }

            set
            {
                this.textBoxInput.Text = value;
            }
        }

        public delegate void LogMessageDelegate(String message);
        public LogMessageDelegate LogMessage;


        public abstract class DieRollComponent
        {
            public abstract int getValue(out String log);
        }

        public class DieRollConstant : DieRollComponent
        {
            protected int value;

            public DieRollConstant(int value)
            {
                this.value = value;
            }

            public override int getValue(out String log)
            {
                log = this.value.ToString() + " ";
                return this.value;
            }

            public override string ToString()
            {
                return this.value.ToString();
            }
        }

        public class DieRoll : DieRollComponent
        {
            protected int numberOfDice;
            protected int DieType;

            public DieRoll(int number_of_dice, int die_value)
            {
                this.numberOfDice = number_of_dice;
                this.DieType = die_value;
            }

            public override int getValue(out String log)
            {
                int sum = 0;
                Random rnd = new Random();
                String logres = "";

                for (int x = 0; x < numberOfDice; x++)
                {
                    int value = rnd.Next(1, DieType + 1);
                    sum += value;
                    logres += " (D" + this.DieType + ")" + value +" +";
                }

                /* Remove last plus sign.. */
                log = logres.TrimEnd('+');
                return sum;
            }

            public override string ToString()
            {
                return this.numberOfDice + "d" + this.DieType;
            }
        }


        public DieRollControl()
        {
            InitializeComponent();
        }

        private List<DieRollComponent> parseText(String text)
        {
            //Lets do this simply. Pattern is something like 2d10 + 4
            text = text.Replace(" ", "");

            /* Lets try a simple hack here...*/
            for(int x = 0; x < text.Length; x++)
            {
                if(text[x] == '-')
                {
                    text = text.Insert(x, "+");
                    x++;
                    //MessageBox.Show("Result is : " + text);
                }
            }

            String[] components = text.Split('+');
            List<DieRollComponent> res = new List<DieRollComponent>();

            foreach (String component in components)
            {
                /* Lets see if component contains a d. */
                if ((component[0] == 'd') || (component[0] == 'D'))
                {
                    int type_of_die;
                    if (!int.TryParse(component.TrimStart(new char[] { 'd', 'D' }), out type_of_die))
                    {
                        throw new Exception("Failed to parse");
                    }

                    res.Add(new DieRoll(1, type_of_die));
                }
                else if (component.Contains("d"))
                {
                    String[] sub = component.Split('d');

                    int number_of_dice;
                    int type_of_die;

                    if (sub.Length == 2)
                    {
                        if (!int.TryParse(sub[0], out number_of_dice))
                        {
                            throw new Exception("Failed to parse");
                        }

                        if (!int.TryParse(sub[1], out type_of_die))
                        {
                            throw new Exception("Failed to parse");
                        }
                    }
                    else
                    {
                        throw new Exception("Failed to parse");
                    }

                    res.Add(new DieRoll(number_of_dice, type_of_die));
                }
                else
                {
                    int constval;

                    if (!int.TryParse(component, out constval))
                    {
                        throw new Exception("Failed to parse");
                    }

                    res.Add(new DieRollConstant(constval));
                }
            }

            /*
            String debug = "";

            foreach(DieRollComponent comp in res)
            {
                debug += " " + comp.ToString(); 
            }
            MessageBox.Show("Parsed : " + debug);
            */

            return res;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(textBoxInput.Text == String.Empty))
            {
                List<DieRollComponent> parsedList;
                int sum = 0;
                try
                {
                    parsedList = parseText(textBoxInput.Text);

                    foreach (DieRollComponent comp in parsedList)
                    {
                        String message;
                        int value = comp.getValue(out message);
                        if (comp != parsedList[parsedList.Count - 1])
                        {
                            message += "+ ";
                        }
                        sum += value;

                        LogMessage?.Invoke(message);

                    }

                    textBoxOutput.Text = sum.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to parse");
                }

                LogMessage?.Invoke("= " + sum);
                LogMessage?.Invoke(Environment.NewLine);
            }
        }
    }
}
