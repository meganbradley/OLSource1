---
title: "Introduction to Visual C++ for UNIX Users"
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
  - "UNIX [C++]"
ms.assetid: 36108b31-e7fa-49a8-a1f7-7077fcbec873
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to Visual C++ for UNIX Users
This topic provides information for UNIX users who are new to [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] and want to become productive with [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)].  
  
## Getting Started on the Command Line  
 You can use [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] from the command line in a similar way that you would use a UNIX command-line environment. You compile from the command prompt with the command-line C and C++ compiler (CL.EXE) and tools, including NMAKE.EXE, the Microsoft version of the UNIX make utility.  
  
 In UNIX, commands are installed in a common folder, such as /usr/bin. In [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)], the command-line tools are installed in your installation directory at VC\bin (on a typical installation at Program Files\Microsoft Visual Studio 8\VC\bin). To use the command-line tools, run vsvars32.bat, which is located in your installation directory at Common7\Tools. This adds your bin directory to your path and sets up other paths that are necessary to compile Visual C++ programs from the command line.  
  
> [!NOTE]
>  If you open a command prompt with the **Visual Studio Command Line Prompt** from the **Start** menu, then vsvars32.bat is run for you.  
  
 To take advantage of more powerful features, such as the debugger, statement completion, and so on, you need to use the development environment. For more information, see [Building on the Command Line](../vs140/building-on-the-command-line.md) and [How to: Compile a Simple C++ Program from the Command Line](../vs140/walkthrough--compiling-a-native-c---program-on-the-command-line.md).  
  
## Debugging Your Code  
 If you use the command line and run your applications on your development workstation, you will see that a dialog box to run the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugger is displayed when your code encounters a memory access violation, unhandled exception, or other unrecoverable errors. If you click **OK**, then the Visual Studio development environment is started, and the debugger will open to the point of failure. It is possible to debug your applications this way, and, in this case, your source code would only be available if you compiled with the [/Z7, /Zd, /Zi, /ZI (Debug Information Format)](../vs140/-z7---zi---zi--debug-information-format-.md) switch. For more information, see [Debugging Visual C++](../vs140/debugging-native-code.md) and [Introducing the Visual Studio IDE (C++)](../vs140/using-the-visual-studio-ide-for-c---desktop-development.md).  
  
## Using the Development Environment  
 It is easier to use the development environment to edit and build your source code in a *project*. A project is a collection of source and related files that will be compiled into a single unit, such as a library or executable. A project also contains information on how the files are to be built. Information about projects is stored in a project file with the extension .prj.  
  
 An application that consists of multiple libraries and executables, each potentially built with a different set of compiler options or even in a different language, are stored in multiple projects that are part of a single *solution*. A solution is an abstraction for a container to group multiple projects together. Information about solutions is stored in a solution file with the extension .sln. For more information, see [PAVE: Managing Solutions and Projects](assetId:///7a50db22-d3cc-46f3-b648-ab7e0528e260) and [Introducing the Visual Studio IDE (C++)](../vs140/using-the-visual-studio-ide-for-c---desktop-development.md).  
  
## Importing Your Existing Code  
 You can use [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] to use existing code that is set up to compile with or without a makefile and put it into a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project. For more information, see the **Create Project From Existing Code Files Wizard**. For more information, see [How to: Create a C++ Project From Existing Code](../vs140/how-to--create-a-c---project-from-existing-code.md).  
  
## Creating a New Project  
 You can create new projects in the development environment. [!INCLUDE[vcprvc](../vs140/includes/vcprvc_md.md)] provides numerous templates that provide standard code for various common projects. You can use application wizards to generate projects with code outlines for various application types.  
  
 You can start with an empty project by using the **Console Application (Win32) Wizard**. Select the **Empty Project** check box. You can then add new and existing files to the project later.  
  
 When you create a project, you must name the project. By default, the project name equals the name of the dynamic-link library (DLL) or executable that is build from the project. For more information, see [How to: Create New Solutions and Projects](../vs140/creating-solutions-and-projects.md).  
  
## Microsoft-Specific Modifiers  
 Visual C++ contains several extensions to the standard C++ programming language. These extensions are used to specify storage class attributes, function calling conventions, and based addressing, among other things. For a complete list of all Visual C++ extensions, see [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md).  
  
 You can disable all Microsoft-specific extensions to C++ by using the **/Za** compiler option. This option is recommended if you want to write code to run on multiple platforms. For more information on the **/Za** compiler option, see [/Za, /Ze (Disable Language Extensions)](../vs140/-za---ze--disable-language-extensions-.md). For more information on Visual C++ conformance, see [Compatibility and Compliance Issues in Visual C++](../vs140/compatibility-and-compliance-issues-in-visual-c--.md).  
  
## Precompiled Headers  
 The Microsoft C and C++ compilers provide options for precompiling any C or C++ code, including inline code. Using this performance feature, you can compile a stable body of code, store the compiled state of the code in a file, and, during subsequent compilations, combine the precompiled code with code that is still under development. Each subsequent compilation is faster because the stable code does not need to be recompiled.  
  
 By default, all precompiled code is specified in the files **stdafx.h** and **stdafx.cpp**. The **New Project** wizard will automatically create these files for you unless you deselect the **Precompiled header** option. For more information on precompiled headers, see [Creating Precompiled Header Files](../vs140/creating-precompiled-header-files.md).  
  
## Related Sections  
 For more information, see [Porting from UNIX to Win32](../vs140/porting-from-unix-to-win32.md).  
  
## See Also  
 [Visual C++ Guided Tour](assetId:///499cb66f-7df1-45d6-8b6b-33d94fd1f17c)