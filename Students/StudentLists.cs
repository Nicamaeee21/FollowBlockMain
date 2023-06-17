namespace Students
{
    public class StudentLists
    {
        public List<ProfileLists> FolNam = new List<ProfileLists>();
        public List<Profiles> Prol = new List<Profiles>();


        void Emlist()
        {

            ProfileLists Sean = new ProfileLists();
            Sean.email = "Sean@Follow";
            Sean.pas = "sean123";
            FolNam.Add(Sean);

            ProfileLists Lorrea = new ProfileLists();
            Lorrea.email = "Lorrea@Follow";
            Lorrea.pas = "lorrea123";
            FolNam.Add(Lorrea);

            ProfileLists Danica = new ProfileLists();
            Danica.email = "Danica@Follow";
            Danica.pas = "danica123";
            FolNam.Add(Danica);

            ProfileLists Claris = new ProfileLists();
            Claris.email = "Claris@Follow";
            Claris.pas = "claris123";
            FolNam.Add(Claris);

            ProfileLists New = new ProfileLists();



        }

        string Profl(string het)
        {
            Profiles SeanP = new Profiles();
            SeanP.proname = "Sean";
            SeanP.prosname = "Estayan";
            SeanP.following = 1;
            SeanP.followers = 0;
            SeanP.blocked = 1;
            Prol.Add(SeanP);

            Profiles LorreaP = new Profiles();
            LorreaP.proname = "Lorrea";
            LorreaP.prosname = "Hugo";
            LorreaP.following = 1;
            LorreaP.followers = 0;
            LorreaP.blocked = 1;
            Prol.Add(LorreaP);

            Profiles DanicaP = new Profiles();
            DanicaP.proname = "Danica";
            DanicaP.prosname = "Cabrera";
            DanicaP.following = 1;
            DanicaP.followers = 0;
            DanicaP.blocked = 1;
            Prol.Add(DanicaP);

            Profiles ClarisP = new Profiles();
            ClarisP.proname = "Claris";
            ClarisP.prosname = "Batacandolo";
            ClarisP.following = 1;
            ClarisP.followers = 0;
            ClarisP.blocked = 1;
            Prol.Add(ClarisP);

            return het;

        }
        /*
                public void Profil() {

                    ProfileLists Sean = new ProfileLists();
                    Sean.email = "Sean@Follow";
                    Sean.pass = "sean123";
                    FolNam.Add(Sean);

                    ProfileLists Lorrea = new ProfileLists();
                    Lorrea.email = "Lorrea@Follow";
                    Lorrea.pass = "lorrea123";
                    FolNam.Add(Lorrea);

                    ProfileLists Danica = new ProfileLists();
                    Danica.email = "Danica@Follow";
                    Danica.pass = "danica123";
                    FolNam.Add(Danica);

                    ProfileLists Claris = new ProfileLists();
                    Claris.email = "Claris@Follow";
                    Claris.pass = "claris123";
                    FolNam.Add(Claris);

                    ProfileLists New = new ProfileLists();

                }

                public void ProfileMain()
                {
                    List<Profiles> prol = new List<Profiles>();

                    Profiles SeanP = new Profiles();
                    SeanP.profname = "Sean";
                    SeanP.profname = "Paula";
                    SeanP.prosname = "Estayan";
                    SeanP.following = 0;
                    SeanP.followers = 0;
                    prol.Add(SeanP);

                    Profiles LorreaP = new Profiles();
                    LorreaP.profname = "Lorrea";
                    LorreaP.prosname = "Hugo";
                    LorreaP.following = 0;
                    LorreaP.followers = 0;
                    prol.Add(LorreaP);

                    Profiles DanicaP = new Profiles();
                    DanicaP.profname = "Danica";
                    DanicaP.prosname = "Cabrera";
                    DanicaP.following = 0;
                    DanicaP.followers = 0;
                    prol.Add(DanicaP);

                    Profiles ClarisP = new Profiles();
                    ClarisP.profname = "Claris";
                    ClarisP.prosname = "Batacandolo";
                    ClarisP.following = 0;
                    ClarisP.followers = 0;
                    prol.Add(ClarisP);

                    Profiles NewP = new Profiles(); 
                }*/
    }
}