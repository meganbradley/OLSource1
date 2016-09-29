---
title: "Compiler Error CS0107"
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
  - "CS0107"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0107"
ms.assetid: 505763c5-6d68-4c57-a8bd-7b03682da4c5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0107
More than one protection modifier  
  
 Only one access modifier ([public](../vs140/public--csharp-reference-.md), [private](../vs140/private--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), or [internal](../vs140/internal--csharp-reference-.md)) is allowed on a class member, with the exception of except **internal protected**.  
  
 The following sample generates CS0107:  
  
```  
// CS0107.cs  
public class C  
{  
   private internal void f()   // CS0107, delete private or internal  
   {  
   }  
  
   public static int Main()  
   {  
      return 1;  
   }  
}  
```