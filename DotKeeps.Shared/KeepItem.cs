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

public class KeepItemData(
  string Season,
  string Episode,
  string Volume,
  string Chapter
    )
{
  public string Season { get; set; } = Season;
  public string Episode { get; set; } = Episode;
  public string Volume { get; set; } = Volume;
  public string Chapter { get; set; } = Chapter;
}

public class KeepItem(
  string Id,
  KeepItemType Type,
  string Name,
  KeepItemData Data,
  DateTime CreationDate,
  DateTime LastUpdateDate
    )
{
  public string Id { get; private set; } = Id;
  public KeepItemType Type { get; set; } = Type;
  public string Name { get; set; } = Name;
  public KeepItemData Data { get; set; } = Data;
  public DateTime CreationDate { get; private set; } = CreationDate;
  public DateTime LastUpdateDate { get; private set; } = LastUpdateDate;
}
