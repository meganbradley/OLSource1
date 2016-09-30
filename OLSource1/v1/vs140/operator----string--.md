---
title: "operator+ (&lt;string&gt;)"
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
  - "std::operator+"
  - "+"
  - "operator+"
  - "std.operator+"
  - "string/std::operator+"
  - "std.+"
  - "std::+"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operators [C++], concatenation"
  - "operator+, strings"
  - "+ operator"
  - "operator +, strings"
  - "concatenation operators, syntax"
  - "strings [C++], concatenating"
ms.assetid: b298125f-de72-4c36-a16d-0065a0802c6c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator+ (&lt;string&gt;)
Concatenates two string objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be concatenated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A C-style string or an object of type <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to be concatenated.  
  
## Return Value  
 The string that is the concatenation of the input strings.  
  
## Remarks  
 The functions each overload <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to concatenate two objects of template class [basic_string Class](../vs140/basic_string-class.md). All effectively return <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>\<**CharType**, **Traits**, **Allocator**>(_*Left*).[append](../vs140/basic_string--append.md)(\_*Right*).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The basic_string s1 = anti.**  
**The basic_string s2 = gravity.**  
**The C-style string s3 = heroine.**  
**The character constant c1 = !.**  
**The string concatenating s1 & s2 is: antigravity**  
**The string concatenating s1 & s3 is: antiheroine**  
**The string concatenating s1 & s3 is: antiheroine!**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)   
 [\<string>](../vs140/-string-.md)   
 [string::operator+](../vs140/string--operator-.md)