---
title: "Compiler Error CS0736"
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
  - "CS0736"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0736"
ms.assetid: 06b14feb-81d5-495f-ab2d-6dc3f5e7216f
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0736
'type name' does not implement interface member 'member name'. 'method name' cannot implement an interface member because it is static.  
  
 This error is generated when a static method is either implicitly or explicitly declared as an implementation of an interface member.  
  
### To correct this error  
  
-   Remove the [static](../vs140/static--csharp-reference-.md) modifier from the method declaration.  
  
-   Change the name of the interface method.  
  
-   Redefine the containing type so that it does not inherit from the interface.  
  
## Example  
 The following code generates CS0736 because <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is declared as static:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)