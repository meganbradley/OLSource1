---
title: "Compiler Error CS1601"
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
  - "CS1601"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1601"
ms.assetid: 5efa1d2d-c70c-446d-a51f-d23d8a3be22e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1601
Method or delegate parameter cannot be of type 'type'  
  
 Some types in the .NET Framework class library, for example, \<xref:System.TypedReference*>, \<xref:System.RuntimeArgumentHandle*> and \<xref:System.ArgIterator*> cannot be used as [ref](../vs140/ref--csharp-reference-.md) or [out](../vs140/out--csharp-reference-.md) parameters because they could potentially be used to perform unsafe operations.  
  
 The following sample generates CS1601:  
  
```  
// CS1601.cs  
using System;  
  
class MyClass  
{  
   public void Test1 (ref TypedReference t)   // CS1601  
   {  
   }  
  
   public void Test2 (out ArgIterator t)   // CS1601  
   {  
   }  
}  
```