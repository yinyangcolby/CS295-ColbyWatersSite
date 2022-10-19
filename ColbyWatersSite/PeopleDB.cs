using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ColbyWatersSite.Models;

namespace PeopleList
{
  public static class PeopleDB
  {
    private static string filename = "people.txt";
    private static bool loaded = false;
    private static List<ProfileModel> people = new List<ProfileModel>();

    public static List<ProfileModel> GetPeople()
    {
      if (loaded == false) LoadPeople();
      return people;
    }

    public static void LoadPeople()
    {
      string line;
      string name;
      string comment;
      int rating;

      try
      {
        StreamReader reader = new StreamReader(filename);

        while (true)
        {
          line = reader.ReadLine();
          if (line == null) break;

          List<string> parts = line.Split('|').ToList();
          name = parts[0];
          rating = Int32.Parse(parts[1]);
          comment = WebUtility.UrlDecode(parts[2]);
          people.Add(new ProfileModel { Name = name, Rating = rating, Comment = comment });
        }

        reader.Close();
      }
      catch (Exception)
      {

      }

      loaded = true;
    }

    public static void AddPerson(ProfileModel person)
    {
      if (loaded == false) LoadPeople();
      person.Comment += string.Format("    [Posted on {0}]", DateTime.Now.ToString("MM/dd/yyyy hh:mm tt"));
      people.Add(person);
    }

    public static void SavePeople()
    {
      if (loaded == false) LoadPeople();

      StreamWriter writer = new StreamWriter(filename);
      foreach (ProfileModel person in people)
      {
        string comment = WebUtility.UrlEncode(person.Comment);
        string line = person.Name + "|" + person.Rating + "|" + comment;
        writer.WriteLine(line);
      }
      writer.Close();

    }

  }
}