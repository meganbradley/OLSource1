---
title: "Compiler Error CS0650"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS0650"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0650"
ms.assetid: c81719ad-343d-4622-8130-41fcb24e3fb5
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0650
Bad array declarator: To declare a managed array the rank specifier precedes the variable's identifier. To declare a fixed size buffer field, use the fixed keyword before the field type.  
  
 An array was declared incorrectly. In C#, unlike in C and C++, the square brackets follow the type, not the variable name. Also, realize that the syntax for a fixed size buffer differs from that of an array.  
  
## Example  
 The following example code generates CS0650.  
  
```  
// CS0650.cs  
public class MyClass  
{  
   public static void Main()  
   {  
// Generates CS0650. Incorrect array declaration syntax:  
      int myarray[2];     
  
      // Correct declaration.  
      int[] myarray2;  
  
      // Declaration and initialization in one statement  
      int[] myArray3= new int[2] {1,2}  
  
      // Access an array element.  
      myarray3[0] = 0;  
    }  
}  
```  
  
## Example  
 The following example shows how to use the `fixed` keyword when you create a fixed size buffer:  
  
```  
// This code must appear in an unsafe block.   
public struct MyArray   
{  
    public fixed char pathName[128];  
}  
  
```  
  
## See Also  
 [Fixed Size Buffers (C# Programming Guide)](../VS_csharp/fixed-size-buffers--csharp-programming-guide-.md)   
 [fixed Statement (C# Reference)](../VS_csharp/fixed-statement--csharp-reference-.md)   
 [Arrays (C# Programming Guide)](../VS_csharp/arrays--csharp-programming-guide-.md)