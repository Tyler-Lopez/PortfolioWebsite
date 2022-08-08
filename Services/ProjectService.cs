using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Services
{
    public class ProjectService
    {
        public List<Project> GetAll()
        {
            List<Project> projects = new List<Project>
            {
                new Project
                {
                    Name = "Activity Art",
                    Description =
                        "This is an Android Application which queries the Strava API to generate highly-modular, aesthetic prints of all an athlete's activities. " +
                        "Filters include distance, year, month, gear, and activity type! Polylines, the series of coordinates that represent a workout, are decoded and drawn using the Android Canvas - one of my favorite tools to work with."
                    ,
                    GithubUrl = "https://github.com/Tyler-Lopez/StravaActivityArt",
                    PictureUrl = "project_activityart.png",
                    Tags = new List<string[]>
                    {
                        new []{ "https://kotlinlang.org/docs/home.html", "Kotlin"},
                        new []{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"},
                        new []{ "https://medium.com/google-developer-experts/exploring-jetpack-compose-canvas-the-power-of-drawing-8cc60815babe", "Canvas"}
                    }
                },
                new Project
                {
                    Name = "Tree Visualizer",
                    Description = 
                        "Published Android App to dynamically visualize binary trees data structures with an attractive user interface. " +
                        "Trees may be unbalanced binary search trees, AVL trees, or heaps. " +
                        "Insertion and removal select elements.",
                    GithubUrl = "https://github.com/Tyler-Lopez/BinaryTreeVisualizer",
                    PictureUrl = "project_visualizer.png",
                    PlayStoreUrl = "https://play.google.com/store/apps/details?id=com.company.avlvisualizer",
                    Tags = new List<string[]>
                    {
                        new []{ "https://kotlinlang.org/docs/home.html", "Kotlin"},
                        new []{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"},
                        new []{ "https://medium.com/google-developer-experts/exploring-jetpack-compose-canvas-the-power-of-drawing-8cc60815babe", "Canvas"}
                    }
                },
                new Project
                {
                    Name = "Computer Science Flashcards",
                    Description = "An Android educational flashcard application in-development. Questions and answers are currently hard-coded and cover various standard courses of an undergraduate computer science degree.",
                    GithubUrl = "https://github.com/Tyler-Lopez/CS-TriviaApp",
                    PictureUrl = "project_flashcards.png",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://dagger.dev/hilt/", "Dagger Hilt"}, new string[]{ "https://www.geeksforgeeks.org/mvvm-model-view-viewmodel-architecture-pattern-in-android/", "Model View ViewModel (MVVM)"}, new string[] { "https://developer.android.com/reference/android/speech/tts/TextToSpeech", "Text-to-Speech"}
                    }
                },
                new Project
                {
                    Name = "SprintLogger",
                    Description = "This Android application in-development will allow the user to track their fastest 400 m sprint times day-to-day. This application serves as a personal exploration in both working with the Android Locations API and in persisting user data with Room. The user should open the app, click \"Start\", then simply run 400 meters. Throughout the run, their current distance, speed, and the amount of seconds which have yet elapsed will be displayed. If the user has not yet sprinted once today, they are encouraged to do so. Data is persisted, so users may review their historical sprints. By default, the \"Sprint History\" is sorted ascending by seconds it took them to run 400 meters.",
                    GithubUrl = "https://github.com/Tyler-Lopez/SprintLogger",
                    PictureUrl = "project_sprintlogger.png",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://medium.com/google-developer-experts/exploring-jetpack-compose-canvas-the-power-of-drawing-8cc60815babe", "Canvas"}, new string[]{ "https://developer.android.com/training/location", "Location API"}, new string[]{ "https://developer.android.com/jetpack/androidx/releases/room", "Room-Persistence Library"}
                    }
                }
            };
            return projects;
        }
    }
}
