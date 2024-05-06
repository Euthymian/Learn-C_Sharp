namespace Shounen {
    class GokuFan {
        public void Display() {
            Console.WriteLine("I am a Goku Fan in Shounen namespace");
        }
    }
    class VegetaFan {
        public void Display() {
            Console.WriteLine("I am a Vegeta Fan in Shounen namespace");
        }
    }
}

namespace Anime {
    class GokuFan {
        public void Display() {
            Console.WriteLine("I am a Goku Fan in Anime namespace");
        }
    }
    class VegetaFan {
        public void Display() {
            Console.WriteLine("I am a Vegeta Fan in Anime namespace");
        }
    }
}

class GokuFan {
    public void Display() {
        Console.WriteLine("I am a Goku Fan no namespace");
    }
}

class VegetaFan {
    public void Display() {
        Console.WriteLine("I am a Vegeta Fan no namespace");
    } 
}