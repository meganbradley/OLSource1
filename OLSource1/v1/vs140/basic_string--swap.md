---
title: "basic_string::swap"
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
  - "basic_string.swap"
  - "xstring/std::basic_string::swap"
  - "std::basic_string::swap"
  - "swap"
  - "std.basic_string.swap"
  - "basic_string::swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap method"
ms.assetid: 94d726c3-b308-4470-9c84-6d723549c88e
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::swap
Exchange the contents of two strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The source string whose elements are to be exchanged with those in the destination string.  
  
## Remarks  
 If the strings being swapped have the same allocator object, the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member function:  
  
-   Occurs in constant time.  
  
-   Throws no exceptions.  
  
-   Invalidates no references, pointers, or iterators that designate elements in the two strings.  
  
 Otherwise, it performs a number of element assignments and constructor calls proportional to the number of elements in the two controlled sequences.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Before swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledee.**  
 **The basic_string s2 = Tweedledum.**  
**After swapping string s1 and s2:**  
 **The basic_string s1 = Tweedledum.**  
 **The basic_string s2 = Tweedledee.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)