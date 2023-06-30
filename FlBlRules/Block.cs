using FlBlData;
using FlBlModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlBlData;

namespace FlBlRules
{
    public class Block
    {
        private BlockData blockData;
        public Block()
        {

            blockData = new BlockData();
        }

        public void BlockAcc(StudentAccount blocker, StudentAccount studentUser)
        {

            blockData.dataBlock(blocker.user, studentUser.user);
        }

        public void UnblockAcc(StudentAccount blocker, StudentAccount studentUser)
        {

            blockData.dataUnblock(blocker.user, studentUser.user);
        }
    }
}
