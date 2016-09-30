---
title: "Compiler Error CS1729"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1729"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1729"
ms.assetid: 69d24ae0-eaca-4fbf-a5f3-70791f43f97a
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1729
'type' does not contain a constructor that takes 'number' arguments.  
  
 This error occurs when you either directly or indirectly invoke the constructor of a class but the compiler cannot find any constructors with the same number of parameters. In the following example, the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class has no constructors that take any arguments. It therefore has only a default constructor that takes zero arguments. Because in the second line in which the error is generated, the derived class declares no constructors of its own, the compiler provides a default constructor. That constructor invokes a parameterless constructor in the base class. Because the base class has no such constructor, CS1729 is generated.  
  
### To correct this error  
  
1.  Adjust the number of parameters in the call to the constructor.  
  
2.  Modify the class to provide a constructor with the parameters you must call.  
  
3.  Provide a parameterless constructor in the base class.  
  
## Example  
 The following example generates CS1729:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Inheritance (C# Programming Guide)](../vs140/inheritance--csharp-programming-guide-.md)   
 [Constructors (C# Programming Guide)](../vs140/constructors--csharp-programming-guide-.md)