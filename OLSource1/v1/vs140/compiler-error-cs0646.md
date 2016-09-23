---
title: "Compiler Error CS0646"
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
  - CS0646
dev_langs: 
  - CSharp
helpviewer_keywords: 
  - CS0646
ms.assetid: 48ea306f-b4a0-4988-8d2b-ca9d38e9bdad
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error CS0646
Cannot specify the DefaultMember attribute on a type containing an indexer  
  
 If a class or other type specifies **System.Reflection.DefaultMemberAttribute**, it cannot contain an indexer. For more information, see [Properties](../vs140/properties--csharp-programming-guide-.md).  
  
 The following sample generates CS0646:  
  
```  
// CS0646.cs  
// compile with: /target:library  
[System.Reflection.DefaultMemberAttribute("x")]   // CS0646  
class MyClass  
{  
   public int this[int index]   // an indexer  
   {  
      get  
      {  
         return 0;  
      }  
   }  
  
   public int x = 0;  
}  
  
// OK  
[System.Reflection.DefaultMemberAttribute("x")]  
class MyClass2  
{  
   public int prop  
   {  
      get  
      {  
         return 0;  
      }  
   }  
  
   public int x = 0;  
}  
  
class MyClass3  
{  
   public int this[int index]   // an indexer  
   {  
      get  
      {  
         return 0;  
      }  
   }  
  
   public int x = 0;  
}  
```