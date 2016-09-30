---
title: "basic_string::capacity"
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
  - "capacity"
  - "basic_string::capacity"
  - "std::basic_string::capacity"
  - "basic_string.capacity"
  - "std.basic_string.capacity"
  - "xstring/std::basic_string::capacity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "capacity method"
ms.assetid: 533c989d-74a4-4da3-bd89-61302b5dd45b
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::capacity
Returns the largest number of elements that could be stored in a string without increasing the memory allocation of the string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The size of storage currently allocated in memory to hold the string.  
  
## Remarks  
 The member function returns the storage currently allocated to hold the controlled sequence, a value at least as large as [size](../vs140/basic_string--size.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Sample Output  
 The following output is for x86.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)