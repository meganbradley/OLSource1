---
title: "Compiler Error CS0446"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0446"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0446"
ms.assetid: d7a07e24-722e-484d-b6d7-ca809b51858f
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0446
Foreach cannot operate on a 'Method or Delegate'. Did you intend to invoke the 'Method or Delegate'?  
  
 This error is caused by specifying a method without parentheses or an anonymous method without parentheses in the part of the `foreach` statement where you would normally put a collection class. Note that it is valid, though unusual, to put a method call in that location, if the method returns a collection class.  
  
## Example  
 The following code will generate CS0446.  
  
```  
// CS0446.cs  
using System;  
class Tester   
{  
    static void Main()   
    {  
        int[] intArray = new int[5];  
        foreach (int i in M) { } // CS0446  
    }  
    static void M() { }  
}  
```