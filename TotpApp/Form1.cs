using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotpApp
{
    public partial class Form1 : Form
    {
        Totp totp;

        Byte[] secretKey = Base32Encoding.ToBytes("mysupersecretkey");
        int remainingTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void email_label_Click(object sender, EventArgs e)
        {

        }

        private void button_generate_totp_Click(object sender, EventArgs e)
        {

            totp = new Totp(secretKey, step: 15, mode: OtpHashMode.Sha1, totpSize: 8);
            var totpCode = totp.ComputeTotp(DateTime.UtcNow);
            remainingTime = totp.RemainingSeconds(DateTime.UtcNow);

            textbox_totp.Text = totpCode;





        }

        private void button_validate_totp_Click(object sender, EventArgs e)
        {
            long timeStepMatched;
            var totp2 = new Totp(secretKey, 15, OtpHashMode.Sha1, 8);
            bool verify = totp2.VerifyTotp(totp: textbox_validate.Text, out timeStepMatched, window: new VerificationWindow(1));

            if (verify == true)
            {
                label_isVerified.Text = "YOUR CODE IS VERIFIED";
                label_isVerified.ForeColor = Color.Green;
            }
            else
            {
                label_isVerified.Text = "YOUR CODE IS NOT VERIFIED";
                label_isVerified.ForeColor = Color.Red;
            }
        }

        private void label_code_Click(object sender, EventArgs e)
        {

        }
    }
}
