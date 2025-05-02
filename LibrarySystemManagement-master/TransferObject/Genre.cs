using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Genre
    {
        private int genreId;
        private string genreName;
        private string genreDescription;

        public int GenreId
        {
            get { return genreId; }
            set { genreId = value; }
        }

        public string GenreName
        {
            get { return genreName; }
            set { genreName = value; }
        }

        public string GenreDescription
        {
            get { return genreDescription; }
            set { genreDescription = value; }
        }
    }

}
