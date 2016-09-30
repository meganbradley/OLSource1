---
title: "Can an MFC DLL create multiple threads?"
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
  - "DLLs [C++], multithreading"
  - "MFC DLLs [C++], multithreading"
  - "threading [MFC], DLLs"
  - "multithreading [C++], DLLs"
ms.assetid: 41d5b5e6-a7d3-42bf-b641-f1245abd1c59
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Can an MFC DLL create multiple threads?
Except during initialization, an MFC DLL can safely create multiple threads as long as it uses the Win32 thread local storage (TLS) functions such as **TlsAlloc** to allocate thread local storage. However, if an MFC DLL uses **__declspec(thread)** to allocate thread local storage, the client application must be implicitly linked to the DLL. If the client application explicitly links to the DLL, the call to **LoadLibrary** will not successfully load the DLL. For more information about creating multiple threads inside MFC DLLs, see the Knowledge Base article, "PRB: Calling LoadLibrary() to Load a DLL That Has Static TLS" (Q118816).  
  
 An MFC DLL that creates a new MFC thread during startup will stop responding when it is loaded by an application. This includes whenever a thread is created by calling <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> inside:  
  
-   The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived object in a regular DLL.  
  
-   A supplied <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or **RawDllMain** function in a regular DLL.  
  
-   A supplied <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or **RawDllMain** function in an Extension DLL.  
  
 For more information about creating threads during initialization, see the Knowledge Base article, "PRB: Cannot Create an MFC Thread During DLL Startup" (Q142243).  
  
## See Also  
 [DLL Frequently Asked Questions](../vs140/dll-frequently-asked-questions.md)