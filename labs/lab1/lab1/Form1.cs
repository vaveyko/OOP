using System.Reflection;
using lab1.Sweetness.Chocolate.FillingChocolate;
using lab1.Sweetness.Marmalad;
using lab1.Sweetness.Chocolate;
using lab1.Sweetness.Sweet.Candy;
using lab1.Sweetness.Sweet.ChocolateCandy;

namespace lab1;

public partial class Form1 : Form
{
    private Sweetness.Sweetness s;
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
        s = sweet;
        
        
        Size lSize = new Size(300, 25);
        // Создание панели для изображения и подписи
        FlowLayoutPanel panel = new FlowLayoutPanel();
        panel.Size = new Size(300, 500);
        panel.BackColor = Color.FromArgb(230, 230, 230);

        // Создание PictureBox
        PictureBox pictureBox = new PictureBox();
        pictureBox.Size = new Size(300, 300);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox.Image = Image.FromFile(fileNames[sweet.photoType]); // Путь к изображению
        pictureBox.DoubleClick += PanelOnDoubleClick;
        
        Label label1 = new Label();
        label1.Text = sweet.photoType;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        label1.Size = lSize;
        
        panel.Controls.Add(pictureBox);
        panel.Controls.Add(label1);

        Type sweetType = sweet.GetType();
        var a = sweetType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (PropertyInfo property in sweetType.GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (property.Name != "Count" && property.Name != "photoType")
            {
                Label label = new Label();
                if (property.PropertyType == typeof(bool))
                {
                    label.Text = (bool)property.GetValue(sweet) ? $"{property.Name}: yes" : $"{property.Name}: no";
                }
                else
                {
                    label.Text = $"{property.Name}: {property.GetValue(sweet)}";
                }
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.Size = lSize;
                panel.Controls.Add(label);
            }
        }

        // Добавление панели в FlowLayoutPanel
        panel.DoubleClick += PanelOnDoubleClick;
        ElementPanel.Controls.Add(panel);
        CountLabel.Text = sweet.Count.ToString();
    }

    private void PanelOnDoubleClick(object? sender, EventArgs e)
    {
        AddSweetnessForm form = new AddSweetnessForm(true, s);
        form.Owner = this;
        form.Show();
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