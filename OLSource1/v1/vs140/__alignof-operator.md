---
title: "__alignof Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "__alignof"
  - "alignof"
  - "alignas"
  - "__alignof_cpp"
  - "alignof_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "alignas"
  - "alignment of structures"
  - "__alignof keyword [C++]"
  - "alignof"
  - "types [C++], alignment requirements"
ms.assetid: acb1eed7-6398-40bd-b0c5-684ceb64afbc
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __alignof Operator
C++11 introduces the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator that returns the alignment, in bytes, of the specified type. For maximum portability, you should use the alignof operator instead of the Microsoft-specific __alignof operator.  
  
 **Microsoft Specific**  
  
 Returns a value of type **size_t** that is the alignment requirement of the type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 For example:  
  
|Expression|Value|  
|----------------|-----------|  
|**__alignof( char )**|1|  
|**__alignof( short )**|2|  
|**__alignof( int )**|4|  
|**__alignof( \__int64 )**|8|  
|**__alignof( float )**|4|  
|**__alignof( double )**|8|  
|**__alignof( char\* )**|4|  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value is the same as the value for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for basic types. Consider, however, this example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 In this case, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value is the alignment requirement of the largest element in the structure.  
  
 Similarly, for  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is equal to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 One use for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> would be as a parameter to one of your own memory-allocation routines. For example, given the following defined structure <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, you could call a memory-allocation routine named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to allocate memory on a particular alignment boundary.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 For more information on modifying alignment, see:  
  
-   [pack](../vs140/pack.md)  
  
-   [align](../vs140/align--c---.md)  
  
-   [__unaligned](../vs140/__unaligned.md)  
  
-   [/Zp (Struct Member Alignment)](../vs140/-zp--struct-member-alignment-.md)  
  
-   [Structure Alignment Examples](../vs140/examples-of-structure-alignment.md) (x64 specific)  
  
 For more information on differences in alignment in code for x86 and x64, see:  
  
-   [Conflicts with the x86 Compiler](../vs140/conflicts-with-the-x86-compiler.md)  
  
## END Microsoft Specific  
  
## See Also  
 [Expressions with Unary Operators](../vs140/expressions-with-unary-operators.md)   
 [Keywords](../vs140/keywords--c---.md)