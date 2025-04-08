using System.Windows.Forms.VisualStyles;

namespace lab1;
using System.Reflection;

public partial class AddSweetnessForm : Form
{
    private bool isEditForm;
    private Sweetness.Sweetness sweet;
    public AddSweetnessForm(bool isEditForm=false, Sweetness.Sweetness sweet = null)
    {
        InitializeComponent();
        this.isEditForm = isEditForm;
        this.sweet = sweet;
        if (isEditForm)
        {
            createAllFieldsEdit(sweet.GetType());
            var a = (sweet.GetType()).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (Object editLine in flowLayoutPanel1.Controls)
            {
                try
                {
                    TextBox text = (TextBox)editLine;
                    Type type = sweet.GetType();
                    PropertyInfo property = type.GetProperty(text.PlaceholderText, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
                    text.Text = property.GetValue(sweet, null).ToString();
                } 
                catch (InvalidCastException exception)
                {
                    CheckBox checkBox = (CheckBox)editLine;
                    Type type = sweet.GetType();
                    PropertyInfo property = type.GetProperty(checkBox.Text, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
                    checkBox.Checked = (bool)(property.GetValue(sweet, null));
                }
            }
        }
        else
        {
            ComboBox SweetnessComboBox = new ComboBox();
            SweetnessComboBox.Size = new Size(flowLayoutPanel1.Size.Width, SweetnessComboBox.Size.Height);
            SweetnessComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FillComboBox(SweetnessComboBox);
            SweetnessComboBox.SelectedIndexChanged += SweetnessComboBox_SelectedIndexChanged;
            flowLayoutPanel1.Controls.Add(SweetnessComboBox);
        }
    }

    private void FillComboBox(ComboBox comboBox)
    {
            var assembly = Assembly.GetExecutingAssembly();
            var allTypes = assembly.GetTypes();

            var baseClassType = typeof(SweetnessFactory);

            foreach (var type in allTypes)
            {
                if (type != baseClassType && baseClassType.IsAssignableFrom(type))
                {
                    comboBox.Items.Add(type.Name);
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

    private void createAllFieldsEdit(Type type)
    {
        ParameterInfo[] fields = getAllFields(type);
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

    private void SweetnessComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isEditForm)
        {
            flowLayoutPanel1.Controls.Clear();
        }
        else
        {
            while (flowLayoutPanel1.Controls.Count > 1)
            {
                flowLayoutPanel1.Controls.RemoveAt(1);
            }
        }
        SweetnessFactory fabric = (SweetnessFactory) getInstanceByName((sender as ComboBox).SelectedItem.ToString());
        createAllFieldsEdit(fabric.sweetnessType);
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void okButton_Click(object sender, EventArgs e)
    {
        int start = isEditForm ? 0 : 1;
        Object[] parameters = new Object[flowLayoutPanel1.Controls.Count - start];
        for (int i = 0; i < parameters.Length; i++)
        {
            try
            {
                TextBox textBox = (TextBox)flowLayoutPanel1.Controls[i+start];
                if (textBox.Text == "")
                {
                    return;
                }
                parameters[i] = textBox.Text;
            }
            catch (InvalidCastException exception)
            {
                CheckBox checkBox = (CheckBox)flowLayoutPanel1.Controls[i+start];
                parameters[i] = checkBox.Checked.ToString();
            }
            
        }

        if (isEditForm)
        {
            sweet.Edit(parameters);
        }
        else
        {
            SweetnessFactory fabric = (SweetnessFactory)getInstanceByName(((ComboBox)flowLayoutPanel1.Controls[0]).SelectedItem.ToString());
            Sweetness.Sweetness sweet = fabric.Create(parameters);
            Form1 parentForm = Owner as Form1;
            parentForm.CreateElemCard(sweet);
        }
        
        Close();
    }
}