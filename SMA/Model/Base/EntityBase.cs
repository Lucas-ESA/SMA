using System;

namespace SMA.Model.Base
{
    public class EntityBase
    {
        protected EntityBase()
        {
            if(ID == null)
            {
                ID = Guid.NewGuid();
            }
        }

        public Guid ID { get; private set; }

    }
}