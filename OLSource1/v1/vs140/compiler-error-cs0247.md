---
title: "Compiler Error CS0247"
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
  - CS0247
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0247
ms.assetid: 95a147bb-3c67-45b7-b816-4fcf7503af06
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0247
Cannot use a negative size with stackalloc  
  
 A negative number was passed to a [stackalloc](../vs140/stackalloc--csharp-reference-.md) statement.  
  
 The following sample generates CS0247:  
  
```  
// CS0247.cs  
// compile with: /unsafe  
public class MyClass  
{  
   unsafe public static void Main()  
   {  
      int *p = stackalloc int [-30];   // CS0247  
   }  
}  
```