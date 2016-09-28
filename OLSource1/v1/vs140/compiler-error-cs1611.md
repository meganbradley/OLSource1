---
title: "Compiler Error CS1611"
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
  - "CS1611"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1611"
ms.assetid: 48bfba77-6be2-4242-b1d2-98bf471b6d1e
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1611
The params parameter cannot be declared as ref or out  
  
 The keywords [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) cannot be used with the [params](../vs140/params--csharp-reference-.md) keyword.  
  
 The following sample generates CS1611:  
  
```  
// CS1611.cs  
public class MyClass  
{  
   public static void Test(params ref int[] a)   // CS1611, remove ref  
   {  
   }  
  
   public static void Main()  
   {  
      Test(1);  
   }  
}  
```