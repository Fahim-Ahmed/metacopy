using System;
using System.Collections.Generic;
using System.Linq;

namespace MetaCopy
{
    [Serializable]
    class FileObject{
        public string Name { set; get; }
        public string Path { set; get; }

        public bool isSelected { set; get; }
        public bool isCut { set; get; }

        private bool isDirectory { set; get; }

        public FileObject(){}

        public FileObject(string name, string path, bool isDirectory){
            this.Name = name;
            this.Path = path;
            this.isDirectory = isDirectory;
        }
    }
}