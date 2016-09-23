---
title: "Compiler Error CS0231"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - CS0231
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0231
ms.assetid: e5e6a8e1-6c9f-4a88-8935-7bedfba88f8c
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0231
A params parameter must be the last parameter in a formal parameter list.  
  
 The [params](../vs140/params--csharp-reference-.md) parameter supports a variable numbers of arguments and must be after all other parameters. For more information, see [Class and Struct Methods (C# Programmer's Reference)](../vs140/methods--csharp-programming-guide-.md).  
  
 The following sample generates CS0231:  
  
```  
// CS0231.cs  
class Test  
{  
   public void TestMethod(params int[] p, int i) {} // CS0231  
   // To resolve the error, use the following line instead:  
   // public void TestMethod(int i, params int[] p) {}   
  
   static void Main()   
   {  
   }  
}  
```