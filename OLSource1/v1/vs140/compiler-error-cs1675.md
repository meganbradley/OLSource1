---
title: "Compiler Error CS1675"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1675"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1675"
ms.assetid: add10021-f751-45c7-addc-0f73fa4a267c
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1675
Enums cannot have type parameters  
  
 To resolve this error, remove the type parameter from the `enum` declaration.  
  
## Example  
 The following sample generates CS1675:  
  
```  
// CS1675.cs  
enum E<T>  // CS1675  
{  
}  
  
class CMain  
{  
    public static void Main()  
    {  
    }  
}  
```