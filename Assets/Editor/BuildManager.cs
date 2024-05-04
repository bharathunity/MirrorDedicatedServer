using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

public class BuildManager
{


    [MenuItem("Build/Server")]
    public static void ServerBuild()
    {
        WindowsServerBuild();
        LinuxServerBuild();
    }

    [MenuItem("Build/Windows Server")]
    public static void WindowsServerBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new string[] { "Assets/Dedicated Server/scene/Main.unity" };
        buildPlayerOptions.locationPathName = "build/server/win/winserver.exe" ;
        buildPlayerOptions.target = BuildTarget.StandaloneWindows;
        buildPlayerOptions.options = BuildOptions.None;

        Console.WriteLine("Windows Server Building ...............");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("**************** Windows Server Build Finished ****************");

    }

    [MenuItem("Build/Linux Server")]
    public static void LinuxServerBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new string[] { "Assets/Dedicated Server/scene/Main.unity" };
        buildPlayerOptions.locationPathName = "build/server/linux/linux_server.x86_64";
        buildPlayerOptions.target = BuildTarget.StandaloneLinux64;
        buildPlayerOptions.options = BuildOptions.None;

        Console.WriteLine("Linux Server Building ...............");
        BuildPipeline.BuildPlayer(buildPlayerOptions);
        Console.WriteLine("**************** Linusx Server Build Finished ****************");

    }
}
