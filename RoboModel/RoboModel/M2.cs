using System;

namespace RoboModel
{
    enum M2_state
    {
        M2_ready_to_loading, 
        M2_start_to_loading,// R1_ready_to_load_M2 eqvivalent
        M2_loaded,
        M2_complete_handling,  //after unloading ready status change to  M2_ready_to_loading
    }
    class M2 : Agregate
    {
        public M2_state M2_status;
        public M2()
        {
            Console.WriteLine("M2 initialisation -M2_ready_to_loading");
            M2_status = M2_state.M2_ready_to_loading;
        }
    }

}

