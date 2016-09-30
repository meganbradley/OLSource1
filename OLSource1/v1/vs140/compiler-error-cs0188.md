---
title: "Compiler Error CS0188"
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
  - "CS0188"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0188"
ms.assetid: 4e693c18-584d-4c94-9863-283c69b97b0b
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0188
The 'this' object cannot be used before all of its fields are assigned to  
  
 All fields in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> have to be assigned by a constructor before the constructor can call a method in the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 If you see this error when trying to initialize a property in a struct constructor, the solution is to change the constructor parameter to specify the backing field instead of the property itself. Auto-implemented properties should be avoided in structs because they have no backing field and therefore cannot be initialized in any way from the constructor.  
  
 For more information, see [Using Structs (C# Programming Guide)](../vs140/using-structs--csharp-programming-guide-.md).  
  
## Example  
 The following sample generates CS0188:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Structs (C# Programming Guide)](../vs140/structs--csharp-programming-guide-.md)   
 [Auto-Implemented Properties (C# Programming Guide)](../vs140/auto-implemented-properties--csharp-programming-guide-.md)