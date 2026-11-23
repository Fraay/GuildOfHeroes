using System.Formats.Tar;

Game Minecraft = new Game("Майнкрафт", "Песочница с открытым миром", 2009);
Game GTAVI = new Game("ГТА 6", "Экшен и шутер от третьего лица", 2026);
Game HalfLife2 = new Game("Халф-Лайф 2", "Шутер от первого лица", 2004);

// Console.WriteLine("Игра №1");
// Console.WriteLine($"Название: {Minecraft.Name}");
// Console.WriteLine($"Жанр: {Minecraft.Genre}");
// Console.WriteLine($"Год выхода: {Minecraft.Year}");
// Console.WriteLine($"Рейтинг: {Minecraft.Rating}");

// Console.WriteLine();

// Console.WriteLine("Игра №2");
// Console.WriteLine($"Название: {GTAVI.Name}");
// Console.WriteLine($"Жанр: {GTAVI.Genre}");
// Console.WriteLine($"Год выхода: {GTAVI.Year}");
// Console.WriteLine($"Рейтинг: {GTAVI.Rating}");

// Console.WriteLine();

// Console.WriteLine("Игра №3");
// Console.WriteLine($"Название: {HalfLife2.Name}");
// Console.WriteLine($"Жанр: {HalfLife2.Genre}");
// Console.WriteLine($"Год выхода: {HalfLife2.Year}");
// Console.WriteLine($"Рейтинг: {HalfLife2.Rating}");

Console.WriteLine($"Старый рейтинг: {Minecraft.Rating}");

Minecraft.NewRating(5.5);
Console.WriteLine($"Изменённый рейтинг: {Minecraft.Rating}");

Minecraft.NewRating(-5.5);
Console.WriteLine($"Изменённый рейтинг: {Minecraft.Rating}");

Minecraft.AddQuantity(35);
GTAVI.AddQuantity(10);
Console.WriteLine();
HalfLife2.AddQuantity(26);
Console.WriteLine(Minecraft.GetInfo());
Console.WriteLine();
Console.WriteLine(GTAVI.GetInfo());
Console.WriteLine();
Console.WriteLine(HalfLife2.GetInfo());