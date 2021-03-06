﻿namespace ChainOfResponsibility.Storages
{
    using System;
    using System.Collections.Generic;

    public class CityStorage : Storage, IHandle
    {
        public const int StorageLimit = 3;

        public CityStorage()
        {
            this.storage = new List<object>(StorageLimit);
            this.Name = "City";
        }

        public override void Add(object item)
        {
            if (this.storage.Count < StorageLimit)
            {
                base.Add(item);
            }
            else
            {
                throw new ApplicationException("Storage is Full");
            }
        }
    }
}
