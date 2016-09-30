---
title: "basic_string::max_size"
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
  - "std::basic_string::max_size"
  - "max_size"
  - "xstring/std::basic_string::max_size"
  - "std.basic_string.max_size"
  - "basic_string::max_size"
  - "basic_string.max_size"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "max_size method"
ms.assetid: d93cae80-b5dd-4a4a-8e7d-3e0029f5eadd
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::max_size
Returns the maximum number of characters a string could contain.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The maximum number of characters a string could contain.  
  
## Remarks  
 A exception of type [length_error Class](../vs140/length_error-class.md) is thrown when an operation produces a string with a length greater than the maximum size.  
  
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