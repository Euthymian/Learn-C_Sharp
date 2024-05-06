interface IEdible {
    void HowToEat();
}

abstract class Fruit : IEdible {
    public abstract void HowToEat();
}

class Apple : Fruit {
    public override void HowToEat() {
        System.Console.WriteLine("Eating apple");
    }
}

class Orange : Fruit {
    public override void HowToEat() {
        System.Console.WriteLine("Eating orange");
    }
}

abstract class Animal1 {
    public abstract string MakeSound();
}

class Tiger : Animal1 {
    public override string MakeSound() {
        return "Tiger: roarrrrr!";
    }
}

class Chicken : Animal1, IEdible {
    public override string MakeSound() {
        return "Chicken: cluck-cluck!";
    }

    void IEdible.HowToEat() {
        // Another way to implement interface method
        System.Console.WriteLine("Eating chicken");
    }
}