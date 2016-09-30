---
title: "Compiler Error CS0737"
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
  - "CS0737"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0737"
ms.assetid: d2247770-5546-46f2-a01d-8e2ebfcbb859
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0737
'type name' does not implement interface member 'member name'. 'method name' cannot implement an interface member because it is not public.  
  
 A method that implements an interface member must have public accessibility. All interface members are <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
### To correct this error  
  
1.  Add the [public](../vs140/public--csharp-reference-.md) access modifier to the method.  
  
## Example  
 The following code generates CS0737:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Interfaces (C# Programming Guide)](../vs140/interfaces--csharp-programming-guide-.md)