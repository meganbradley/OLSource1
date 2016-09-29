---
title: "How to: Use the Windows ReadFile Function (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "ReadFile function [C#]"
ms.assetid: 46bb53e0-a658-48c9-ae36-6720da7781c1
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the Windows ReadFile Function (C# Programming Guide)
This example demonstrates the Windows `ReadFile` function by reading and displaying a text file. The `ReadFile` function requires the use of `unsafe` code because it requires a pointer as a parameter.  
  
 The byte array passed into the `Read` function is a managed type. This means that the common language runtime (CLR) garbage collector could relocate the memory used by the array at will. To prevent this, [fixed](../vs140/fixed-statement--csharp-reference-.md) is used to get a pointer to the memory and mark it so that the garbage collector will not move it. At the end of the `fixed` block, the memory automatically returns to being subject to moving through garbage collection.  
  
 This capability is known as *declarative pinning*. With pinning, there is very little overhead unless a garbage collection occurs in the `fixed` block, which is an unlikely occurrence. However, pinning can lead to some undesirable side effects during the global garbage collection runs. The garbage collector's ability to compact memory is greatly limited by pinned buffers. Therefore, pinning should be avoided if at all possible.  
  
## Example  
 [!code[csProgGuidePointers#2](../vs140/codesnippet/CSharp/how-to--use-the-windows-readfile-function--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Programmer's Reference](../vs140/csharp-reference.md)   
 [Unsafe Code (C#)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [Pointer types](../vs140/pointer-types--csharp-programming-guide-.md)   
 [Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9)