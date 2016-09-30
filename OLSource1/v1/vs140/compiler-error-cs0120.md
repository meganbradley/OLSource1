---
title: "Compiler Error CS0120"
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
  - "CS0120"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0120"
ms.assetid: 3ff67f11-bdf9-436b-bc0c-4fa3cd1925a6
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0120
An object reference is required for the nonstatic field, method, or property 'member'  
  
 In order to use a non-static field, method, or property, you must first create an object instance. For more information about static methods, see [Static Classes and Static Class Members (C# Programming Guide)](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md). For more information about creating instances of classes, see [Instance Constructors (C# Programmer's Reference)](../vs140/instance-constructors--csharp-programming-guide-.md).  
  
 The following sample generates CS0120:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 CS0120 will also be generated if there is a call to a non-static method from a static method, as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Similarly, a static method cannot call an instance method unless you explicitly give it an instance of the class, as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Objects, Classes and Structs (C# Programming Guide)](../vs140/classes-and-structs--csharp-programming-guide-.md)