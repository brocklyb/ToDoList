using System.Collections.Generic;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taskName = "";
            int taskPriority = 0;
            
        }

        public createTask(string taskName, int taskPriority) {
            return{taskName,taskPriority};
        }
    }
}
