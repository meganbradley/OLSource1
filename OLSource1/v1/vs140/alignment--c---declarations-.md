---
title: "Alignment (C++ Declarations)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
ms.assetid: a986d510-ccb8-41f8-b905-433df9183485
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Alignment (C++ Declarations)
One of the low-level features of C++ is the ability to specify the precise alignment of objects in memory to take maximum advantage of a specific hardware architecture. By default, the compiler aligns class and struct members on their size value: bool and char are aligned one one byte boundaries, short on two byte, int on four bytes, long long, double and long double on eight bytes. In most scenarios you never have to be concerned with alignment because the default alignment is already optimal. In some cases however, you can achieve significant performance improvements, or memory savings, by specifying a custom alignment for your data structures. Prior to Visual Studio 2015 you could use the Microsoft-specific keywords __alignof and declspec(alignas) to specify an alignment greater than the default. Starting in Visual Studio 2015 you should use the C++11 standard keywords [alignof and alignas (C++)](../vs140/alignof-and-alignas--c---.md) for maximum code portability. The new keywords behave in the same way under the hood as the Microsoft-specific extensions, and the documentation for those extensions also applies to the new keywords. See [__alignof Operator](../vs140/__alignof-operator.md) and [align (C++)](../vs140/align--c---.md) for more information. The C++ standard does not specify packing behavior for aligning on boundaries smaller than the compiler default for the target platform, so you still need to use the Microsoft #pragma [pack](../vs140/pack.md) in that case.  
  
 The C++ standard library provides the [aligned_storage Class](../vs140/aligned_storage-class.md) for allocating memory for data structures with custom alignments, and the [aligned_union Class](../vs140/aligned_union-class.md) for specifying alignment for unions with non-trivial constructors or destructors.  
  
## About Alignment  
 Alignment is a property of a memory address, expressed as the numeric address modulo a power of 2. For example, the address 0x0001103F modulo 4 is 3; that address is said to be aligned to 4n+3, where 4 indicates the chosen power of 2. The alignment of an address depends on the chosen power of two. The same address modulo 8 is 7. An address is said to be aligned to X if its alignment is Xn+0.  
  
 CPUs execute instructions that operate on data stored in memory, and the data are identified by their addresses in memory. In addition to its address, a single datum also has a size. A datum is called naturally aligned if its address is aligned to its size, and misaligned otherwise. For example, an 8-byte floating-point datum is naturally aligned if the address used to identify it is aligned to 8.  
  
 Compiler handling of data alignmentDevice compilers attempt to allocate data in a way that prevents data misalignment.  
  
 For simple data types, the compiler assigns addresses that are multiples of the size in bytes of the data type. Thus, the compiler assigns addresses to variables of type long that are multiples of four, setting the bottom two bits of the address to zero.  
  
 In addition, the compiler pads structures in a way that naturally aligns each element of the structure. Consider the structure struct x_ in the following code example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The compiler pads this structure to enforce alignment naturally.  
  
 The following code example shows how the compiler places the padded structure in memory:Copy  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
1.  Both declarations return sizeof(struct x_) as 12 bytes.  
  
2.  The second declaration includes two padding elements:  
  
3.  char _pad0[3] to align the int b member on a four-byte boundary  
  
4.  char _pad1[1] to align the array elements of the structure struct _x bar[3];  
  
5.  The padding aligns the elements of bar[3] in a way that allows natural access.  
  
 The following code example shows the bar[3] array layout:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Data Structure Alignment](http://en.wikipedia.org/wiki/Data_structure_alignment)