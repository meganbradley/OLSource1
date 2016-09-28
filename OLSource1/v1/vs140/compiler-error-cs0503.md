---
title: "Compiler Error CS0503"
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
  - "CS0503"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0503"
ms.assetid: 12a337c9-8c5d-473d-8ce6-057b2c7e7935
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0503
The abstract method 'method' cannot be marked virtual  
  
 It is redundant to mark a member method as both [abstract](../vs140/abstract--csharp-reference-.md) and [virtual](../vs140/virtual--csharp-reference-.md) because **abstract** implies **virtual**.  
  
 The following sample generates CS0503:  
  
```  
// CS0503.cs  
namespace x  
{  
   abstract public class clx  
   {  
      abstract virtual public void f();   // CS0503  
   }  
}  
```