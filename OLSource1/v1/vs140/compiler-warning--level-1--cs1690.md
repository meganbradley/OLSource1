---
title: "Compiler Warning (level 1) CS1690"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1690"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1690"
ms.assetid: bc76efe0-4304-4449-8c11-950667aa8ac9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS1690
Accessing a member on 'member' may cause a runtime exception because it is a field of a marshal-by-reference class  
  
 This warning occurs when you try to call a method, property, or indexer on a member of a class that derives from <xref:System.MarshalByRefObject*>, and the member is a value type. Objects that inherit from `MarshalByRefObject` are typically intended to be marshaled by reference across an application domain. If any code ever attempts to directly access the value-type member of such an object across an application domain, a runtime exception will occur. To resolve the warning, first copy the member into a local variable and call the method on that variable.  
  
 The following sample generates CS1690:  
  
```  
// CS1690.cs  
using System;  
  
class WarningCS1690: MarshalByRefObject  
{  
   int i = 5;  
  
   public static void Main()   
   {  
     WarningCS1690 e = new WarningCS1690();  
     e.i.ToString();   // CS1690  
  
     // OK  
     int i = e.i;  
     i.ToString();  
     e.i = i;  
   }  
}  
```