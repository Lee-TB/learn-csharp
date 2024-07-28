using System.Globalization;
using System.Text;

class Program
{
  static async Task Main()
  {
    var user = new User { UserId = 1, Name = "João", AddressName = new Address { Street = "Rua 1", City = "Cidade 1", State = "Estado 1", Country = "País 1", PostalCode = "CEP 1" } };
    foreach (var prop in user.GetType().GetProperties())
    {
      System.Console.WriteLine($"{prop.Name}: {prop.GetValue(user)}");
    }


  }




}

public class User
{
  public int UserId { get; set; }
  public string Name { get; set; }
  public Address Address { get; set; }
  public bool HasId(int id) => UserId == id;

}

public class Address
{
  public string Street { get; set; }
  public string City { get; set; }
  public string State { get; set; }
  public string Country { get; set; }
  public string PostalCode { get; set; }
  public string FullAddress => $"{Street}, {City}, {State}, {Country}, {PostalCode}";
}

public static class StringExtensions
{
  public static string RemoveDiacritics(this string text)
  {
    if (string.IsNullOrWhiteSpace(text))
      return text;

    var normalizedString = text.Normalize(NormalizationForm.FormD);
    var stringBuilder = new StringBuilder();

    foreach (var c in normalizedString)
    {
      var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
      if (unicodeCategory != UnicodeCategory.NonSpacingMark)
      {
        stringBuilder.Append(c);
      }
    }

    return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
  }
}