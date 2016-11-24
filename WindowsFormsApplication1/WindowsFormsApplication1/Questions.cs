using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Questions
    {
        public string[] question;
        public string[,] options;
        public byte[] ans;
        public byte i, score;
        public int timeLeft;

        public Questions()
        {
            question = new string[] { "1. Access Modifier For Class",
                                      "2. Class supports Multiple Inheritance",
                                      "3. Integer takes How Many Bytes in Memory",
                                      "4. '~' Name this Sign",
                                      "5. Setter Method is also known as?" };

            options = new string[5,2] { { "Public", "InterNal" }, { "Yes", "No" }, { "8", "4" }, { "tild", "delta" }, { "accessor", "mutator" } };
            ans = new byte[] { 2, 2, 2, 1, 2 };

            i = 0; score = 0;
            timeLeft = 16;
        }
    }
}
