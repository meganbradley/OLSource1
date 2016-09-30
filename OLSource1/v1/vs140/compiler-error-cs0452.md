---
title: "Compiler Error CS0452"
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
  - "CS0452"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0452"
ms.assetid: 50a87734-fe07-4bce-891d-a76e131db6cc
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0452
The type 'type name' must be a reference type in order to use it as parameter 'parameter name' in the generic type or method 'identifier of generic'  
  
 This error occurs when you pass a value type such as a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as a parameter to a generic type or method that has a reference type constraint.  
  
## Example  
 The following code generates error CS0452.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Constraints on Type Parameters (C# Programming Guide)](../vs140/constraints-on-type-parameters--csharp-programming-guide-.md)