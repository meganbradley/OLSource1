---
title: "Compiler Error CS0525"
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
  - CS0525
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0525
ms.assetid: fcecfd4f-221f-41e6-a95c-1685be78926e
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0525
Interfaces cannot contain fields  
  
 An [interface](../vs140/interface--csharp-reference-.md) can contain methods and properties but not fields.  
  
 The following sample generates CS0525:  
  
```  
// CS0525.cs  
namespace x  
{  
   public interface clx  
   {  
      public int i;   // CS0525  
   }  
}  
```