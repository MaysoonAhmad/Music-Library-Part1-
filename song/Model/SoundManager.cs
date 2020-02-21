using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
/// <summary>
/// /////////////////////////////
/// </summary>
namespace song.Model
{
    public static class SoundManager
    {
        private static List<Sound> getSounds()

        {

            var sounds = new List<Sound>();



            sounds.Add(new Sound("Hello", SoundCategory.Adele));

            sounds.Add(new Sound("Someone", SoundCategory.Adele));



            sounds.Add(new Sound("What", SoundCategory.Justin));

            sounds.Add(new Sound("Yummy", SoundCategory.Justin));



            sounds.Add(new Sound("Chandelier", SoundCategory.Sia));

            sounds.Add(new Sound("Cheap", SoundCategory.Sia));



            sounds.Add(new Sound("Look", SoundCategory.Taylor));

            sounds.Add(new Sound("Shake", SoundCategory.Taylor));



            return sounds;

        }



        public static void GetAllSounds(ObservableCollection<Sound> sounds)

        {

            var allSounds = getSounds();

            sounds.Clear();

            allSounds.ForEach(s => sounds.Add(s));

        }



        public static void GetSoundsByCategory(

            ObservableCollection<Sound> sounds, SoundCategory category)

        {

            var allSounds = getSounds();

            var filteredSounds = allSounds.Where(s => s.Category == category).ToList();

            sounds.Clear();

            filteredSounds.ForEach(s => sounds.Add(s));

        }



    }

}
