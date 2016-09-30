using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaCopy
{
    class FileObject{
        private String name { set; get; }
        private String path { set; get; }

        private bool isSelected { set; get; }
        private bool isCut { set; get; }

        public FileObject(){}

        public FileObject(string name, string path, bool isSelected){
            this.name = name;
            this.path = path;
            this.isSelected = isSelected;
        }
    }
}