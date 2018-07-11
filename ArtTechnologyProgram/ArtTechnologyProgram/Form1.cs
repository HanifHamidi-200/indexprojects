using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtTechnologyProgram
{
    public partial class Form1 : Form
    {
        private int nFirstRecord;
        private int mnCount = 22;

        private void fPutRecord(int nRecord,int nPos)
        {
            Item picture1 = new Item
            {
                nNumber = 1,
                sTitle="temasak",
                sDescription="The cauldron boiling over",
                sFile= "temasak.png"
            };
            Item picture2 = new Item
            {
                nNumber = 2,
                sTitle = "jondle",
                sDescription = "guiding the horses",
                sFile = "jondle.png"
            };
            Item picture3 = new Item
            {
                nNumber = 3,
                sTitle = "nacuta",
                sDescription = "the sea interweaving",
                sFile = "nacuta.png"
            };
            Item picture4 = new Item
            {
                nNumber = 4,
                sTitle = "perelli",
                sDescription = "shapes and sizes of your belongings",
                sFile = "perelli.png"
            };
            Item picture5 = new Item
            {
                nNumber = 5,
                sTitle = "phute",
                sDescription = "The planet Jupiter in receding motion",
                sFile = "phute.png"
            };
            Item picture6 = new Item
            {
                nNumber = 6,
                sTitle = "forenset",
                sDescription = "discovering new minerals in your everyday life",
                sFile = "forenset.png"
            };
            Item picture7 = new Item
            {
                nNumber = 7,
                sTitle = "kurasek",
                sDescription = "lemmings orientated mapping",
                sFile = "temasak.png"
            };
            Item picture8 = new Item
            {
                nNumber = 8,
                sTitle = "pillion",
                sDescription = "supercended parcelinabox algorithm",
                sFile = "jondle.png"
            };
            Item picture9 = new Item
            {
                nNumber = 9,
                sTitle = "gimmick",
                sDescription = "usesmiles translater routine",
                sFile = "nacuta.png"
            };
            Item picture10 = new Item
            {
                nNumber = 10,
                sTitle = "selence",
                sDescription = "crumblings ForcepsAnecdotes",
                sFile = "perelli.png"
            };
            Item picture11 = new Item
            {
                nNumber = 11,
                sTitle = "dopine",
                sDescription = "usewise VehicleAssault",
                sFile = "phute.png"
            };
            Item picture12 = new Item
            {
                nNumber = 12,
                sTitle = "emu",
                sDescription = "coalesced bordering",
                sFile = "temasak.png"
            };
            Item picture13 = new Item
            {
                nNumber =13,
                sTitle = "poltry",
                sDescription = "tripmarked pointer",
                sFile = "jondle.png"
            };
            Item picture14 = new Item
            {
                nNumber = 14,
                sTitle = "thwice",
                sDescription = "sayings and belongings",
                sFile = "nacuta.png"
            };
            Item picture15 = new Item
            {
                nNumber = 15,
                sTitle = "serrant",
                sDescription = "a fashioned servant",
                sFile = "perelli.png"
            };
            Item picture16 = new Item
            {
                nNumber = 16,
                sTitle = "molken",
                sDescription = "difference of distinguishments",
                sFile = "phute.png"
            };
            Item picture17 = new Item
            {
                nNumber = 17,
                sTitle = "jaded",
                sDescription = "patterned ribcage",
                sFile = "phute.png"
            };
            Item picture18 = new Item
            {
                nNumber = 18,
                sTitle = "farsate",
                sDescription = "diamondkeepers",
                sFile = "temasak.png"
            };
            Item picture19 = new Item
            {
                nNumber = 19,
                sTitle = "indoer",
                sDescription = "PlaceOfExistence",
                sFile = "jondle.png"
            };
            Item picture20 = new Item
            {
                nNumber = 20,
                sTitle = "trapweze",
                sDescription = "world of Fantasy",
                sFile = "nacuta.png"
            };
            Item picture21 = new Item
            {
                nNumber = 21,
                sTitle = "logold",
                sDescription = "Verstalt Sie gehen",
                sFile = "perelli.png"
            };
            Item picture22 = new Item
            {
                nNumber = 22,
                sTitle = "refacce",
                sDescription = "manumission ceiling",
                sFile = "phute.png"
            };

            Item picExamine = new Item();

            switch (nRecord)
            {
                case 1:
                    picExamine = picture1;
                    break;
                case 2:
                    picExamine = picture2;
                    break;
                case 3:
                    picExamine = picture3;
                    break;
                case 4:
                    picExamine = picture4;
                    break;
                case 5:
                    picExamine = picture5;
                    break;
                case 6:
                    picExamine = picture6;
                    break;
                case 7:
                    picExamine = picture7;
                    break;
                case 8:
                    picExamine = picture8;
                    break;
                case 9:
                    picExamine = picture9;
                    break;
                case 10:
                    picExamine = picture10;
                    break;
                case 11:
                    picExamine = picture11;
                    break;
                case 12:
                    picExamine = picture12;
                    break;
                case 13:
                    picExamine = picture13;
                    break;
                case 14:
                    picExamine = picture14;
                    break;
                case 15:
                    picExamine = picture15;
                    break;
                case 16:
                    picExamine = picture16;
                    break;
                case 17:
                    picExamine = picture17;
                    break;
                case 18:
                    picExamine = picture18;
                    break;
                case 19:
                    picExamine = picture19;
                    break;
                case 20:
                    picExamine = picture20;
                    break;
                case 21:
                    picExamine = picture21;
                    break;
                default:
                    picExamine = picture22;
                    break;
            }

            if (nPos > 4)
            {
                nPos -= 4;
            }
            switch (nPos)
            {
                case 1:
                    lblNumber1.Text = Convert.ToString(picExamine.nNumber);
                    lblTitle1.Text = picExamine.sTitle;
                    lblDescription1.Text = picExamine.sDescription;
                    pic1.Image = Image.FromFile(@picExamine.sFile);
                    break;
                case 2:
                    lblNumber2.Text = Convert.ToString(picExamine.nNumber);
                    lblTitle2.Text = picExamine.sTitle;
                    lblDescription2.Text = picExamine.sDescription;
                    pic2.Image = Image.FromFile(@picExamine.sFile);
                    break;
                case 3:
                    lblNumber3.Text = Convert.ToString(picExamine.nNumber);
                    lblTitle3.Text = picExamine.sTitle;
                    lblDescription3.Text = picExamine.sDescription;
                    pic3.Image = Image.FromFile(@picExamine.sFile);
                    break;
                case 4:
                    lblNumber4.Text = Convert.ToString(picExamine.nNumber);
                    lblTitle4.Text = picExamine.sTitle;
                    lblDescription4.Text = picExamine.sDescription;
                    pic4.Image = Image.FromFile(@picExamine.sFile);
                    break;
            }
        }

        private void fUpdateDisplay()
        {
            int nPos = 0;
            int nRecord;

            for (int i = nFirstRecord; i <= nFirstRecord + 3; i++)
            {
                nPos += 1;
                nRecord = i;
                if (nRecord > mnCount)
                {
                    nRecord -= mnCount;
                }
                fPutRecord(nRecord, nPos);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {     
            nFirstRecord = 1;
            fUpdateDisplay();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            nFirstRecord += 1;
            if (nFirstRecord == mnCount+1)
            {
                nFirstRecord = 1;
            }
            fUpdateDisplay();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            nFirstRecord -= 1;
            if (nFirstRecord == 0)
            {
                nFirstRecord = mnCount;
            }
            fUpdateDisplay();
        }
    }
}
