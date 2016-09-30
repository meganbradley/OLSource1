---
title: "Tips for Debugging Threads in Native Code"
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
  - "threading [Visual Studio], debugging"
  - "debugging [Visual Studio], threads"
ms.assetid: 0374c8c6-57a3-4cfe-8047-2effef5ff5dc
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Tips for Debugging Threads in Native Code
Here are some tips you can use when debugging threads in native code:  
  
-   You can view the contents of the Thread Information Block by typing <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> in the **Watch** window or **QuickWatch** dialog box.  
  
-   You can view the last error code for the current thread by entering <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in the **Watch** window or **QuickWatch** dialog box.  
  
-   C Run-Time Libraries (CRT) functions can be useful for debugging a multithreaded application. For more information, see [_malloc_dbg](../vs140/_malloc_dbg.md).  
  
## See Also  
 [Debugging Multithreaded Applications](../vs140/debug-multithreaded-applications-in-visual-studio.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)