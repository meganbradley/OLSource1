---
title: "basic_string::basic_string"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.basic_string.basic_string"
  - "basic_string.basic_string"
  - "std::basic_string::basic_string"
  - "basic_string::basic_string"
  - "basic_string"
  - "xstring/std::basic_string::basic_string"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_string method"
  - "basic_string class, constructor"
ms.assetid: efd3bec9-e7a5-4527-9ba6-7d5054bdb9f1
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::basic_string
Constructs a string that is empty, initialized by specific characters, or is a copy of all or part of another string object or C style (null-terminated) string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The C-string whose characters are to be used to initialize the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> being constructed. This value cannot be a null pointer.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The storage allocator class for the string object being constructed.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The number of characters to be initialized.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The string to initialize the string being constructed.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The index of a character in a string that is the first to be used to initialize character values for the string being constructed.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The character value to be copied into the string being constructed.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the first element in the source range to be inserted.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 An input iterator, const_pointer, or const_iterator addressing the position of the one beyond the last element in the source range to be inserted.  
  
## Return Value  
 A reference to the string object that is being constructed by the constructors.  
  
## Remarks  
 All constructors store an [basic_string::allocator_type](../vs140/basic_string--allocator_type.md) and initialize the controlled sequence. The allocator object is the argument <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, if present. For the copy constructor, it is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>[get_allocator](../vs140/basic_string--get_allocator.md)<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Otherwise, it is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 The controlled sequence is initialized to a copy of the operand sequence specified by the remaining operands. A constructor without an operand sequence specifies an empty initial controlled sequence. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is an integer type in a template constructor, the operand sequence _F<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> behaves the same as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [\<string>](../vs140/-string-.md)   
 [Lvalues and Rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)