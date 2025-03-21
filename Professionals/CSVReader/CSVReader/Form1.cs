namespace CSVReader
{
    public partial class Form1 : Form
    {
        private List<Measurement> zeilen;

        public Form1()
        {
            InitializeComponent();
            zeilen = new List<Measurement>();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxFilepath.Text = openFileDialog1.FileName;
                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            zeilen.Add(new Measurement(sr.ReadLine()));
                        }
                    }
                }
                tbxContent.Text = string.Join(Environment.NewLine, zeilen);
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            float averageDuration = 0;
            foreach (Measurement measurement in zeilen)
            {
                averageDuration += measurement.GetDurationSec();
            }
            averageDuration /= zeilen.Count;

            tbxMeasurements.Text = zeilen.Count.ToString();
            tbxAverageDuration.Text = string.Format("{0:0.00}", averageDuration);

            // MeasID und DurationSec anzeigen
            string ausgabe = "";
            foreach (Measurement zeile in zeilen)
            {
                ausgabe += zeile + Environment.NewLine;
            }
            tbxContent.Text = ausgabe;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
