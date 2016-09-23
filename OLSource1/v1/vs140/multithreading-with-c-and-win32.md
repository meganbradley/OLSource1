---
title: "Multithreading with C and Win32"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - Windows API [C++], multithreading
  - multithreading [C++], C and Win32
  - Visual C, multithreading
  - Win32 applications [C++], multithreading
  - threading [C++], C and Win32
  - Win32 [C++], multithreading
  - threading [C]
ms.assetid: 67cdc99e-1ad9-452b-a042-ed246b70040e
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Multithreading with C and Win32
Microsoft Visual C++ provides support for creating multithread applications with Microsoft Windows: Windows XP, Windows 2000, Windows NT, Windows Me, and Windows 98. You should consider using more than one thread if your application needs to manage multiple activities, such as simultaneous keyboard and mouse input. One thread can process keyboard input while a second thread filters mouse activities. A third thread can update the display screen based on data from the mouse and keyboard threads. At the same time, other threads can access disk files or get data from a communications port.  
  
 With Visual C++, there are two ways to program with multiple threads: use the Microsoft Foundation Class (MFC) library or the C run-time library and the Win32 API. For information about creating multithread applications with MFC, see [Multithreading with C++ and MFC](../vs140/multithreading-with-c---and-mfc.md) after reading the following topics about multithreading in C.  
  
 These topics explain the features in Visual C++ that support the creation of multithread programs.  
  
## What do you want to know more about?  
  
-   [What multithreading is about](../vs140/multithread-programs.md)  
  
-   [Library support for multithreading](../vs140/library-support-for-multithreading.md)  
  
-   [Include files for multithreading](../vs140/include-files-for-multithreading.md)  
  
-   [C Run-Time library functions for thread control](../vs140/c-run-time-library-functions-for-thread-control.md)  
  
-   [Sample multithread program in C](../vs140/sample-multithread-c-program.md)  
  
-   [Writing a Multithread Win32 Program](../vs140/writing-a-multithreaded-win32-program.md)  
  
-   [Compiling and linking multithread programs](../vs140/compiling-and-linking-multithread-programs.md)  
  
-   [Avoiding problem areas with multithread programs](../vs140/avoiding-problem-areas-with-multithread-programs.md)  
  
-   [Thread local storage (TLS)](../vs140/thread-local-storage--tls-.md)  
  
## See Also  
 [Multithreading Support for Older Code (Visual C++)](../vs140/multithreading-support-for-older-code--visual-c---.md)