---
title: "&#39;Case&#39; can only appear inside a &#39;Select Case&#39; statement"
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
  - vbc30072
  - bc30072
helpviewer_keywords: 
  - BC30072
ms.assetid: da808bc3-f154-444a-b547-3cf55beff8a9
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# &#39;Case&#39; can only appear inside a &#39;Select Case&#39; statement
A `Case` statement occurs outside a `Select` block. A `Case` statement can be used only between a `Select` or `Select Case` statement and its corresponding `End Select` statement.  
  
 **Error ID:** BC30072  
  
### To correct this error  
  
-   Remove the `Case` statement or move it to within a `Select` block.  
  
## See Also  
 [Select...Case Statement](../vs140/select...case-statement--visual-basic-.md)