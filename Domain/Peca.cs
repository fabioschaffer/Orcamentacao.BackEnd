namespace Domain;

public class Peca {

    public Peca() { }

    public Peca(string partNumber, string Nome) {
        partNumber = partNumber ?? throw new ArgumentNullException(nameof(partNumber));
        Nome = Nome ?? throw new ArgumentNullException(nameof(Nome));
    }

    public int Id { get; set; }
    public string PartNumber { get; set; }
    public string Nome { get; set; }
}