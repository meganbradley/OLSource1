---
title: "Compiler Error CS0449"
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
  - "CS0449"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0449"
ms.assetid: 32c07a2c-4c48-4d07-b643-72422a6b9fac
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0449
The 'class' or 'struct' constraint must come before any other constraints  
  
 The constraints on the type parameter of a generic type or method must occur in a specific order: <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> must be first, if present, then any interface constraints, and finally any constructor constraints. This error is caused by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> constraint not appearing first. To resolve this error, reorder the constraint clauses.  
  
## Example  
 The following sample generates CS0449.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>