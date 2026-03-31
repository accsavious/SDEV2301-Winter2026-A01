# Setting up the .NET MAUI Blazor App

## Pre-requisites

1. Install the MAUI workload (one time setup)
    - Open a terminal and run the following command:
        ```
        dotnet workload install maui
        ```
2. Download the Java Development Kit (JDK) so that the Android emulators can run. Use the Windows 64-bit version of the MSI found here: https://learn.microsoft.com/en-us/java/openjdk/download

## Running a New App
1. Create a new __.NET MAUI Blazor Hybrid App__ (not the "Web App" one)
2. Debug the "Windows Machine" version of the application first to confirm the project builds.
3. Debug the "Android" version of the application using the emulator
    - If this is your first time running the emulator, you will be prompted to install one and the appropriate Android SDK.
    - The debugging process for the Android emulator takes much longer than the windows machine version.
    - You can also debug on your own Android device if you are interested, but this will not be covered in the course.

If both of these run properly your MAUI app is good to go.

## Troubleshooting
One issue that can be common is file names that are too long. The Android compilation process creates some files with quite long names nested deep inside the `obj` and `bin` folders of the visual studio solution.

To solve the long file path issues there are a few steps to take.

1. Enable long file paths on your Windows machine. https://www.thewindowsclub.com/how-to-enable-or-disable-win32-long-paths-in-windows-11-10 (this requires a restart.)
2. Git Bash does not support long paths by default, to enable long paths with git command, open a Windows Terminal and type:
```
git config --system core.longpaths true
```