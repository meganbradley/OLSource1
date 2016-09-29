---
title: "How to: Use Pointers to Copy an Array of Bytes  (C# Programming Guide)"
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
  - "byte arrays [C#]"
  - "arrays [C#], byte"
  - "pointers [C#], to copy bytes"
ms.assetid: ec16fbb4-a24e-45f5-a763-9499d3fabe0a
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Pointers to Copy an Array of Bytes  (C# Programming Guide)
The following example uses pointers to copy bytes from one array to another.  
  
 This example uses the [unsafe](../VS_csharp/unsafe--csharp-reference-.md) keyword, which enables you to use pointers in the `Copy` method. The [fixed](../VS_csharp/fixed-statement--csharp-reference-.md) statement is used to declare pointers to the source and destination arrays. This *pins* the location of the source and destination arrays in memory so that they will not be moved by garbage collection. The memory blocks for the arrays are unpinned when the `fixed` block is completed. Because the `Copy` method in this example uses the `unsafe` keyword, it must be compiled with the **/unsafe** compiler option. To set the option in Visual Studio, right-click the project name, and then click **Properties**. On the **Build** tab, select **Allow unsafe code**.  
  
## Example  
 [!code[csProgGuidePointers#3](../VS_csharp/codesnippet/CSharp/how-to--use-pointers-to-copy-an-array-of-bytes---csharp-programming-guide-_1.cs)]  
  
 [!code[csProgGuidePointers#18](../VS_csharp/codesnippet/CSharp/how-to--use-pointers-to-copy-an-array-of-bytes---csharp-programming-guide-_2.cs)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Unsafe Code and Pointers (C# Programming Guide)](../VS_csharp/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [/unsafe (Enable Unsafe Mode)](../VS_csharp/-unsafe--csharp-compiler-options-.md)   
 [Garbage Collection](assetId:///22b6cb97-0c80-4eeb-a2cf-5ed7655e37f9)