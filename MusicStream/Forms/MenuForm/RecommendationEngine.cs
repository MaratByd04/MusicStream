﻿namespace MusicStream.Forms.MenuForm
{
    public class RecommendationEngine
    {
        public List<Songs> GetSportPlaylist()
        {
            using (var db = new ApplicationContext())
            {
                var sportPlaylist = db.Songs
                    .Where(s => (s.Genre != "Classic" && s.Mood != "Depressive" && s.Mood != "Positive") &&
                                (s.Genre == "Rock" || s.Mood == "Adrenaline" || s.Genre == "Rap"))
                    .ToList();

                var random = new Random();
                sportPlaylist = sportPlaylist.OrderBy(x => random.Next()).ToList();

                var selectedSongs = sportPlaylist.Take(6).ToList();

                return selectedSongs;
            }
        }

        public List<Songs> GetWorkPlaylist()
        {
            using (var db = new ApplicationContext())
            {
                var workPlaylist = db.Songs
                    .Where(s => (s.Genre != "Rap" && s.Mood != "Depressive" && s.Mood != "Adrenaline") &&
                    (s.Mood == "Positive" || s.Mood == "Calmness"))
                    .ToList();

                var random = new Random();
                workPlaylist = workPlaylist.OrderBy(x => random.Next()).Take(6).ToList();

                return workPlaylist;
            }
        }

        public List<Songs> GetSadnessPlaylist()
        {
            using(var db = new ApplicationContext())
            {
            var sadnessPlaylist = db.Songs
                .Where(s => (s.Mood == "Depressive") && (s.Mood != "Positive" && s.Mood != "Adrenaline")) 
                .ToList();

                var random = new Random();
                sadnessPlaylist = sadnessPlaylist.OrderBy(x => random.Next()).ToList();

                var selectedSongs = sadnessPlaylist.Take(6).ToList();

                return sadnessPlaylist;
            }
        }
    }
}
