using System;

using RPGChallenge.Project.Idcreator;

namespace RPGChallenge.Project
{
    internal class ID
    {
        private static IdCreator idCreator = new IdCreator();
        private string id;
        public ID()
        {
            id = idCreator.CreateId();
        }
        public string Get()
        {
            return id;
        }
    }
}
