public class mag_toy
{
    public string _name = "Игра без названия";
    public int Count { get; private set; }
    public List<string> Toys = new List<string>();
    public mag_status Status { get; private set; }
    public string Name {
        get { return _name; }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Игра без названи";
                return;
            }

            _name = value.Trim();
        }
    }

    public mag_toy(string name, int count)

    {
        Name = name;
        Count = count;
        Status = mag_status.Open;

        if (Count <= 0) { Count = 0; }

        if (Count > 10) { Count = 10; }

    
    }


    public void Open() { Status = mag_status.Open; }
    public void Close() { Status = mag_status.Close; }
    public bool Count_pr() { return Count > 0; }
    public bool status_pr() { return Status != mag_status.Open; }




    public string Buy_game(string toy)
    {
        if (status_pr()) { return "Магазин закрыт"; }

        if (string.IsNullOrWhiteSpace(toy) || Count_pr() == false) { return "Произошла ошибка"; }

        foreach (string i in Toys)

            if (toy.ToLower() == i.ToLower())
            {
                Count -= 1;
                Toys.RemoveAll(t => t.ToLower() == toy.ToLower());
                return $"Вы успешно купили {toy}";
            }

        return "Вы ввели такой игры нету в каталоге";

    }

    public string Add_toy(string toy, int count)
    {
        if (count <= 0 || string.IsNullOrWhiteSpace(toy) || Count_pr() == false) { return "Произошла ошибка"; }

        foreach (string i in Toys)
        {
            if (toy.ToLower() == i.ToLower())
            {
                Count += count;
                return $"Количество игрушек увеличено на {count}";
            }

            return "игрушка добавлена в реестр";


        }
        Toys.Add(toy);
        return "Вы ввели такой игры нету в каталоге";
    }

    public string Get_Info()
    {
        if (status_pr()) { return "Магазин закрыт"; }

        Console.WriteLine("каталог игр:");
        return $"{Toys}";
    }
    










}