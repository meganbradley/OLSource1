---
title: "basic_string::resize"
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
  - "std.basic_string.resize"
  - "Resize"
  - "std::basic_string::resize"
  - "basic_string.resize"
  - "resize"
  - "xstring/std::basic_string::resize"
  - "basic_string::resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "resize method"
ms.assetid: 973e71c3-100e-4798-a907-fe5bb0c909bb
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::resize
Specifies a new size for a string, appending or erasing elements as required.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The new size of the string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value that appended characters are initialized with if additional elements are required.  
  
## Remarks  
 If the resulting size exceeds the maximum number of characters, the form throws <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The original string str1 is: Hello world**  
**The current size of original string str1 is: 11.**  
**The capacity of original string str1 is: 15.**  
**The resized string str1 is: Hello world!!**  
**The current size of resized string str1 is: 13.**  
**The capacity of resized string str1 is: 15.**  
**The resized string str1 is: Hello world!!**   
**The current size of modified string str1 is: 33.**  
**The capacity of modified string str1 is: 47.**  
**The downsized string str1 is: Hello**  
**The current size of downsized string str1 is: 5.**  
**The capacity of downsized string str1 is: 47.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [basic_string::size and basic_string::resize](../vs140/basic_string--size-and-basic_string--resize.md)