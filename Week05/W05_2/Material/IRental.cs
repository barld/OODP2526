/*
Properties: CurrentRenter, IsRented
Methods: StartRental(take in a Person) EndRental
*/
public interface IRental
{
    Person? CurrentRenter { get; set; }
    bool IsRented {get;}

    void StartRental(Person person);
    void EndRental();
}
