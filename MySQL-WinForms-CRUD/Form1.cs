namespace MySQL_WinForms_CRUD;

public partial class Form1 : Form
{
    List<Person> people = new List<Person>();

    // Prepares form
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

    // Search function
    private void button1_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        int id;

        try
        {
            id = Convert.ToInt32(textBox1.Text);
        }
        catch
        {
            MessageBox.Show("id value is not an int", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        people = db.GetPeople(id);
        UpdateList();

        textBox1.Text = "";

        if (people.Count == 0)
        {
            MessageBox.Show("Did not find person with such id", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    
    }

    // Insert function
    private void button2_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        int id = db.Count() + 1;
        bool vote;

        try
        {
            vote = Convert.ToBoolean(textBox3.Text);
        }
        catch
        {
            MessageBox.Show("Vote value is not a bool", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (textBox2.Text == "")
        {
            MessageBox.Show("Name value is not a string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        db.InsetPerson(id, textBox2.Text, vote);
        UpdateList();

        textBox2.Text = "";
        textBox3.Text = "";
    }

    // Loads whole db
    private void button3_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        people = db.GetAll();
        UpdateList();

        if (people.Count == 0)
        {
            MessageBox.Show("Database is empty", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Delete function
    private void button4_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        int id;

        try
        {
            id = Convert.ToInt32(textBox1.Text);
        }
        catch
        {
            MessageBox.Show("id value is not an int", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        db.DeletePerson(id);

        textBox1.Text = "";
    }

    // Update function
    private void button5_Click(object sender, EventArgs e)
    {
        DataAccess db = new DataAccess();

        int id;
        bool vote;

        try
        {
            id = Convert.ToInt32(textBox6.Text);
        }
        catch
        {
            MessageBox.Show("id value is not an int", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            vote = Convert.ToBoolean(textBox4.Text);
        }
        catch
        {
            MessageBox.Show("Vote value is not a bool", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (textBox5.Text == "")
        {
            MessageBox.Show("Name value is not a string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        db.UpdatePerson(id, textBox5.Text, vote);
        UpdateList();

        textBox4.Text = "";
        textBox5.Text = "";
        textBox6.Text = "";
    }
}