---
title: "Walkthrough: Debugging a Project (C++)"
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
  - "projects [C++], debugging"
  - "project debugging [C++]"
  - "debugging projects"
ms.assetid: a5cade77-ba51-4b03-a7a0-6897e3cd6a59
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Debugging a Project (C++)
In this walkthrough, you modify the program to fix the problem that you discovered when you tested the project.  
  
## Prerequisites  
  
-   This walkthrough assumes that you understand the fundamentals of the C++ language.  
  
-   It also assumes that you have completed the earlier related walkthroughs that are listed in [Using the Visual Studio IDE for C++ Desktop Development](../vs140/using-the-visual-studio-ide-for-c---desktop-development.md).  
  
### To fix a program that has a bug  
  
1.  To see what occurs when a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> object is destroyed, view the destructor for the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class.  
  
     On the menu bar, choose **View**, **Class View**.  
  
     In the **Class View** window, expand the **Game** project tree and select the **Cardgame** class to display the class members and methods.  
  
     Open the shortcut menu for the **~Cardgame(void)** destructor and then choose **Go To Definition**.  
  
2.  To decrease the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> when a Cardgame terminates, add the following code between the opening and closing braces of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> destructor.  
  
     [!code[NVC_Walkthrough_Debugging_A_Project#110](../vs140/codesnippet/CPP/walkthrough--debugging-a-project--c---_1.cpp)]  
  
3.  The Cardgame.cpp file should resemble this after you change it:  
  
     [!code[NVC_Walkthrough_Debugging_A_Project#111](../vs140/codesnippet/CPP/walkthrough--debugging-a-project--c---_2.cpp)]  
  
4.  On the menu bar, choose **Build**, **Build Solution**.  
  
5.  When the build completes, run it in Debug mode by choosing **Debug**, **Start Debugging** on the menu bar, or by choosing the F5 key. The program pauses at the first breakpoint.  
  
6.  To step through the program, on the menu bar, choose **Debug**, **Step Over**, or choose the F10 key.  
  
     Notice that after each Cardgame constructor executes, the value of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> increases. When the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> function returns, as each Cardgame instance goes out of scope and is deleted (and the destructor is called), <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> decreases. Just before the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> statement is executed, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> equals 0.  
  
7.  Continue stepping through the program until it exits, or let it run by choosing **Debug**, **Run** on the menu bar, or by choosing the F5 key.  
  
## Next Steps  
 **Previous:** [Testing a Project (C++)](../vs140/walkthrough--testing-a-project--c---.md) &#124; **Next:**[Deploying Your Program (C++)](../vs140/walkthrough--deploying-your-program--c---.md)  
  
## See Also  
 [Visual C++ Guided Tour](assetId:///499cb66f-7df1-45d6-8b6b-33d94fd1f17c)   
 [DELETE_PENDING_Building and Debugging](assetId:///9f6ba537-5ea0-46fb-b6ba-b63d657d84f1)