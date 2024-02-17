using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotKeeps.Shared;

public enum UserType
{
  ADMIN,
  USER,
}

public class User(
  string Id,
  UserType Type,
  string Name,
  string Email,
  DateTime CreatedAt,
  DateTime UpdatedAt
  )
{
  public string Id { get; set; } = Id;
  public UserType Type { get; set; } = Type;
  public string Name { get; set; } = Name;
  public string Email { get; set; } = Email;
  public DateTime CreatedAt { get; set; } = CreatedAt;
  public DateTime UpdatedAt { get; set; } = UpdatedAt;

  static public User New(
    UserType Type,
    string Name,
    string Email
  )
  {
    return new User(
      "",
      Type,
      Name,
      Email,
      DateTime.Now,
      DateTime.Now
    );
  }
}

public class UserRegister(string Email, string Password, string Confirm)
{
  [Required(ErrorMessage = "The email is required."), EmailAddress(ErrorMessage = "Type a valid email.")]
  public string Email { get; set; } = Email;

  [Required(ErrorMessage = "The password is required."), MinLength(6, ErrorMessage = "The password needs to be bigger than 6 characters."), MaxLength(64, ErrorMessage = "The password needs to be smaller than 64 characters.")]
  public string Password { get; set; } = Password;

  [Compare(nameof(Password), ErrorMessage = "The passwords need to match.")]
  public string Confirm { get; set; } = Confirm;
}

public class UserLogin(string Email, string Password)
{
  [Required(ErrorMessage = "The email is required."), EmailAddress(ErrorMessage = "Type a valid email.")]
  public string Email { get; set; } = Email;

  [Required(ErrorMessage = "The password is required."), MinLength(6, ErrorMessage = "The password needs to be bigger than 6 characters."), MaxLength(64, ErrorMessage = "The password needs to be smaller than 64 characters.")]
  public string Password { get; set; } = Password;
}