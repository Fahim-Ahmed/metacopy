using System;
using System.Collections.Generic;
using System.Linq;

namespace MetaCopy
{
    [Serializable]
    class FileObject{
        public string Name { set; get; }
        public string Path { set; get; }
        public string Ext { set; get; }

        public bool isSelected { set; get; }
        public bool isCut { set; get; }

        private bool isDirectory { set; get; }

        public FileObject(){}

        public FileObject(string name, string path, string ext, bool isSelected){
            this.Name = name;
            this.Path = path;
            this.Ext = ext;
            this.isSelected = isSelected;
        }
    }
}