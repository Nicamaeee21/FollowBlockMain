using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlBlData;
using FlBlModel;

namespace FlBlRules
{
    public  class Follow
    {
        private FollowData followData;    

        public Follow() {
        
            followData = new FollowData();
        }

        public void FollowAcc(StudentAccount follower, StudentAccount studentUser) {

            followData.dataFollow(follower.user, studentUser.user);
        }

        public void UnfollowAcc(StudentAccount follower, StudentAccount studentUser)
        {

            followData.dataUnfollow(follower.user, studentUser.user);
        }
    }
}
