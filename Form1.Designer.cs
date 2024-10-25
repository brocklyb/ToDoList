namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            all_tasks = new ListView();
            task_name = new TextBox();
            task_priority = new TextBox();
            due_date = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // all_tasks
            // 
            all_tasks.Location = new Point(12, 53);
            all_tasks.Name = "all_tasks";
            all_tasks.Size = new Size(181, 256);
            all_tasks.TabIndex = 0;
            all_tasks.UseCompatibleStateImageBehavior = false;
            // 
            // task_name
            // 
            task_name.Location = new Point(295, 53);
            task_name.Name = "task_name";
            task_name.Size = new Size(274, 23);
            task_name.TabIndex = 1;
            // 
            // task_priority
            // 
            task_priority.Location = new Point(295, 94);
            task_priority.Name = "task_priority";
            task_priority.Size = new Size(88, 23);
            task_priority.TabIndex = 2;
            task_priority.Text = "1-9";
            // 
            // due_date
            // 
            due_date.Location = new Point(295, 136);
            due_date.Name = "due_date";
            due_date.Size = new Size(200, 23);
            due_date.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 55);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 5;
            label1.Text = "Task Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 97);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 142);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 7;
            label3.Text = "Due Date";
            // 
            // button1
            // 
            button1.Location = new Point(216, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Create Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 286);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 586);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(due_date);
            Controls.Add(task_priority);
            Controls.Add(task_name);
            Controls.Add(all_tasks);
            Name = "Form1";
            Text = "To Do List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView all_tasks;
        private TextBox task_name;
        private TextBox task_priority;
        private DateTimePicker due_date;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}
