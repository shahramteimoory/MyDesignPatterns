using StrategyPattern.Example2.Entities;

namespace StrategyPattern.Example2
{
    public class UserByIId : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            if (x.Id == y.Id)
                return 0;
            else if (x.Id < y.Id)
                return -1;
            else
                return 1;
        }
    }
}
