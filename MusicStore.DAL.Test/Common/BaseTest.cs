using MusicStore.DAL.Tests.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Test.Common
{
    public abstract class BaseTest
    {
        protected readonly ApplicationTestDbContext dbContext;

        public BaseTest()
        {
            this.dbContext = new ApplicationTestDbContext();
        }
    }
}
