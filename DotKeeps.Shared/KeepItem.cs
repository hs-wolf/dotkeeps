namespace DotKeeps.Shared;

public enum KeepItemType
{
  NONE,
  SERIE,
  MOVIE,
  COMIC,
  ANIME,
  MANGA,
  MANHUA,
  MANHWA
}

public class KeepItem(
  string Id,
  string UserId,
  KeepItemType Type,
  string Name,
  string Season,
  string Episode,
  string Volume,
  string Chapter,
  string Link,
  DateTime CreatedAt,
  DateTime UpdatedAt
  )
{
  public string Id { get; set; } = Id;
  public string UserId { get; set; } = UserId;
  public KeepItemType Type { get; set; } = Type;
  public string Name { get; set; } = Name;
  public string? Season { get; set; } = Season;
  public string? Episode { get; set; } = Episode;
  public string? Volume { get; set; } = Volume;
  public string? Chapter { get; set; } = Chapter;
  public string? Link { get; set; } = Link;
  public DateTime CreatedAt { get; set; } = CreatedAt;
  public DateTime UpdatedAt { get; set; } = UpdatedAt;
}