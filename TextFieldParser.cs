using Microsoft.VisualBasic.FileIO;
using System;

namespace Importar
{
    internal class TextFieldParser
    {
        private string fileName;

        public TextFieldParser(string fileName)
        {
            this.fileName = fileName;
        }

        public bool EndOfData { get; internal set; }
        public FieldType TextFieldType { get; internal set; }

        internal string[] ReadFields()
        {
            throw new NotImplementedException();
        }

        internal void SetDelimiters(string v)
        {
            throw new NotImplementedException();
        }
    }
}