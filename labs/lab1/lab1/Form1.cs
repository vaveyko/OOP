using lab1.Sweetness.Chocolate.FillingChocolate;
using lab1.Sweetness.Marmalad;
using lab1.Sweetness.Chocolate;
using lab1.Sweetness.Sweet.Candy;
using lab1.Sweetness.Sweet.ChocolateCandy;

namespace lab1;

public partial class Form1 : Form
{
    Dictionary<string, string> fileNames = new Dictionary<string, string>()
    {
        {"Candy", "images/chupa-chups.jpg"},
        {"FillingChocolate", "images/bolci.jpg"},
        {"Chocolate", "images/alenka.jpg"},
        {"ChocolateCandy", "images/guyLian.jpg"},
        {"Marmalade", "images/tinki.jpg"},
    };
    public void CreateElemCard(Sweetness.Sweetness sweet)
    {
        // Создание панели для изображения и подписи
        FlowLayoutPanel panel = new FlowLayoutPanel();
        panel.Size = new Size(300, 430);
        panel.BackColor = Color.FromArgb(230, 230, 230);

        // Создание PictureBox
        PictureBox pictureBox = new PictureBox();
        pictureBox.Size = new Size(300, 300);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Image = Image.FromFile(fileNames[sweet.photoType]); // Путь к изображению
        
        Label label1 = new Label();
        label1.Text = sweet.photoType;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        label1.Size = new Size(300, label1.Size.Height);
        
        Label label2 = new Label();
        label2.Text = "Compani: " + sweet.CompaniName;
        label2.TextAlign = ContentAlignment.MiddleLeft;
        label2.Size = new Size(300, label2.Size.Height);
        
        Label label3 = new Label();
        label3.Text = "Weight: " + sweet.Weight.ToString() + " g.";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        label3.Size = new Size(300, label3.Size.Height);
        
        Label label4 = new Label();
        label4.Text = "Sweetness: " + sweet.SweetPercent.ToString() + " %";
        label4.TextAlign = ContentAlignment.MiddleLeft;
        label4.Size = new Size(300, label4.Size.Height);

        // Добавление PictureBox и Label в панель
        panel.Controls.Add(pictureBox);
        panel.Controls.Add(label1);
        panel.Controls.Add(label2);
        panel.Controls.Add(label3);
        panel.Controls.Add(label4);

        // Добавление панели в FlowLayoutPanel
        ElementPanel.Controls.Add(panel);
        CountLabel.Text = sweet.Count.ToString();
    }
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        AddSweetnessForm form = new AddSweetnessForm();
        form.Owner = this;
        form.Show();
    }
}