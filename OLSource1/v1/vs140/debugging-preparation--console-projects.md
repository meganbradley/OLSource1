---
title: "Debugging Preparation: Console Projects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], console applications"
  - "debugging console applications"
  - "console applications, debugging"
ms.assetid: 9641f1d9-2d5a-48b1-8731-6525e8f67892
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Debugging Preparation: Console Projects
Preparing to debug a Console project is similar to preparing to debug a Windows project, with some additional considerations. For more information, see [Debugging Preparation: Windows Forms Applications](../vs140/debugging-preparation--windows-forms-applications.md), and [Debugging Preparation: Windows Forms Applications (.NET)](assetId:///a8bc54de-41a3-464d-9a12-db9bdcbc1ad5). Because of the similarity of all console applications, this topic covers the following project types:  
  
-   C# Console Application  
  
-   Visual Basic Console Application  
  
-   C++ Console Application (.NET)  
  
-   C++ Console Application (Win32)  
  
 You might have to specify command-line arguments for your console application. For more information, see [Project Settings for a C or C++ Debug Configuration](../vs140/project-settings-for-a-c---debug-configuration.md), [Project Settings for a Visual Basic Debug Configuration](../vs140/project-settings-for-a-visual-basic-debug-configuration.md), or [Project Settings for  C# and J# Debug Configurations](../vs140/project-settings-for--csharp-debug-configurations.md).  
  
 Like all project properties, these arguments persist between debug sessions and between  Visual Studio sessions. Therefore, if the console application is one that you have debugged previously, remember that there might be arguments from previous sessions entered in the **<Project\> Property Pages** dialog box.  
  
 A console application uses the **Console** window to accept input and to display output messages. To write to the **Console** window, your application must use the **Console** object instead of the Debug object. To write to the **Visual Studio Output** window, use the Debug object, as usual. Be sure that you know where your application is writing or you might be looking for messages in the wrong place. For more information, see [Console Class](https://msdn.microsoft.com/en-us/library/system.console.aspx), [Debug Class](https://msdn.microsoft.com/en-us/library/system.diagnostics.debug.aspx), and [Output Window](../vs140/output-window.md).  
  
## Starting the application  
 When some console applications start, they run to completion and then exit. This behavior might not give you enough time to break execution and debug. To be able to debug an application, use one of the following procedures to start the application:  
  
-   Your application starts executing and runs untils it reaches the breakpoint.  
  
-   Your application starts and immediately breaks at the first line of source code.  
  
-   In a source code window, right-click a line and select **Run to cursor**.  
  
     Your application starts and runs to the selected line, or to a breakpoint, if the breakpoint is hit before the line.  
  
 When you debug a console application, you might want to start the application from the command prompt rather than from Visual Studio. In that case, you can start the application from the command prompt and attach the Visual Studio debugger to it. For more information, see [Attaching to Running Processes](../vs140/attach-to-running-processes-with-the-visual-studio-debugger.md).  
  
 When you start a console application from Visual Studio, the **Console** window sometimes appears behind the Visual Studio window. If you try to start your console application from Visual Studio and nothing seems to happen, try to move the Visual Studio window.  
  
## See Also  
 [Debugging Native Code](../vs140/debugging-native-code.md)   
 [Debugging Managed Code](../vs140/debugging-managed-code.md)   
 [Debugging Preparation: Visual C++ Project Types](../vs140/debugging-preparation--visual-c---project-types.md)   
 [Debugging Preparation: C#, J#, and Visual Basic Project Types](../vs140/debugging-preparation--csharp--fsharp--and-visual-basic-project-types.md)   
 [Project Settings for a C or C++ Debug Configuration](../vs140/project-settings-for-a-c---debug-configuration.md)   
 [Debugger Security](../vs140/debugger-security.md)