using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Locall
{
    public class Maakond: INotifyPropertyChanged
    {
        string nimetus;
        string pealinn;
        int inimeste_arv;
        string asukoht;
        string naabermaakond;
        int pindala;
        // lisame konstruktori...
        public Maakond() { }
        public Maakond(string Nimetus, string Pealinn, int Inimeste_arv, int Pindala, string Asukoht, string Naabermaakond)
        {
            nimetus = Nimetus;
            pealinn = Pealinn;
            inimeste_arv = Inimeste_arv;
            pindala = Pindala;
            asukoht = Asukoht;
            naabermaakond = Naabermaakond;
        }

        public string Nimetus
        {
            get { return nimetus; }
            set
            {
                if (nimetus != value)
                {
                    nimetus = value;
                    OnPropertyChanged("Nimetus");
                }
            }
        }
        public string Pealinn
        {
            get { return pealinn; }
            set
            {
                if (pealinn != value)
                {
                    pealinn = value;
                    OnPropertyChanged("Pealinn");
                }
            }
        }
        public int Inimeste_arv
        {
            get { return inimeste_arv; }
            set
            {
                if (inimeste_arv != value)
                {
                    inimeste_arv = value;
                    OnPropertyChanged("Inimeste_arv");
                }
            }
        }
        public int Pindala
        {
            get { return pindala; }
            set
            {
                if (pindala != value)
                {
                    pindala = value;
                    OnPropertyChanged("Pindala");
                }
            }
        }
        public string Asukoht
        {
            get { return asukoht; }
            set
            {
                if (asukoht != value)
                {
                    asukoht = value;
                    OnPropertyChanged("Asukoht");
                }
            }
        }
        public string Naabermaakond
        {
            get { return naabermaakond; }
            set
            {
                if (naabermaakond != value)
                {
                    naabermaakond = value;
                    OnPropertyChanged("Naabermaakond");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
