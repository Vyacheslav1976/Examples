using System;

namespace RoboModel
{
    enum M1_state
    {
        M1_ready_to_loading, // eqvivalent end of unload
        M1_start_to_loading, // R1_ready_to_load_M1 eqvivalent
        M1_Loaded,
        M1_complete_handling,  //after unloading ready status change to  M1_ready_to_loading
    }
    class M1 : Agregate
    {
        public M1_state M1_status;
        public M1()
        {
            Console.WriteLine("M1 initialisation -M1_ready_to_loading");
            M1_status = M1_state.M1_ready_to_loading;
        }
    }

}

