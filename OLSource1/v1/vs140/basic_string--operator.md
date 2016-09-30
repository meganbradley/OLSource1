---
title: "basic_string::operator"
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
  - "xstring/std::basic_string::operator[]"
  - "[]"
  - "basic_string::operator[]"
  - "operator[]"
  - "std::basic_string::operator[]"
  - "std.basic_string.operator[]"
  - "basic_string.operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator []"
  - "[] operator, with specific standard C++ objects"
  - "operator[], strings"
  - "operator[]"
  - "operator [], strings"
ms.assetid: 1907e077-6848-40bb-a6f7-2f6ba6439ee9
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::operator
Provides a reference to the character with a specified index in a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the position of the element to be referenced.  
  
## Return Value  
 A reference to the character of the string at the position specified by the parameter index.  
  
## Remarks  
 The first element of the string has an index of zero, and the following elements are indexed consecutively by the positive integers, so that a string of length *n* has an *n*th element indexed by the number *n* - 1.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is faster than the member function [at](../vs140/basic_string--at.md) for providing read and write access to the elements of a string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not check whether the index passed as a parameter is valid, but the member function **at** does and so should be used in the validity is not certain. An invalid index (an index less that zero or greater than or equal to the size of the string) passed to the member function **at** throws an [out_of_range Class](../vs140/out_of_range-class.md) exception. An invalid index passed to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> results in undefined behavior, but the index equal to the length of the string is a valid index for const strings and the operator returns the null character when passed this index.  
  
 The reference returned may be invalidated by string reallocations or modifications for the non-**const** strings.  
  
 When compiling with _SECURE_SCL 1, a runtime error will occur if you attempt to access an element outside the bounds of the string.  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)