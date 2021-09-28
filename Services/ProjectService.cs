﻿using System;
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
                    PictureUrl = "https://github.com/Tyler-Lopez/CS-TriviaApp/blob/main/app/demo/gif_preview%20(2).gif?raw=true",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://dagger.dev/hilt/", "Dagger Hilt"}, new string[]{ "https://www.geeksforgeeks.org/mvvm-model-view-viewmodel-architecture-pattern-in-android/", "Model View ViewModel (MVVM)"}, new string[] { "https://developer.android.com/reference/android/speech/tts/TextToSpeech", "Text-to-Speech"}
                    }
                },
                new Project
                {
                    Name = "NoNumerosity!",
                    Description = "Game-based assessments used as screening questions for job applicants are not very enjoyable or effective. This Android app will automatically solve Numerosity arithmetic, used by HireVue, for you.",
                    GithubUrl = "https://github.com/Tyler-Lopez/NumerositySolver",
                    PictureUrl = "https://user-images.githubusercontent.com/77797048/133953754-262bd731-8b74-488b-8860-139aa4a81ae0.png",
                    Tags = new List<string[]>
                    {
                        new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}
                    }
                },
                new Project
                {
                    Name = "Speed Card Game",
                    Description = "This repository is my primary focus at present and an engaging exercise in mastering the Canvas composable. The long-term goal is to create a local multi-player game where two users may play the card game of speed against one another. The featured picture is an early-development preview towards how suit shapes are being drawn; each as a solution to the tangram puzzle.",
                    GithubUrl = "https://github.com/Tyler-Lopez/SpeedCardGame",
                    PictureUrl = "https://user-images.githubusercontent.com/77797048/135025444-b15a5620-3468-49e3-b12f-ada1b2216e99.png",
                    Tags = new List<string[]>
                    {
                       new string[]{ "https://kotlinlang.org/docs/home.html", "Kotlin"}, new string[]{ "https://developer.android.com/jetpack/compose", "Jetpack Compose"}, new string[]{ "https://medium.com/google-developer-experts/exploring-jetpack-compose-canvas-the-power-of-drawing-8cc60815babe", "Canvas"}, new string[]{ "https://dagger.dev/hilt/", "Dagger Hilt"}, new string[]{ "https://www.geeksforgeeks.org/mvvm-model-view-viewmodel-architecture-pattern-in-android/", "Model View ViewModel (MVVM)"},
                    }
                }
            };
            return projects;
        }
    }
}
