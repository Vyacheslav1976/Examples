using System;

namespace RoboModel
{
    enum R2_state
    {
        R2_ready = 1,  //Start of work cicle
        R2_ready_to_load_M1, // 
        R2_ready_to_move_to_M2,//M1_Loaded eqvivalent
        R2_ready_to_load_M2, //
        R2_ready_to_move_from_L1_to_L2,//M2_loaded eqvivalent       
        R2_L2_from_L1_loaded, // start to unload M1 without moving to M1
        R2_ready_to_move_from_M1_to_L2,
        R2_L2_from_M1_loaded,
        R2_ready_to_move_from_M2_to_L2,
        R2_L2_from_M2_loaded,
    }
    class R2 : Agregate
    {
        public R2_state R2_status;
        public R2()
        {
            Console.WriteLine("R2 initialisation - R2_ready");
            R2_status = R2_state.R2_ready;
        }
    }

}

