---
title: "Fixed Size Buffers (C# Programming Guide)"
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
  - "fixed size buffers [C#]"
  - "unsafe buffers [C#]"
  - "unsafe code [C#], fixed size buffers"
ms.assetid: 6220d454-947c-4977-ac9d-9308c6ed5051
caps.latest.revision: 35
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Fixed Size Buffers (C# Programming Guide)
In C#, you can use the [fixed](../vs140/fixed-statement--csharp-reference-.md) statement to create a buffer with a fixed size array in a data structure. This is useful when you are working with existing code, such as code written in other languages, pre-existing DLLs or COM projects. The fixed array can take any attributes or modifiers that are allowed for regular struct members. The only restriction is that the array type must be <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In early versions of C#, declaring a C++ style fixed-size structure was difficult because a C# struct that contains an array does not contain the array elements. Instead, the struct contains a reference to the elements.  
  
 C# 2.0 added the ability to embed an array of fixed size in a [struct](../vs140/struct--csharp-reference-.md) when it is used in an [unsafe](../vs140/unsafe--csharp-reference-.md) code block.  
  
 For example, before C# 2.0, the following <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> would be 8 bytes in size. The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> array is a reference to the heap-allocated array:  
  
 [!code[csProgGuidePointers#19](../vs140/codesnippet/CSharp/fixed-size-buffers--csharp-programming-guide-_1.cs)]  
  
 Beginning with C# 2.0, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> can contain an embedded array. In the following example, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> array has a fixed size. To access the elements of the array, you use a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> statement to establish a pointer to the first element. The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> statement pins an instance of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to a specific location in memory.  
  
 [!code[csProgGuidePointers#20](../vs140/codesnippet/CSharp/fixed-size-buffers--csharp-programming-guide-_2.cs)]  
  
 The size of the 128 element <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> array is 256 bytes. Fixed size [char](../vs140/char--csharp-reference-.md) buffers always take two bytes per character, regardless of the encoding. This is true even when char buffers are marshaled to API methods or structs with <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. For more information, see \<xref:System.Runtime.InteropServices.CharSet*>.  
  
 Another common fixed-size array is the [bool](../vs140/bool--csharp-reference-.md) array. The elements in a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> array are always one byte in size. <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> arrays are not appropriate for creating bit arrays or buffers.  
  
> [!NOTE]
>  Except for memory created by using [stackalloc](../vs140/stackalloc--csharp-reference-.md), the C# compiler and the common language runtime (CLR) do not perform any security buffer overrun checks. As with all unsafe code, use caution.  
  
 Unsafe buffers differ from regular arrays in the following ways:  
  
-   You can only use unsafe buffers in an unsafe context.  
  
-   Unsafe buffers are always vectors, or one-dimensional arrays.  
  
-   The declaration of the array should include a count, such as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. You cannot use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> instead.  
  
-   Unsafe buffers can only be instance fields of structs in an unsafe context.  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Unsafe Code (C#)](../vs140/unsafe-code-and-pointers--csharp-programming-guide-.md)   
 [fixed Statement](../vs140/fixed-statement--csharp-reference-.md)   
 [Interoperability (C# Programming Guide)](../vs140/interoperability--csharp-programming-guide-.md)