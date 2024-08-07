﻿using System.Runtime.Serialization;

namespace _08._07._24.WCFLibrary
{
    [DataContract]
    public class Personel
    {
        private int personelID;
        private string personelAdi;
        private string personelSoyad;

        [DataMember]
        public int PersonelID
        {
            get { return personelID; }
            set { personelID = value;}
        }

        [DataMember]
        public string PersonelAdi
        {
            get { return personelAdi; }
            set { personelAdi = value; }
        }

        [DataMember]
        public string PersonelSoyad
        {
            get { return personelSoyad; }
            set { personelSoyad = value; }
        }

    }
}
