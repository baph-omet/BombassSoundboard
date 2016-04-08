using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombassSoundboard.Exceptions {
    class InvalidSoundFileException : Exception {
        public InvalidSoundFileException() : base() { }
        public InvalidSoundFileException(String message) : base(message) { }
    }
}
