using System;

namespace RoboModel
{
    enum R2_state
    {
        R2_ready_to_move_not_ready_item_to_M3 = 1,  //Start of work cicle
        R2_ready_to_load_M3, // 
        R2_ready_to_move_ready_item_1_to_L3,//
        R2_ready_to_move_ready_item_2_to_L3,//
        R2_waiting_fot_M3_finish_handle,
        R2_ready_for_unload_M3,
        R2_ready_to_move_from_M3_to_L3,
        R2_waiting_for_L2_loaded_not_ready_item,
    }
    class R2 : Agregate
    {
        public R2_state R2_status;
        public R2()
        {
            Console.WriteLine("R2 initialisation - R2_ready_to_move_ready_item_1_to_L3");     
//            R2_status = R2_state.R2_ready_to_move_ready_item_1_to_L3; //first state for start work
            R2_status = R2_state.R2_ready_to_move_not_ready_item_to_M3; //first state for start work
            operTime = 1;
        }
    }

}

