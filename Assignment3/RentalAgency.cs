public class RentalAgency
{
    // Properties
    private List<Vehicle> Fleet { get; set; }
    public decimal TotalRevenue { get; private set; }

    
    public RentalAgency()
    {
        Fleet = new List<Vehicle>();
        TotalRevenue = 0;
    }

    
    public void AddVehicle(Vehicle vehicle)
    {
        Fleet.Add(vehicle);
    }

    
    public void RemoveVehicle(Vehicle vehicle)
    {
        Fleet.Remove(vehicle);
    }

    
    public void RentVehicle(Vehicle vehicle, int days)
    {
        decimal rentalCost = vehicle.RentalPrice * days;
        TotalRevenue += rentalCost;
        Console.WriteLine($"Vehicle {vehicle.Model} rented for {days} days. Total cost: {rentalCost:C}");
    }
}

