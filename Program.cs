using System;
using System.IO;
using System.Diagnostics;
using System.Media;
using System.Threading;
using static System.Console;

namespace CPR_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Logon Screen
            //Title = "CPR TRAINING AND SIMULATION MODULE";
            //SetCursorPosition(0, 1);
            //WriteLine("Enter Username: ");
            //SetCursorPosition(17, 1);
            //var username = Console.ReadLine();
            //SetCursorPosition(0, 28);
            //ForegroundColor = ConsoleColor.Blue;
            //Write("Saving Username> ");
            //for (int i = 0; i < username.Length; i++)
            //{
            //    for (int j = 1; j < 29; j++)
            //    {
            //        ForegroundColor = ConsoleColor.Red;
            //        SetCursorPosition(17 + i, j);
            //        Write(username[i]);
            //        SetCursorPosition(17 + i, j - 1);
            //        Write(" ");
            //        Thread.Sleep(10);
            //        Beep(27000 + j, 20);
            //    }
            //}
            //SetCursorPosition(115, 28);
            //ReadLine();
            //Clear();
            #endregion

            #region Start Screen
            SoundPlayer dispatch = new SoundPlayer("Resources/911_dispatch_cardiac.wav");
            dispatch.Load();
            SoundPlayer ambulance = new SoundPlayer("Resources/ambulance.wav");
            ambulance.Load();
            SoundPlayer intro = new SoundPlayer("Resources/intro.wav");
            intro.Load();
            SoundPlayer heartbeat = new SoundPlayer("Resources/heartbeat1.wav");
            heartbeat.Load();
            SoundPlayer redAlert = new SoundPlayer("Resources/red_alert.wav");
            redAlert.Load();
            SoundPlayer purpose = new SoundPlayer("Resources/purpose.wav");
            purpose.Load();
            SoundPlayer statistics = new SoundPlayer("Resources/statistics.wav");
            statistics.Load();
            SoundPlayer trainingPt1 = new SoundPlayer("Resources/trainingPt1.wav");
            trainingPt1.Load();
            SoundPlayer trainingPt2 = new SoundPlayer("Resources/trainingPt2.wav");
            trainingPt2.Load();
            CursorVisible = false;
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"

                                          Learn how to save a life with CPRsim");
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"
                                                  |  \ \ | |/ /
                                                  |  |\ `' ' /
                                                  |  ;'aorta \      / , pulmonary
                                                  | ;    _,   |    / / ,  arteries
                                         superior | |   (  `-.;_,-' '-' ,
                                      vena cava | `,   `-._       _,-'_
                                                  |,-`.    `.)    ,<_,-'_, pulmonary
                                                 ,'    `.   /   ,'  `;-' _,  veins
                                                ;        `./   /`,    \-'
                                                | right   /   |  ;\   |\
                                                | atrium ;_,._|_,  `, ' \
                                                |        \    \ `       `,
                                                `      __ `    \   left  ;,
                                                 \   ,'  `      \,  ventricle
                                                  \_(            ;,      ;;
                                                  |  \           `;,     ;;
                                         inferior |  |`.          `;;,   ;'
                                        vena cava |  |  `-.        ;;;;,;'
                                                  |  |    |`-.._  ,;;;;;'
                                                  |  |    |   | ``';;;'  
                                                          aorta");
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"
                               The most important console application ever created - EVER!");
            intro.PlaySync();
            Clear();
            #endregion

            #region 9-1-1 Dispatch Screen
            CursorVisible = true;
            ForegroundColor = ConsoleColor.Red;
            WriteLine(@"
                                  ______/\\\\\\\\\_________/\\\______/\\\_        
                                   ____/\\\///////\\\___/\\\\\\\__/\\\\\\\_       
                                    ___/\\\______\//\\\_\/////\\\_\/////\\\_      
                                     __\//\\\_____/\\\\\_____\/\\\_____\/\\\_     
                                      ___\///\\\\\\\\/\\\_____\/\\\_____\/\\\_    
                                       _____\////////\/\\\_____\/\\\_____\/\\\_   
                                        ___/\\________/\\\______\/\\\_____\/\\\_  
                                         __\//\\\\\\\\\\\/_______\/\\\_____\/\\\_ 
                                          ___\///////////_________\///______\///_ ");

            ForegroundColor = ConsoleColor.Blue;
            SetCursorPosition(52, 12);
            WriteLine("9-1-1 DISPATCH");
            SetCursorPosition(46, 14);
            WriteLine("Call Center: Miami, FL");
            SetCursorPosition(46, 15);
            WriteLine("Date: " + DateTime.Now.ToString("dddd, dd MMMM yyyy"));
            SetCursorPosition(46, 16);
            WriteLine("Time: " + DateTime.Now.ToString("HH:mm"));
            SetCursorPosition(24, 18);
            Write("Call Type:");
            SetCursorPosition(25, 20);
            Write("Location:");
            SetCursorPosition(29, 22);
            Write("Unit:");
            dispatch.Play();
            ForegroundColor = ConsoleColor.White;
            SetCursorPosition(35, 18);
            Type("(50-19) Respond to an 88 year old female, heart problems", 70);
            SetCursorPosition(35, 20);
            Type("564 North East 125th Street", 70);
            SetCursorPosition(35, 22);
            Type("(15-23) to County", 70);
            dispatch.Stop();
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            string prompt = "press any key to continue";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (prompt.Length / 2)) + "}", prompt));
            CursorVisible = false;
            ReadKey();
            Clear();
            #endregion

            #region Title Screen
            WriteLine();
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            Write(@"
           CCCCCCCCCCCCCPPPPPPPPPPPPPPPPP  RRRRRRRRRRRRRRRRR                          iiii                         "); ForegroundColor = ConsoleColor.White; Write(@"   
         CCC::::::::::::P::::::::::::::::P R::::::::::::::::R                        i::::i                        "); ForegroundColor = ConsoleColor.Blue; Write(@"
       CC:::::::::::::::P::::::PPPPPP:::::PR::::::RRRRRR:::::R                        iiii                         "); ForegroundColor = ConsoleColor.Red; Write(@"
      C:::::CCCCCCCC::::PP:::::P     P:::::RR:::::R     R:::::R                                                    "); ForegroundColor = ConsoleColor.White; Write(@"
     C:::::C       CCCCCC P::::P     P:::::P R::::R     R:::::R         ssssssssss  iiiiiii   mmmmmmm    mmmmmmm   "); ForegroundColor = ConsoleColor.Blue; Write(@"
    C:::::C               P::::P     P:::::P R::::R     R:::::R       ss::::::::::s i:::::i mm:::::::m  m:::::::mm "); ForegroundColor = ConsoleColor.Red; Write(@"
    C:::::C               P::::PPPPPP:::::P  R::::RRRRRR:::::R      ss:::::::::::::s i::::im::::::::::mm::::::::::m"); ForegroundColor = ConsoleColor.White; Write(@"
    C:::::C               P::::JASON::::PP   R:::::MASS::::RR       s::::::ssss:::::si::::im::::::::::::::::::::::m"); ForegroundColor = ConsoleColor.Blue; Write(@"
    C:::::C               P::::PPPPPPPPP     R::::RRRRRR:::::R       s:::::s  ssssss i::::im:::::mmm::::::mmm:::::m"); ForegroundColor = ConsoleColor.Red; Write(@"
    C:::::C               P::::P             R::::R     R:::::R        s::::::s      i::::im::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.White; Write(@"
    C:::::C               P::::P             R::::R     R:::::R           s::::::s   i::::im::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.Blue; Write(@"
     C:::::C       CCCCCC P::::P             R::::R     R:::::R     ssssss   s:::::s i::::im::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.Red; Write(@"
      C:::::CCCCCCCC::::PP::::::PP         RR:::::R     R:::::R     s:::::ssss::::::i::::::m::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.White; Write(@"
       CC:::::::::::::::P::::::::P         R::::::R     R:::::R     s::::::::::::::si::::::m::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.Blue; Write(@"
         CCC::::::::::::P::::::::P         R::::::R     R:::::R      s:::::::::::ss i::::::m::::m   m::::m   m::::m"); ForegroundColor = ConsoleColor.Red; WriteLine(@"
            CCCCCCCCCCCCPPPPPPPPPP         RRRRRRRR     RRRRRRR       sssssssssss   iiiiiiimmmmmm   mmmmmm   mmmmmm");

            WriteLine();
            string title1 = "CPR TRAINING AND SIMULATION MODULE";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (title1.Length / 2)) + "}", title1));
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            string refs = "REFERENCES:";
            string ref1 = "2020 American Heart Association Guidelines Update for CPR and ECC";
            string ref2 = "2020 BLS Algorithms for Adults, Children, and Infants";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (refs.Length / 2)) + "}", refs));
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (ref1.Length / 2)) + "}", ref1));
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (ref2.Length / 2)) + "}", ref2));
            ambulance.PlaySync();
            WriteLine();
            ForegroundColor = ConsoleColor.Blue;
            string start = "press ANY KEY to begin training";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (start.Length / 2)) + "}", start));
            ReadKey();
            Clear();
            #endregion

            #region Purpose Screen
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine(" Application Purpose ");
            ResetColor();
            WriteLine();
            WriteLine("This training application is intended for non-medical rescuers to learn and practice the concepts of CPR, also known as\nBasic Life Support (BLS). This application has two components:");
            WriteLine();
            WriteLine("   1. Instructional information will be presented with CPR standards for adults, children, and infants.");
            WriteLine();
            WriteLine("   2. A simulation will prompt the participant to answer questions about a simulated patient and practice cycles of CPR.");
            WriteLine();
            WriteLine("Successful completion requires performing the correct actions in the proper sequence with the appropriate\nstandards for adult, child, or infant CPR.");
            WriteLine();
            heartbeat.PlaySync();
            purpose.PlaySync();
            ForegroundColor = ConsoleColor.Blue;
            string next = "press ANY KEY to continue training";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (next.Length / 2)) + "}", next));
            ReadKey();
            Clear();
            #endregion

            #region Statistics Screen
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine(" Cardiac Arrest Statistics (American Heart Association) ");
            ResetColor();
            WriteLine();
            WriteLine(" *In the U.S., more than 350,000 cardiac arrests occur outside the hospital each year.");
            WriteLine("     Where?\n        -homes/residences (70%)\n        -public settings (18.8%)\n        -nursing homes (11.2%)");
            WriteLine();
            WriteLine(" *CPR can double or triple a person’s chance of survival if performed immediately after cardiac arrest.");
            WriteLine();
            WriteLine(" *In 2017, only 45.7% of cardiac arrests (outside of hospitals) received CPR before EMS arrived.");
            WriteLine();
            WriteLine(" *Many non-medical bystanders are not willing to attempt CPR due to being unfamiliar.");
            WriteLine();
            WriteLine(" *On average, someone dies of cardiac failure in U.S. every 36 seconds (2,380/day in 2018).");
            WriteLine();
            heartbeat.PlaySync();
            statistics.PlaySync();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (next.Length / 2)) + "}", next));
            ReadKey();
            Clear();
            #endregion

            #region Training Information Screen - Part 1
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine(" Training Information - Part 1 ");
            WriteLine();
            BackgroundColor = ConsoleColor.Black;
            string ref3a = "Refer to the PDF of the 2020 AHA guidleines for CPR titled:";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (ref3a.Length / 2)) + "}", ref3a));
            string ref3b = "'Summary of High-Quality CPR Components for BLS Providers'  ";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (ref3b.Length / 2)) + "}", ref3b));
            WriteLine();
            ResetColor();
            WriteLine("High-quality CPR consists of:");
            WriteLine(" *specific rate of chest compressions");
            WriteLine(" *specific depth of chest compressions");
            WriteLine(" *full chest recoil");
            WriteLine(" *effective rescue breaths");
            WriteLine(" *minimal interruptions to compressions (less than 10 seconds for each interruption)");
            WriteLine();
            WriteLine("Chest Compression Fraction (CCF) is the percent of CPR time in which compressions are being performed");
            WriteLine(" *CCF minimum is >60%");
            WriteLine(" *CCF goal is 80%");
            WriteLine();
            WriteLine("The following CPR standards are the SAME for adults, children, and infants:");
            WriteLine(" *1 CPR cycle is 30:2 (30 compressions and 2 breaths)");
            WriteLine(" *Compression Rate is 100-120 compressions per minute");
            WriteLine(" *That rate equates to about 4 CPR cycles per minute (or about 15 seconds per cycle)");
            WriteLine(" *Stop CPR every 2 minutes (about 8 cycles) to check for a pulse and breathing for 10 seconds");
            WriteLine();
            heartbeat.PlaySync();
            trainingPt1.PlaySync();
            ForegroundColor = ConsoleColor.Blue;
            string next2 = "type 'X' to view PDF or press ENTER to continue training";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (next2.Length / 2)) + "}", next2));
            string screenOption = ReadLine().ToUpper();
            while (screenOption != "X" && screenOption != "")
            {
                WriteLine("You must type 'X' or press ENTER");
                screenOption = ReadLine();
            }
            if (screenOption == "X")
            {
                //Process openPDF = new Process();
                //openPDF.StartInfo.FileName = @"c:\CPR_Sim\2020_AHA_CPR_Summary.pdf";
                //openPDF.Start();
                //Process.Start(@"c:\CPR_Sim\2020_AHA_CPR_Summary.jpg");
                WriteLine("PDF file was opened inside the associated application on your computer.\nReview the PDF and return to this screen when finished.\nThen, press ENTER to resume training.");
                ReadLine();
            }
            Clear();
            #endregion

            #region Training Information Screen - Part 2
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            BackgroundColor = ConsoleColor.White;
            WriteLine(" Training Information - Part 2 ");
            WriteLine();
            ResetColor();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Some CPR standards are DIFFERENT between adults, children, and infants.");
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Adults (includes adolescents)");
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(" adult age definition: anyone who has entered puberty or older");
            ResetColor();
            WriteLine();
            WriteLine(" *Adults most often require CPR due to cardiac failure");
            WriteLine(" *Hands-only CPR is effective (chest compressions only - no ventilations)");
            WriteLine(" *Rescue breathing (without compressions) = 1 breath every 6 seconds (10/min)");
            WriteLine(" *Call First – if alone, call 9-1-1 to activate EMS before starting CPR");
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("Children and Infants");
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(" child age definition: at least 1 y/o and before puberty");
            WriteLine(" infant age definition: less than 1 y/o, excluding newborns");
            ResetColor();
            WriteLine();
            WriteLine(" *Children and infants most often require CPR due to respiratory failure");
            WriteLine(" *CPR cycles with chest compressions must include 2 rescue breaths");
            WriteLine(" *Rescue breathing (without compressions) = 1 breath every 2-3 seconds (20-30/min)");
            WriteLine(" *Call Fast – if alone, do 5 cycles of CPR before calling 9-1-1");
            WriteLine();
            heartbeat.PlaySync();
            trainingPt2.PlaySync();
            ForegroundColor = ConsoleColor.Blue;
            string startSim = "press ENTER to begin CPR simulation";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (startSim.Length / 2)) + "}", startSim));
            string simStart = ReadLine();
            while (simStart != "")
            {
                WriteLine("You must press ENTER to continue");
                simStart = ReadLine();
            }
            Clear();
            #endregion

            #region CPR Simulation
            WriteLine();
            ForegroundColor = ConsoleColor.Red;
            string title2 = "CPR SIMULATION";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (title2.Length / 2)) + "}", title2));
            WriteLine();
            ResetColor();

            //Simulation Instructions
            ForegroundColor = ConsoleColor.White;
            WriteLine("INSTRUCTIONS:\n\nThis simulation will provide situational information along the way.\nYou will be prompted to answer questions and take action based on the information you have learned.\nFeedback about your performance will be provided in real-time.\nYour CPR cycles will also be timed throughout this simulation.\nA final report will be generated at the end to display your results.");
            WriteLine();
            WriteLine("Are you ready?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string ready = ReadLine();
            ForegroundColor = ConsoleColor.White;
            if (ready == "Y")
            {
                WriteLine();
                WriteLine("Let's begin! Press ENTER");
                ReadLine();
            }
            else if (ready == "N")
            {
                WriteLine("Press ENTER when you are ready");
                ReadLine();
            }
            Clear();
            #endregion

            #region Scenario Build
            ForegroundColor = ConsoleColor.White;
            WriteLine("SCENARIO:\n\nIt’s a bright, sunny day and you are relaxing in a park near a big lake.\nHowever, you might suddenly find yourself in a situation that would require you to save someone’s life.\nThe situation will develop based how you answer the initial questions.");
            WriteLine();
            WriteLine("Did anyone come with you to the park?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string guestQ = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            int guestCount = 0;
            if (guestQ == "Y")
            {
                WriteLine();
                WriteLine("How many friends or family members are with you?");
                ForegroundColor = ConsoleColor.Blue;
                Write("Enter #: ");
                guestCount = Convert.ToInt32(ReadLine());
                ForegroundColor = ConsoleColor.White;
                WriteLine("Hopefully you're having a great time with each other!");
            }
            else if (guestQ == "N")
            {
                WriteLine("There's plenty of things to do in the park. Maybe you'll make a new friend or two while you're here.");
            }

            WriteLine();
            WriteLine("Take a look around this virtual park. How many other people do you see nearby, if any?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter #: ");
            int parkPeople = Convert.ToInt16(ReadLine());
            ForegroundColor = ConsoleColor.White;

            WriteLine();
            WriteLine("Some people leave their cell phones behind when they are trying to relax. Do you have your cell phone with you?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string cellPhone = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("You decide to take a stroll down one of the pathways. What are one of the things you see?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Answer: ");
            string observation1 = ReadLine().ToLower();
            ForegroundColor = ConsoleColor.White;
            WriteLine("What else do you see?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Answer: ");
            string observation2 = ReadLine().ToLower();
            ForegroundColor = ConsoleColor.White;
            #endregion

            #region Scene Safety
            Clear();
            CursorVisible = false;
            ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 3; i++)
            {
                redAlert.Play();
                WriteLine("\n\n\n\n");
                Write(@"
                            ██████  ███████ ██████       █████  ██      ███████ ██████  ████████ 
                            ██   ██ ██      ██   ██     ██   ██ ██      ██      ██   ██    ██    
                            ██████  █████   ██   ██     ███████ ██      █████   ██████     ██    
                            ██   ██ ██      ██   ██     ██   ██ ██      ██      ██   ██    ██    
                            ██   ██ ███████ ██████      ██   ██ ███████ ███████ ██   ██    ██");
                Thread.Sleep(1000);
                Clear();
                Thread.Sleep(1000);
            }
            CursorVisible = true;
            ResetColor();
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("You suddenly see someone as they collapse face-down on the ground under a tree, between the " + observation1 + " and the " + observation2 + ".\nYou run over to see if they are alright, but they don’t respond to your voice.");
            WriteLine();
            WriteLine("Now you are kneeling by the victim. What age do you estimate them to be?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter Age: ");
            int age = Convert.ToInt16(ReadLine());
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("QUESTION: Now look in the area around you. Think about the safety of the environment.\nConsider things like the heat from direct sunlight, exposed electrical wires, broken glass on the ground,\na potential active shooter in the area, or any other threats to safety.\nIs the environment safe for both you and the victim?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string sceneSafety = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            if (sceneSafety == "N")
            {
                WriteLine("FEEDBACK: Move yourself and the victim to safety if possible. Otherwise, contact 9 - 1 - 1 and wait for help to arrive.");
            }
            else if (sceneSafety == "Y")
            {
                WriteLine("FEEDBACK: Good. You are both safe. You can continue assisting the victim.");
            }
            #endregion

            #region Category
            WriteLine();
            WriteLine("DECISION: According to the American Heart Association standards, what category is this person considered?");
            WriteLine("(1) Adult/Adolescent\n(2) Child \n(3) Infant");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter #: ");
            int category = Convert.ToInt16(ReadLine());
            ForegroundColor = ConsoleColor.Red;
            if (category == 1 && age >= 10)
            {
                WriteLine("FEEDBACK: That is correct. This person is considered an adult.");
            }
            else if (category == 1 && age >= 1 && age < 8)
            {
                WriteLine("FEEDBACK: That is NOT correct. This person is considered a child.");
            }
            else if (category == 2 && age >= 1 && age < 8)
            {
                WriteLine("FEEDBACK: That is correct. This person is considered a child.");
            }
            if (category == 2 && age >= 10)
            {
                WriteLine("FEEDBACK: That is NOT correct. This person is considered an adult.");
            }
            if (category == 3 && age >= 10)
            {
                WriteLine("FEEDBACK: That is NOT correct. This person is considered an adult.");
            }
            if (category == 3 && age >= 1 && age < 8)
            {
                WriteLine("FEEDBACK: That is NOT correct. This person is considered a child.");
            }
            #endregion

            #region Initial Assessment
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            WriteLine("QUESTION: Is this person conscious?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string conscious = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            if (conscious == "Y")
            {
                WriteLine("FEEDBACK: CPR is not required. This simulation has ended.");
                Environment.Exit(1);
            }
            else if (conscious == "N")
            {
                WriteLine("This person really needs your help. Continue providing assistance.");
            }
            WriteLine();
            WriteLine("QUESTION: Are there any signs of irreversible death (rigor mortis, decapitation, etc.)?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string doa = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            if (doa == "Y")
            {
                WriteLine("FEEDBACK: CPR is not required. This simulation has ended.");
                Environment.Exit(2);
            }
            else if (doa == "N")
            {
                WriteLine("Very good. This means there's a chance you can help them survive. Keep going - every second counts!");
            }
            ForegroundColor = ConsoleColor.Blue;
            WriteLine();
            string continueSim = "press ENTER to continue simulation";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (continueSim.Length / 2)) + "}", continueSim));
            ReadKey();
            Clear();
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("ACTION: If there are any bystanders, ask if they know if this person\nhas a “Do-Not-Resucitate (DNR) Order” from a doctor.");
            WriteLine();
            WriteLine("QUESTION: Has anyone given you a physical copy of a DNR order?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string dnrOrder = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            if (dnrOrder == "Y")
            {
                WriteLine("FEEDBACK: CPR is not required. This simulation has ended.");
                Environment.Exit(3);
            }
            else if (dnrOrder == "N")
            {
                WriteLine("Since there's no DNR Order, you can continue.");
            }
            WriteLine();
            WriteLine("ACTION: Now you need to check for a carotid pulse (at the neck).");
            WriteLine("DECISION: Is there a pulse present?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string pulsePresent = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            if (pulsePresent == "Y")
            {
                WriteLine("FEEDBACK: This person does not require chest compressions at this time.\nThat could change and you will need to keep checking the pulse until EMS arrives.\nNow, you need to check for breathing.");
            }
            else if (pulsePresent == "N")
            {
                WriteLine("FEEDBACK: This person will require chest compressions.");
            }
            WriteLine();
            WriteLine("ACTION: Place your ear near the person’s mouth and check for breathing\nby looking at the person’s chest for movement, listening for breathing from their mouth,\nand feeling for movement of air on your cheek. Look, listen, and feel for 10 seconds.");
            WriteLine();
            WriteLine("DECISION: is this person breathing?");
            ForegroundColor = ConsoleColor.Blue;
            Write("Y or N: ");
            string isBreathing = ReadLine().ToUpper();
            ForegroundColor = ConsoleColor.White;
            switch (isBreathing)
            {
                case "Y":
                    WriteLine();
                    WriteLine("Noted, the victim is breathing");
                    break;
                case "N":
                    WriteLine();
                    WriteLine("Noted, the victim is not breathing");
                    break;
            }
            #endregion

            #region Call 9-1-1 Who?
            WriteLine();
            WriteLine("QUESTION: Who needs to call 9-1-1 under the current conditions?");
            WriteLine("(1) Yourself\n(2) Someone Else");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter #: ");
            int whoCalls911 = Convert.ToInt32(ReadLine());
            if (whoCalls911 == 1 && guestQ == "N" && parkPeople == 0 && cellPhone == "Y")
            {
                WriteLine("That is correct. You didn't come to the park with any guests and you didn't see anyone else.\nThat means you are alone and you will need to call 9-1-1 yourself.\nIt's a good thing you brought your cell phone.");
            }
            else if (whoCalls911 == 1 && guestCount == 1 && parkPeople == 0)
            {
                WriteLine("No. That is NOT correct. You came to the park with one guest. You can ask them to call 9-1-1.");
            }
            else if (whoCalls911 == 1 && guestCount > 1 && parkPeople == 0)
            {
                WriteLine("No. That is NOT correct. You came to the park with " + guestCount + " guests. You can ask one of them to call 9-1-1.");
            }
            else if (whoCalls911 == 1 && guestQ == "N" && parkPeople > 0 && cellPhone == "Y")
            {
                WriteLine("No. That is NOT correct. You didn't come to the park with any guests,\nbut you did see at least one other person in the park when you arrived.\nYou can yell for help and ask them to call 9-1-1 while you start CPR.\nIt's a good thing you have your cell phone just in case, though.");
            }
            else if (whoCalls911 == 2 && guestQ == "N" && parkPeople > 0)
            {
                WriteLine("That is correct. You didn't come to the park with any guests,\nbut you did see at least one other person in the park when you arrived.\nYou can yell for help and ask them to call 9-1-1 while you start CPR.");
            }
            else if (whoCalls911 == 2 && guestCount == 0 && parkPeople == 0 && cellPhone == "Y")
            {
                WriteLine("That is NOT correct. You did not come to the park with any guest and you didn't see anyone else in the park when you arrived.\nThat means you are alone and you will need to call 9-1-1 yourself.\nIt's a good thing you brought your cell phone.");
            }
            else if (whoCalls911 == 2 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is NOT correct. You did not come to the park with any guest and you didn't see anyone else in the park when you arrived.\nThat means you are alone and you will need to call 9-1-1 yourself.\nYou didn't bring your cell phone. So, just lay this person on their back,\ntilt their head back to open their airway, and find the nearest phone.");
            }
            else if (whoCalls911 == 2 && guestCount == 1 && parkPeople == 0)
            {
                WriteLine("That is correct. You came to the park with a guest,\nbut you didn't see anyone else in the park when you arrived.\nYou can ask your guest to call 9-1-1 while you start CPR.");
            }
            else if (whoCalls911 == 2 && guestCount > 1 && parkPeople == 0)
            {
                WriteLine("That is correct. You came to the park with " + guestCount + " guests,\nbut you didn't see anyone else in the park when you arrived.\nYou can ask one of your guests to call 9-1-1 while you start CPR.");
            }
            #endregion

            #region Call 9-1-1 When?
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("When should the 9-1-1 call me made?");
            WriteLine("(1) Before starting CPR\n(2) At the same time CPR is started\n(3) After five (5) cycles of CPR");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter #: ");
            int whenCall911 = Convert.ToInt32(ReadLine());
            ForegroundColor = ConsoleColor.Red;
            if (whenCall911 == 1 && category == 1 && guestCount == 0 && parkPeople == 0)
            {
                WriteLine("That is correct. For adults, we 'Call First' before starting CPR if we are alone.\nYou can put this person on their back and tilt their head back to open the airway while you find a phone.");
            }
            if (whenCall911 == 1 && category == 2)
            {
                WriteLine("That is NOT correct. If you are alone with a child or infant and without a cell phone,\nyou need to 'Call Fast', but not first. Do 5 cycles of CPR, then call 9-1-1.");
            }
            if (whenCall911 == 1 && category == 3)
            {
                WriteLine("That is NOT correct. If you are alone with a child or infant and without a cell phone,\nyou need to 'Call Fast', but not first. Do 5 cycles of CPR, then call 9-1-1.");
            }
            if (whenCall911 == 2 && category == 1 && guestCount > 0)
            {
                WriteLine("That is correct. You can start CPR while someone else calls 9-1-1.");
            }
            if (whenCall911 == 2 && category == 1 && parkPeople > 0)
            {
                WriteLine("That is correct. You can start CPR while someone else calls 9-1-1.");
            }
            if (whenCall911 == 2 && category == 2 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is NOT correct. If you are alone with a child and without a cell phone,\nyou need to do 5 cycles of CPR, then call 9-1-1.");
            }
            if (whenCall911 == 2 && category == 3 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is NOT correct. If you are alone with a child and without a cell phone,\nyou need to do 5 cycles of CPR, then call 9-1-1");
            }
            if (whenCall911 == 3 && category == 1 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is NOT correct. If you are alone with an adult and without a cell phone,\nyou need to call 9-1-1 first, then start CPR.");
            }
            if (whenCall911 == 3 && category == 2 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is correct. If you are alone with a child and without a cell phone,\nyou need to do 5 cycles of CPR, then call 9-1-1.");
            }
            if (whenCall911 == 3 && category == 3 && guestCount == 0 && parkPeople == 0 && cellPhone == "N")
            {
                WriteLine("That is correct. If you are alone with an infant and without a cell phone,\nyou need to do 5 cycles of CPR, then call 9-1-1.");
            }
            if (whenCall911 == 3 && category == 2 && guestCount == 0 && parkPeople == 0 && cellPhone == "Y")
            {
                WriteLine("That is NOT correct. If you are alone with a child and you have a cell phone,\nyou can call 9-1-1 on speaker phone while you start CPR.");
            }
            if (whenCall911 == 3 && category == 3 && guestCount == 0 && parkPeople == 0 && cellPhone == "Y")
            {
                WriteLine("That is NOT correct. If you are alone with an infant and you have a cell phone,\nyou can call 9-1-1 on speaker phone while you start CPR.");
            }
            #endregion

            #region Assistance Type
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("How will you assist this victim?");
            WriteLine("(1) Rescue Breathing (no compressions)\n(2) Hands-Only Chest Compressions (no breaths)\n(3) Full CPR (compressions and breaths)\n(4) Wait for EMS");
            ForegroundColor = ConsoleColor.Blue;
            Write("Enter #: ");
            int assistType = Convert.ToInt32(ReadLine());
            ForegroundColor = ConsoleColor.Red;

            if (assistType == 1 && isBreathing == "N" && pulsePresent == "Y")
            {
                WriteLine("That is correct. You must provide rescue breathing if someone has a pulse, but is not breathing on their own.");
            }
            if (assistType == 1 && isBreathing == "Y" && pulsePresent == "Y")
            {
                WriteLine("That is NOT correct. You must only wait for EMS if someone has a pulse and is breathing.\nJust stay with them and monitor them closely");
            }
            if (assistType == 2 && pulsePresent == "Y")
            {
                WriteLine("That is NOT correct. If someone has a pulse, you do not need to do compressions.");
            }
            if (assistType == 2 && pulsePresent == "N" && category == 1)
            {
                WriteLine("That is correct. If an adult does not have a pulse, hand-only compressions without rescue breaths can be effective.");
            }
            if (assistType == 2 && pulsePresent == "N" && category == 2)
            {
                WriteLine("That is NOT correct. If an child does not have a pulse, rescue breaths must be provided with compressions during CPR cycles.");
            }
            if (assistType == 2 && pulsePresent == "N" && category == 3)
            {
                WriteLine("That is NOT correct. If an child does not have a pulse, rescue breaths must be provided with compressions during CPR cycles.");
            }
            if (assistType == 3 && isBreathing == "N" && pulsePresent == "N")
            {
                WriteLine("That is correct. CPR cycles with both chest compressions and rescue breaths\ncan help a person of any age who is not breathing and has no pulse.");
            }
            if (assistType == 3 && isBreathing == "N" && pulsePresent == "Y")
            {
                WriteLine("That is NOT correct. A person with a pulse does not need chest compressions.\nThis person only needs rescue breathing, but if you wait too long their heart might stop.\nThen, they will need full CPR cycles at that point.");
            }
            if (assistType == 4 && isBreathing == "Y" && pulsePresent == "Y")
            {
                WriteLine("That is correct. A person who is breathing and has a pulse does not need any CPR. Just stay with them and monitor them closely until EMS arrives.");
            }
            if (assistType == 4 && isBreathing == "N" && pulsePresent == "Y")
            {
                WriteLine("That is NOT correct. A person who is not breathing needs rescue breaths.\nThe brain starts to die after four minutes without oxygen.\nYou must perform rescue breathing while waiting for EMS to arrive.");
            }
            if (assistType == 4 && isBreathing == "N" && pulsePresent == "N")
            {
                WriteLine("That is NOT correct. A person who has no pulse needs chest compressions. Children and infants also must have rescue breaths.\nYou must do CPR while you wait for EMS to arrive.");
            }
            #endregion

            #region CPR Cycles
            Clear();
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine("Now it's time to begin cycles of CPR. Remember, the ratio of compressions to breaths is 30:2.");
            WriteLine("Type 'C' for one compression.");
            WriteLine("Type 'B' for one breath.");
            WriteLine("Type 'P' to pause CPR and check pulse and respirations.");
            WriteLine("press ENTER to end a cycle");
            WriteLine();
            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 1: ");
            string cycle1 = ReadLine();
            while (cycle1 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 1: ");
                cycle1 = ReadLine();
            }
            if (cycle1 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }
            
            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 2: ");
            string cycle2 = ReadLine();
            while (cycle2 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 2: ");
                cycle2 = ReadLine();
            }
            if (cycle2 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }
            
            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 3: ");
            string cycle3 = ReadLine();
            while (cycle3 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 3: ");
                cycle3 = ReadLine();
            }
            if (cycle3 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }

            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 4: ");
            string cycle4 = ReadLine();
            while (cycle4 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 4: ");
                cycle4 = ReadLine();
            }
            if (cycle4 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }

            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 5: ");
            string cycle5 = ReadLine();
            while (cycle5 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 5: ");
                cycle5 = ReadLine();
            }
            if (cycle5 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }

            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 6: ");
            string cycle6 = ReadLine();
            while (cycle6 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 6: ");
                cycle6 = ReadLine();
            }
            if (cycle6 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }

            ForegroundColor = ConsoleColor.White; 
            Write("Begin Cycle 7: ");
            string cycle7 = ReadLine();
            while (cycle7 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, the ratio is 30:2");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 7: ");
                cycle7 = ReadLine();
            }
            if (cycle7 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBB")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("That was a perfect CPR cycle! Press ENTER to start the next cycle.");
                ReadLine();
            }

            ForegroundColor = ConsoleColor.White;
            Write("Begin Cycle 8: ");
            string cycle8 = ReadLine();
            while (cycle8 != "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBBP")
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine();
                WriteLine("That cycle was not quite right. Remember, to pause CPR every 2 minutes to check for a pulse and breathing.");
                WriteLine("press ENTER to try this cycle again");
                ForegroundColor = ConsoleColor.White;
                Write("Repeat Cycle 8: ");
                cycle8 = ReadLine();
            }
            if (cycle8 == "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCBBP")
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Great CPR cycle! It’s good that you stopped to check for pulse and breathing\nbecause this person now has both! You saved their life!!!\nThey are becoming conscious again. Stay with this person, keep them calm, and wait for EMS to arrive.");
            }
            #endregion

            ForegroundColor = ConsoleColor.Yellow;
            WriteLine();
            WriteLine("You have completed this CPR simulation");
            WriteLine();

            ForegroundColor = ConsoleColor.Blue;
            string exitSim = "press ENTER to exit";
            WriteLine(String.Format("{0," + ((WindowWidth / 2) + (exitSim.Length / 2)) + "}", exitSim));
            ReadKey();

            Environment.Exit(911);
        }
        public static void Type(string text, int speed)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(speed);
            }
            Console.WriteLine();
        }
    }
}
