---
title: "C++ Program Startup and Termination"
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
  - "Standard C++ Library, program startup and termination"
  - "terminating execution"
  - "Function Main procedures"
  - "control text streams"
  - "startup code, and C++ program termination"
  - "main function, program startup"
ms.assetid: f72c8f76-f507-4ddd-a270-7b60f4fed625
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C++ Program Startup and Termination
A C++ program performs the same operations as a C program does at program startup and at program termination, plus a few more outlined here.  
  
 Before the target environment calls the function <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, and after it stores any constant initial values you specify in all objects that have static duration, the program executes any remaining constructors for such static objects. The order of execution is not specified between translation units, but you can nevertheless assume that some [iostreams](../vs140/iostreams-conventions.md) objects are properly initialized for use by these static constructors. These control text streams are:  
  
-   [cin](../vs140/cin.md) — for standard input.  
  
-   [cout](../vs140/cout.md) — for standard output.  
  
-   [cerr](../vs140/cerr.md) — for unbuffered standard error output.  
  
-   [clog](../vs140/clog.md) — for buffered standard error output.  
  
 You can also use these objects within the destructors called for static objects, during program termination.  
  
 As with C, returning from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or calling <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> calls all functions registered with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in reverse order of registry. An exception thrown from such a registered function calls <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## See Also  
 [STL Overview](../vs140/c---standard-library-overview.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)