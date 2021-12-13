using QRCoder;

namespace QrCodeGenerate
{
    public partial class Form1 : Form
    {
        string folder;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (txtNameFile.Text != "" && urlLink.Text != "")
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(urlLink.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                Bitmap qrCodeImg = qRCode.GetGraphic(20);
                qrCodeImage.Image = qrCodeImg;
                string pathSave = folder + "\\" + txtNameFile.Text + ".jpg";
                qrCodeImage.Image.Save(pathSave);
                MessageBox.Show("Salvo Com sucesso!");
            }
            else
            {
                MessageBox.Show("Preencha os campos vazios! ");
            }

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folder = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}