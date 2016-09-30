---
title: "C Bit Fields"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "bitfields"
  - "bit fields"
ms.assetid: 9faf74c4-7fd5-4b44-ad18-04485193d06e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C Bit Fields
In addition to declarators for members of a structure or union, a structure declarator can also be a specified number of bits, called a "bit field." Its length is set off from the declarator for the field name by a colon. A bit field is interpreted as an integral type.  
  
## Syntax  
 *struct-declarator*:  
 *declarator*  
  
 *type-specifier declarator* opt**:** *constant-expression*  
  
 The *constant-expression* specifies the width of the field in bits. The *type-specifier* for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, **signed int**, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and the *constant-expression* must be a nonnegative integer value. If the value is zero, the declaration has no <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Arrays of bit fields, pointers to bit fields, and functions returning bit fields are not allowed. The optional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> names the bit field. Bit fields can only be declared as part of a structure. The address-of operator (**&**) cannot be applied to bit-field components.  
  
 Unnamed bit fields cannot be referenced, and their contents at run time are unpredictable. They can be used as "dummy" fields, for alignment purposes. An unnamed bit field whose width is specified as 0 guarantees that storage for the member following it in the *struct-declaration-list* begins on an <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> boundary.  
  
 Bit fields must also be long enough to contain the bit pattern. For example, these two statements are not legal:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This example defines a two-dimensional array of structures named <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The array contains 2,000 elements. Each element is an individual structure containing four bit-field members: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. The size of each structure is two bytes.  
  
 Bit fields have the same semantics as the integer type. This means a bit field is used in expressions in exactly the same way as a variable of the same base type would be used, regardless of how many bits are in the bit field.  
  
 **Microsoft Specific**  
  
 Bit fields defined as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> are treated as signed. A Microsoft extension to the ANSI C standard allows <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and **long** types (both **signed** and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) for bit fields. Unnamed bit fields with base type **long**, **short**, or <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> (**signed** or <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) force alignment to a boundary appropriate to the base type.  
  
 Bit fields are allocated within an integer from least-significant to most-significant bit. In the following code  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 the bits would be arranged as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Since the 8086 family of processors stores the low byte of integer values before the high byte, the integer <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> above would be stored in physical memory as <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> followed by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Structure Declarations](../vs140/structure-declarations.md)