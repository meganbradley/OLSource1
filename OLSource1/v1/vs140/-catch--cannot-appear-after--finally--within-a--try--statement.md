---
title: "&#39;Catch&#39; cannot appear after &#39;Finally&#39; within a &#39;Try&#39; statement"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc30379"
  - "bc30379"
helpviewer_keywords: 
  - "BC30379"
ms.assetid: 33d1278b-cf10-4c66-aaf8-08a4372f370b
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Catch&#39; cannot appear after &#39;Finally&#39; within a &#39;Try&#39; statement
A `Catch` statement appears in the code after the `Finally` ending a `Try` statement block. `Catch` must appear within a `Try...Catch...Finally` statement block.  
  
 **Error ID:** BC30379  
  
### To correct this error  
  
1.  Move the `Catch` statement to a more appropriate place in the code.  
  
## See Also  
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Structured Exception Handling Overview for Visual Basic](assetId:///bb81af80-a735-4873-9711-6151a48e418a)