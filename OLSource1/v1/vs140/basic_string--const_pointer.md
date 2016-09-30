---
title: "basic_string::const_pointer"
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
  - "std.basic_string.const_pointer"
  - "xstring/std::basic_string::const_pointer"
  - "basic_string.const_pointer"
  - "std::basic_string::const_pointer"
  - "const_pointer"
  - "basic_string::const_pointer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "const_pointer typedef"
  - "const_pointer method"
ms.assetid: 98a58d6f-d97b-4eb0-b408-5dcf7439cf49
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::const_pointer
A type that provides a pointer to a **const** element in a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for **allocator_type::const_pointer**.  
  
 For type **string**, it is equivalent to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>*.  
  
 Pointers that are declared const must be initialized when they are declared. Const pointers always point to the same memory location and may point to constant or nonconstant data.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The string pstr1a is: In Here.**  
**The C-string cstr1c is: Out There.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)