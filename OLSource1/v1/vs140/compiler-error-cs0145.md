---
title: "Compiler Error CS0145"
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
  - "CS0145"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0145"
ms.assetid: e5f9a90f-1700-4e6a-8f82-23d0c0287b85
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0145
A const field requires a value to be provided  
  
 You must initialize a [const](../vs140/const--csharp-reference-.md) variable. For more information, see [Constants (C# Programmer's Reference)](../vs140/constants--csharp-programming-guide-.md).  
  
 The following sample generates CS0145:  
  
```  
// CS0145.cs  
class MyClass  
{  
   const int i;   // CS0145  
   // try the following line instead  
   // const int i = 0;  
  
   public static void Main()  
   {  
   }  
}  
```