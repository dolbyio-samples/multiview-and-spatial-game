<!--
[![Build Package](https://github.com/dolbyio-samples/template-repo/actions/workflows/build-package.yml/badge.svg)](https://github.com/dolbyio-samples/template-repo/actions/workflows/build-package.yml)
[![Publish Package](https://github.com/dolbyio-samples/template-repo/actions/workflows/publish-package.yml/badge.svg)](https://github.com/dolbyio-samples/template-repo/actions/workflows/publish-package.yml)
[![npm](https://img.shields.io/npm/v/dolbyio-samples/template-repo)](https://www.npmjs.com/package/dolbyio-samples/template-repo)
[![License](https://img.shields.io/github/license/dolbyio-samples/template-repo)](LICENSE)

Adding shields would also be amazing -->

<div align="center">
    <img src="https://github.com/dolbyio-samples/multiview-and-spatial-game/assets/112442274/616ad1f0-1e19-4ae9-a963-1c0681c7671c" alt="image">
</div>

# Elevate Your Game: Miniature E-Sports Setup Inspirations
Using Unity's Boss Room, this version integrates a multiview camera system and spatial audio. 

# Overview
This small-scale co-op multiplayer game uses both of Dolby.io Unity plugins to create a thoughtful and interactive experience for both users and audience. Through the use of spatial chat, the players can communicate in real-time spatially while the audience gets to interact with a multi-cam system inside the game that gives them the ability to watch their favorite players from different angles.

# Requirements 
- Apple MacOS x64/arm64 or Microsoft Windows 10+ x64.
- A [Dolby.io account](https://dolby.io/). If you do not have an account, you can sign up for a free account.
- The client access token is copied from the Dolby.io dashboard. To create the token, log into the Dolby.io dashboard, create an application, and navigate to the API keys section.
- Install  [git-lfs](https://git-lfs.com/) command line tool on your computer if you wish to install directly using the GitHub link.

# Getting Started
With the project downloaded, navigate to Unity Hub, select Open, and browse to the project's directory on your local machine. Ensure the project is unzipped before opening it on the game engine. The editor version used for this project is _2021.3.10f1_; our SDK works with any Unity version as long as Visual Scripting is installed. Bolt Visual Scripting will continue to support projects on Unity 2018, 2019, and 2020 LTS versions. 

A good way to check if it is integrated into your project is to go to Window > Package Manager and search Visual Scripting in the packages from your project. Otherwise, at the top of the Package Manager window, there will be a "+" button; you will select "Add package by name..." and enter "com.unity.visualscripting". This is also where we will add Dolby.io's spatial chat plugin. In the same "+" button, select instead "Add package from git URL..." and paste this: https://github.com/DolbyIO/comms-sdk-unity.

After it finishes loading, it will show up as DolbyIO Communications version 1.1.1. This is the same location where you could update the plugin in the future as you follow along with future guides from this SDK. 

For the streaming plugin, the same procedure as before, with the difference being the package added from the git URL will be "https://github.com/millicast/millicast-unity-sdk". It will read Millicast, the acquired company powering the Dolby.io streaming solution.

# Report a Bug 
In the case any bugs occur, report it using Github issues, and we will see to it. 

# Forking
We welcome your interest in trying to experiment with our repos.

# Feedback 
If there are any suggestions or if you would like to deliver any positive notes, feel free to open an issue and let us know!

# Learn More
For a deeper dive, we welcome you to review the following:
  - [Spatial Chat Plugin Overview](https://docs.dolby.io/communications-apis/docs/unity-overview)
  - [Getting Started - Visual Scripting](https://api-references.dolby.io/comms-sdk-dotnet/documentation/unity/visualscripting/tutorials/initialization.html)
  - [Talk - Beyond Loudness: Spatial Chat and The Future of Gaming Communication](https://www.youtube.com/watch?v=UialznHym0U)
  - [Introduction to Virtual Worlds: How to Get Started with Unity](https://www.youtube.com/watch?v=5lAtRyTrkVU&list=PLhM0JoBtFX00Sq1uzUWzU13EAcuFZ-e7x)
  - [Stream The World: A Guide to Start Streaming Your Game](https://dolby.io/blog/stream-the-world-a-guide-to-start-streaming-your-game/)

# About Dolby.io

Using decades of Dolby's research in sight and sound technology, Dolby.io provides APIs to integrate real-time streaming, voice & video communications, and file-based media processing into your applications. [Sign up for a free account](https://dashboard.dolby.io/signup/) to get started building the next generation of immersive, interactive, and social apps.

<div align="center">
  <a href="https://dolby.io/" target="_blank"><img src="https://img.shields.io/badge/Dolby.io-0A0A0A?style=for-the-badge&logo=dolby&logoColor=white"/></a>
&nbsp; &nbsp; &nbsp;
  <a href="https://docs.dolby.io/" target="_blank"><img src="https://img.shields.io/badge/Dolby.io-Docs-0A0A0A?style=for-the-badge&logoColor=white"/></a>
&nbsp; &nbsp; &nbsp;
  <a href="https://dolby.io/blog/category/developer/" target="_blank"><img src="https://img.shields.io/badge/Dolby.io-Blog-0A0A0A?style=for-the-badge&logoColor=white"/></a>
</div>

<div align="center">
&nbsp; &nbsp; &nbsp;
  <a href="https://youtube.com/@dolbyio" target="_blank"><img src="https://img.shields.io/badge/YouTube-red?style=flat-square&logo=youtube&logoColor=white" alt="Dolby.io on YouTube"/></a>
&nbsp; &nbsp; &nbsp; 
  <a href="https://twitter.com/dolbyio" target="_blank"><img src="https://img.shields.io/badge/Twitter-blue?style=flat-square&logo=twitter&logoColor=white" alt="Dolby.io on Twitter"/></a>
&nbsp; &nbsp; &nbsp;
  <a href="https://www.linkedin.com/company/dolbyio/" target="_blank"><img src="https://img.shields.io/badge/LinkedIn-0077B5?style=flat-square&logo=linkedin&logoColor=white" alt="Dolby.io on LinkedIn"/></a>
</div>
