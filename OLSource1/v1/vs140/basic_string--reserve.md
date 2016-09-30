---
title: "basic_string::reserve"
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
  - "std.basic_string.reserve"
  - "basic_string::reserve"
  - "xstring/std::basic_string::reserve"
  - "std::basic_string::reserve"
  - "basic_string.reserve"
  - "reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve method"
ms.assetid: a5c686fb-9dcd-42c5-9b79-a1e281d6cfee
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::reserve
Sets the capacity of the string to a number at least as great as a specified number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of characters for which memory is being reserved.  
  
## Remarks  
 Having sufficient capacity is important because reallocations is a time-consuming process and invalidates all references, pointers, and iterators that refer to characters in a string.  
  
 The concept of capacity for objects of type strings is the same as for objects of type vector. Unlike vector, the member function **reserve** may be called to shrink the capacity of an object. The request is nonbinding and may or may not happen. As the default value for the parameter is zero, a call of **reserve** is a non-binding request to shrink the capacity of the string to fit the number of characters currently in the string. The capacity is never reduced below the current number of characters.  
  
 Calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the only possible way to shrink the capacity of a string. However, as noted above, this request is nonbinding and may not happen.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello world**  
**The current size of original string str1 is: 11.**  
**The capacity of original string str1 is: 15.**  
**The string str1with augmented capacity is: Hello world**  
**The current size of string str1 is: 11.**  
**The new capacity of string str1 is: 47.**  
**The string str1 with downsized capacity is: Hello world**  
**The current size of string str1 is: 11.**  
**The reduced capacity of string str1 is: 47.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)