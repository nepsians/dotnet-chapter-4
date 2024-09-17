namespace Chapter4 {
    public delegate T Transformer<T>(T args);

    public class Util{
        public static void Transform<T>(T[] values, Transformer<T> transformer){

            for(int i = 0; i < values.Length; i++){
                values[i] = transformer(values[i]); 
                // values[i] = Square(values[i])
            }
        }
    }

    public class Test{
        static int Square(int x){
            return x * x; // 2*2
        }
        static int Cube(int x){
            return x * x * x;
        }
        static void Main(){
            int[] values = {1,2,3,4};

            Util.Transform(values, Square);

            foreach(int value in values){
                Console.WriteLine(value);
            }

            Util.Transform(values, Cube);

             foreach(int value in values){
                Console.WriteLine(value);
            }

        }
    }
}