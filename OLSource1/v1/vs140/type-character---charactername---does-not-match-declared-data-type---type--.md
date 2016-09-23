---
title: "Type character &#39;&lt;charactername&gt;&#39; does not match declared data type &#39;&lt;type&gt;&#39;"
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
  - vbc30277
  - bc30277
helpviewer_keywords: 
  - BC30277
ms.assetid: 9808f57e-a46c-43f9-b5e7-275794627763
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Type character &#39;&lt;charactername&gt;&#39; does not match declared data type &#39;&lt;type&gt;&#39;
A variable is declared with one data type but referred to with a type character representing an incompatible data type, for example `K$ = 10` when `K` is declared `Integer`.  
  
 **Error ID:** BC30277  
  
### To correct this error  
  
-   Change the declared data type of the variable, or change or remove the type character in the reference.  
  
## See Also  
 [Type Characters](../vs140/type-characters--visual-basic-.md)