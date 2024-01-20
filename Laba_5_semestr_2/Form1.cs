using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Laba_5_semestr_2
{
    public partial class Form1 : Form
    {
        public Random rndl = new Random();
        Baza b = new Baza();
        public List<People> ListV_1 = new List<People>();
        public List<People> ListV_2 = new List<People>();
        public List<People> List_All = new List<People>();
        public void reConnect()
        {
            VPeople_all.DataSource = null;
            VPeople_all.DataSource = List_All;
            VPeople_all.DisplayMember = "ame";

            VPeople_1.DataSource = null;
            VPeople_1.DataSource = ListV_1;
            VPeople_1.DisplayMember = "ame";

            VPeople_2.DataSource = null;
            VPeople_2.DataSource = ListV_2;
            VPeople_2.DisplayMember = "ame";
        }
        public Form1()
        {
            InitializeComponent();

            List_All = b.list_All;
            reConnect();
        }

        private void V_all_Click(object sender, EventArgs e)
        {
            if (VPeople_all.Items != null)
            {
                for (int i = 0; i < VPeople_all.Items.Count; i++)
                {
                    ListV_1.Add((People)VPeople_all.Items[i]);
                    List_All.Remove((People)VPeople_all.Items[i]);
                }
                
            }
            reConnect();
        }

        private void V_1_Click(object sender, EventArgs e)
        {
            if (VPeople_all.Items != null)
            {
                for (int i = 0; i < VPeople_all.Items.Count; i++)
                {
                    if (((People)VPeople_all.Items[i]).V_Count == 0)
                    {
                        ListV_1.Add((People)VPeople_all.Items[i]);
                        List_All.Remove((People)VPeople_all.Items[i]);
                    }
                }
            }
            reConnect();
        }
        private void V_2_Click(object sender, EventArgs e)
        {
            if (VPeople_all.Items != null)
            {
                for (int i = 0; i < VPeople_all.Items.Count; i++)
                {
                    if (((People)VPeople_all.Items[i]).V_Count == 1)
                    {
                        ListV_1.Add((People)VPeople_all.Items[i]);
                        List_All.Remove((People)VPeople_all.Items[i]);
                    }
                }
            }
            reConnect();
        }

        private void Vack_Click(object sender, EventArgs e)
        {
            if (VPeople_1.Items != null)
            {
                for (int i = 0; i < VPeople_1.Items.Count; i++)
                {
                    int b = rndl.Next(100);
                    if (b > 50)
                    {
                        ((People)VPeople_1.Items[i]).V_Count++;
                    }
                    if (((People)VPeople_1.Items[i]).V_Count == 2)
                    {
                        ListV_2.Add((People)VPeople_1.Items[i]);
                        ListV_1.Remove((People)VPeople_1.Items[i]);
                    }
                    if (((People)VPeople_1.Items[i]).V_Count < 2)
                    {
                        List_All.Add((People)VPeople_1.Items[i]);
                        ListV_1.Remove((People)VPeople_1.Items[i]);
                    }
                }  
            }
            reConnect();
        }
    }
}
