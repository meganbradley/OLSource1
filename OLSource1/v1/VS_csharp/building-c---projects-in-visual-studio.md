---
title: "Building C++ Projects in Visual Studio"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Visual C++ projects, building"
  - "projects [C++], building"
  - "builds [C++], about building in Visual Studio"
ms.assetid: 9e8bc1a2-bb17-4951-937a-c757ed88d2d1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Building C++ Projects in Visual Studio
In the Visual Studio integrated development environment (IDE), there are several ways to build an entire solution or just one project in it. You can also modify build settings and specify custom build steps to make your development process more efficient.  
  
 To build a solution that's open in [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] and selected in **Solution Explorer**, you can:  
  
-   On the menu bar, choose **Build**, **Build Solution**.  
  
-   Or, in **Solution Explorer**, open the shortcut menu for the solution and then choose **Build Solution**.  
  
-   Or, press F7. (This is the default keyboard shortcut for the C/C++ development settings.)  
  
-   Or, in the [Command Window](../VS_csharp/command-window.md) (on the menu bar, choose **View**, **Other Windows**, **Command Window**), enter `Build.BuildSolution`.  
  
-   Or, in the [Quick Launch](../VS_csharp/quick-launch--environment--options-dialog-box.md) box, enter `build build solution`.  
  
 To build a project that's selected in **Solution Explorer**, you can:  
  
-   On the menu bar, choose **Build**, **Build <Project Name\>**.  
  
-   Or, in **Solution Explorer**, open the shortcut menu for the project and then choose **Build**.  
  
-   Or, in the Command Window (on the menu bar, choose **View**, **Other Windows**, **Command Window**), enter `Build.BuildOnlyProject`.  
  
-   Or, in the Quick Launch box, enter `build project only build only <project name>`.  
  
 When you build a Visual C++ application in Visual Studio, you can modify many of the build's settings in the project's Property Pages dialog box. For information about how to set project properties, see [Working with Project Properties](../VS_csharp/working-with-project-properties.md).  
  
 For an example about how to use the IDE to create, build, and debug a C++ project, see [Walkthrough: Explore the Visual Studio IDE with C++](../VS_csharp/getting-started-with-c---in-visual-studio.md). For an example about how to use the IDE to build a C++/CLR project, see [Walkthrough: Compiling a C++ Program that Targets the CLR in Visual Studio](../VS_csharp/walkthrough--compiling-a-c---program-that-targets-the-clr-in-visual-studio.md). For an example about how to use the IDE to create a Windows Runtime app, see [Create your first Windows Runtime app using C++](http://msdn.microsoft.com/library/windows/apps/hh974580.aspx).  
  
 To read more about how to build, modify build settings, and specify custom build steps, see the following articles.  
  
## In This Section  
 [Understanding Custom Build Steps and Build Events](../VS_csharp/understanding-custom-build-steps-and-build-events.md)  
 Describes how to customize the build process in the integrated development environment.  
  
 [Common Macros for Build Commands and Properties](../VS_csharp/common-macros-for-build-commands-and-properties.md)  
 Lists macros that you can use where strings are accepted.  
  
 [Building External Projects](../VS_csharp/building-external-projects.md)  
 Discusses building projects that use facilities outside the integrated development environment.  
  
 [Project Files](../VS_csharp/project-files.md)  
 Presents the XML structure of a .vcxproj file.  
  
## Related Sections  
 [VC++ Directories, Projects, Options Dialog Box](assetId:///e027448b-c811-4c3d-8531-4325ad3f6e02)  
 Discusses how to modify the search path for executable files, include files, library files, and source code files during a build  
  
 [Compiling and Building](../VS_csharp/compiling-and-building-in-visual-studio.md)  
 Provides information on building within Visual Studio.  
  
 [Building C/C++ Programs](../VS_csharp/building-c-c---programs.md)  
 Provides links to topics describing building your program from the command line or from the integrated development environment of Visual Studio.  
  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)  
 Provides links to an overview of building programs in C++, compiler and linker options, and additional build tools.  
  
 [Upgrading Projects from Earlier Versions of Visual C++](../VS_csharp/upgrading-projects-from-earlier-versions-of-visual-c--.md)  
 Provides links to topics covering issues on upgrading Visual C++ 6.0 and later projects to Visual C++ .NET.  
  
 [Porting and Upgrading Programs](assetId:///c36c44b3-5a9b-4bb4-9b7a-469aa770ed00)  
 Provides details about porting applications and discusses makefiles.  
  
## See Also  
 [Roadmap for Windows Store apps using C++](assetId:///0b71e4a4-5d8a-4a20-b2ec-e40062675ec1)