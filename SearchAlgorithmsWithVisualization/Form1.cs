using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System;

namespace SearchAlgorithmsWithVisualization
{
    public partial class Form1 : Form
    {
        #region Form Actions
        private void FordFulkersonStreamSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FordFulkersonStreamSearch.CapacityOfFlow.ToString());
        }
        private void FloydWarshallPathSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilities.GetResult(FloydWarshallPathSearch.MatrixOfTheShortesPathes));
        }
        private void BellmanFordPahSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilities.GetResult(BellmanFordPathSearch.ShortestPathes, Graph.SetOfNodes[int.Parse(BFPS.Text)]));
        }
        private void JohnsonPathSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilities.GetResult(JohnsonPathSearch.MatrixOfTheShortesPathes));
        }
        private void BreadthFirstSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawResult(BreadthFirstSearch.ResultOfSearching);
        }
        private void DijkstraPathSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Utilities.GetResult(DijkstraPathSearch.ShortestPathes, Graph.SetOfNodes[int.Parse(DPS.Text)]));
        }
        private void KruskalTreeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawResult(KruskalTreeSearch.MinimumSpanningTree);
        }
        private void DepthFirstSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawResult(DepthFirstSearch.ResultOfSearching);
        }
        private void PrimTreeSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawResult(PrimTreeSearch.MinimumSpanningTree);
        }
        private void APathSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrawResult(AStarPathSearch.ShortesPath);
        }
        private void InstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1 : Load your graph.\nStep 2 : Input values to the text boxes\nStep 3 : Press \"Actions -> Calculate\".\nStep 4 : Call an appropriate function from \"Algorithms\".");
        }
        private void StartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepthFirstSearch = new DepthFirstSearchAlgorithm(Graph);

            BreadthFirstSearch = new BreadthFirstSearchAlgorithm(Graph);

            KruskalTreeSearch = new KruscalAlgorithm(Graph);

            PrimTreeSearch = new PrimAlgorithm(Graph);

            BellmanFordPathSearch = new BellmanFordAlgorithm(Graph);

            DijkstraPathSearch = new DijkstraAlgorithm(Graph);

            FloydWarshallPathSearch = new FloydWarshallAlgorithm(Graph);

            JohnsonPathSearch = new JohnsonAlgorithm(Graph);

            AStarPathSearch = new AStarAlgorithm(Graph);

            FordFulkersonStreamSearch = new FordFulkersonAlgorithm(Graph);

            string[] Request = DFS.Text.Split(' ');

            if (Request.Length.Equals(1) && Request[0] != "")
            {
                DepthFirstSearch.DepthFirstSearch(Graph.SetOfNodes[int.Parse(Request[0])]);
            }
            else if (Request.Length.Equals(2))
            {
                DepthFirstSearch.DepthFirstSearch(Graph.SetOfNodes[int.Parse(Request[0])], Graph.SetOfNodes[int.Parse(Request[1])]);
            }

            Request = BFS.Text.Split(' ');

            if (Request.Length.Equals(1) && Request[0] != "")
            {
                BreadthFirstSearch.BreadthFirstSearch(Graph.SetOfNodes[int.Parse(Request[0])]);
            }
            else if (Request.Length.Equals(2))
            {
                BreadthFirstSearch.BreadthFirstSearch(Graph.SetOfNodes[int.Parse(Request[0])], Graph.SetOfNodes[int.Parse(Request[1])]);
            }

            KruskalTreeSearch.FindMinimumSpanningTree();

            Request = PTS.Text.Split(' ');

            if (Request.Length.Equals(1) && Request[0] != "")
            {
                PrimTreeSearch.FindMinimumSpanningTree(Graph.SetOfNodes[int.Parse(Request[0])]);
            }

            Request = BFPS.Text.Split(' ');

            if (Request.Length.Equals(1) && Request[0] != "")
            {
                BellmanFordPathSearch.FindTheShortestPathes(Graph.SetOfNodes[int.Parse(Request[0])]);
            }

            Request = DPS.Text.Split(' ');

            if (Request.Length.Equals(1) && Request[0] != "")
            {
                DijkstraPathSearch.FindTheShortestPathes(Graph.SetOfNodes[int.Parse(Request[0])]);
            }

            FloydWarshallPathSearch.FindAllTheShortestPathes();

            JohnsonPathSearch.FindAllTheShortestPathes();

            Request = FFSS.Text.Split(' ');

            if (Request.Length.Equals(2) && Request[0] != "" && Request[1] != "")
            {
                FordFulkersonStreamSearch.FindMaximumFlowWithDFSRealization(Graph.SetOfNodes[int.Parse(Request[0])], Graph.SetOfNodes[int.Parse(Request[1])]);
            }

            Request = ASPS.Text.Split(' ');

            if (Request.Length.Equals(2) && Request[0] != "" && Request[1] != "")
            {
                AStarPathSearch.FindTheShortesPath(Graph.SetOfNodes[int.Parse(Request[0])], Graph.SetOfNodes[int.Parse(Request[1])]);
            }

            MessageBox.Show("All algorithms were calculated!");
        }
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGraph();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Additional Functions
        private FordFulkersonAlgorithm FordFulkersonStreamSearch { get; set; }
        private FloydWarshallAlgorithm FloydWarshallPathSearch { get; set; }
        private BreadthFirstSearchAlgorithm BreadthFirstSearch { get; set; }
        private BellmanFordAlgorithm BellmanFordPathSearch { get; set; }
        private DepthFirstSearchAlgorithm DepthFirstSearch { get; set; }
        private JohnsonAlgorithm JohnsonPathSearch { get; set; }
        private DijkstraAlgorithm DijkstraPathSearch { get; set; }
        private KruscalAlgorithm KruskalTreeSearch { get; set; }
        private AStarAlgorithm AStarPathSearch { get; set; }
        private PrimAlgorithm PrimTreeSearch { get; set; }
        private void DrawResult(List<Edge> Edges)
        {
            Reset();

            for (int Index = 0; Index < Edges.Count; Index++)
            {
                Edges[Index][0].MarkNodeAsVisited();

                Edges[Index][0].FillCircle();

                Edges[Index][0].DrawNameOfNode();

                Thread.Sleep(500);

                Edges[Index].MarkEdgeAsVisited();

                Edges[Index].DrawNameOfEdge();

                Edges[Index][0].FillCircle();

                Edges[Index][0].DrawNameOfNode();

                Edges[Index][1].FillCircle();

                Edges[Index][1].DrawNameOfNode();

                Thread.Sleep(500);

                Edges[Index][1].MarkNodeAsVisited();

                Thread.Sleep(500);
            }
        }
        private Graph Graph { get; set; }
        private void LoadGraph()
        {
            Visualizer.Refresh();

            StreamReader Reader = new StreamReader("TestGraph1.txt");

            string CurrentLine = string.Empty;

            int NumberOfNodes = 0;

            Graph = new Graph();

            string[] Data;

            for (; !Reader.EndOfStream;)
            {
                CurrentLine = Reader.ReadLine();

                if (CurrentLine.StartsWith("Nodes"))
                {
                    Data = CurrentLine.Split(' ');

                    NumberOfNodes = int.Parse(Data[1]);
                }

                Data = CurrentLine.Split(' ');

                if (Data.Length.Equals(3))
                {
                    Graph.AddNode(new Node(Visualizer, NumberOfNodes, Data[0], int.Parse(Data[1]), int.Parse(Data[2])));
                }

                if (CurrentLine.StartsWith("t"))
                {
                    Data = CurrentLine.Split(' ');

                    Graph.AddTwoWayEdge(new Edge(Visualizer, double.Parse(Data[1]), Graph.SetOfNodes[int.Parse(Data[2])], Graph.SetOfNodes[int.Parse(Data[3])]));
                }
            }

            Reader.Close();

            for (int Index = 0; Index < Graph.NumberOfNodes; Index++)
            {
                Graph.SetOfNodes[Index].FillCircle();

                Graph.SetOfNodes[Index].DrawNameOfNode();
            }
        }
        private void Reset()
        {
            Visualizer.Refresh();

            for (int Index = 0; Index < Graph.NumberOfNodes; Index++)
            {
                Graph.SetOfNodes[Index].MarkNodeAsUnVisited();
            }

            for (int Index = 0; Index < Graph.NumberOfEdges; Index++)
            {
                Graph.SetOfEdges[Index].MarkEdgeAsUnVisited();
            }

            for (int Index = 0; Index < Graph.NumberOfNodes; Index++)
            {
                Graph.SetOfNodes[Index].FillCircle();

                Graph.SetOfNodes[Index].DrawNameOfNode();
            }
        }
        #endregion
    }

    public static class Utilities
    {
        #region Useful Stuff
        public static double Infinity { get { return double.PositiveInfinity; } }
        public static double Min(double FirstValue, double SecondValue)
        {
            if (FirstValue < SecondValue)
            {
                return FirstValue;
            }

            return SecondValue;
        }
        public static double CalculateHeuristic(Node Start, Node Target)
        {
            return Math.Sqrt(Math.Pow(Start.CoordinateX - Target.CoordinateX, 2) + Math.Pow(Start.CoordinateY - Target.CoordinateY, 2));
        }
        public static void SetNodesWeightOfInfinity(List<Node> Nodes)
        {
            for (int Index = 0; Index < Nodes.Count; Index++)
            {
                Nodes[Index].Weight = Infinity;
            }
        }
        public static string GetResult(List<Node> Nodes, Node Start)
        {
            string Result = string.Empty;

            Result += $"{Start.Name} => ";

            Result += string.Join($"{Start.Name} => ", Nodes.Select(Node => Node.Name + $" = {Node.Weight}\n"));

            return Result;
        }
        public static void PrintResult(List<Node> Nodes, Node Start)
        {
            Console.Write($"{Start.Name} => ");

            Console.WriteLine(string.Join($"{Start.Name} => ", Nodes.Select(Node => Node.Name + $" = {Node.Weight}\n")));
        }
        public static void PrintResult(List<Edge> Edges)
        {
            Console.WriteLine(string.Join(" => ", Edges.Select(Edge => Edge.Name)));
        }
        public static string GetResult(double[,] Matrix)
        {
            string Result = string.Empty;

            Result += "\t";

            for (int Index = 0; Index < Matrix.GetLength(0); Index++)
            {
                Result += $"[{Index.ToString()}]\t";
            }

            Result += "\n\n";

            for (int FirstIndex = 0; FirstIndex < Matrix.GetLength(0); FirstIndex++)
            {
                Result += $"[{FirstIndex}]\t";

                for (int SecondIndex = 0; SecondIndex < Matrix.GetLength(0); SecondIndex++)
                {
                    Result += $"{Matrix[FirstIndex, SecondIndex]}\t";
                }

                Result += "\n\n";
            }

            return Result;
        }
        public static void PrintResult(double[,] Matrix)
        {
            Console.Write("\t");

            for (int Index = 0; Index < Matrix.GetLength(0); Index++)
            {
                Console.Write($"[{Index.ToString()}]\t");
            }

            Console.WriteLine("\n");

            for (int FirstIndex = 0; FirstIndex < Matrix.GetLength(0); FirstIndex++)
            {
                Console.Write($"[{FirstIndex}]\t");

                for (int SecondIndex = 0; SecondIndex < Matrix.GetLength(0); SecondIndex++)
                {
                    Console.Write($"{Matrix[FirstIndex, SecondIndex]}\t");
                }

                Console.WriteLine("\n");
            }
        }
        #endregion
    }

    public class Node : ICloneable
    {
        #region Graphic Presentation Of Node
        public Node(PictureBox Box, int NumberOfInheritors, string Name, int CoordinateX, int CoordinateY)
        {
            Inheritors = new Node[NumberOfInheritors + 1];

            this.CoordinateX = CoordinateX;

            this.CoordinateY = CoordinateY;

            this.Name = $"[{Name}]";

            Weight = 0.0;

            Index = 0;

            Circle = Box.CreateGraphics();

            Circle.DrawEllipse(new Pen(Color.Black, 2), CoordinateX, CoordinateY, 35, 35);
        }
        public void MarkNodeAsUnVisited()
        {
            Circle.DrawEllipse(new Pen(Color.Black, 2), CoordinateX, CoordinateY, 35, 35);
        }
        public void MarkNodeAsVisited()
        {
            Circle.DrawEllipse(new Pen(Color.MintCream, 3), CoordinateX, CoordinateY, 35, 35);
        }
        public void DrawNameOfNode()
        {
            Circle.DrawString(Name, new Font("Calibri Light", 12, FontStyle.Bold), new SolidBrush(Color.Blue), CoordinateX + 3, CoordinateY + 5);
        }
        public Graphics Circle { get; set; }
        public void FillCircle()
        {
            Circle.FillEllipse(new SolidBrush(Color.Silver), CoordinateX + 2, CoordinateY + 2, 31, 31);
        }
        #endregion

        #region Mathematical Presentation Of Node
        public Node(int NumberOfInheritors, string Name, int CoordinateX, int CoordinateY)
        {
            Inheritors = new Node[NumberOfInheritors + 1];

            this.CoordinateX = CoordinateX;

            this.CoordinateY = CoordinateY;

            this.Name = $"[{Name}]";

            Weight = 0.0;

            Index = 0;
        }
        public Node(int NumberOfInheritors, string Name)
        {
            Inheritors = new Node[NumberOfInheritors + 1];

            this.Name = $"[{Name}]";

            Weight = 0.0;

            Index = 0;
        }
        public double HeuristicPathWeight { get; set; }
        public double GainedPathWeight { get; set; }
        public override bool Equals(object Object)
        {
            Node Node = (Node)Object;

            return this.Name.Equals(Node.Name);
        }
        public double TotalPathWeight { get; set; }
        public int CoordinateX { get; private set; }
        public int CoordinateY { get; private set; }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Node[] Inheritors { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index < Inheritors.Length)
                {
                    return Inheritors[Index];
                }

                return null;
            }
            set
            {
                if (Index >= 0 && Index < Inheritors.Length)
                {
                    Inheritors[Index] = value;
                }
            }
        }
        public int Index { get; set; }
        public object Clone()
        {
            Node Node = new Node
            {
                CoordinateX = this.CoordinateX,

                CoordinateY = this.CoordinateY,

                Inheritors = this.Inheritors,

                Weight = this.Weight,

                Name = this.Name,

                Circle = this.Circle,

                Index = this.Index,
            };

            return Node;
        }
        public Node()
        {
            HeuristicPathWeight = 0.0;

            GainedPathWeight = 0.0;

            TotalPathWeight = 0.0;

            Name = string.Empty;

            Inheritors = null;

            CoordinateX = 0;

            CoordinateY = 0;

            Weight = 0.0;

            Circle = null;

            Index = 0;
        }
        #endregion
    }

    public class Edge : ICloneable
    {
        #region Graphic Presentation Of Edge
        public Edge(PictureBox Box, double Weight, params Node[] Nodes)
        {
            Ends = new List<Node>();

            for (int Index = 0; Index < Nodes.Length; Index++)
            {
                Ends.Add(Nodes[Index]);
            }

            StartCoordinateX = Nodes[0].CoordinateX + 12;

            StartCoordinateY = Nodes[0].CoordinateY + 20;

            EndCoordinateX = Nodes[1].CoordinateX + 12;

            EndCoordinateY = Nodes[1].CoordinateY + 20;

            this.Weight = Weight;

            Ends[0][Nodes[1].Index] = Nodes[1];

            Name = $"{Nodes[0].Name}{Nodes[1].Name}";

            Line = Box.CreateGraphics();

            Line.DrawLine(new Pen(Color.Black, 2), StartCoordinateX, StartCoordinateY, EndCoordinateX, EndCoordinateY);

            Line.DrawString(Weight.ToString(), new Font("Calibri Light", 15, FontStyle.Bold), new SolidBrush(Color.Red), (EndCoordinateX + StartCoordinateX) / 2, (EndCoordinateY + StartCoordinateY) / 2);
        }
        private int StartCoordinateX { get; set; }
        private int StartCoordinateY { get; set; }
        private int EndCoordinateX { get; set; }
        private int EndCoordinateY { get; set; }
        public void MarkEdgeAsUnVisited()
        {
            Line.DrawLine(new Pen(Color.Black, 2), StartCoordinateX, StartCoordinateY, EndCoordinateX, EndCoordinateY);

            Line.DrawString(Weight.ToString(), new Font("Calibri Light", 15, FontStyle.Bold), new SolidBrush(Color.Red), (EndCoordinateX + StartCoordinateX) / 2 , (EndCoordinateY + StartCoordinateY) / 2);
        }
        public void MarkEdgeAsVisited()
        {
            Line.DrawLine(new Pen(Color.LightGreen, 3), StartCoordinateX, StartCoordinateY, EndCoordinateX, EndCoordinateY);
        }
        public void DrawNameOfEdge()
        {
            Line.DrawString(Weight.ToString(), new Font("Calibri Light", 15, FontStyle.Bold), new SolidBrush(Color.Red), (EndCoordinateX + StartCoordinateX) / 2, (EndCoordinateY + StartCoordinateY) / 2);
        }
        public Graphics Line { get; set; }
        #endregion

        #region Mathematical Presentation Of Edge
        public Edge(double Weight, params Node[] Nodes)
        {
            Ends = new List<Node>();

            for (int Index = 0; Index < Nodes.Length; Index++)
            {
                Ends.Add(Nodes[Index]);
            }

            this.Weight = Weight;

            Ends[0][Nodes[1].Index] = Nodes[1];

            Name = $"{Nodes[0].Name}{Nodes[1].Name}";
        }
        public List<Node> Ends { get; private set; }
        public string Name { get; private set; }
        public double Weight { get; set; }
        public Node this[int Index]
        {
            get
            {
                if (Index >= 0 && Index <= 1)
                {
                    return Ends[Index];
                }

                return null;
            }
        }
        public Edge ReverseEdge()
        {
            Edge Edge = new Edge(this.Weight, this.Ends[1], this.Ends[0])
            {
                StartCoordinateX = this.StartCoordinateX,

                StartCoordinateY = this.StartCoordinateY,

                EndCoordinateX = this.EndCoordinateX,

                EndCoordinateY = this.EndCoordinateY,

                Line = this.Line
            };

            return Edge;
        }
        public int Index { get; set; }
        public object Clone()
        {
            List<Node> EndsOfEdge = new List<Node>()
            {
                (Node)this.Ends[0].Clone(),

                (Node)this.Ends[1].Clone()
            };

            Edge Edge = new Edge
            {
                StartCoordinateX = this.StartCoordinateX,

                StartCoordinateY = this.StartCoordinateY,

                EndCoordinateX = this.EndCoordinateX,

                EndCoordinateY = this.EndCoordinateY,

                Weight = this.Weight,

                Ends = EndsOfEdge,

                Name = this.Name,

                Index = this.Index,

                Line = this.Line,
            };

            return Edge;
        }
        public Edge()
        {
            Ends = new List<Node>();

            Name = string.Empty;

            Weight = 0.0;

            Line = null;

            Index = 0;
        }
        #endregion
    }

    public class Graph
    {
        #region Mathematical Presentation Of Graph
        public int NumberOfNodes { get { return SetOfNodes.Count; } }
        public int NumberOfEdges { get { return SetOfEdges.Count; } }
        public bool NegativeCycleChecker(List<Node> Nodes)
        {
            for (int Index = 0; Index < NumberOfEdges; Index++)
            {
                if (Nodes[SetOfEdges[Index][1].Index].Weight > Nodes[SetOfEdges[Index][0].Index].Weight + SetOfEdges[Index].Weight)
                {
                    return false;
                }
            }
            return true;
        }
        public bool NegativeCycleChecker(Node[] Nodes)
        {
            for (int Index = 0; Index < NumberOfEdges; Index++)
            {
                if (Nodes[SetOfEdges[Index][1].Index].Weight > Nodes[SetOfEdges[Index][0].Index].Weight + SetOfEdges[Index].Weight)
                {
                    return false;
                }
            }
            return true;
        }
        public List<Node> SetOfNodes { get; private set; }
        public List<Edge> SetOfEdges { get; private set; }
        public Edge FindEdge(params Node[] Nodes)
        {
            for (int Index = 0; Index < NumberOfEdges; Index++)
            {
                if (SetOfEdges[Index][0].Equals(Nodes[0]) && SetOfEdges[Index][1].Equals(Nodes[1]))
                {
                    return SetOfEdges[Index];
                }
            }

            return new Edge { Weight = double.PositiveInfinity };
        }
        public void AddOneWayEdge(Edge Edge)
        {
            SetOfEdges.Add(Edge);

            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;
        }
        public void AddTwoWayEdge(Edge Edge)
        {
            SetOfEdges.Add(Edge);

            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;

            SetOfEdges.Add(Edge.ReverseEdge());

            SetOfEdges[SetOfEdges.Count - 1].Index = SetOfEdges.Count - 1;
        }
        public void AddNode(Node Node)
        {
            SetOfNodes.Add(Node);

            SetOfNodes[SetOfNodes.Count - 1].Index = SetOfNodes.Count - 1;
        }
        public object Clone()
        {
            List<Node> SetOfNodes = new List<Node>();

            for (int Index = 0; Index < NumberOfNodes; Index++)
            {
                SetOfNodes.Add((Node)this.SetOfNodes[Index].Clone());
            }

            List<Edge> SetOfEdges = new List<Edge>();

            for (int Index = 0; Index < NumberOfEdges; Index++)
            {
                SetOfEdges.Add((Edge)this.SetOfEdges[Index].Clone());
            }

            Graph Graph = new Graph
            {
                SetOfNodes = SetOfNodes,

                SetOfEdges = SetOfEdges
            };

            return Graph;
        }
        public Graph()
        {
            SetOfNodes = new List<Node>();

            SetOfEdges = new List<Edge>();
        }
        #endregion
    }

    #region Algorithms
    public class DepthFirstSearchAlgorithm
    {
        public bool DepthFirstSearch(Node Start, Node Target, Node[] FoundPath)
        {
            VisitedNodes.Add(Start);

            if (VisitedNodes.Contains(Target))
            {
                return true;
            }

            for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]) && InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]).Weight > 0)
                {
                    FoundPath[Index] = Start;

                    if (DepthFirstSearch(InnerGraph.SetOfNodes[Index], Target, FoundPath))
                    {
                        return true;
                    }
                }
            }

            return VisitedNodes.Contains(Target);
        }
        public bool DepthFirstSearch(Node Start, Node Target)
        {
            VisitedNodes.Add(Start);

            if (VisitedNodes.Contains(Target))
            {
                return true;
            }

            for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                {
                    ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));

                    if (DepthFirstSearch(InnerGraph.SetOfNodes[Index], Target))
                    {
                        return true;
                    }
                }
            }

            return VisitedNodes.Contains(Target);
        }
        public DepthFirstSearchAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            ResultOfSearching = new List<Edge>();

            VisitedNodes = new List<Node>();
        }
        public bool DepthFirstSearch(Node Start)
        {
            VisitedNodes.Add(Start);

            for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
            {
                if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                {
                    ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));

                    DepthFirstSearch(InnerGraph.SetOfNodes[Index]);
                }
            }

            return VisitedNodes.Count.Equals(InnerGraph.NumberOfNodes);
        }
        public List<Edge> ResultOfSearching { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }
    }

    public class BreadthFirstSearchAlgorithm
    {
        public bool BreadthFirstSearch(Node Start, Node Target, Node[] FoundPath)
        {
            Queue.Enqueue(Start);

            VisitedNodes.Add(Start);

            FoundPath[Start.Index] = Start;

            if (VisitedNodes.Contains(Target))
            {
                return true;
            }

            for (; Queue.Count > 0;)
            {
                Start = Queue.Dequeue();

                for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
                {
                    if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]) && InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]).Weight > 0)
                    {
                        FoundPath[Index] = Start;

                        Queue.Enqueue(InnerGraph.SetOfNodes[Index]);

                        VisitedNodes.Add(InnerGraph.SetOfNodes[Index]);
                    }
                }
            }

            return VisitedNodes.Contains(Target);
        }
        public bool BreadthFirstSearch(Node Start, Node Target)
        {
            Queue.Enqueue(Start);

            VisitedNodes.Add(Start);

            if (VisitedNodes.Contains(Target))
            {
                return true;
            }

            for (; Queue.Count > 0;)
            {
                Start = Queue.Dequeue();

                for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
                {
                    if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                    {
                        ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));

                        Queue.Enqueue(InnerGraph.SetOfNodes[Index]);

                        VisitedNodes.Add(InnerGraph.SetOfNodes[Index]);

                        if (VisitedNodes.Contains(Target))
                        {
                            return true;
                        }
                    }
                }
            }

            return VisitedNodes.Contains(Target);
        }
        public BreadthFirstSearchAlgorithm(Graph Graph)
        {
            Queue = new Queue<Node>();

            InnerGraph = (Graph)Graph.Clone();

            ResultOfSearching = new List<Edge>();

            VisitedNodes = new List<Node>();
        }
        public bool BreadthFirstSearch(Node Start)
        {
            Queue.Enqueue(Start);

            VisitedNodes.Add(Start);

            for (; Queue.Count > 0;)
            {
                Start = Queue.Dequeue();

                for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
                {
                    if (InnerGraph.SetOfNodes[Start.Index][Index] != null && !VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                    {
                        ResultOfSearching.Add(InnerGraph.FindEdge(Start, InnerGraph.SetOfNodes[Index]));

                        Queue.Enqueue(InnerGraph.SetOfNodes[Index]);

                        VisitedNodes.Add(InnerGraph.SetOfNodes[Index]);
                    }
                }
            }

            return VisitedNodes.Count.Equals(InnerGraph.NumberOfNodes);
        }
        public List<Edge> ResultOfSearching { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }
        private Queue<Node> Queue { get; }
    }

    public class KruscalAlgorithm
    {
        public List<Edge> MinimumSpanningTree { get; }
        private static Graph InnerGraph { get; set; }
        public bool FindMinimumSpanningTree()
        {
            SortEdges();

            for (int Index = 0; Index < InnerGraph.NumberOfEdges; Index++)
            {
                Node StartNode = FindSubTree(InnerGraph.SetOfEdges[Index][0]);

                Node EndNode = FindSubTree(InnerGraph.SetOfEdges[Index][1]);

                if (!StartNode.Equals(EndNode))
                {
                    MinimumSpanningTree.Add(InnerGraph.SetOfEdges[Index]);

                    InnerGraph.SetOfNodes[EndNode.Index] = StartNode;
                }
            }

            return true;
        }
        public KruscalAlgorithm(Graph Graph)
        {
            MinimumSpanningTree = new List<Edge>();

            InnerGraph = (Graph)Graph.Clone();
        }
        private Node FindSubTree(Node Root)
        {
            Node OldNode = new Node();

            Node RootOfTree = Root;

            for (; !RootOfTree.Equals(InnerGraph.SetOfNodes[RootOfTree.Index]);)
            {
                RootOfTree = InnerGraph.SetOfNodes[RootOfTree.Index];
            }

            for (; !Root.Equals(RootOfTree);)
            {
                OldNode = InnerGraph.SetOfNodes[Root.Index];

                InnerGraph.SetOfNodes[Root.Index] = RootOfTree;

                Root = OldNode;
            }

            return RootOfTree;
        }
        private void SortEdges()
        {
            Edge TemporaryEdge = new Edge();

            for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfEdges; FirstIndex++)
            {
                for (int SecondIndex = FirstIndex + 1; SecondIndex < InnerGraph.NumberOfEdges; SecondIndex++)
                {
                    if (InnerGraph.SetOfEdges[FirstIndex].Weight > InnerGraph.SetOfEdges[SecondIndex].Weight)
                    {
                        TemporaryEdge = InnerGraph.SetOfEdges[FirstIndex];

                        InnerGraph.SetOfEdges[FirstIndex] = InnerGraph.SetOfEdges[SecondIndex];

                        InnerGraph.SetOfEdges[SecondIndex] = TemporaryEdge;
                    }
                }
            }
        }
    }

    public class PrimAlgorithm
    {
        public bool FindMinimumSpanningTree(Node Start)
        {
            VisitedNodes.Add(InnerGraph.SetOfNodes[Start.Index]);

            for (; VisitedNodes.Count < InnerGraph.NumberOfNodes;)
            {
                Node Root = new Node();

                Node End = new Node();

                Edge CurrentEdge = new Edge { Weight = Utilities.Infinity };

                for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
                {
                    if (VisitedNodes.Contains(InnerGraph.SetOfNodes[Index]))
                    {
                        foreach (Node Inheritor in InnerGraph.SetOfNodes[Index].Inheritors.Where(Node => Node != null && !VisitedNodes.Contains(Node)))
                        {
                            if (CurrentEdge.Weight > InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], Inheritor).Weight)
                            {
                                CurrentEdge = InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], Inheritor);

                                Root = CurrentEdge[0];

                                End = CurrentEdge[1];
                            }
                        }
                    }
                }

                VisitedNodes.Add(End);

                MinimumSpanningTree.Add(InnerGraph.FindEdge(Root, End));
            }

            return VisitedNodes.Count.Equals(InnerGraph.NumberOfNodes);
        }
        public List<Edge> MinimumSpanningTree { get; }
        private static Graph InnerGraph { get; set; }
        private List<Node> VisitedNodes { get; }
        public PrimAlgorithm(Graph Graph)
        {
            MinimumSpanningTree = new List<Edge>();

            InnerGraph = (Graph)Graph.Clone();

            VisitedNodes = new List<Node>();
        }
    }

    public class BellmanFordAlgorithm
    {
        public List<Node> ShortestPathes { get; private set; }
        public bool FindTheShortestPathes(Node Start)
        {
            ShortestPathes[Start.Index].Weight = 0;

            for (int FirstIndex = 1; FirstIndex < InnerGraph.NumberOfNodes - 1; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfEdges; SecondIndex++)
                {
                    ShortestPathes[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight = Utilities.Min(ShortestPathes[InnerGraph.SetOfEdges[SecondIndex][1].Index].Weight, ShortestPathes[InnerGraph.SetOfEdges[SecondIndex][0].Index].Weight + InnerGraph.SetOfEdges[SecondIndex].Weight);
                }
            }

            return InnerGraph.NegativeCycleChecker(ShortestPathes);
        }
        public BellmanFordAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            ShortestPathes = InnerGraph.SetOfNodes;

            Utilities.SetNodesWeightOfInfinity(ShortestPathes);
        }
        private static Graph InnerGraph { get; set; }
    }

    public class DijkstraAlgorithm
    {
        public List<Node> ShortestPathes { get; private set; }
        public bool FindTheShortestPathes(Node Start)
        {
            ShortestPathes[Start.Index].Weight = 0;

            for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfNodes - 1; FirstIndex++)
            {
                Node CurrentNode = new Node { Weight = Utilities.Infinity };

                for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                {
                    if (!VisitedNodes.Contains(ShortestPathes[SecondIndex]) && ShortestPathes[SecondIndex].Weight <= CurrentNode.Weight)
                    {
                        CurrentNode = ShortestPathes[SecondIndex];

                        Index = ShortestPathes[SecondIndex].Index;
                    }
                }

                VisitedNodes.Add(ShortestPathes[Index]);

                for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                {
                    if (!VisitedNodes.Contains(ShortestPathes[SecondIndex]) && InnerGraph.SetOfNodes[Index][SecondIndex] != null && !ShortestPathes[Index].Weight.Equals(Utilities.Infinity) && ShortestPathes[SecondIndex].Weight > ShortestPathes[Index].Weight + InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], InnerGraph.SetOfNodes[SecondIndex]).Weight)
                    {
                        ShortestPathes[SecondIndex].Weight = ShortestPathes[Index].Weight + InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], InnerGraph.SetOfNodes[SecondIndex]).Weight;
                    }
                }
            }

            return InnerGraph.NegativeCycleChecker(ShortestPathes);
        }
        private static Graph InnerGraph { get; set; }
        public DijkstraAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            ShortestPathes = InnerGraph.SetOfNodes;

            VisitedNodes = new List<Node>();

            Utilities.SetNodesWeightOfInfinity(ShortestPathes);
        }
        private List<Node> VisitedNodes { get; }
        private int Index { get; set; }
    }

    public class FloydWarshallAlgorithm
    {
        public double[,] MatrixOfTheShortesPathes { get; private set; }
        public FloydWarshallAlgorithm(Graph Graph)
        {
            MatrixOfTheShortesPathes = new double[Graph.NumberOfNodes, Graph.NumberOfNodes];

            InnerGraph = (Graph)Graph.Clone();

            for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfNodes; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                {
                    if (InnerGraph.SetOfNodes[FirstIndex][SecondIndex] != null)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = InnerGraph.FindEdge(InnerGraph.SetOfNodes[FirstIndex], InnerGraph.SetOfNodes[SecondIndex]).Weight;
                    }
                    else
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = Utilities.Infinity;
                    }
                }
            }
        }
        private static Graph InnerGraph { get; set; }
        public bool FindAllTheShortestPathes()
        {
            for (int Index = 0; Index < InnerGraph.NumberOfNodes; Index++)
            {
                MatrixOfTheShortesPathes[Index, Index] = 0;
            }

            for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfNodes; FirstIndex++)
            {
                for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                {
                    for (int ThirdIndex = 0; ThirdIndex < InnerGraph.NumberOfNodes; ThirdIndex++)
                    {
                        MatrixOfTheShortesPathes[SecondIndex, ThirdIndex] = Utilities.Min(MatrixOfTheShortesPathes[SecondIndex, ThirdIndex], MatrixOfTheShortesPathes[SecondIndex, FirstIndex] + MatrixOfTheShortesPathes[FirstIndex, ThirdIndex]);
                    }
                }
            }

            return true;
        }
    }

    public class JohnsonAlgorithm
    {
        private static BellmanFordAlgorithm BellmanFordPathSearch { get; set; }
        public double[,] MatrixOfTheShortesPathes { get; private set; }
        private static DijkstraAlgorithm DijkstraPathSearch { get; set; }
        private static Graph AuxiliaryGraph { get; set; }
        private static Graph InnerGraph { get; set; }
        public JohnsonAlgorithm(Graph Graph)
        {
            MatrixOfTheShortesPathes = new double[Graph.NumberOfNodes, Graph.NumberOfNodes];

            AuxiliaryGraph = (Graph)Graph.Clone();

            InnerGraph = (Graph)Graph.Clone();
        }
        public bool FindAllTheShortestPathes()
        {
            AuxiliaryGraph.AddNode(new Node(AuxiliaryGraph.NumberOfNodes, "Temporary"));

            for (int Index = 0; Index < AuxiliaryGraph.NumberOfNodes - 1; Index++)
            {
                AuxiliaryGraph.AddTwoWayEdge(new Edge(0, AuxiliaryGraph.SetOfNodes[AuxiliaryGraph.NumberOfNodes - 1], AuxiliaryGraph.SetOfNodes[Index]));
            }

            BellmanFordPathSearch = new BellmanFordAlgorithm(AuxiliaryGraph);

            if (BellmanFordPathSearch.FindTheShortestPathes(AuxiliaryGraph.SetOfNodes[AuxiliaryGraph.NumberOfNodes - 1]))
            {
                for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfNodes; FirstIndex++)
                {
                    DijkstraPathSearch = new DijkstraAlgorithm(InnerGraph);

                    DijkstraPathSearch.FindTheShortestPathes(InnerGraph.SetOfNodes[FirstIndex]);

                    for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = DijkstraPathSearch.ShortestPathes[SecondIndex].Weight;
                    }
                }

                return true;
            }
            else
            {
                for (int Index = 0; Index < InnerGraph.NumberOfEdges; Index++)
                {
                    InnerGraph.SetOfEdges[Index].Weight = InnerGraph.SetOfEdges[Index].Weight + BellmanFordPathSearch.ShortestPathes[InnerGraph.SetOfEdges[Index][0].Index].Weight - BellmanFordPathSearch.ShortestPathes[InnerGraph.SetOfEdges[Index][1].Index].Weight;
                }

                for (int FirstIndex = 0; FirstIndex < InnerGraph.NumberOfNodes; FirstIndex++)
                {
                    DijkstraPathSearch = new DijkstraAlgorithm(InnerGraph);

                    DijkstraPathSearch.FindTheShortestPathes(InnerGraph.SetOfNodes[FirstIndex]);

                    for (int SecondIndex = 0; SecondIndex < InnerGraph.NumberOfNodes; SecondIndex++)
                    {
                        MatrixOfTheShortesPathes[FirstIndex, SecondIndex] = DijkstraPathSearch.ShortestPathes[SecondIndex].Weight;
                    }
                }
            }

            return true;
        }
    }

    public class FordFulkersonAlgorithm
    {
        public bool FindMaximumFlowWithDFSRealization(Node Start, Node Target)
        {
            if (Start.Equals(Target))
            {
                CapacityOfFlow = 0.0;

                return true;
            }

            Node CurrentNode = new Node();

            for (; DepthFirstSearch.DepthFirstSearch(Start, Target, FoundPath);)
            {
                double CurrentStreamCapacity = Utilities.Infinity;

                for (int Index = Target.Index; Index != Start.Index; Index = FoundPath[Index].Index)
                {
                    CurrentNode = FoundPath[Index];

                    CurrentStreamCapacity = Utilities.Min(CurrentStreamCapacity, InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight);
                }

                for (int Index = Target.Index; Index != Start.Index; Index = FoundPath[Index].Index)
                {
                    InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight -= CurrentStreamCapacity;

                    InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], CurrentNode).Weight += CurrentStreamCapacity;
                }

                CapacityOfFlow += CurrentStreamCapacity;

                DepthFirstSearch = new DepthFirstSearchAlgorithm(InnerGraph);
            }

            return true;
        }
        public bool FindMaximumFlowWithBFSRealization(Node Start, Node Target)
        {
            if (Start.Equals(Target))
            {
                CapacityOfFlow = 0.0;

                return true;
            }

            Node CurrentNode = new Node();

            for (; BreadthFirstSearch.BreadthFirstSearch(Start, Target, FoundPath);)
            {
                double CurrentStreamCapacity = Utilities.Infinity;

                for (int Index = Target.Index; Index != Start.Index; Index = FoundPath[Index].Index)
                {
                    CurrentNode = FoundPath[Index];

                    CurrentStreamCapacity = Utilities.Min(CurrentStreamCapacity, InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight);
                }

                for (int Index = Target.Index; Index != Start.Index; Index = FoundPath[Index].Index)
                {
                    InnerGraph.FindEdge(CurrentNode, InnerGraph.SetOfNodes[Index]).Weight -= CurrentStreamCapacity;

                    InnerGraph.FindEdge(InnerGraph.SetOfNodes[Index], CurrentNode).Weight += CurrentStreamCapacity;
                }

                CapacityOfFlow += CurrentStreamCapacity;

                BreadthFirstSearch = new BreadthFirstSearchAlgorithm(InnerGraph);
            }

            return true;
        }
        private static BreadthFirstSearchAlgorithm BreadthFirstSearch { get; set; }
        private static DepthFirstSearchAlgorithm DepthFirstSearch { get; set; }
        public double CapacityOfFlow { get; private set; }
        public FordFulkersonAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            BreadthFirstSearch = new BreadthFirstSearchAlgorithm(InnerGraph);

            DepthFirstSearch = new DepthFirstSearchAlgorithm(InnerGraph);

            FoundPath = new Node[InnerGraph.NumberOfNodes];

            CapacityOfFlow = 0.0;
        }
        private static Graph InnerGraph { get; set; }
        private Node[] FoundPath { get; set; }
    }

    public class AStarAlgorithm
    {
        public bool FindTheShortesPath(Node Start, Node Target)
        {
            Node CurrentNode = Start;

            OpenList.Add(CurrentNode);

            for (; OpenList.Count > 0;)
            {
                CurrentNode = OpenList[0];

                if (CurrentNode.Equals(Target))
                {
                    VisitedNodes.Add(Target);

                    for (int Index = 0; Index < VisitedNodes.Count - 1; Index++)
                    {
                        ShortesPath.Add(InnerGraph.FindEdge(VisitedNodes[Index], VisitedNodes[Index + 1]));
                    }

                    return true;
                }

                OpenList.Remove(CurrentNode);

                ClosedList.Add(CurrentNode);

                foreach (Node Inheritor in CurrentNode.Inheritors.Where(Node => Node != null && Node.Index != Node.Inheritors.Length - 1))
                {
                    if (!ClosedList.Contains(Inheritor))
                    {
                        if (!OpenList.Contains(Inheritor))
                        {
                            Inheritor[Inheritor.Index] = CurrentNode;

                            Inheritor.HeuristicPathWeight = Utilities.CalculateHeuristic(Inheritor, Target);

                            Inheritor.GainedPathWeight = InnerGraph.FindEdge(CurrentNode, Inheritor).Weight;

                            Inheritor.TotalPathWeight = Inheritor.GainedPathWeight + Inheritor.HeuristicPathWeight;

                            OpenList.Add(Inheritor);

                            OpenList = OpenList.OrderBy(Node => Node.TotalPathWeight).ToList<Node>();
                        }
                    }
                }

                VisitedNodes.Add(CurrentNode);
            }

            return true;
        }
        private static Graph InnerGraph { get; set; }
        private List<Node> ClosedList { get; set; }
        private List<Node> VisitedNodes { get; }
        private List<Node> OpenList { get; set; }
        public AStarAlgorithm(Graph Graph)
        {
            InnerGraph = (Graph)Graph.Clone();

            VisitedNodes = new List<Node>();

            ShortesPath = new List<Edge>();

            ClosedList = new List<Node>();

            OpenList = new List<Node>();
        }
        public List<Edge> ShortesPath { get; }
    }
    #endregion
}