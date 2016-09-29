---
title: "Walkthrough: Compiling a C++ Program that Targets the CLR in Visual Studio"
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
  - "command-line applications [C++], managed code"
  - "compiling programs [C++]"
  - "Visual C++, managed code"
  - "managed code [C++]"
ms.assetid: 339f89df-a5d2-4040-831a-ddbe25b5dce4
caps.latest.revision: 44
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Compiling a C++ Program that Targets the CLR in Visual Studio
You can create Visual C++ programs that use .NET classes and compile them by using the Visual Studio Development Environment.  
  
 For this procedure you can type your own Visual C++ program or use one of the sample programs. The sample program that we use in this procedure creates a text file named textfile.txt and saves it to the project directory.  
  
## Prerequisites  
 These topics assume that you understand the fundamentals of the C++ language.  
  
### To create a new project in Visual Studio and add a new source file  
  
1.  Create a new project. On the **File** menu, point to **New**, and then click **Project…**.  
  
2.  From the Visual C++ project types, click **CLR**, and then click **CLR Empty Project**.  
  
3.  Type a project name.  
  
     By default, the solution that contains the project has the same name as the new project, but you can enter a different name. You can enter a different location for the project if you want.  
  
     Click **OK** to create the new project.  
  
4.  If Solution Explorer is not visible, click **Solution Explorer** on the **View** menu.  
  
5.  Add a new source file to the project:  
  
    -   Right-click the **Source Files** folder in Solution Explorer, point to **Add** and click **New Item…**.  
  
    -   Click **C++ File (.cpp)** and type a file name and then click **Add**.  
  
     The **.cpp** file appears in the **Source Files** folder in Solution Explorer and a tabbed window appears where you type the code you want in that file.  
  
6.  Click in the newly created tab in Visual Studio and type a valid Visual C++ program, or copy and paste one of the sample programs.  
  
     For example, you can use the [How to: Write a Text File](../VS_csharp/how-to--write-a-text-file--c---cli-.md) sample program (in the **File Handling and I/O** node of the Programming Guide).  
  
     If you use the sample program, notice that you use the `gcnew`keyword instead of `new` when creating a .NET object, and that `gcnew` returns a handle (`^`) rather than a pointer (`*`):  
  
     `StreamWriter^ sw = gcnew StreamWriter(fileName);`  
  
     For more information on the new Visual C++ syntax, see [New C++ Language Features](../VS_csharp/component-extensions-for-runtime-platforms.md).  
  
7.  On the **Build** menu, click **Build Solution**.  
  
     The **Output** window displays information about the compilation progress, such as the location of the build log and a message that indicates the build status.  
  
     If you make changes and run the program without doing a build, a dialog box might indicate that the project is out of date. Select the checkbox on this dialog before you click **OK** if you want Visual Studio to always use the current versions of files instead of prompting you each time it builds the application.  
  
8.  On the **Debug** menu, click **Start without Debugging**.  
  
9. If you used the sample program, when you run the program a command window is displayed that indicates the text file has been created. Press any key to close the command window.  
  
     The **textfile.txt** text file is now located in your project directory. You can open this file by using Notepad.  
  
    > [!NOTE]
    >  Choosing the empty CLR project template automatically set the **/clr** compiler option. To verify this, right-click the project in **Solution Explorer** and clicking **Properties**, and then check the **Common Language Runtime support** option in the **General** node of **Configuration Properties**.  
  
## What's Next  
 **Previous:** [Compiling a Native C++ Program from the Command Line (C++)](../VS_csharp/walkthrough--compiling-a-native-c---program-on-the-command-line.md) &#124; **Next:**[Compiling a C Program (C++)](../VS_csharp/walkthrough--compiling-a-c-program-on-the-command-line.md)  
  
## See Also  
 [Visual C++ Guided Tour](assetId:///499cb66f-7df1-45d6-8b6b-33d94fd1f17c)   
 [C++ Language Reference](../VS_csharp/c---language-reference.md)   
 [Building a C/C++ Program](../VS_csharp/building-c-c---programs.md)