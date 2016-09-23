---
title: "Search Path Used by Windows to Locate a DLL"
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
  - searching [C++], DLLs
  - DLLs [C++], Windows search path
  - Windows [C++], DLL search path
  - known DLL searches [C++]
  - locating DLLs
  - finding DLLs
  - search paths [C++]
ms.assetid: 84bfb380-ad7b-4962-b2d0-51b19a45f1bb
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Search Path Used by Windows to Locate a DLL
With both implicit and explicit linking, Windows first searches for "known DLLs", such as Kernel32.dll and User32.dll. Windows then searches for the DLLs in the following sequence:  
  
1.  The directory where the executable module for the current process is located.  
  
2.  The current directory.  
  
3.  The Windows system directory. The **GetSystemDirectory** function retrieves the path of this directory.  
  
4.  The Windows directory. The **GetWindowsDirectory** function retrieves the path of this directory.  
  
5.  The directories listed in the PATH environment variable.  
  
    > [!NOTE]
    >  The LIBPATH environment variable is not used.  
  
## What do you want to do?  
  
-   [Link implicitly](../vs140/linking-implicitly.md)  
  
-   [Link explicitly](../vs140/linking-explicitly.md)  
  
-   [Determine which linking method to use](../vs140/determining-which-linking-method-to-use.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)