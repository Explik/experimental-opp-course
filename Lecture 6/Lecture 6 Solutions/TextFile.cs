using System;
using System.IO;
using System.Text;

namespace Lecture_6_Solutions
{
    public class TextFile : IDisposable
    {
        private bool _isDisposed = false;
        private StreamReader _reader;

        public TextFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            _reader = new StreamReader(stream, Encoding.UTF8);
        }

        public string Content
        {
            get
            {
                if (!_isDisposed)
                {
                    return _reader.ReadToEnd();
                }
                return null;
            }
        }

        public void Dispose()
        {
            _reader.Dispose();
            _isDisposed = true;
        }
    }
}