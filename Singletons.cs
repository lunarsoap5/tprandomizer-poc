

namespace tprandomizer_poc_main
{ 
    public class Singleton
    {
        public ItemFunctions Items = new ItemFunctions();
        public CheckFunctions Checks = new CheckFunctions();
        public RoomFunctions Rooms = new RoomFunctions();
        
        private static Singleton instance;
        
        
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}