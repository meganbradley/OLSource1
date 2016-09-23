---
title: "Linker Support for Delay-Loaded DLLs"
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
  - delayed loading of DLLs, linker support
ms.assetid: b2d7e449-2809-42b1-9c90-2c0ca5e31a14
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Support for Delay-Loaded DLLs
The Visual C++ linker now supports the delayed loading of DLLs. This relieves you of the need to use the [!INCLUDE[winsdkshort](../vs140/includes/winsdkshort_md.md)] functions **LoadLibrary** and **GetProcAddress** to implement DLL delayed loading.  
  
 Before Visual C++ 6.0, the only way to load a DLL at run time was by using **LoadLibrary** and **GetProcAddress**; the operating system would load the DLL when the executable or DLL using it was loaded.  
  
 Beginning with Visual C++ 6.0, when statically linking with a DLL, the linker provides options to delay load the DLL until the program calls a function in that DLL.  
  
 An application can delay load a DLL using the [/DELAYLOAD (Delay Load Import)](../vs140/-delayload--delay-load-import-.md) linker option with a helper function (default implementation provided by Visual C++). The helper function will load the DLL at run time by calling **LoadLibrary** and **GetProcAddress** for you.  
  
 You should consider delay loading a DLL if:  
  
-   Your program may not call a function in the DLL.  
  
-   A function in the DLL may not get called until late in your program's execution.  
  
 The delayed loading of a DLL can be specified during the build of either a .EXE or .DLL project. A .DLL project that delays the loading of one or more DLLs should not itself call a delay-loaded entry point in Dllmain.  
  
 The following topics describe delay loading DLLs:  
  
-   [Specifying DLLs to Delay Load](../vs140/specifying-dlls-to-delay-load.md)  
  
-   [Explicitly Unloading a Delay-Loaded DLL](../vs140/explicitly-unloading-a-delay-loaded-dll.md)  
  
-   [Loading All Imports for a Delay-Loaded DLL](../vs140/loading-all-imports-for-a-delay-loaded-dll.md)  
  
-   [Binding Imports](../vs140/binding-imports.md)  
  
-   [Error Handling and Notification](../vs140/error-handling-and-notification.md)  
  
-   [Dumping Delay-Loaded Imports](../vs140/dumping-delay-loaded-imports.md)  
  
-   [Constraints of Delay Loading DLLs](../vs140/constraints-of-delay-loading-dlls.md)  
  
-   [Understanding the Helper Function](../vs140/understanding-the-helper-function.md)  
  
-   [Developing Your Own Helper Function](../vs140/developing-your-own-helper-function.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)   
 [Linking](../vs140/linking.md)