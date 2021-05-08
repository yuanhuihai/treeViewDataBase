using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace treeViewDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载
        private void Form1_Load(object sender, EventArgs e)
        {

            InitModuleTree(getData());

        }
        //从数据库获取数据
        public DataTable getData()
        {
            //数据库连接
            SQLiteConnection myCon;
            myCon = new SQLiteConnection("Data Source=tree.sqlite;Version=3;");
            myCon.Open();
            //选择所有数据
            SQLiteDataAdapter mAdapter = new SQLiteDataAdapter("select * from tree", myCon);
            DataTable dt = new DataTable();
            mAdapter.Fill(dt);
          //关闭数据库
            myCon.Close();
            return dt;
        }
        //绑定TrreView
        private void InitModuleTree(DataTable dt)
        {
            //清空treeview上所有节点
            this.tree_Role.Nodes.Clear();
            int[] gen = new int[dt.Rows.Count]; //用于存储父节点Tag
            int[] zi = new int[dt.Rows.Count];  //用于存储子节点Tag
            for (int i = 0; i < gen.Length; i++)
            {
                string zhi = dt.Rows[i][1].ToString();//获取节点Tag值   eg：1-2
                if (zhi.Length > 1)   //表示是子节点   eg：1-2
                {
                    gen[i] = int.Parse(zhi.Substring(0, zhi.IndexOf('-')));
                    zi[i] = int.Parse(zhi.Substring(zhi.IndexOf('-') + 1));
                }
                else    //表示是根节点   eg：2
                {
                    //将所有父节点加到treeview上
                    zi[i] = int.Parse(zhi);
                    TreeNode nodeParent = new TreeNode();
                    nodeParent.Tag = (zi[i]).ToString();
                    nodeParent.Text = dt.Rows[i][0].ToString();//填充父节点名称
                    tree_Role.Nodes.Add(nodeParent);
                }
            }
            bindChildNote(dt, gen, zi);
        }
        //绑定子节点
        private void bindChildNote(DataTable dt, int[] gen, int[] zi)
        {
            for (int i = 0; i < gen.Length; i++)
            {
                if (gen[i] != 0 && zi[i] != 0)        //便利所有节点，找到所有子节点
                {
                    TreeNode childNode = new TreeNode();
                    foreach (TreeNode item in tree_Role.Nodes)   //便历treeview上所有父节点
                    {
                        if (item.Tag.ToString() == gen[i].ToString())  //找到当前子节点的父节点
                        {
                            childNode.Tag = zi[i].ToString();
                            childNode.Text = dt.Rows[i][0].ToString();//填充子节点名称
                            item.Nodes.Add(childNode);
                        }
                    }
                }
            }
            tree_Role.ExpandAll();      //展开整棵树
        } 
        //保存父节点
        private void baocun_Click(object sender, EventArgs e)
        {
            //数据库连接
            SQLiteConnection myCon;
            myCon = new SQLiteConnection("Data Source=tree.sqlite;Version=3;");
            myCon.Open();

            string sql = "insert into tree values ('" + fname.Text + "', '" + flevel.Text + "')";
            SQLiteCommand command = new SQLiteCommand(sql, myCon);
            command.ExecuteNonQuery();
       
            myCon.Close();
            InitModuleTree(getData());
        }
        //保存子节点
        private void baocun2_Click(object sender, EventArgs e)
        {
            //数据库连接
            SQLiteConnection myCon;
            myCon = new SQLiteConnection("Data Source=tree.sqlite;Version=3;");
            myCon.Open();

            string sql = "insert into tree values ('" + cname.Text + "', '" + clevel.Text + "')";
            SQLiteCommand command = new SQLiteCommand(sql, myCon);
            command.ExecuteNonQuery();
      
            myCon.Close();
            InitModuleTree(getData());
        }

     

      

        private void tree_Role_DoubleClick(object sender, EventArgs e)
        {
        
            choseName.Text = tree_Role.SelectedNode.Text;
        }
    }
}
