---
title: "&#39;Case&#39; cannot follow a &#39;Case Else&#39; in the same &#39;Select&#39; statement"
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
  - "bc30321"
  - "vbc30321"
helpviewer_keywords: 
  - "BC30321"
ms.assetid: eeedbceb-2c8d-4acb-b84c-8b42c058f083
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Case&#39; cannot follow a &#39;Case Else&#39; in the same &#39;Select&#39; statement
A `Case Else` statement introduces statements to be executed if no match is found for the initial `Case`. A `Case` statement has been found after a `Case Else` in the same `Select` block.  
  
 **Error ID:** BC30321  
  
### To correct this error  
  
-   Move the `Case Else` to the appropriate location after the `Case` statement.  
  
## See Also  
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)