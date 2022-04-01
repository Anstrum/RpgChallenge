using System;
using System.Collections.Generic;

namespace RPGChallenge.Project.Idcreator
{
    internal class IdCreator
    {
        private List<string> _ids;
        private Random random;
        public IdCreator()
        {
            _ids = new List<string>();
            random = new Random((int)DateTime.Now.TimeOfDay.TotalSeconds * (int)DateTime.Now.TimeOfDay.TotalSeconds);
        }
        public string CreateId()
        {
            string idText = "";

            again:
            while (idText.Length != 30)
            {
                idText += (char)random.Next(33, 91);
            }
            if (AlreadyExist(idText))
            {
                goto again;
            }
            return idText;
        }

        private bool AlreadyExist(string _id)
        {
            foreach(string id in _ids)
            {
                if(id != _id)
                {
                    continue;
                }
                return true;
            }
            return false;
        }
    }
}
