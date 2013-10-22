using CoachUs.Data;
using System;

namespace CoachUs.Managers
{
    public abstract class BaseManager : IDisposable
    {
        protected CoachUsEntities context = null;

        public BaseManager() : this(null)
        {
        }

        internal BaseManager(CoachUsEntities context = null)
        {
            this.context = context ?? new CoachUsEntities();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
