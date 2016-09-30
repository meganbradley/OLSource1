---
title: "How to: Set a Thread Name in Native Code"
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
  - "debugging [C++], threads"
  - "SetThreadName function"
  - "threading [Visual Studio], names"
  - "thread names"
  - "debugging [Visual Studio], threads"
ms.assetid: c85d0968-9f22-4d69-87f4-acca2ae777b8
caps.latest.revision: 41
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Set a Thread Name in Native Code
To set a thread name in your program, use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function, as shown in the following code example. Note that the thread name is copied to the thread so that the memory for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter can be released.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Debugging Multithreaded Applications](../vs140/debug-multithreaded-applications-in-visual-studio.md)   
 [Viewing Data in the Debugger](../vs140/viewing-data-in-the-debugger.md)   
 [How to: Set a Thread Name in Managed Code](../vs140/how-to--set-a-thread-name-in-managed-code.md)