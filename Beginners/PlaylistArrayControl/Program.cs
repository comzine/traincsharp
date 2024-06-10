bool exit = false;
string[] playlist = new string[10];

while (!exit)
{
  Console.WriteLine("What would you like to do?");
  Console.WriteLine("1. Add a song");
  Console.WriteLine("2. Display playlist");
  Console.WriteLine("3. Exit");

  string choice = Console.ReadLine();

  switch (choice)
  {
    case "1":
      AddSong(playlist);
      break;
    case "2":
      DisplayPlaylist(playlist);
      break;
    case "3":
      exit = true;
      break;
    default:
      Console.WriteLine("Invalid choice. Please try again.");
      break;
  }
}

static void AddSong(string[] playlist)
{
  Console.WriteLine("Enter the song title:");
  string title = Console.ReadLine();

  bool added = false;

  for (int i = 0; i < playlist.Length; i++)
  {
    if (string.IsNullOrEmpty(playlist[i]))
    {
      playlist[i] = title;
      added = true;
      break;
    }
  }

  if (added)
  {
    Console.WriteLine("Song added successfully.");
  }
  else
  {
    Console.WriteLine("Playlist is full. Cannot add more songs.");
  }
}

static void DisplayPlaylist(string[] playlist)
{
  Console.WriteLine("Playlist:");

  for (int i = 0; i < playlist.Length; i++)
  {
    if (!string.IsNullOrEmpty(playlist[i]))
    {
      Console.WriteLine(playlist[i]);
    }
  }
}