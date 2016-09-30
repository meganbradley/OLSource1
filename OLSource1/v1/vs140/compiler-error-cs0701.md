---
title: "Compiler Error CS0701"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0701"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0701"
ms.assetid: eb844e31-00bd-468d-9f77-11d10a4ef120
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0701
'identifier' is not a valid constraint. A type used as a constraint must be an interface, a non-sealed class or a type parameter.  
  
 This error occurs if a sealed type is used as a constraint. To resolve this error, use only non-sealed types as constraints.  
  
## Example  
 The following sample generates CS0701.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>