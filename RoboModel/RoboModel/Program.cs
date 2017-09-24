using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboModel
{
    class RoboModel
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start modeling!");
            int timeCounter = 0;

            //============================
            //  initialisation
            //============================

            bool exit = false;
            R1 R1_robot = new R1();
            M1 M1_agregate = new M1();
            M2 M2_agregate = new M2();
            M3 M3_agregate = new M3();
            L2 L2_lotok = new L2();
            int R1_new_status_flag = 1; // if new status just set flag = 1, else =0
            //=============
            //work cicle
            //=============
            while (!exit)
            {
                Console.WriteLine("Time: {0} seconds", timeCounter);
                if (timeCounter == 400) { exit = true; }
                //                R1_robot
                //==================================
                //  R1 cicle
                //===============
                R1_robot.operTime--;  // decrease oper time 
//                for (int i = 0; i < 2; i++)  // execute switch 2 times for  status setting                 { 
                switch (R1_robot.R1_status)
                {
                    case R1_state.R1_ready:
                        //Start of work cicle 
                        if (R1_new_status_flag == 1)
                        {
                            // init R1 move to load M1 counter 11 c
                            R1_robot.operTime = R1_robot.operTime + 11; 
                            R1_new_status_flag = 0;
                        }
                        if (R1_robot.operTime == 0)
                        {
                            Console.WriteLine("R1 switch to R1_ready_to_load_M1"); 
                            R1_robot.R1_status = R1_state.R1_ready_to_load_M1;
                                M1_agregate.M1_status = M1_state.M1_start_to_loading;
                                R1_new_status_flag = 1;                                
                        }
                        break;
                    case R1_state.R1_ready_to_load_M1: // 
                        if (R1_new_status_flag == 1)
                        {
                            // init R1 to loading M1 counter - 4c
                            R1_robot.operTime = R1_robot.operTime + 4;//  4 -1;
                            R1_new_status_flag = 0;
                        }
                        if (R1_robot.operTime == 0)
                        {
                            Console.WriteLine("Switch to R1_ready_to_move_to_M2"); ;
                            R1_robot.R1_status = R1_state.R1_ready_to_move_to_M2;
                            M1_agregate.M1_status=M1_state.M1_Loaded;  //
                            R1_new_status_flag = 1;
                        }
                        break;
                    case R1_state.R1_ready_to_move_to_M2:
                            if (R1_new_status_flag == 1)
                            {
                                // init R1 to moving to M2 counter - 11c
//                                R1_robot.operTime = 11;
                            R1_robot.operTime = R1_robot.operTime + 11;
                                R1_new_status_flag = 0;
                            }
                            if (R1_robot.operTime == 0)
                            {
                                R1_robot.R1_status = R1_state.R1_ready_to_load_M2;
                                M2_agregate.M2_status = M2_state.M2_start_to_loading;
                                Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                                R1_new_status_flag = 1;
                            }
                            break;
                    case R1_state.R1_ready_to_load_M2:
                            if (R1_new_status_flag == 1)
                            {
                            // init R1 to load M2 counter - 4c
                            //                                R1_robot.operTime = 4;
                            R1_robot.operTime = R1_robot.operTime + 4;
                                R1_new_status_flag = 0;
                            }
                            if (R1_robot.operTime == 0)
                            {
                                R1_robot.R1_status = R1_state.R1_ready_to_move_from_L1_to_L2;
                                M2_agregate.M2_status = M2_state.M2_loaded;
                                Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                                R1_new_status_flag = 1;
                            }

                            break;
                    case R1_state.R1_ready_to_move_from_L1_to_L2://M2_loaded eqvivalent       
                            if (R1_new_status_flag == 1)
                            {
                                // init R1 to move fromL1 to L2 counter - 8c
//                                R1_robot.operTime = 8;
                            R1_robot.operTime = R1_robot.operTime + 8;
                                R1_new_status_flag = 0;
                            }
                            if (R1_robot.operTime == 0)
                            {
                            R1_robot.R1_status = R1_state.R1_L2_from_L1_loaded; 
                                if (L2_lotok.L2_state != L2_state.L2_not_ready_item_loaded
                                || L2_lotok.L2_state != L2_state.L2_ready_item_loaded)
                                {
                                    L2_lotok.L2_state = L2_state.L2_not_ready_item_loaded;
                                Console.WriteLine("L2 lotok {0}", L2_lotok.L2_state);
                            }
                                else { Console.WriteLine("Error! Trying to load loaded L2 lotok"); }

                                Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                                R1_new_status_flag = 1;
                            }
                            break;
                    case R1_state.R1_L2_from_L1_loaded: // start to unload M1 without moving to M1
                        if (R1_new_status_flag == 1)
                        {
                            // init R1 to unload M1 to L2 counter - 4c
                            //                            R1_robot.operTime = 4;
                            R1_robot.operTime = R1_robot.operTime + 4;
                            R1_new_status_flag = 0;
                        }
                        if (R1_robot.operTime == 0)
                        {
                            R1_robot.R1_status = R1_state.R1_ready_to_move_from_M1_to_L2;
                            Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                            M1_agregate.M1_status = M1_state.M1_ready_to_loading;
                            R1_new_status_flag = 1;
                        }
                        break;
                    case R1_state.R1_ready_to_move_from_M1_to_L2:
                            if (R1_new_status_flag == 1)
                            {
                                // init R1 to move from M1 to L2 counter - 6c
//                                R1_robot.operTime = 6;
                            R1_robot.operTime = R1_robot.operTime + 6;
                                R1_new_status_flag = 0;
                            }
                            if (R1_robot.operTime == 0)
                            {
                                R1_robot.R1_status = R1_state.R1_L2_from_M1_loaded;
                            if (L2_lotok.L2_state != L2_state.L2_not_ready_item_loaded
                            || L2_lotok.L2_state != L2_state.L2_ready_item_loaded)
                            {
                                L2_lotok.L2_state = L2_state.L2_ready_item_loaded;
                                Console.WriteLine("L2 lotok {0}", L2_lotok.L2_state);
                            }
                                else { Console.WriteLine("Error! Trying to load loaded L2 lotok"); }

                                Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                                R1_new_status_flag = 1;
                            }
                            break;
                    case R1_state.R1_L2_from_M1_loaded:  // ready to unload M2
                        if (R1_new_status_flag == 1)
                        {
                            // init R1 to unload M2 to L2 counter - 4c
//                            R1_robot.operTime = 4;
                            R1_robot.operTime = R1_robot.operTime + 4;
                            R1_new_status_flag = 0;
                        }
                        if (R1_robot.operTime == 0)
                        {
                            R1_robot.R1_status = R1_state.R1_ready_to_move_from_M2_to_L2;
                            Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                            M2_agregate.M2_status = M2_state.M2_ready_to_loading;
                            R1_new_status_flag = 1;
                        }
                        break;
                    case R1_state.R1_ready_to_move_from_M2_to_L2:
                        if (R1_new_status_flag == 1)
                        {
                            // init R1 to move from M2 to L2 counter - 6c
//                            R1_robot.operTime = 6;
                            R1_robot.operTime = R1_robot.operTime + 6;
                            R1_new_status_flag = 0;
                        }
                        if (R1_robot.operTime == 0)
                        {
                            R1_robot.R1_status = R1_state.R1_ready;
                            if (L2_lotok.L2_state != L2_state.L2_not_ready_item_loaded
                            || L2_lotok.L2_state != L2_state.L2_ready_item_loaded)
                            {
                                L2_lotok.L2_state = L2_state.L2_ready_item_loaded;
                                Console.WriteLine("L2 lotok {0}", L2_lotok.L2_state);
                            }
                            else { Console.WriteLine("Error! Trying to load loaded L2 lotok"); }

                            Console.WriteLine("Switch to {0}", R1_robot.R1_status);
                            R1_new_status_flag = 1;
                        }

                        break;
//                    case R1_state.R1_L2_from_M2_loaded:
//                        break;
                }
                    switch (M1_agregate.M1_status)
                    {
                        case M1_state.M1_ready_to_loading:
                            break;
                        case M1_state.M1_start_to_loading:
                            break;
                        case M1_state.M1_Loaded:
                            break;
                        case M1_state.M1_complete_handling:
                            break;
                    }
                    switch (M2_agregate.M2_status)
                    {
                        case M2_state.M2_ready_to_loading:
                            break;
                        case M2_state.M2_start_to_loading:
                            break;
                        case M2_state.M2_loaded:
                            break;
                        case M2_state.M2_complete_handling:
                            break;
                    }
                    switch (M3_agregate.M3_status)
                    {
                        case M3_state.M3_ready_to_loading:
                            break;
                        case M3_state.M3_start_to_loading:
                            break;
                        case M3_state.M3_Loaded:
                            break;
                        case M3_state.M3_complete_handling:
                            break;
                    }

                timeCounter++;
//                R1_robot.operTime--;  // decrease oper time 
                /*R1_ready_to_load_M1, // 
                R1_ready_to_move_to_M2 ,//M1_Loaded eqvivalent
                R1_ready_to_load_M2, //
                */

            }// end of while
            Console.ReadLine();
        } //end of main
    }

    class Agregate
    {
        public int Status { set; get; } // 1 - 
        public int workTimeCount { set; get; }  // work time counter
        public int itemHandledCounter { set; get; }  // number of handled items
        public int waitingTimeCounter { set; get; } // waiting time counter
        public int operTime { set; get; } // current oper time
    }
    
   
    enum M4_state
    {
        M4_ready_to_loading, // R1_ready_to_load_M2 eqvivalent
        M4_Loaded,
        M4_complete_handling,  //after unloading ready status change to  M1_ready_to_loading
    }

    enum L2_state
    {
        L2_ready_item_loaded, // 
        L2_not_ready_item_loaded,
        L2_empty,        
    }
    enum L3_state
    {
        L3_loaded, // 
        L3_empty,
    }

    class L2 : Agregate
    {
        public L2() {
            L2_state = L2_state.L2_empty;
        }
        public int itemCount { set; get; }
        public L2_state L2_state { set; get; }
        void addItem()
        {
            itemCount++;
        }
        void removeItem()
        {
            itemCount--;
        }


    }

}

