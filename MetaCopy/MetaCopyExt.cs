using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpShell.Attributes;
using SharpShell.SharpContextMenu;
using XDMessaging;

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

            itemCountLines.Click += (sender, args) => AddToMeta();
            menu.Items.Add(itemCountLines);

            return menu;
        }

        private void AddToMeta(){
            try {
                Process[] processes = Process.GetProcessesByName("MetaCopy");

                XDMessagingClient client = new XDMessagingClient();
                IXDBroadcaster broadcaster = client.Broadcasters.GetWindowsMessagingBroadcaster();

                if (processes.Length == 0) {

                    IXDListener listener = client.Listeners.GetWindowsMessagingListener();
                    listener.RegisterChannel("MetaStartChannel");

                    listener.MessageReceived += (o, e) => {
                        if (e.DataGram.Channel == "MetaStartChannel") {
                            listener.UnRegisterChannel("MetaStartChannel");
                            broadcaster.SendToChannel("MetaChannel", SelectedItemPaths);
                        }
                    };

                    Process.Start(Environment.GetEnvironmentVariable("MetaCopyPath", EnvironmentVariableTarget.User));
                }
                else {
                    broadcaster = client.Broadcasters.GetWindowsMessagingBroadcaster();
                    broadcaster.SendToChannel("MetaChannel", SelectedItemPaths);
                }
            }
            catch (FileNotFoundException ex){
                MessageBox.Show("MetaCopy not found.");
            }
        }
    }
}