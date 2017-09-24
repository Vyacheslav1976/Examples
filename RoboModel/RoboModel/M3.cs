using System;

namespace RoboModel
{
    enum M3_state
    {
        M3_ready_to_loading, // R1_ready_to_load_M2 eqvivalent3
        M3_start_to_loading,
        M3_Loaded,
        M3_complete_handling,  //after unloading ready status change to  M1_ready_to_loading
    }
    class M3 : Agregate
    {
        public M3_state M3_status;
        public M3()
        {
            Console.WriteLine("M3 initialisation -M3_ready_to_loading");
            M3_status = M3_state.M3_ready_to_loading;
            //            M3_status = M3_state.M3_Loaded;
            operTime = 1;// 25;
        }
    }

}

