---
title: "Compiler Error CS1575"
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
  - "CS1575"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1575"
ms.assetid: 76a9c57c-8f79-482e-9ae8-c70e8f199dd7
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1575
A stackalloc expression requires [] after type  
  
 The size of the requested allocation, with [stackalloc](../vs140/stackalloc--csharp-reference-.md), must be specified in square brackets.  
  
 The following sample generates CS1575:  
  
```  
// CS1575.cs  
// compile with: /unsafe  
public class MyClass  
{  
   unsafe public static void Main()  
   {  
      int *p = stackalloc int (30);   // CS1575  
      // try the following line instead  
      // int *p = stackalloc int [30];  
   }  
}  
```