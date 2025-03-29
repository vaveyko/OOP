namespace lab1;
using System.Reflection;

public partial class AddSweetnessForm : Form
{
    public AddSweetnessForm()
    {
        InitializeComponent();
        
        FillComboBox();
    }

    private void FillComboBox()
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
            if (field.ParameterType.Name == "Boolean")
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Font = new Font(checkBox.Font.FontFamily, 12f);
                checkBox.Text = field.Name;
                checkBox.Size = new Size(300, 30);
                flowLayoutPanel1.Controls.Add(checkBox);
            }
            else
            {
                TextBox textBox = new TextBox();
                textBox.Font = new Font(textBox.Font.FontFamily, 12f);
                textBox.PlaceholderText = field.Name;
                textBox.Size = new Size(300, 30);
                flowLayoutPanel1.Controls.Add(textBox);
            }
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
            try
            {
                TextBox textBox = (TextBox)flowLayoutPanel1.Controls[i];
                if (textBox.Text == "")
                {
                    return;
                }
                parameters[i] = textBox.Text;
            }
            catch (InvalidCastException exception)
            {
                CheckBox checkBox = (CheckBox)flowLayoutPanel1.Controls[i];
                parameters[i] = checkBox.Checked.ToString();
            }
            
        }
        
        SweetnessFactory fabric = (SweetnessFactory) getInstanceByName(SweetnessComboBox.SelectedItem.ToString());
        Sweetness.Sweetness sweet = fabric.Create(parameters);
        Form1 parentForm = Owner as Form1;
        parentForm.CreateElemCard(sweet);
        
        
        Close();
    }
}