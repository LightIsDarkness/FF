using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Laba_6_semestr_2.BLL
{
    public class BL
    {
        public Random rndl = new Random();
        public int m = 0;
        public List<int> list = new List<int>();
        public ObservableCollection<People> ListV_Vack { get; set; }
        public ObservableCollection<People> ListV_Sert { get; set; }
        public ObservableCollection<People> List_All { get; set; }
        public People SelectedPatient { get; set; }
        public BL()
        {
            ListV_Vack = new ObservableCollection<People>();
            ListV_Sert = new ObservableCollection<People>();
            List_All = new ObservableCollection<People>() {
                new People ("Alex",0),
                new People ("Max",0),
                new People ("Jain",0),
                new People ("Masha",0),
                new People ("Nikita",0),
                new People ("Nikita",0)
            };
        }
        public RelayCommand allToVaccination { get { return new RelayCommand(execute => AllToVaccination()); }}
        public void AllToVaccination()
        {
            if (List_All != null)
            {
                foreach (People p in List_All)
                {
                    ListV_Vack.Add(p);
                }
                List_All.Clear();
            } 
        }
        public RelayCommand selectedToVaccination { get { return new RelayCommand(execute => SelectedToVaccination()); } }
        public void SelectedToVaccination()
        {
            if (List_All != null && List_All[0] != null) 
            { 
                if (SelectedPatient != null)
                {
                    ListV_Vack.Add(SelectedPatient);
                    List_All.Remove(SelectedPatient);
                }
            }
        }
        public RelayCommand toFirstVaccination { get { return new RelayCommand(execute => ToFirstVaccination()); } }
        public void ToFirstVaccination()
        {
            if (List_All != null)
            {
                for (int i = 0; i < List_All.Count; i++)
                {
                    if (List_All[i].V_Count == 0)
                    {
                        ListV_Vack.Add(List_All[i]);
                        list.Add(i);
                    }
                }
                foreach (int x in list)
                {
                    List_All.Remove(List_All[x-m]);
                    m++;
                }
                m=0;
                list.Clear();
            }
        }
        public RelayCommand toSecondVaccination { get { return new RelayCommand(execute => ToSecondVaccination()); } }
        public void ToSecondVaccination()
        {
            if (List_All != null)
            {
                for (int i = 0; i < List_All.Count; i++)
                {
                    if (List_All[i].V_Count == 1)
                    {
                        ListV_Vack.Add(List_All[i]);
                        list.Add(i);
                    }
                }
                foreach (int x in list)
                {
                    List_All.Remove(List_All[x - m]);
                    m++;
                }
                m = 0;
                list.Clear();
            }
        }
        public RelayCommand vaccination { get { return new RelayCommand(execute => Vaccination()); } }
        public void Vaccination()
        {
            if (ListV_Vack != null)
            {
                for (int i = 0; i < ListV_Vack.Count; i++)
                {
                    int b = rndl.Next(100);
                    if (b > 50)
                    {
                        ListV_Vack[i].V_Count++;
                    }
                    if (ListV_Vack[i].V_Count == 2)
                    {
                        ListV_Sert.Add(ListV_Vack[i]);
                    }
                    if (ListV_Vack[i].V_Count < 2)
                    {
                        List_All.Add(ListV_Vack[i]);
                    }
                }
                ListV_Vack.Clear();
            }
        }

       }
}
