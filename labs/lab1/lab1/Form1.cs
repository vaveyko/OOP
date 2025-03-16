using lab1.Sweetness.Chocolate.FillingChocolate;
using lab1.Sweetness.Marmalad;
using lab1.Sweetness.Chocolate;
using lab1.Sweetness.Sweet.Candy;
using lab1.Sweetness.Sweet.ChocolateCandy;

namespace lab1;

public partial class Form1 : Form
{
    Dictionary<int, string> fileNames = new Dictionary<int, string>()
    {
        {1, "images/chupa-chups.jpg"},
        {2, "images/bolci.jpg"},
        {3, "images/alenka.jpg"},
        {4, "images/guyLian.jpg"},
        {5, "images/tinki.jpg"},
    };
    private void CreateElemCard(Sweetness.Sweetness sweet, int fileIndex)
    {
        // Создание панели для изображения и подписи
        Panel panel = new Panel();
        panel.Size = new Size(300, 400);
        panel.BackColor = Color.FromArgb(230, 230, 230);

        // Создание PictureBox
        PictureBox pictureBox = new PictureBox();
        pictureBox.Size = new Size(300, 300);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Image = Image.FromFile(fileNames[fileIndex]); // Путь к изображению
            
            
        // Создание Label1
        Label label1 = new Label();
        label1.Text = "Compani: " + sweet.CompaniName;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        label1.AutoSize = true;
        label1.Location = new Point(10, 310); // Положение внутри панели
        // Создание Label2
        Label label2 = new Label();
        label2.Text = "Weight: " + sweet.Weight.ToString() + " g.";
        label2.TextAlign = ContentAlignment.MiddleCenter;
        label2.AutoSize = true;
        label2.Location = new Point(10, 340);
        // Создание Label3
        Label label3 = new Label();
        label3.Text = "Sweetness: " + sweet.SweetPercent.ToString() + " %";
        label3.TextAlign = ContentAlignment.MiddleCenter;
        label3.AutoSize = true;
        label3.Location = new Point(10, 370);

        // Добавление PictureBox и Label в панель
        panel.Controls.Add(pictureBox);
        panel.Controls.Add(label1);
        panel.Controls.Add(label2);
        panel.Controls.Add(label3);

        // Добавление панели в FlowLayoutPanel
        ElementPanel.Controls.Add(panel);
        CountLabel.Text = sweet.Count.ToString();
    }
    public Form1()
    {
        InitializeComponent();

        Sweetness.Sweetness sweet = new Candy(100, 23, "Chupa-Chups");
        CreateElemCard(sweet, 1);
        sweet = new FillingChocolate(1045, 1233, "Bolci");
        CreateElemCard(sweet, 2);
        sweet = new Chocolate(230, 83, "Alenka");
        CreateElemCard(sweet, 3);
        sweet = new ChocolateCandy(400, 93, "GuyLian");
        CreateElemCard(sweet, 4);
        sweet = new Marmalade(120, 67, 12,"Tinki");
        CreateElemCard(sweet, 5);
    }
}