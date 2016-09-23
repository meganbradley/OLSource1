---
title: "&#39;Try&#39; must end with a matching &#39;End Try&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - bc30384
  - vbc30384
helpviewer_keywords: 
  - BC30384
ms.assetid: 898300b4-c091-4105-aeb0-9bd559ff6b6f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;Try&#39; must end with a matching &#39;End Try&#39;
`Try` is used to initiate a `Try` block; hence it can only appear at the beginning of the block, with a matching`End Try` statement ending the block. Either you have a redundant `Try`, or you did not end your `Try` block with `Finally`.  
  
 **Error ID:** BC30384  
  
### To correct this error  
  
1.  Locate and remove the extraneous `Try`, or end the block with a matching `End Try`.  
  
## See Also  
 [Try...Catch...Finally Statement](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Structured Exception Handling Overview for Visual Basic](assetId:///bb81af80-a735-4873-9711-6151a48e418a)