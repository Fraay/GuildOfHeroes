public class Game
{
    public string Name;
    public string Genre;
    public int Year;
    public int Quantity;
    public double Rating;

 public Game(string name, string genre, int year) {
        Name = name;
        Genre = genre;
        Year = year;
        Rating = 0.0;
        Quantity = 0;
    }
    public void NewRating(double amount) {
        if (amount <= 0) {
            return;
        }
        Rating += amount;
    }

    public void AddQuantity(int amount) {
        if (amount <= 0) {
            return;
        }
        Quantity += amount;
    }

    public bool IsAvailaible() {
        return Quantity > 0;
    }
    
    public string GetInfo() {
        return $">>> {Name} <<<\n" +
           $"Жанр: {Genre}\n" +
           $"Год выпуска: {Year}\n" +
           $"Рейтинг: {Rating}\n" +
           $"Копий в наличии: {Quantity}";
    }
}