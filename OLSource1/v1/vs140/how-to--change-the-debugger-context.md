---
title: "How to: Change the Debugger Context"
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
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], editing variables"
  - "debugging [Visual Studio], Locals window"
  - "Locals window"
  - "variables [debugger], editing"
ms.assetid: 8a69ea63-2ef0-4b4f-9521-cf8ad2e3ec5e
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Change the Debugger Context
The **Locals** window displays variables local to the current context or scope. To modify information in the **Locals** window, the debugger must be in break mode.  
  
 In run mode, information may appear in the **Locals** window, but the information will not be current until the next time your program breaks.  
  
### To change the context of the Locals window  
  
-   In break mode, use the **Debug Location** toolbar to select the desired function, thread, or process.  
  
     —or—  
  
-   Double-click a stack frame in the **Call Stack** window to change the context to that function call.  
  
     —or—  
  
-   Double-click a thread in the **Threads** window to change the context to that thread.  
  
     —or—  
  
-   Double-click a process in the **Processes** window to change the context to that process.  
  
## See Also  
 [Debugger Variable Windows](../vs140/variable-windows.md)