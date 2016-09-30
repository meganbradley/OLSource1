---
title: "Compiler Error CS1951"
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
  - "CS1951"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1951"
ms.assetid: 799ba212-a000-44d9-b7da-a8c00eae63fa
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1951
An expression tree lambda may not contain an out or ref parameter.  
  
 An expression tree just represents expressions as data structures. There is no way to represent specific memory locations as is required when you pass a parameter by reference.  
  
### To correct this error  
  
1.  The only option is to remove the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier in the delegate definition and pass in the parameter by value.  
  
## Example  
 The following example generates CS1951:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Expression Trees](../vs140/expression-trees--csharp-and-visual-basic-.md)