using QRCoder;
using static QRCoder.PayloadGenerator;

namespace QRCoderExample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var qrGenerator = new QRCodeGenerator();

            var qrCodeData = qrGenerator.CreateQrCode(new Url(""), 
                QRCodeGenerator.ECCLevel.Q);

            var qrCode = new QRCode(qrCodeData);
            var qrCodeImage = qrCode.GetGraphic(20, "#2196FA", "#FFFFFF", true);

            pictureBox.Image = qrCodeImage;
        }
    }
}