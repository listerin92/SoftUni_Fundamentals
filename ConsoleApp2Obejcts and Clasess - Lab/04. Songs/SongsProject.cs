using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    partial class SongsProject
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> data = Console.ReadLine().
                    Split("_").
                    ToList();

                Song song = new Song();
                song.TypeList = data[0];
                song.Name = data[1];
                song.Time = data[2];

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            List<Song> filtersongs = songs.Where(s => s.TypeList == typeList || typeList == "all").ToList();

            foreach (Song song in filtersongs)
            {
                Console.WriteLine(song.Name);
            }

        }
    }
}
