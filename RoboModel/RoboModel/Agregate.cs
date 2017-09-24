namespace RoboModel
{
    class Agregate
    {
        public int Status { set; get; } // 1 - 
        public int workTimeCount { set; get; }  // work time counter
        public int itemHandledCounter { set; get; }  // number of handled items
        public int waitingTimeCounter { set; get; } // waiting time counter
        public int operTime { set; get; } // current oper time
    }

}

