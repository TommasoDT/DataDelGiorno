using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeTommaso.Tommaso._4J.DataDelGiorno.Models
{
    class Data
    {
        private int anno;
        private int giorniDaInizioAnno;

        public bool AnnoBisestile
        {
            get
            {
                return ((anno % 400 == 0) || ((anno % 4 == 0) && (anno % 100 != 0)));
            }
        }

        public int Anno
        {
            get
            {
                return anno;
            }
        }

        public int Mese
        {
            get
            {
                if (AnnoBisestile)
                {
                    if (giorniDaInizioAnno >= 1 && giorniDaInizioAnno <= 31)
                        return 1;
                    else if (giorniDaInizioAnno <= 60)
                        return 2;
                    else if (giorniDaInizioAnno <= 91)
                        return 3;
                    else if (giorniDaInizioAnno <= 121)
                        return 4;
                    else if (giorniDaInizioAnno <= 152)
                        return 5;
                    else if (giorniDaInizioAnno <= 182)
                        return 6;
                    else if (giorniDaInizioAnno <= 213)
                        return 7;
                    else if (giorniDaInizioAnno <= 244)
                        return 8;
                    else if (giorniDaInizioAnno <= 274)
                        return 9;
                    else if (giorniDaInizioAnno <= 305)
                        return 10;
                    else if (giorniDaInizioAnno <= 335)
                        return 11;
                    else if (giorniDaInizioAnno <= 366)
                        return 12;
                    return 0;
                }
                else
                {
                    if (giorniDaInizioAnno >= 1 && giorniDaInizioAnno <= 31)
                        return 1;
                    else if (giorniDaInizioAnno <= 59)
                        return 2;
                    else if (giorniDaInizioAnno <= 90)
                        return 3;
                    else if (giorniDaInizioAnno <= 120)
                        return 4;
                    else if (giorniDaInizioAnno <= 151)
                        return 5;
                    else if (giorniDaInizioAnno <= 181)
                        return 6;
                    else if (giorniDaInizioAnno <= 212)
                        return 7;
                    else if (giorniDaInizioAnno <= 243)
                        return 8;
                    else if (giorniDaInizioAnno <= 273)
                        return 9;
                    else if (giorniDaInizioAnno <= 304)
                        return 10;
                    else if (giorniDaInizioAnno <= 334)
                        return 11;
                    else if (giorniDaInizioAnno <= 365)
                        return 12;
                    return 0;
                }
            }
        }

        public int Giorno
        {
            get
            {
                if (AnnoBisestile)
                {
                    if (giorniDaInizioAnno >= 1 && giorniDaInizioAnno <= 31)
                        return giorniDaInizioAnno;
                    else if (giorniDaInizioAnno <= 60)
                        return giorniDaInizioAnno - 31;
                    else if (giorniDaInizioAnno <= 91)
                        return giorniDaInizioAnno - 60;
                    else if (giorniDaInizioAnno <= 121)
                        return giorniDaInizioAnno - 91;
                    else if (giorniDaInizioAnno <= 152)
                        return giorniDaInizioAnno - 121;
                    else if (giorniDaInizioAnno <= 182)
                        return giorniDaInizioAnno - 152;
                    else if (giorniDaInizioAnno <= 213)
                        return giorniDaInizioAnno - 182;
                    else if (giorniDaInizioAnno <= 244)
                        return giorniDaInizioAnno - 213;
                    else if (giorniDaInizioAnno <= 274)
                        return giorniDaInizioAnno - 244;
                    else if (giorniDaInizioAnno <= 305)
                        return giorniDaInizioAnno - 274;
                    else if (giorniDaInizioAnno <= 335)
                        return giorniDaInizioAnno - 305;
                    else if (giorniDaInizioAnno <= 366)
                        return giorniDaInizioAnno - 335;
                    return 0;
                }
                else
                {
                    if (giorniDaInizioAnno >= 1 && giorniDaInizioAnno <= 31)
                        return giorniDaInizioAnno;
                    else if (giorniDaInizioAnno <= 59)
                        return giorniDaInizioAnno - 31;
                    else if (giorniDaInizioAnno <= 90)
                        return giorniDaInizioAnno - 59;
                    else if (giorniDaInizioAnno <= 120)
                        return giorniDaInizioAnno - 90;
                    else if (giorniDaInizioAnno <= 151)
                        return giorniDaInizioAnno - 120;
                    else if (giorniDaInizioAnno <= 181)
                        return giorniDaInizioAnno - 151;
                    else if (giorniDaInizioAnno <= 212)
                        return giorniDaInizioAnno - 181;
                    else if (giorniDaInizioAnno <= 243)
                        return giorniDaInizioAnno - 212;
                    else if (giorniDaInizioAnno <= 273)
                        return giorniDaInizioAnno - 243;
                    else if (giorniDaInizioAnno <= 304)
                        return giorniDaInizioAnno - 273;
                    else if (giorniDaInizioAnno <= 334)
                        return giorniDaInizioAnno - 304;
                    else if (giorniDaInizioAnno <= 365)
                        return giorniDaInizioAnno - 334;
                    return 0;
                }
            }
        }

        public Data(int _giorno, int _mese, int _anno)
        {
            CambiaData(_giorno, _mese, _anno);
        }

        public Data() : this(1, 1, 1900) { }

        public void CambiaData(int _giorno, int _mese, int _anno)
        {
            giorniDaInizioAnno = 0;
            anno = _anno;

            if (AnnoBisestile)
            {
                if (_mese == 1)
                    giorniDaInizioAnno += 0;
                else if (_mese == 2)
                    giorniDaInizioAnno += 31;
                else if (_mese == 3)
                    giorniDaInizioAnno += 60;
                else if (_mese == 4)
                    giorniDaInizioAnno += 91;
                else if (_mese == 5)
                    giorniDaInizioAnno += 121;
                else if (_mese == 6)
                    giorniDaInizioAnno += 152;
                else if (_mese == 7)
                    giorniDaInizioAnno += 182;
                else if (_mese == 8)
                    giorniDaInizioAnno += 213;
                else if (_mese == 9)
                    giorniDaInizioAnno += 244;
                else if (_mese == 10)
                    giorniDaInizioAnno += 274;
                else if (_mese == 11)
                    giorniDaInizioAnno += 305;
                else if (_mese == 12)
                    giorniDaInizioAnno += 335;
            }
            else
            {
                if (_mese == 1)
                    giorniDaInizioAnno += 0;
                else if (_mese == 2)
                    giorniDaInizioAnno += 31;
                else if (_mese == 3)
                    giorniDaInizioAnno += 59;
                else if (_mese == 4)
                    giorniDaInizioAnno += 90;
                else if (_mese == 5)
                    giorniDaInizioAnno += 120;
                else if (_mese == 6)
                    giorniDaInizioAnno += 151;
                else if (_mese == 7)
                    giorniDaInizioAnno += 181;
                else if (_mese == 8)
                    giorniDaInizioAnno += 212;
                else if (_mese == 9)
                    giorniDaInizioAnno += 243;
                else if (_mese == 10)
                    giorniDaInizioAnno += 273;
                else if (_mese == 11)
                    giorniDaInizioAnno += 304;
                else if (_mese == 12)
                    giorniDaInizioAnno += 334;
            }

            giorniDaInizioAnno += _giorno;
        }

        public void AggiungiGiorni(int giorniDaAggiungere)
        {
            if (AnnoBisestile && (giorniDaAggiungere / 366 != 0))
            {
                anno += giorniDaAggiungere / 366;
                giorniDaAggiungere = giorniDaAggiungere % 366;
            }                
            else if(!AnnoBisestile && (giorniDaAggiungere / 366 != 0))
            {
                anno += giorniDaAggiungere / 365;
                giorniDaAggiungere = giorniDaAggiungere % 365;
            }
            
            giorniDaInizioAnno += giorniDaAggiungere;
        }

        public void TogliGiorni(int giorniDaTogliere)
        {
            if (AnnoBisestile && (giorniDaTogliere / 366 != 0))
            {
                anno -= giorniDaTogliere / 366;
                giorniDaTogliere = giorniDaTogliere % 366;
            }
            else if (!AnnoBisestile && (giorniDaTogliere / 366 != 0))
            {
                anno -= giorniDaTogliere / 365;
                giorniDaTogliere = giorniDaTogliere % 365;
            }

            giorniDaInizioAnno -= giorniDaTogliere;
        }

        public override string ToString()
        {
            return ToString("GMA");
        }

        public string ToString(string format)
        {
            string strGiorno = Giorno.ToString();
            string strMese = Mese.ToString();
            string strAnno = Anno.ToString();

            if (strGiorno.Length < 2)
                strGiorno = "0" + strGiorno;
            if (strMese.Length < 2)
                strMese = "0" + strMese;

            if (format == "GMA")
                return strGiorno + "/" + strMese + "/" + strAnno;
            else if (format == "MGA")
                return strMese + "/" + strGiorno + "/" + strAnno;
            else if (format == "AMG")
                return strAnno + "/" + strMese + "/" + strGiorno;
            return "";
        }

        public static bool operator == (Data data1, Data data2)
        {
            return (data1.giorniDaInizioAnno == data2.giorniDaInizioAnno) && (data1.anno == data2.anno);
        }

        public static bool operator != (Data data1, Data data2)
        {
            return (data1.giorniDaInizioAnno != data2.giorniDaInizioAnno) && (data1.anno == data2.anno);
        }

        public static bool operator > (Data data1, Data data2)
        {
            return (data1.giorniDaInizioAnno > data2.giorniDaInizioAnno) && (data1.anno > data2.anno);
        }

        public static bool operator < (Data data1, Data data2)
        {
            return (data1.giorniDaInizioAnno < data2.giorniDaInizioAnno) && (data1.anno < data2.anno);
        }
    }
}
