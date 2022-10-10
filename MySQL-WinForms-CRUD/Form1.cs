namespace MySQL_WinForms_CRUD;

public partial class Form1 : Form
{
    List<Person> people = new List<Person>();

    public Form1()
    {
        InitializeComponent();

        UpdateList();
    }

    // Refreshes listBox1
    private void UpdateList()
    {
        listBox1.DataSource = people;
        listBox1.DisplayMember = "FullInfo";
    }

    // Search button
    private void button1_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        people = db.GetPeople(Convert.ToInt32(textBox1.Text));

        UpdateList();
    }
}