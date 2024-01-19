using System;

class Product
{
    private int productID;
    private string name;
    private string manufacturingDate;
    private int warrantyMonths;
    private float price;
    private int stock;
    private int gst;
    private int discount;

    // Getters and Setters for private members
    public int ProductID
    {
        get { return productID; }
        set
        {
            if (value > 0)
                productID = value;
            else
                throw new ArgumentException("ProductID should be greater than 0.");
        }
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 3)
                name = value;
            else
                throw new ArgumentException("Name should have a length greater than 3.");
        }
    }

    public string ManufacturingDate
    {
        get { return manufacturingDate; }
        set
        {
            DateTime currentDate = DateTime.Now;
            if (DateTime.TryParse(value, out DateTime date) && date < currentDate)
                manufacturingDate = value;
            else
                throw new ArgumentException("Invalid manufacturing date.");
        }
    }

    public int Warranty
    {
        get { return warrantyMonths; }
        set
        {
            if (value >= 0)
                warrantyMonths = value;
            else
                throw new ArgumentException("Warranty cannot be negative.");
        }
    }

    public float Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
            else
                throw new ArgumentException("Price should be greater than 0.");
        }
    }

    public int Stock
    {
        get { return stock; }
        set
        {
            if (value > 0)
                stock = value;
            else
                throw new ArgumentException("Stock should be greater than 0.");
        }
    }

    public int GST
    {
        get { return gst; }
        set
        {
            if (value == 5 || value == 12 || value == 18 || value == 28)
                gst = value;
            else
                throw new ArgumentException("GST should be 5, 12, 18, or 28.");
        }
    }

    public int Discount
    {
        get { return discount; }
        set
        {
            if (value >= 1 && value <= 30)
                discount = value;
            else
                throw new ArgumentException("Discount should be between 1 and 30.");
        }
    }

    // Public methods
    public float GetTaxPrice()
    {
        return Price + Price * GST / 100;
    }

    public float GetDiscountPrice()
    {
        float taxPrice = GetTaxPrice();
        return taxPrice - taxPrice * Discount / 100;
    }

    public float GetTotalPrice()
    {
        return GetDiscountPrice() * Stock;
    }

    public string Display()
    {
        string formattedString = $"Product ID: {ProductID}\n" +
                                 $"Name: {Name}\n" +
                                 $"Manufacturing Date: {ManufacturingDate}\n" +
                                 $"Warranty (months): {warrantyMonths}\n" +
                                 $"Tax Price: {GetTaxPrice()}\n" +
                                 $"Discount Price: {GetDiscountPrice()}\n" +
                                 $"Total Price: {GetTotalPrice()}\n";

        return formattedString;
    }
}


class ProductManager
{
    static void Main()
    {
        Product[] myProducts;
        Console.WriteLine("Enter Maximum Length of Array: ");
        int maxItems = int.Parse(Console.ReadLine());
        myProducts = new Product[maxItems];

        int cur_index = 0;

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Enter product details");
            Console.WriteLine("2. Display product details");
            Console.WriteLine("3. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        if (cur_index >= maxItems) {
                            Console.WriteLine("Array is full. You cannot add more items.");
                        }

                        Product myProduct = new Product();

                        Console.WriteLine("Enter product details:");

                        Console.Write("Product ID: ");
                        myProduct.ProductID = int.Parse(Console.ReadLine());

                        Console.Write("Name: ");
                        myProduct.Name = Console.ReadLine();

                        Console.Write("Manufacturing Date (yyyy-MM-dd): ");
                        myProduct.ManufacturingDate = Console.ReadLine();

                        Console.Write("Warranty (in months): ");
                        myProduct.Warranty = int.Parse(Console.ReadLine());

                        Console.Write("Price: ");
                        myProduct.Price = float.Parse(Console.ReadLine());

                        Console.Write("Stock: ");
                        myProduct.Stock = int.Parse(Console.ReadLine());

                        Console.Write("GST (5, 12, 18, or 28): ");
                        myProduct.GST = int.Parse(Console.ReadLine());

                        Console.Write("Discount (1-30): ");
                        myProduct.Discount = int.Parse(Console.ReadLine());

                        myProducts[cur_index] = myProduct;
                        cur_index++;

                        break;

                    case 2:
                        for (int i = 0; i < cur_index; i++) {
                            Console.WriteLine(myProducts[i].Display());
                        }
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}