namespace lab1;
using System.Reflection;

public partial class AddSweetnessForm : Form
{
    public AddSweetnessForm()
    {
        InitializeComponent();
        
        FillComboBox();
    }

    public void FillComboBox()
    {
            var assembly = Assembly.GetExecutingAssembly();
            var allTypes = assembly.GetTypes();

            var baseClassType = typeof(SweetnessFactory);

            foreach (var type in allTypes)
            {
                if (type != baseClassType && baseClassType.IsAssignableFrom(type))
                {
                    SweetnessComboBox.Items.Add(type.Name);
                }
            }
    }

    public ParameterInfo[] getAllFields(Type type)
    {
        ConstructorInfo constructor = type.GetConstructors()[0];
        ParameterInfo[] parameters = constructor.GetParameters();
        foreach (ParameterInfo parameter in parameters)
        {
            Console.WriteLine($"bom {parameter.Name}");
        }
        return parameters;
    }

    private Object getInstanceByName(String name)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type[] types = assembly.GetTypes();
        foreach (Type type in types)
        {
            if (type.Name == name)
            {
                return Activator.CreateInstance(type);
            }
        }
        return null;
    }

    private void SweetnessComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        flowLayoutPanel1.Controls.Clear();
        SweetnessFactory fabric = (SweetnessFactory) getInstanceByName(SweetnessComboBox.SelectedItem.ToString());
        ParameterInfo[] fields = getAllFields(fabric.sweetnessType);
        foreach (ParameterInfo field in fields)
        {
            TextBox textBox = new TextBox();
            textBox.Font = new Font(textBox.Font.FontFamily, 12f);
            textBox.PlaceholderText = field.Name;
            textBox.Size = new Size(300, 300);
            flowLayoutPanel1.Controls.Add(textBox);
        }
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        Object[] parameters = new Object[flowLayoutPanel1.Controls.Count];
        for (int i = 0; i < parameters.Length; i++)
        {
            TextBox textBox = flowLayoutPanel1.Controls[i] as TextBox;
            if (textBox.Text == "")
            {
                return;
            }
            parameters[i] = textBox.Text;
        }
        
        SweetnessFactory fabric = (SweetnessFactory) getInstanceByName(SweetnessComboBox.SelectedItem.ToString());
        Sweetness.Sweetness sweet = fabric.Create(parameters);
        Form1 parentForm = this.Owner as Form1;
        parentForm.CreateElemCard(sweet);
        
        
        Close();
    }
}