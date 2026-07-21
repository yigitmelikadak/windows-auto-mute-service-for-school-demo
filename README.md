# windows-auto-mute-service-for-school-demo
A C# Windows Service that automatically mutes system audio based on a daily schedule.  //School Project

## Features
* **Background Windows Service:** Runs seamlessly in the background without needing a user interface.
* **Scheduled Volume Control:** Automatically mutes system audio outside specified time intervals.
* **Audio API Integration:** Utilizes `NAudio` (WASAPI / MMDevice API) to control system endpoint audio levels in real-time.

## Tech Stack & Dependencies
* **Language:** C#
* **Framework:** .NET Framework 4.7.2 (Windows Service)
* **Audio Library:** [NAudio 2.2.1](https://github.com/naudio/NAudio)

## Installation & Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/yigitmelikadak/windows-auto-mute-service-for-school-demo.git

1)Open balance.sln in Visual Studio and build the solution (Ctrl + Shift + B).
2)Open Command Prompt / PowerShell as Administrator.
3)Navigate to the .NET Framework installation folder and run InstallUtil.exe:
4)Open terminal and type,
```bash
cd C:\Windows\Microsoft.NET\Framework\v4.0.30319
InstallUtil.exe "C:\Path\To\Your\Project\bin\Debug\balance.exe"
```
5. Open services.msc on Windows and start "Kabuk Optimizasyon Servisi" (or mctrg).
(Note: Named stealthily as a system service to prevent classmates from stopping it during school hours.)

What I Learned

Working with C# Windows Services architecture and system lifecycle (OnStart, OnStop, Timers).
Interacting with core Windows Audio via NAudio.
Installing and managing custom Windows services using InstallUtil.
