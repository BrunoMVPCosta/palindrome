using Palindrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTwoPoints_Click(object sender, EventArgs e)
        {
            IPalindromeStrategy strategy = new TwoPointersPalindromeStrategy();
            RunValidation(strategy);
        }

        private void btnReverseArray_Click(object sender, EventArgs e)
        {
            IPalindromeStrategy strategy = new ReserveArrayPalindromeStrategy();
            RunValidation(strategy);
        }

        private void RunValidation(IPalindromeStrategy strategy)
        {
            PalindromeValidator validator = new PalindromeValidator(strategy);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            bool result = false;
            for (int i = 0; i <= 10000; i++)
            {
                result = validator.IsValid(txtWord.Text);
            }

            sw.Stop();

            lblResult.Text = string.Format("{0}. Took {1} ms",
                result ? "Palindrome word" : "Just another word",
                sw.ElapsedMilliseconds);
        }
    }
}
