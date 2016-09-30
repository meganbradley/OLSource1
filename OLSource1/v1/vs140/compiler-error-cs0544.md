---
title: "Compiler Error CS0544"
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
  - "CS0544"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0544"
ms.assetid: f8230a02-a666-4a1a-94cb-46f87463206a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0544
'property override': cannot override because 'non-property' is not a property  
  
 An attempt was made to override a nonproperty data type as a [property](../vs140/properties--csharp-programming-guide-.md), which is not allowed.  
  
 The following sample generates CS0544:  
  
```  
// CS0544.cs  
// compile with: /target:library  
public class a  
{  
   public int i;  
}  
  
public class b : a  
{  
   public override int i {   // CS0544  
   // try the following line instead  
   // public new int i {  
      get  
      {  
         return 0;  
      }  
   }  
}  
```