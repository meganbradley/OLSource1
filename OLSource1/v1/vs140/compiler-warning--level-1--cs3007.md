---
title: "Compiler Warning (level 1) CS3007"
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
  - "CS3007"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS3007"
ms.assetid: 9c6bf776-3099-4ab5-ae89-4068ec722f79
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) CS3007
Overloaded method 'method' differing only by unnamed array types is not CLS-compliant  
  
 This error occurs if you have an overloaded method that takes a jagged array and the only difference between the method signatures is the element type of the array. To avoid this error, consider using a rectangular array rather than a jagged array; use an additional parameter to disambiguate the function call; rename one or more of the overloaded methods; or, if CLS Compliance is not needed, remove the <xref:System.CLSCompliantAttribute*> attribute. For more information on CLS Compliance, see [What Is the Common Language Specification](assetId:///4f0b77d0-4844-464f-af73-6e06bedeafc6).  
  
## Example  
 The following example generates CS3007:  
  
```  
// CS3007.cs  
[assembly: System.CLSCompliant(true)]  
public struct S  
{  
    public void F(int[][] array) { }  
    public void F(byte[][] array) { }  // CS3007  
    // Try this instead:  
    // public void F1(int[][] array) {}  
    // public void F2(byte[][] array) {}  
    // or   
    // public void F(int[,] array) {}  
    // public void F(byte[,] array) {}  
}  
```