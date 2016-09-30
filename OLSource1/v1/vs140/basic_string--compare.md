---
title: "basic_string::compare"
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
  - "Compare"
  - "std.basic_string.compare"
  - "basic_string.compare"
  - "std::basic_string::compare"
  - "basic_string::compare"
  - "xstring/std::basic_string::compare"
  - "compare"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compare method"
ms.assetid: 5c719d5c-93b1-4ea8-bbd3-80c2745b5c73
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::compare
Performs a case sensitive comparison with a specified string to determine if the two strings are equal or if one is lexicographically less than the other.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string that is to be compared to the operand string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the operand string at which the comparison begins.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum number of characters from the operand string to be compared.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum number of characters from the parameter string to be compared.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The index of the parameter string at which the comparison begins.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The maximum number of characters from the parameter string to be compared.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The C-string to be compared to the operand string.  
  
## Return Value  
 A negative value if the operand string is less than the parameter string; zero if the two strings are equal; or a positive value if the operand string is greater than the parameter string.  
  
## Remarks  
 The **compare** member functions compare either all or part of the parameter and operand strings depending on which in used.  
  
 The comparison performed is case sensitive.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand string is: CAB**  
**The parameter string is: CAB**  
**The operand string is equal to the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter string.**  
**The first three characters of the operand string**  
 **are less than the parameter string.**  
**The operand string is: AACAB**  
**The parameter string is: DCABD**  
**The three characters from position 2 of the operand string are equal to**  
 **the 3 characters parameter string from position 1.**  
**The operand string is: ABC**  
**The parameter C-string is: DEF**  
**The operand string is less than the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter string is: CAB**  
**The last three characters of the operand string**  
 **are equal to the parameter C-string.**  
**The operand string is: AACAB**  
**The parameter C-string is: ACAB**  
**The 3 characters from position 2 of the operand string are equal to**  
 **the first 3 characters of the parameter C-string.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)