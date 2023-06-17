using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowBlockMain
{
    public class EmailLists
    {
        public List<ProfileLists> FolNam = new List<ProfileLists>();
        public List<Profiles> Prol = new List<Profiles>();
        public List<string> Sfeed = new List<string>();
        public List<string> Lfeed = new List<string>();
        public List<string> Dfeed = new List<string>();
        public List<string> Cfeed = new List<string>();
        public List<string> Nfeed = new List<string>();
        public List<Block> SBList = new List<Block>();
        public List<Block> LBList = new List<Block>();
        public List<Block> DBList = new List<Block>();
        public List<Block> CBList = new List<Block>();
        public List<Block> NBList = new List<Block>();
        public List<Follow> SFList = new List<Follow>();
        public List<Follow> LFList = new List<Follow>();
        public List<Follow> DFList = new List<Follow>();
        public List<Follow> CFList = new List<Follow>();
        public List<Follow> NFList = new List<Follow>();


        public void AddEmail(ProfileLists fileli)
        {
            FolNam.Add(fileli);
        }

        public void AddProfl(Profiles selif)
        {
            Prol.Add(selif);
        }

        void AddSFollow(Follow flow)
        {
            SFList.Add(flow);
            LFList.Add(flow);
            DFList.Add(flow);
            CFList.Add(flow);
        }

        void AddBlock(Block bock)
        {
            SBList.Add(bock);
            LBList.Add(bock);
            DBList.Add(bock);
            CBList.Add(bock);
        }

      /*  internal bool EmailExists(string newEmail)
        {
            //throw new NotImplementedException();
            if (!FolNam.Exists(newEmail)) { return true; }
            else { return false; }
        }*/
    }
}
