---
title: "List Threads Command"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "debug.listthreads"
helpviewer_keywords: 
  - "ListThreads command"
  - "list threads command"
  - "Debug.ListThreads command"
ms.assetid: 34b665c0-d46f-4c1a-a066-b678eba5ac54
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# List Threads Command
Displays a list of the threads in the current program.  
  
## Syntax  
  
```  
Debug.ListThreads [index]  
```  
  
## Arguments  
 `index`  
 Optional. Selects a thread by its index to be the current thread.  
  
## Remarks  
 When specified, the `index` argument marks the indicated thread as the current thread. An asterisk (*) is displayed in the list next to the current thread.  
  
## Example  
  
```  
>Debug.ListThreads   
```  
  
## See Also  
 [List Call Stack Command](../VS_csharp/list-call-stack-command.md)   
 [List Disassembly Command](../VS_csharp/list-disassembly-command.md)   
 [Visual Studio Commands](../VS_csharp/visual-studio-commands.md)   
 [Command Window](../VS_csharp/command-window.md)   
 [Find/Command Box](../VS_csharp/find-command-box.md)   
 [Visual Studio Command Aliases](../VS_csharp/visual-studio-command-aliases.md)