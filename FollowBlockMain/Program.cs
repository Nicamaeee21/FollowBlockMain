using System;
using System.Linq;

namespace FollowBlockMain
{
    class Program
    {


        static int i;
        static void Main(string[] args, object prol)
        {
            Fmenu fmenu = new Fmenu();
            ProfileLists plist = new ProfileLists();
            LogIn login = new LogIn();
            EmailLists elist = new EmailLists();
            //Profiles seliforp = new Profiles(); 

            ProfileLists Sean = new ProfileLists
            {
                email = "Sean@Follow",
                pas = "sean123"
            };
            ProfileLists Lorrea = new ProfileLists {
                email = "Lorrea@Follow",
                pas = "lorrea123"
            };
            ProfileLists Danica = new ProfileLists {
                email = "Danica@Follow",
                pas = "danica123"
            };
            ProfileLists Claris = new ProfileLists {
                email = "Claris@Follow",
                pas = "claris123"
            }; 
           
            Profiles SeanP = new Profiles {
                proname = "Sean",
                prosname = "Estayan",
                following = 1,
                followers = 0,
                blocked = 1
            };
            Profiles LorreaP = new Profiles
            {
                proname = "Lorrea",
                prosname = "Hugo",
                following = 1,
                followers = 0,
                blocked = 1
            };
            Profiles DanicaP = new Profiles
            {
                proname = "Danica",
                prosname = "Cabrera",
                following = 1,
                followers = 0,
                blocked = 1
            };
            Profiles ClarisP = new Profiles
            {
                proname = "Claris",
                prosname = "Batacandolo",
                following = 1,
                followers = 0,
                blocked = 1
            };

            Follow SeanF = new Follow
            {
                
            };

            elist.AddEmail(Sean);
            elist.AddEmail(Lorrea);
            elist.AddEmail(Danica);
            elist.AddEmail(Claris);



            do
            {
                string input;
                input = fmenu.Welcome();

                switch (input)
                {
                    case "1":
                        string pass, emil, chr;
                        int sum;

                        Console.WriteLine("\n===LOG IN===");
                        Console.Write("Email: ");
                        emil = Console.ReadLine();
 
                        if (emil.Equals(Sean.email))
                            {
                            pass = login.Password();

                            if (pass.Equals(Sean.pas))
                            {
                                do {

                                    fmenu.ShowProfile(SeanP);
                                    chr = fmenu.Screen();

                                    switch (chr)
                                    {

                                        case "1":

                                            for (i = 0; i < SFList.Count; i++)
                                            {
                                                Console.WriteLine(SFList[i]);

                                            }

                                            break;

                                        case "2":

                                            for (i = 0; i < SBList.Count; i++)
                                            {
                                                Console.WriteLine(SBList[i]);

                                            }

                                            break;

                                        case "3":

                                            Console.WriteLine("Search: ");
                                            var search = Console.ReadLine();
                                       //     var tosearch = prol.Find(x => x.proname == search);
                                       //     tosearch = prol.Find(x => x.prosname == search);

                                            Console.WriteLine("Do you wish to follow/block? type F / B");
                                            string fb = Console.ReadLine().ToLower();



                                    /*        switch (fb)
                                            {
                                                case "f":

                                                    if (!SFList.Contains(tosearch.proname)) { SFList.Add($"{tosearch.proname} {tosearch.prosname}");
                                                        sum = tosearch.following + 1;
                                                        SeanP.following = sum; }

                                                    else { Console.WriteLine("Already Following"); } break;


                                                case "b":
                                                    if (!SBList.Contains(tosearch.proname))
                                                    {
                                                        SBList.Add($"{tosearch.proname} {tosearch.prosname}");
                                                        sum = tosearch.blocked + 1;
                                                        SeanP.blocked = sum;
                                                    }

                                                    else { Console.WriteLine("Already Following"); } break;


                                            }*/
                                            break;
                                    }
                                } while (chr != "x");
                            }                  
                }
                                break;
                  case "2":
                        Console.WriteLine("~~~SIGN UP~~~");
                        Console.Write("Enter your email: ");
                        string newEmail = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string newPassword = Console.ReadLine();

                        // Check if the email already exists
                        if (!elist.EmailExists(newEmail))
                        {
                            // Create a new profile
                            Profiles newProfile = new Profiles
                            {
                                proname = "New User",
                                prosname = "New",
                                following = 0,
                                followers = 0,
                                blocked = 0
                            };

                            // Create a new profile list
                            ProfileLists newProfileList = new ProfileLists
                            {
                                email = newEmail,
                                pas = newPassword
                            };

                            // Add the new profile and email to the respective lists
                            prol.Add(newProfile);
                            elist.AddEmail(newProfileList);

                            Console.WriteLine("Sign-up successful!");
                        }
                        else
                        {
                            Console.WriteLine("Email already exists. Please try again.");
                        }
                        break;
                }

                if (input.ToLower() == "x")
                {
                    Console.WriteLine("Program Terminated");
                    break;
                }
            }
            while (true);
        }
    }
}
