---
title: "Compiler Error CS1919"
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
  - "CS1919"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1919"
ms.assetid: 5d1e468b-ddec-4edd-a8b1-9c65c2332778
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1919
Unsafe type 'type name' cannot be used in object creation.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator creates objects only on the managed heap. However, you can create objects in unmanaged memory indirectly by using the interoperability capabilities of the language to call native methods that return pointers.  
  
### To correct this error  
  
1.  Use a safe type in the new object creation expression. For example, use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
2.  If you must create objects in unmanaged memory, use a Win32 or COM method or else write your own function in C or C++ and call it from C#.  
  
## Example  
 The following example generates CS1919 because a pointer type is unsafe:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Interoperability (C# Programming Guide)](../vs140/interoperability--csharp-programming-guide-.md)