---
title: "How Can I Debug Access Violations When Running My Program Outside the Debugger?"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.access"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "access violation debugging"
  - "debugging [Visual Studio], access violations"
ms.assetid: 780a298a-132e-4245-8370-8c82ca27c6c1
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How Can I Debug Access Violations When Running My Program Outside the Debugger?
## Problem Description  
 My program runs fine in the Visual Studio environment, but when I run it stand-alone with the Windows operating system, it produces an access violation. How can I debug this problem?  
  
## Solution  
 Set the [Just-in-time debugging](../vs140/just-in-time-debugging-in-visual-studio.md) option and run your program stand-alone until the access violation occurs. Then, in the **Access Violation** dialog box, you can click **Cancel** to start the debugger.  
  
 Also see the Knowledge Base article Q133174, "How to Locate Where a General Protection (GP) Fault Occurs." You can find Knowledge Base articles on the MSDN Library CD or by searching [http://support.microsoft.com/](http://support.microsoft.com/).  
  
## See Also  
 [Debugging Native Code FAQs](../vs140/debugging-native-code-faqs.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)