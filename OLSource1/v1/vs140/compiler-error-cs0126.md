---
title: "Compiler Error CS0126"
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
  - "CS0126"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0126"
ms.assetid: 15fb0f38-ac9d-4c09-a69f-398a4903d790
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0126
An object of a type convertible to 'type' is required  
  
 A return statement is present, but the statement does not return a value of the expected type. For more information, see [Properties (C# Programmer's Reference)](../vs140/properties--csharp-programming-guide-.md).  
  
 The following sample generates CS0126:  
  
```  
// CS0126.cs  
public class a  
{  
   public int i  
   {  
      set  
      {  
      }  
      get  
      {  
         return;   // CS0126, specify a value to return  
      }  
   }  
}  
```