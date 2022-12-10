using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAttackDetailsDal : EfEntityRepositoryBase<AttackDetails, DataBaseContext>, IAttackDetailsDal
    {
    }
}
