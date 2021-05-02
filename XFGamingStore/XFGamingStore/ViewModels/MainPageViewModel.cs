using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFGamingStore.Models;
using XFGamingStore.ViewModel;

namespace XFGamingStore.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Games = new ObservableCollection<Game>();
            OpenVideoTrailerCommand = new Command<int>(async (param) => await ExecuteOpenVideoTrailerCommand(param));
            GetGames();
        }

        public Command OpenVideoTrailerCommand { get; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _imageBackground;
        public string ImageBackground
        {
            get { return _imageBackground; }
            set { SetProperty(ref _imageBackground, value); }
        }

        private int _trophies;
        public int Trophies
        {
            get { return _trophies; }
            set { SetProperty(ref _trophies, value); }
        }

        public ObservableCollection<Game> Games { get; }

        void GetGames()
        {
            Games.Add(new Game()
            {
                name = "Mortal Kombat X",
                image = "mortal_kombat.png",
                description = "Two years after the events of Mortal Kombat, Johnny Cage, Sonya Blade and Kenshi coordinate a battalion to protect the Jinsei from the forces of Shinnok who was found manipulating the events of Mortal Kombat. While on one of the helicopters, the trio are attacked by Scorpion and a spectre of the undead Kuai Liang. During the ensuring fight Johnny manages to push Scorpion off the helicopter. Scorpion manages to teleport away leading Johnny to hit the ground, stunned but otherwise unhurt. With the pilots killed and the helicopter damaged, Sonya is able to crash land the craft. Johnny is able to defeat both undead warriors, and rejoins Kenshi and Sonya. Meanwhile, Raiden and Fujin are in the Sky Temple protecting the entrance to the Jinsei from the Netherrealm demons. Suddenly, Quan Chi arrives and brings Kabal, Sindel and Stryker under his control to fight them.",
                urlTrailer = "https://www.imdb.com/video/vi2172500761?playlistId=tt3772796",
                imageBackground = "mortal_kombat_background.png",
                android = true,
                appleIOS = true,
                sonyPlaystation = true,
                xBox = true,
                pc = true,
                trophies = 5
            });

            Games.Add(new Game()
            {
                name = "God Of War",
                image = "gow.png",
                description = "After five more years of errands for the gods, things come to a head when the Hyrda and Ares' forces almost decimate Kratos' fleet of ships. He asks Athena how much longer he must fight until his memories are taken from him, so she gives him a final task: save Athens from being destroyed by Ares. Having despised the god of war for so long, the task proves to be a win-win situation. With the secret blessing of the Olympians, Kratos seeks out the oracle of Athens and learns he must use the power within Pandora's Box to defeat Ares. Kratos travels to a nearby desert in search of the titan Cronos, who has a temple chained to his back that contains the fabled box. With numerous traps and monsters no mortal could ever beat, Kratos was the first to conquer them all and secure Pandora's Box.",
                urlTrailer = "https://www.imdb.com/video/vi195803929?playlistId=tt5838588",
                imageBackground = "gow_background.png",
                android = false,
                appleIOS = false,
                sonyPlaystation = true,
                xBox = false,
                pc = false,
                trophies = 15
            });

            Games.Add(new Game()
            {
                name = "The Last Of Us Part II",
                image = "tlou2.png",
                description = "Five years after their dangerous journey across the post-pandemic United States, Ellie and Joel have settled down in Jackson, Wyoming. Living amongst a thriving community of survivors has allowed them peace and stability, despite the constant threat of the infected and other, more desperate survivors.",
                urlTrailer = "https://www.imdb.com/video/vi4029464089?playlistId=tt6298000",
                imageBackground = "tlou2_background.png",
                android = false,
                appleIOS = false,
                sonyPlaystation = true,
                xBox = false,
                pc = false,
                trophies = 20
            });

            Games.Add(new Game()
            {
                name = "Horizon Zero Dawn",
                image = "hzd.png",
                description = "Tells a classic science fiction story, one of my favorite examples of the genre: a tale of how humanity’s indomitable spirit and survival instinct can conquer the most hostile circumstances one could imagine. But that alone isn’t why I love it so much. The specifics of Horizon Zero Dawn go beyond that familiar framework to deliver a unique sense of thrill and hope that’s far less common — a vision of the future that’s optimistic because of how strongly it centers women.",
                urlTrailer = "https://www.imdb.com/video/vi3566516505?playlistId=tt4044024",
                imageBackground = "hzd_background.png",
                android = false,
                appleIOS = false,
                sonyPlaystation = true,
                xBox = false,
                pc = true,
                trophies = 25
            });

            Games.Add(new Game()
            {
                name = "Red Dead Redemption II",
                image = "red_dead2.png",
                description = "America, 1899. The end of the Wild West era has begun. After a robbery goes badly wrong in the western town of Blackwater, Arthur Morgan and the Van der Linde gang are forced to flee. With federal agents and the best bounty hunters in the nation massing on their heels, the gang must rob, steal and fight their way across the rugged heartland of America in order to survive. As deepening internal divisions threaten to tear the gang apart, Arthur must make a choice between his own ideals and loyalty to the gang who raised him.",
                urlTrailer = "https://www.imdb.com/video/vi3812669465?playlistId=tt6161168",
                imageBackground = "red_dead2_background.png",
                android = false,
                appleIOS = false,
                sonyPlaystation = true,
                xBox = true,
                pc = true,
                trophies = 18
            });

            Games.Add(new Game()
            {
                name = "Little Nightmares II",
                image = "little_nightmares2.png",
                description = "Little Nightmares II is a suspense-adventure game in which you play as Mono, a young boy trapped in a world that has been distorted by the humming transmission of a distant tower. With Six, the girl in a yellow raincoat, as his guide, Mono sets out to discover the dark secrets of The Signal Tower and save Six from her terrible fate. But their journey will not be straightforward as Mono and Six will face a gallery of new threats from the terrible residents of this world.",
                urlTrailer = "https://www.imdb.com/video/vi1682096409?playlistId=tt12857290",
                imageBackground = "little_nightmares2_background.png",
                android = false,
                appleIOS = false,
                sonyPlaystation = true,
                xBox = true,
                nintendoSwitch = true,
                pc = true,
                trophies = 22
            });

            SetGameDetails();
        }

        public void SetGameDetails(int index = 0)
        {
            Name = Games[index].name;
            Description = Games[index].description;
            ImageBackground = Games[index].imageBackground;
            Trophies = Games[index].trophies;
        }

        private async Task ExecuteOpenVideoTrailerCommand(int selectedIndex)
        {
            var urlTrailer = Games[selectedIndex].urlTrailer.ToLower();
            await Browser.OpenAsync(new Uri(urlTrailer), BrowserLaunchMode.SystemPreferred);
        }
    }
}
