---
title: "FreeLibrary and AfxFreeLibrary"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - FreeLibrary
  - AfxFreeLibrary
dev_langs: 
  - C++
helpviewer_keywords: 
  - extension DLLs [C++], unloading
  - AfxFreeLibrary method
  - unloading DLLs
  - FreeLibrary method
  - DLLs [C++], linking
  - explicit linking [C++]
  - DLLs [C++], unloading
ms.assetid: 4a48d290-3971-43e9-8e97-ba656cd0c8f8
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# FreeLibrary and AfxFreeLibrary
Processes that explicitly link to a DLL call the [FreeLibrary](http://go.microsoft.com/fwlink/p/?LinkID=259188) function when the DLL module is no longer needed. This function decrements the module's reference count and, if the reference count is zero, unmaps it from the address space of the process.  
  
 In an MFC application, use [AfxFreeLibrary](../vs140/afxfreelibrary.md) instead of `FreeLibrary` to unload an extension DLL. The interface (function prototype) for `AfxFreeLibrary` is the same as `FreeLibrary`.  
  
## What do you want to do?  
  
-   [Link implicitly](../vs140/linking-implicitly.md)  
  
-   [Determine which linking method to use](../vs140/determining-which-linking-method-to-use.md)  
  
## What do you want to know more about?  
  
-   [LoadLibrary and AfxLoadLibrary](../vs140/loadlibrary-and-afxloadlibrary.md)  
  
-   [GetProcAddress](../vs140/getprocaddress.md)  
  
## See Also  
 [DLLs in Visual C++](../vs140/dlls-in-visual-c--.md)   
 [FreeLibrary](http://go.microsoft.com/fwlink/p/?LinkID=259188)   
 [AfxFreeLibrary](../vs140/afxfreelibrary.md)