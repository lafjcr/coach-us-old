using CoachUs.Data.Entities;
using System;
using System.Linq;

namespace CoachUs.Managers
{
    public class SecurityManager : BaseManager
    {
        #region Roles
        public IOrderedQueryable<Role> GetRoles()
        {
            return context.Roles.OrderBy(item => item.Name);
        }
        #endregion

        #region Permissions
        #endregion

        #region Actions
        #endregion
    }
}
