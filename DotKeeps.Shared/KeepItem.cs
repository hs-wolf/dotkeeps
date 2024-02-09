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
  KeepItemType Type,
  string Name,
  string Link,
  DateTime CreationDate,
  DateTime LastUpdateDate
  )
{
  public string Id { get; private set; } = Id;
  public KeepItemType Type { get; set; } = Type;
  public string Name { get; set; } = Name;
  public string Link { get; set; } = Link;
  public DateTime CreationDate { get; set; } = CreationDate;
  public DateTime LastUpdateDate { get; set; } = LastUpdateDate;
}

public class KeepItemData
{
  public string Season { get; set; }
  public string Episode { get; set; }
  public string Volume { get; set; }
  public string Chapter { get; set; }
}