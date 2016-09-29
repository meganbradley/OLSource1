---
title: "Compiler Error CS1530"
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
  - "CS1530"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1530"
ms.assetid: 3844b5ef-e0ec-42df-9267-72689020f128
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1530
Keyword 'new' is not allowed on elements defined in a namespace  
  
 It is not necessary to specify the [new](../vs140/new--csharp-reference-.md) keyword on any construct that is in a [namespace](../vs140/namespace--csharp-reference-.md).  
  
 The following sample generates CS1530:  
  
```  
// CS1530.cs  
namespace a  
{  
   new class i   // CS1530  
   {  
   }  
  
   // try the following instead  
   class ii  
   {  
      public static void Main()  
      {  
      }  
   }  
}  
```