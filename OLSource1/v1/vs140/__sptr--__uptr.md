---
title: "__sptr, __uptr"
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
  - "__uptr_cpp"
  - "__sptr"
  - "__uptr"
  - "__sptr_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "__sptr modifier"
  - "__uptr modifier"
ms.assetid: c7f5f3b2-9106-4a0b-a6de-d1588ab153ed
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# __sptr, __uptr
## Microsoft Specific  
 Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> modifier on a 32-bit pointer declaration to specify how the compiler converts a 32-bit pointer to a 64-bit pointer. A 32-bit pointer is converted, for example, when it is assigned to a 64-bit pointer variable or is dereferenced on a 64-bit platform.  
  
 Microsoft documentation for support of 64-bit platforms sometimes refers to the most significant bit of a 32-bit pointer as the sign bit. By default, the compiler uses sign extension to convert a 32-bit pointer to a 64-bit pointer. That is, the least significant 32 bits of the 64-bit pointer are set to the value of the 32-bit pointer and the most significant 32 bits are set to the value of the sign bit of the 32-bit pointer. This conversion yields correct results if the sign bit is 0, but not if the sign bit is 1. For example, the 32-bit address 0x7FFFFFFF yields the equivalent 64-bit address 0x000000007FFFFFFF, but the 32-bit address 0x80000000 is incorrectly changed to 0xFFFFFFFF80000000.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or signed pointer, modifier specifies that a pointer conversion set the most significant bits of a 64-bit pointer to the sign bit of the 32-bit pointer. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or unsigned pointer, modifier specifies that a conversion set the most significant bits to zero. The following declarations show the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> modifiers used with two unqualified pointers, two pointers qualified with the [__ptr32](../vs140/__ptr32--__ptr64.md) type, and a function parameter.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> modifiers with pointer declarations. Use the modifiers in the position of a [pointer type qualifier](../vs140/pointer-declarations.md), which means the modifier must follow the asterisk. You cannot use the modifiers with [pointers to members](../vs140/pointers-to-members.md). The modifiers do not affect non-pointer declarations.  
  
 If you do not use the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> modifier, and you enable [Compiler Warning (level 2) C4826](../vs140/compiler-warning--level-2--c4826.md), the compiler issues a warning when a 32-bit pointer is converted to 64 bits.  
  
## Example  
 The following example declares 32-bit pointers that use the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> modifiers, assigns each 32-bit pointer to a 64-bit pointer variable, and then displays the hexadecimal value of each 64-bit pointer. The example is compiled with the native 64-bit compiler and is executed on a 64-bit platform.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Display each 32-bit pointer (as an unsigned 64-bit pointer):**  
**p32d:       0000000087654321**  
**p32s:       0000000087654321**  
**p32u:       0000000087654321**  
**Display the 64-bit pointer created from each 32-bit pointer:**  
**p32d: p64 = FFFFFFFF87654321**  
**p32s: p64 = FFFFFFFF87654321**  
**p32u: p64 = 0000000087654321**   
## END Microsoft Specific  
  
## See Also  
 [Microsoft-Specific Modifiers](../vs140/microsoft-specific-modifiers.md)