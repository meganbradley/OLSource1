---
title: "basic_string::end"
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
  - "xstring/std::basic_string::end"
  - "std::basic_string::end"
  - "basic_string.end"
  - "end"
  - "std.basic_string.end"
  - "basic_string::end"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "end method"
ms.assetid: 8a40e6ac-99b8-4a3a-83de-fffb05215e04
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::end
Returns an iterator that addresses the location succeeding the last element in a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a random-access iterator that addresses the location succeeding the last element in a string.  
  
## Remarks  
 **end** is often used to test whether an iterator has reached the end of its string. The value returned by **end** should not be dereferenced.  
  
 If the return value of **end** is assigned to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the string object cannot be modified. If the return value of **end** is assigned to an **iterator**, the string object can be modified.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The last character-letter of the string str1 is: t**  
**The full orginal string str1 is: No way out.**  
**The string is now: No way out.**  
**The last character-letter of the modified str1 is now: T**  
**The modified string str1 is now: No way ouT.**  
**The string str2 is empty.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)