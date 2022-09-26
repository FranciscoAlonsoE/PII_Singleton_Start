namespace Library{
    public class Singleton<T> where T : new(){
        private static T Instance;
        public static T getInstance{
            get
            {
                if (Instance == null)
                {
                    Instance = new T();
                }

                return Instance;
            }
        }
    }
}