---
title: "Compiler Error CS0820"
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
  - "CS0820"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0820"
ms.assetid: 38c05162-ef20-42a8-9611-02698360dec5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0820
Cannot assign array initializer to an implicitly typed local  
  
 An implicitly typed array is an array whose element type is inferred by the compiler. It must be initialized by using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>[] modifier as shown in the example code.  
  
### To correct this error  
  
-   Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[] modifier with the array initializer.  
  
-   Do not use an implicitly typed local variable.  
  
## Example  
 The following code generates CS0820 and shows how to correctly initialize an implicitly typed array:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Implicitly Typed Local Variables (C# Programming Guide)](../vs140/implicitly-typed-local-variables--csharp-programming-guide-.md)