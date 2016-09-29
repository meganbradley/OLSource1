---
title: "Compiler Error CS0060"
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
  - "CS0060"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0060"
ms.assetid: ae6d4fb7-5ff9-4883-82c3-f55b190f439a
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0060
Inconsistent accessibility: base class 'class1' is less accessible than class 'class2'  
  
 Class accessibility should be consistent between the base class and inherited class.  
  
 The following sample generates CS0060:  
  
```  
// CS0060.cs  
class MyClass  
// try the following line instead  
// public class MyClass  
{  
}  
  
public class MyClass2 : MyClass   // CS0060  
{  
   public static void Main()  
   {  
   }  
}  
```  
  
## See Also  
 [Access Modifiers (C# Programmers Reference)](../vs140/access-modifiers--csharp-programming-guide-.md)