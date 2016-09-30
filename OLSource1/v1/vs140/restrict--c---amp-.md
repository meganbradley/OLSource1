---
title: "restrict (C++ AMP)"
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
  - "cpu_CPP"
  - "amp_CPP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "restrict clause (C++ AMP)"
ms.assetid: 07d3291f-7edf-456b-8828-283ac8673661
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# restrict (C++ AMP)
The restriction specifier can be applied to function and lambda declarations. It enforces restrictions on the code in the function and on the behavior of the function in applications that use the C++ Accelerated Massive Parallelism (C++ AMP) runtime.  
  
> [!NOTE]
>  For information about the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword that is part of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> storage-class attributes, see [restrict](../vs140/restrict.md).  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause takes the following forms:  
  
|Clause|Description|  
|------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The function can use the full C++ language. Only other functions that are declared by using restrict(cpu) functions can call the function.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The function can only use the subset of the C++ language that C++ AMP can accelerate.|  
|A sequence of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.|The function must adhere to the limitations of both <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The function can be called by functions that are declared by using <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>,  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.\<br />\<br /> The form <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> can be written as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
## Remarks  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keyword is a contextual keyword. The restriction specifiers, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> are not reserved words. The list of specifiers is not extensible. A function that does not have a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> clause is the same as a function that has the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> clause.  
  
 A function that has the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> clause has the following limitations:  
  
-   The function can call only functions that have the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> clause.  
  
-   The function must be inlinable.  
  
-   The function can declare only <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> variables, and classes and structures that contain only these types. <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is also allowed, but it must be 4-byte-aligned if you use it in a compound type.  
  
-   Lambda functions cannot capture by reference and cannot capture pointers.  
  
-   References and single-indirection pointers are supported only as local variables, function arguments, and return types.  
  
-   The following are not allowed:  
  
    -   Recursion.  
  
    -   Variables declared with the [volatile](../vs140/volatile--c---.md) keyword.  
  
    -   Virtual functions.  
  
    -   Pointers to functions.  
  
    -   Pointers to member functions.  
  
    -   Pointers in structures.  
  
    -   Pointers to pointers.  
  
    -   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statements.  
  
    -   Labeled statements.  
  
    -   <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> statements.  
  
    -   Global variables.  
  
    -   Static variables. Use [tile_static](../vs140/tile_static-keyword.md) instead.  
  
    -   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> casts.  
  
    -   The <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> operator.  
  
    -   asm declarations.  
  
    -   Varargs.  
  
 For a discussion of function limitations, see [restrict(amp) Restrictions](http://go.microsoft.com/fwlink/p/?LinkId=251089).  
  
## Example  
 The following example shows how to use the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>clause.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [C++ Accelerated Massive Parallelism (C++ AMP)](../vs140/c---amp--c---accelerated-massive-parallelism-.md)