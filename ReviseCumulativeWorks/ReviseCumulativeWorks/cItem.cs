using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviseCumulativeWorks
{
    class cItem
    {
        private List<String> _date = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _text1 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<String> _text2 = new List<string> { null, null, null, null, null, null, null, null, null, null };
        private List<int> _combo1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _combo2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _combo3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _number4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnCount, mnItem;

        public void fSet(int nItem,String sDate,String sText1,String sText2,int nCombo1,int nCombo2,int nCombo3,int nNumber1,int nNumber2,int nNumber3,int nNumber4)
        {
            mnItem = nItem;
            _date[mnItem - 1] = sDate;
            _text1[mnItem - 1] = sText1;
            _text2[mnItem - 1] = sText2;
            _combo1[mnItem - 1] = nCombo1;
            _combo2[mnItem - 1] = nCombo2;
            _combo3[mnItem - 1] = nCombo3;
            _number1[mnItem - 1] = nNumber1;
            _number2[mnItem - 1] = nNumber2;
            _number3[mnItem - 1] = nNumber3;
            _number4[mnItem - 1] = nNumber4;
        }

        public void fSet2(int nItem)
        {
            mnItem = nItem;
        }

        public String fGet()
        {
            String sDate = _date[mnItem - 1];
            int nNumber1 = _number1[mnItem - 1];
            int nNumber2 = _number2[mnItem - 1];
            int nNumber3 = _number3[mnItem - 1];
            int nNumber4 = _number4[mnItem - 1];
            String sText = "Date(" + sDate + ")=(" + Convert.ToString(nNumber1) + "," + Convert.ToString(nNumber2) + "," + Convert.ToString(nNumber3) + "," + Convert.ToString(nNumber4) + ")";

            return sText;
        }
    }
}
