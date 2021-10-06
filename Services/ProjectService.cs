using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                    Name = "Computer Science Flashcards",
                    Description = "An Android educational flashcard application in-development. Questions and answers are currently hard-coded and cover various standard courses of an undergraduate computer science degree.",
                    GithubUrl = "https://github.com/Tyler-Lopez/CS-TriviaApp",
                    PictureUrl = "project_flashcards.gif",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://dagger.dev/hilt/", "Dagger Hilt"}, new string[]{ "https://www.geeksforgeeks.org/mvvm-model-view-viewmodel-architecture-pattern-in-android/", "Model View ViewModel (MVVM)"}, new string[] { "https://developer.android.com/reference/android/speech/tts/TextToSpeech", "Text-to-Speech"}
                    }
                },
                new Project
                {
                    Name = "Speed Card Game",
                    Description = "This repository is one of my primary focuses at present and an engaging exercise in mastering the Canvas composable. The long-term goal is to create a local multi-player game where two users may play the card game of speed against one another. The featured picture is an early-development preview towards how suit shapes are being drawn; each as a solution to the tangram puzzle.",
                    GithubUrl = "https://github.com/Tyler-Lopez/SpeedCardGame",
                    PictureUrl = "project_speedcard.png",
                    Tags = new List<string[]>
                    {
                       new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://medium.com/google-developer-experts/exploring-jetpack-compose-canvas-the-power-of-drawing-8cc60815babe", "Canvas"}, new string[]{ "https://dagger.dev/hilt/", "Dagger Hilt"}, new string[]{ "https://www.geeksforgeeks.org/mvvm-model-view-viewmodel-architecture-pattern-in-android/", "Model View ViewModel (MVVM)"},
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
                },
                new Project
                {
                    Name = "NoNumerosity!",
                    Description = "Game-based assessments used as screening questions for job applicants are not very enjoyable or effective. This Android app will automatically solve Numerosity arithmetic, used by HireVue, for you.",
                    GithubUrl = "https://github.com/Tyler-Lopez/NumerositySolver",
                    PictureUrl = "project_numerosity.png",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}
                    }
                }
            };
            return projects;
        }
    }
}
