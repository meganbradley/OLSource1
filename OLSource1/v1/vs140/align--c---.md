---
title: "align (C++)"
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
  - "align"
  - "align_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "align __declspec keyword"
  - "__declspec keyword [C++], align"
ms.assetid: 9cb63f58-658b-4425-ac47-af8eabfc5878
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# align (C++)
In Visual Studio 2015 and later, use the C++11 standard <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> specifier to control alignment. For more information, see [Alignment (C++ Declarations)](../vs140/alignment--c---declarations-.md).  
  
 **Microsoft Specific**  
  
 Use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to precisely control the alignment of user-defined data (for example, static allocations or automatic data in a function).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Writing applications that use the latest processor instructions introduces some new constraints and issues. In particular, many new instructions require that data must be aligned to 16-byte boundaries. Additionally, by aligning frequently used data to the cache line size of a specific processor, you improve cache performance. For example, if you define a structure whose size is less than 32 bytes, you may want to align it to 32 bytes to make sure that objects of that structure type are efficiently cached.  
  
 \# is the alignment value. Valid entries are integer powers of two from 1 to 8192 (bytes), such as 2, 4, 8, 16, 32, or 64. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is the data that you are declaring as aligned.  
  
 For information about how to return a value of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> that is the alignment requirement of the type, see [__alignof](../vs140/__alignof-operator.md). For information about how to declare unaligned pointers when targeting 64-bit processors, see [__unaligned](../vs140/__unaligned.md).  
  
 You can use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> when you define a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, or when you declare a variable.  
  
 The compiler does not guarantee or attempt to preserve the alignment attribute of data during a copy or data transform operation. For example, [memcpy](../vs140/memcpy--wmemcpy.md) can copy a struct declared with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> to any location. Note that ordinary allocators—for example, [malloc](../vs140/malloc.md), C++ [operator new](../vs140/operator-new---new--.md), and the Win32 allocators—return memory that is usually not sufficiently aligned for <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> structures or arrays of structures. To guarantee that the destination of a copy or data transformation operation is correctly aligned, use [_aligned_malloc](../vs140/_aligned_malloc.md), or write your own allocator.  
  
 You cannot specify alignment for function parameters. When data that has an alignment attribute is passed by value on the stack, its alignment is controlled by the calling convention. If data alignment is important in the called function, copy the parameter into correctly aligned memory before use.  
  
 Without <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, Visual C++ generally aligns data on natural boundaries based on the target processor and the size of the data, up to 4-byte boundaries on 32-bit processors, and 8-byte boundaries on 64-bit processors. Data in classes or structures is aligned in the class or structure at the minimum of its natural alignment and the current packing setting (from #pragma <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or the **/Zp** compiler option).  
  
 This example demonstrates the use of <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 This type now has a 32-byte alignment attribute. This means that all static and automatic instances start on a 32-byte boundary. Additional structure types declared with this type as a member preserve this type's alignment attribute, that is, any structure with <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> as an element will have an alignment attribute of at least 32.  
  
 Note that <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is equal to 32. This implies that if an array of Str1 objects is created, and the base of the array is 32-byte aligned, each member of the array is also 32-byte aligned. To create an array whose base is correctly aligned in dynamic memory, use [_aligned_malloc](../vs140/_aligned_malloc.md), or write your own allocator.  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> value for any structure is the offset of the final member, plus that member's size, rounded up to the nearest multiple of the largest member alignment value or the whole structure alignment value, whichever is larger.  
  
 The compiler uses these rules for structure alignment:  
  
-   Unless overridden with <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, the alignment of a scalar structure member is the minimum of its size and the current packing.  
  
-   Unless overridden with <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the alignment of a structure is the maximum of the individual alignments of its member(s).  
  
-   A structure member is placed at an offset from the start of its parent structure which is the smallest multiple of its alignment greater than or equal to the offset of the end of the previous member.  
  
-   The size of a structure is the smallest multiple of its alignment greater than or equal to the offset of the end of its last member.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> can only increase alignment restrictions.  
  
 For more information, see:  
  
-   [align Examples](#vclrfalignexamples)  
  
-   [Defining New Types with __declspec(align(#))](#vclrf_declspecaligntypedef)  
  
-   [Aligning Data in Thread Local Storage](#vclrfthreadlocalstorageallocation)  
  
-   [How align Works with Data Packing](#vclrfhowalignworkswithdatapacking)  
  
-   [Structure Alignment Examples](../vs140/examples-of-structure-alignment.md) (x64 specific)  
  
##  \<a name="vclrfalignexamples">\</a> align Examples  
 The following examples show how <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> affects the size and alignment of data structures. The examples assume the following definitions:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In this example, the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> structure is defined by using <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. All uses of <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> for a variable definition or in other type declarations are 32-byte aligned. <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> returns 32, and <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> has 16 padding bytes following the 16 bytes required to hold the four integers. Each <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> member requires 4-byte alignment, but the alignment of the structure itself is declared to be 32. Therefore, the overall alignment is 32.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 In this example, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> returns 16, which is exactly the sum of the member sizes, because that is a multiple of the largest alignment requirement (a multiple of 8).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 In the following example, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> returns 64.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 In this example, notice that <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> has the alignment of its natural type, in this case, 4 bytes. However, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> must be 32-byte aligned. Twenty-eight bytes of padding follow <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, so that <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> starts at offset 32. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> then inherits the alignment requirement of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, because it is the largest alignment requirement in the structure. <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> returns 64.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The following three variable declarations also use <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>. In each case, the variable must be 32-byte aligned. In the case of the array, the base address of the array, not each array member, is 32-byte aligned. The <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> value for each array member is not affected when you use <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To align each member of an array, code such as this should be used:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 In this example, notice that aligning the structure itself and aligning the first element have the same effect:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> have identical alignment, allocation, and size characteristics.  
  
 In this example, the alignment of the starting addresses of a, b, c, and d are 4, 1, 4, and 1, respectively.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The alignment when memory is allocated on the heap depends on which allocation function is called.  For example, if you use <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, the result depends on the operand size. If *arg* >= 8, the memory returned is 8 byte aligned. If *arg* < 8, the alignment of the memory returned is the first power of 2 less than *arg*. For example, if you use malloc(7), the alignment is 4 bytes.  
  
##  \<a name="vclrf_declspecaligntypedef">\</a> Defining New Types with __declspec(align(#))  
 You can define a type with an alignment characteristic.  
  
 For example, you can define a <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> with an alignment value this way:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Now, <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> are the same size (8 bytes) but variables of type <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> will be 32-byte aligned.  
  
##  \<a name="vclrfthreadlocalstorageallocation">\</a> Aligning Data in Thread Local Storage  
 Static thread-local storage (TLS) created with the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> attribute and put in the TLS section in the image works for alignment exactly like normal static data. To create TLS data, the operating system allocates memory the size of the TLS section and respects the TLS section alignment attribute.  
  
 This example shows various ways to place aligned data into thread local storage.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
##  \<a name="vclrfhowalignworkswithdatapacking">\</a> How align Works with Data Packing  
 The **/Zp** compiler option and the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> pragma have the effect of packing data for structure and union members. This example shows how **/Zp** and <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> work together:  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The following table lists the offset of each member under a variety of **/Zp** (or #pragma <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>) values, showing how the two interact.  
  
|Variable|/Zp1|/Zp2|/Zp4|/Zp8|  
|--------------|-----------|-----------|-----------|-----------|  
|a|0|0|0|0|  
|b|1|2|2|2|  
|c|3|4|4|8|  
|d|32|32|32|32|  
|e|40|40|40|40|  
|f|41|42|44|48|  
|sizeof(S)|64|64|64|64|  
  
 For more information, see [/Zp (Struct Member Alignment)](../vs140/-zp--struct-member-alignment-.md).  
  
 The offset of an object is based on the offset of the previous object and the current packing setting, unless the object has a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> attribute, in which case the alignment is based on the offset of the previous object and the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> value for the object.  
  
### END Microsoft Specific  
  
## See Also  
 [__declspec](../vs140/__declspec.md)   
 [Overview of ARM ABI Conventions](../vs140/overview-of-arm-abi-conventions.md)   
 [x64 Calling Conventions](../vs140/overview-of-x64-calling-conventions.md)