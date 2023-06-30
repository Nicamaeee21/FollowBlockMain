using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlBlModel;


namespace FlBlData
{
    internal class FollowData
    {
        public FollowData(string tofollow, string myAccount) {

            FollowedAccounts followedAccounts = new();
            followedAccounts.follower =  myAccount;
            followedAccounts.following = tofollow;

           
        
        }
    }
}
