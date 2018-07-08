using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLines
{
    public partial class Form1 : Form
    {
        private static List<String> _labels1 = new List<String> { null,null,null,null,null };
        private static List<String> _labels2 = new List<String> { null, null, null, null, null };
        private static List<String> _labels3 = new List<String> { null, null, null, null, null };
        private static List<String> _labels4 = new List<String> { null, null, null, null, null };
        private static List<String> _values11 = new List<String> { null, null, null };
        private static List<String> _values12 = new List<String> { null, null, null };
        private static List<String> _values13 = new List<String> { null, null, null };
        private static List<String> _values14 = new List<String> { null, null, null };
        private static List<String> _values15 = new List<String> { null, null, null };
        private static List<String> _values21 = new List<String> { null, null, null };
        private static List<String> _values22 = new List<String> { null, null, null };
        private static List<String> _values23 = new List<String> { null, null, null };
        private static List<String> _values24 = new List<String> { null, null, null };
        private static List<String> _values25 = new List<String> { null, null, null };
        private static List<String> _values31 = new List<String> { null, null, null };
        private static List<String> _values32 = new List<String> { null, null, null };
        private static List<String> _values33 = new List<String> { null, null, null };
        private static List<String> _values34 = new List<String> { null, null, null };
        private static List<String> _values35 = new List<String> { null, null, null };
        private static List<String> _values41 = new List<String> { null, null, null };
        private static List<String> _values42 = new List<String> { null, null, null };
        private static List<String> _values43 = new List<String> { null, null, null };
        private static List<String> _values44 = new List<String> { null, null, null };
        private static List<String> _values45 = new List<String> { null, null, null };
        private int mnButton = 1;

        public Form1()
        {
            InitializeComponent();
            _labels1[0] = "MFCAccounts";
            _labels1[1] = "Phone";
            _labels1[2] = "OilIslands";
            _labels2[0] = "ReinforcedConcrete";
            _labels2[1] = "(OddsAre,FavoursAre)";
            _labels2[2] = "SupplyAndDemand";
            _labels2[3] = "ProfitWarnings_akaUsury";
            _labels3[0] = "DiaryInnovation";
            _labels3[1] = "ColourCodedScheme";
            _labels3[2] = "IntrovertComments";
            _labels4[0] = "MathsTutorial";
            _labels4[1] = "GraphicsInterest";
            _labels4[2] = "FunctionalProgramming";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            mnButton = rnd1.Next(1, 5);
            switch (mnButton)
            {
                case 1:
                    lbl1.Text = _labels1[0];
                    lbl2.Text = _labels1[1];
                    lbl3.Text = _labels1[2];
                    lbl4.Text = _labels1[3];
                    lbl5.Text = _labels1[4];
                    txt11.Text = _values11[0];
                    txt12.Text = _values11[1];
                    txt13.Text = _values11[2];
                    txt21.Text = _values12[0];
                    txt22.Text = _values12[1];
                    txt23.Text = _values12[2];
                    txt31.Text = _values13[0];
                    txt32.Text = _values13[1];
                    txt33.Text = _values13[2];
                    txt41.Text = _values14[0];
                    txt42.Text = _values14[1];
                    txt43.Text = _values14[2];
                    txt51.Text = _values15[0];
                    txt52.Text = _values15[1];
                    txt53.Text = _values15[2];
                    break;
                case 2:
                    lbl1.Text = _labels2[0];
                    lbl2.Text = _labels2[1];
                    lbl3.Text = _labels2[2];
                    lbl4.Text = _labels2[3];
                    lbl5.Text = _labels2[4];
                    txt11.Text = _values21[0];
                    txt12.Text = _values21[1];
                    txt13.Text = _values21[2];
                    txt21.Text = _values22[0];
                    txt22.Text = _values22[1];
                    txt23.Text = _values22[2];
                    txt31.Text = _values23[0];
                    txt32.Text = _values23[1];
                    txt33.Text = _values23[2];
                    txt41.Text = _values24[0];
                    txt42.Text = _values24[1];
                    txt43.Text = _values24[2];
                    txt51.Text = _values25[0];
                    txt52.Text = _values25[1];
                    txt53.Text = _values25[2];
                    break;
                case 3:
                    lbl1.Text = _labels3[0];
                    lbl2.Text = _labels3[1];
                    lbl3.Text = _labels3[2];
                    lbl4.Text = _labels3[3];
                    lbl5.Text = _labels3[4];
                    txt11.Text = _values31[0];
                    txt12.Text = _values31[1];
                    txt13.Text = _values31[2];
                    txt21.Text = _values32[0];
                    txt22.Text = _values32[1];
                    txt23.Text = _values32[2];
                    txt31.Text = _values33[0];
                    txt32.Text = _values33[1];
                    txt33.Text = _values33[2];
                    txt41.Text = _values34[0];
                    txt42.Text = _values34[1];
                    txt43.Text = _values34[2];
                    txt51.Text = _values35[0];
                    txt52.Text = _values35[1];
                    txt53.Text = _values35[2];
                    break;
               default:
                    lbl1.Text = _labels4[0];
                    lbl2.Text = _labels4[1];
                    lbl3.Text = _labels4[2];
                    lbl4.Text = _labels4[3];
                    lbl5.Text = _labels4[4];
                    txt11.Text = _values41[0];
                    txt12.Text = _values41[1];
                    txt13.Text = _values41[2];
                    txt21.Text = _values42[0];
                    txt22.Text = _values42[1];
                    txt23.Text = _values42[2];
                    txt31.Text = _values43[0];
                    txt32.Text = _values43[1];
                    txt33.Text = _values43[2];
                    txt41.Text = _values44[0];
                    txt42.Text = _values44[1];
                    txt43.Text = _values44[2];
                    txt51.Text = _values45[0];
                    txt52.Text = _values45[1];
                    txt53.Text = _values45[2];
                    break;
             }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (mnButton)
            {
                case 1:
                    fra1.Text = "DeliberationCounters";
                    _values11[0] = txt11.Text;
                    _values11[1] = txt12.Text;
                    _values11[2] = txt13.Text;
                    _values12[0] = txt21.Text;
                    _values12[1] = txt22.Text;
                    _values12[2] = txt23.Text;
                    _values13[0] = txt31.Text;
                    _values13[1] = txt32.Text;
                    _values13[2] = txt33.Text;
                    _values14[0] = txt41.Text;
                    _values14[1] = txt42.Text;
                    _values14[2] = txt43.Text;
                    _values15[0] = txt51.Text;
                    _values15[1] = txt52.Text;
                    _values15[2] = txt53.Text;
                    break;
                case 2:
                    fra1.Text = "ChoiceAndSelectionOutput";
                    _values21[0] = txt11.Text;
                    _values21[1] = txt12.Text;
                    _values21[2] = txt13.Text;
                    _values22[0] = txt21.Text;
                    _values22[1] = txt22.Text;
                    _values22[2] = txt23.Text;
                    _values23[0] = txt31.Text;
                    _values23[1] = txt32.Text;
                    _values23[2] = txt33.Text;
                    _values24[0] = txt41.Text;
                    _values24[1] = txt42.Text;
                    _values24[2] = txt43.Text;
                    _values25[0] = txt51.Text;
                    _values25[1] = txt52.Text;
                    _values25[2] = txt53.Text;
                    break;
                case 3:
                    fra1.Text = "ProjectManagement+CADSystem";
                    _values31[0] = txt11.Text;
                    _values31[1] = txt12.Text;
                    _values31[2] = txt13.Text;
                    _values32[0] = txt21.Text;
                    _values32[1] = txt22.Text;
                    _values32[2] = txt23.Text;
                    _values33[0] = txt31.Text;
                    _values33[1] = txt32.Text;
                    _values33[2] = txt33.Text;
                    _values34[0] = txt41.Text;
                    _values34[1] = txt42.Text;
                    _values34[2] = txt43.Text;
                    _values35[0] = txt51.Text;
                    _values35[1] = txt52.Text;
                    _values35[2] = txt53.Text;
                    break;
                default:
                    fra1.Text = "OpenLearn_LinearProgramming";
                    _values41[0] = txt11.Text;
                    _values41[1] = txt12.Text;
                    _values41[2] = txt13.Text;
                    _values42[0] = txt21.Text;
                    _values42[1] = txt22.Text;
                    _values42[2] = txt23.Text;
                    _values43[0] = txt31.Text;
                    _values43[1] = txt32.Text;
                    _values43[2] = txt33.Text;
                    _values44[0] = txt41.Text;
                    _values44[1] = txt42.Text;
                    _values44[2] = txt43.Text;
                    _values45[0] = txt51.Text;
                    _values45[1] = txt52.Text;
                    _values45[2] = txt53.Text;
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnButton = 1;
            fra1.Text = "DeliberationCounters";
            lbl1.Text = _labels1[0];
            lbl2.Text = _labels1[1];
            lbl3.Text = _labels1[2];
            lbl4.Text = _labels1[3];
            lbl5.Text = _labels1[4];
            txt11.Text = _values11[0];
            txt12.Text = _values11[1];
            txt13.Text = _values11[2];
            txt21.Text = _values12[0];
            txt22.Text = _values12[1];
            txt23.Text = _values12[2];
            txt31.Text = _values13[0];
            txt32.Text = _values13[1];
            txt33.Text = _values13[2];
            txt41.Text = _values14[0];
            txt42.Text = _values14[1];
            txt43.Text = _values14[2];
            txt51.Text = _values15[0];
            txt52.Text = _values15[1];
            txt53.Text = _values15[2];
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnButton = 2;
            fra1.Text = "ChoiceAndSelectionOutput";
            lbl1.Text = _labels2[0];
            lbl2.Text = _labels2[1];
            lbl3.Text = _labels2[2];
            lbl4.Text = _labels2[3];
            lbl5.Text = _labels2[4];
            txt11.Text = _values21[0];
            txt12.Text = _values21[1];
            txt13.Text = _values21[2];
            txt21.Text = _values22[0];
            txt22.Text = _values22[1];
            txt23.Text = _values22[2];
            txt31.Text = _values23[0];
            txt32.Text = _values23[1];
            txt33.Text = _values23[2];
            txt41.Text = _values24[0];
            txt42.Text = _values24[1];
            txt43.Text = _values24[2];
            txt51.Text = _values25[0];
            txt52.Text = _values25[1];
            txt53.Text = _values25[2];
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnButton = 3;
            fra1.Text = "ProjectManagement+CADSystem";
            lbl1.Text = _labels3[0];
            lbl2.Text = _labels3[1];
            lbl3.Text = _labels3[2];
            lbl4.Text = _labels3[3];
            lbl5.Text = _labels3[4];
            txt11.Text = _values31[0];
            txt12.Text = _values31[1];
            txt13.Text = _values31[2];
            txt21.Text = _values32[0];
            txt22.Text = _values32[1];
            txt23.Text = _values32[2];
            txt31.Text = _values33[0];
            txt32.Text = _values33[1];
            txt33.Text = _values33[2];
            txt41.Text = _values34[0];
            txt42.Text = _values34[1];
            txt43.Text = _values34[2];
            txt51.Text = _values35[0];
            txt52.Text = _values35[1];
            txt53.Text = _values35[2];
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            mnButton = 4;
            fra1.Text = "OpenLearn_LinearProgramming";
            lbl1.Text = _labels4[0];
            lbl2.Text = _labels4[1];
            lbl3.Text = _labels4[2];
            lbl4.Text = _labels4[3];
            lbl5.Text = _labels4[4];
            txt11.Text = _values41[0];
            txt12.Text = _values41[1];
            txt13.Text = _values41[2];
            txt21.Text = _values42[0];
            txt22.Text = _values42[1];
            txt23.Text = _values42[2];
            txt31.Text = _values43[0];
            txt32.Text = _values43[1];
            txt33.Text = _values43[2];
            txt41.Text = _values44[0];
            txt42.Text = _values44[1];
            txt43.Text = _values44[2];
            txt51.Text = _values45[0];
            txt52.Text = _values45[1];
            txt53.Text = _values45[2];
        }
    }
}
