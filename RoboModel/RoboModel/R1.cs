using System;

namespace RoboModel
{
    enum R1_state
    {
        R1_ready = 1,  //Start of work cicle
        R1_ready_to_load_M1, // 
        R1_ready_to_move_to_M2,//M1_Loaded eqvivalent
        R1_ready_to_load_M2, //
        R1_ready_to_move_from_L1_to_L2,//M2_loaded eqvivalent       
        R1_L2_from_L1_loaded, // start to unload M1 without moving to M1
        R1_ready_to_move_from_M1_to_L2,
        R1_L2_from_M1_loaded,
        R1_ready_to_move_from_M2_to_L2,
        R1_L2_from_M2_loaded,
    }
    class R1 : Agregate
    {
        public R1_state R1_status;
        public R1()
        {
            Console.WriteLine("R1 initialisation - R1_ready");
            R1_status = R1_state.R1_ready;
            operTime = 1;
        }
    }

}

