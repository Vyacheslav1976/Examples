namespace RoboModel
{
    enum L2_state
    {
        L2_ready_item_loaded, // 
        L2_not_ready_item_loaded,
        L2_empty,
    }
    class L2 : Agregate
    {

        public L2() {
            L2_state = L2_state.L2_empty;//L2_ready_item_loaded;
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

