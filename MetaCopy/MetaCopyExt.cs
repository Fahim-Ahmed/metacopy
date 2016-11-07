using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;

namespace MetaCopy
{
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.AllFiles)]
    [COMServerAssociation(AssociationType.Directory)]
    [COMServerAssociation(AssociationType.Drive)]
    public class MetaCopyExt : SharpContextMenu
    {
        public string ExePath { set; get; }

        protected override bool CanShowMenu(){
            return true;
        }

        protected override ContextMenuStrip CreateMenu(){
            var menu = new ContextMenuStrip();

            var itemCountLines = new ToolStripMenuItem{
                Text = "Add to MetaCopy",
            };

            itemCountLines.Click += (sender, args) => CountLines();
            menu.Items.Add(itemCountLines);

            return menu;
        }

        private void CountLines(){
            try{
                Process p = Process.Start(Environment.GetEnvironmentVariable("MetaCopyPath", EnvironmentVariableTarget.User));
            }
            catch (FileNotFoundException ex){
                MessageBox.Show("MetaCopy not found.");
            }
        }
    }
}