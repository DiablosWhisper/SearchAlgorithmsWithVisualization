namespace SearchAlgorithmsWithVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depthFirstSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breadthFirstSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kruskalTreeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primTreeSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bellmanFordPahSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijkstraPathSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floydWarshallPathSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.johnsonPathSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fordFulkersonStreamSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPathSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Visualizer = new System.Windows.Forms.PictureBox();
            this.DFS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BFS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BFPS = new System.Windows.Forms.TextBox();
            this.PTS = new System.Windows.Forms.TextBox();
            this.DPS = new System.Windows.Forms.TextBox();
            this.FFSS = new System.Windows.Forms.TextBox();
            this.ASPS = new System.Windows.Forms.TextBox();
            this.InstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem,
            this.algorithmsToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.InstructionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1281, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // algorithmsToolStripMenuItem
            // 
            this.algorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depthFirstSearchToolStripMenuItem,
            this.breadthFirstSearchToolStripMenuItem,
            this.kruskalTreeSearchToolStripMenuItem,
            this.primTreeSearchToolStripMenuItem,
            this.bellmanFordPahSearchToolStripMenuItem,
            this.dijkstraPathSearchToolStripMenuItem,
            this.floydWarshallPathSearchToolStripMenuItem,
            this.johnsonPathSearchToolStripMenuItem,
            this.fordFulkersonStreamSearchToolStripMenuItem,
            this.aPathSearchToolStripMenuItem});
            this.algorithmsToolStripMenuItem.Name = "algorithmsToolStripMenuItem";
            this.algorithmsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algorithmsToolStripMenuItem.Text = "Algorithms";
            // 
            // depthFirstSearchToolStripMenuItem
            // 
            this.depthFirstSearchToolStripMenuItem.Name = "depthFirstSearchToolStripMenuItem";
            this.depthFirstSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.depthFirstSearchToolStripMenuItem.Text = "Depth First Search";
            this.depthFirstSearchToolStripMenuItem.Click += new System.EventHandler(this.DepthFirstSearchToolStripMenuItem_Click);
            // 
            // breadthFirstSearchToolStripMenuItem
            // 
            this.breadthFirstSearchToolStripMenuItem.Name = "breadthFirstSearchToolStripMenuItem";
            this.breadthFirstSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.breadthFirstSearchToolStripMenuItem.Text = "Breadth First Search";
            this.breadthFirstSearchToolStripMenuItem.Click += new System.EventHandler(this.BreadthFirstSearchToolStripMenuItem_Click);
            // 
            // kruskalTreeSearchToolStripMenuItem
            // 
            this.kruskalTreeSearchToolStripMenuItem.Name = "kruskalTreeSearchToolStripMenuItem";
            this.kruskalTreeSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.kruskalTreeSearchToolStripMenuItem.Text = "Kruskal Tree Search";
            this.kruskalTreeSearchToolStripMenuItem.Click += new System.EventHandler(this.KruskalTreeSearchToolStripMenuItem_Click);
            // 
            // primTreeSearchToolStripMenuItem
            // 
            this.primTreeSearchToolStripMenuItem.Name = "primTreeSearchToolStripMenuItem";
            this.primTreeSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.primTreeSearchToolStripMenuItem.Text = "Prim Tree Search";
            this.primTreeSearchToolStripMenuItem.Click += new System.EventHandler(this.PrimTreeSearchToolStripMenuItem_Click);
            // 
            // bellmanFordPahSearchToolStripMenuItem
            // 
            this.bellmanFordPahSearchToolStripMenuItem.Name = "bellmanFordPahSearchToolStripMenuItem";
            this.bellmanFordPahSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.bellmanFordPahSearchToolStripMenuItem.Text = "Bellman-Ford Pah Search";
            this.bellmanFordPahSearchToolStripMenuItem.Click += new System.EventHandler(this.BellmanFordPahSearchToolStripMenuItem_Click);
            // 
            // dijkstraPathSearchToolStripMenuItem
            // 
            this.dijkstraPathSearchToolStripMenuItem.Name = "dijkstraPathSearchToolStripMenuItem";
            this.dijkstraPathSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.dijkstraPathSearchToolStripMenuItem.Text = "Dijkstra Path Search";
            this.dijkstraPathSearchToolStripMenuItem.Click += new System.EventHandler(this.DijkstraPathSearchToolStripMenuItem_Click);
            // 
            // floydWarshallPathSearchToolStripMenuItem
            // 
            this.floydWarshallPathSearchToolStripMenuItem.Name = "floydWarshallPathSearchToolStripMenuItem";
            this.floydWarshallPathSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.floydWarshallPathSearchToolStripMenuItem.Text = "Floyd-Warshall Path Search";
            this.floydWarshallPathSearchToolStripMenuItem.Click += new System.EventHandler(this.FloydWarshallPathSearchToolStripMenuItem_Click);
            // 
            // johnsonPathSearchToolStripMenuItem
            // 
            this.johnsonPathSearchToolStripMenuItem.Name = "johnsonPathSearchToolStripMenuItem";
            this.johnsonPathSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.johnsonPathSearchToolStripMenuItem.Text = "Johnson Path Search";
            this.johnsonPathSearchToolStripMenuItem.Click += new System.EventHandler(this.JohnsonPathSearchToolStripMenuItem_Click);
            // 
            // fordFulkersonStreamSearchToolStripMenuItem
            // 
            this.fordFulkersonStreamSearchToolStripMenuItem.Name = "fordFulkersonStreamSearchToolStripMenuItem";
            this.fordFulkersonStreamSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.fordFulkersonStreamSearchToolStripMenuItem.Text = "Ford-Fulkerson Stream Search";
            this.fordFulkersonStreamSearchToolStripMenuItem.Click += new System.EventHandler(this.FordFulkersonStreamSearchToolStripMenuItem_Click);
            // 
            // aPathSearchToolStripMenuItem
            // 
            this.aPathSearchToolStripMenuItem.Name = "aPathSearchToolStripMenuItem";
            this.aPathSearchToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.aPathSearchToolStripMenuItem.Text = "A* Path Search";
            this.aPathSearchToolStripMenuItem.Click += new System.EventHandler(this.APathSearchToolStripMenuItem_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Calculate";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // Visualizer
            // 
            this.Visualizer.BackColor = System.Drawing.Color.Silver;
            this.Visualizer.Location = new System.Drawing.Point(13, 28);
            this.Visualizer.Name = "Visualizer";
            this.Visualizer.Size = new System.Drawing.Size(1085, 529);
            this.Visualizer.TabIndex = 1;
            this.Visualizer.TabStop = false;
            // 
            // DFS
            // 
            this.DFS.Location = new System.Drawing.Point(1125, 44);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(109, 20);
            this.DFS.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1130, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depth First Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1130, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breadth First Search";
            // 
            // BFS
            // 
            this.BFS.Location = new System.Drawing.Point(1125, 83);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(109, 20);
            this.BFS.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1136, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prim Tree Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1113, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bellman-Ford Path Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1129, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dijkstra Path Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1104, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ford-Fulkerson Stream Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1140, 263);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "A* Path Search";
            // 
            // BFPS
            // 
            this.BFPS.Location = new System.Drawing.Point(1125, 161);
            this.BFPS.Name = "BFPS";
            this.BFPS.Size = new System.Drawing.Size(108, 20);
            this.BFPS.TabIndex = 15;
            // 
            // PTS
            // 
            this.PTS.Location = new System.Drawing.Point(1125, 122);
            this.PTS.Name = "PTS";
            this.PTS.Size = new System.Drawing.Size(108, 20);
            this.PTS.TabIndex = 16;
            // 
            // DPS
            // 
            this.DPS.Location = new System.Drawing.Point(1125, 201);
            this.DPS.Name = "DPS";
            this.DPS.Size = new System.Drawing.Size(108, 20);
            this.DPS.TabIndex = 17;
            // 
            // FFSS
            // 
            this.FFSS.Location = new System.Drawing.Point(1125, 240);
            this.FFSS.Name = "FFSS";
            this.FFSS.Size = new System.Drawing.Size(109, 20);
            this.FFSS.TabIndex = 18;
            // 
            // ASPS
            // 
            this.ASPS.Location = new System.Drawing.Point(1125, 279);
            this.ASPS.Name = "ASPS";
            this.ASPS.Size = new System.Drawing.Size(108, 20);
            this.ASPS.TabIndex = 19;
            // 
            // InstructionToolStripMenuItem
            // 
            this.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem";
            this.InstructionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.InstructionToolStripMenuItem.Text = "Instruction";
            this.InstructionToolStripMenuItem.Click += new System.EventHandler(this.InstructionToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 569);
            this.Controls.Add(this.ASPS);
            this.Controls.Add(this.FFSS);
            this.Controls.Add(this.DPS);
            this.Controls.Add(this.PTS);
            this.Controls.Add(this.BFPS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.Visualizer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Visualizer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algorithmsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depthFirstSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breadthFirstSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kruskalTreeSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primTreeSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bellmanFordPahSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijkstraPathSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floydWarshallPathSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem johnsonPathSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fordFulkersonStreamSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPathSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.PictureBox Visualizer;
        private System.Windows.Forms.TextBox DFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BFS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BFPS;
        private System.Windows.Forms.TextBox PTS;
        private System.Windows.Forms.TextBox DPS;
        private System.Windows.Forms.TextBox FFSS;
        private System.Windows.Forms.TextBox ASPS;
        private System.Windows.Forms.ToolStripMenuItem InstructionToolStripMenuItem;
    }
}

