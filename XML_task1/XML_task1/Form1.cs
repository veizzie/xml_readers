using System.Xml;
namespace XML_task1
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        private void LoadEmployees()
        {

            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes[0].Value;
                int age = int.Parse(node["Age"].InnerText);
                bool programmer = bool.Parse(node["Programmer"].InnerText);
                listBox1.Items.Add(new Employee(name, age, programmer));
            }
        }
        public Form1()
        {
            InitializeComponent();
            doc.Load("xmltext.xml");
            LoadEmployees();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                propertyGrid1.SelectedObject = listBox1.SelectedItem;
            }
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
        }
    }
}