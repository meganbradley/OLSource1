---
title: "basic_string::replace"
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
  - "replace"
  - "std::basic_string::replace"
  - "basic_string::replace"
  - "xstring/std::basic_string::replace"
  - "std.basic_string.replace"
  - "basic_string.replace"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "replace method"
ms.assetid: 16d81b9d-9724-458a-9179-556748034507
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_string::replace
Replaces elements in a string at a specified position with specified characters or characters copied from other ranges or strings or C-strings.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The string that is to be a source of characters for the operand string.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The index of the operand string at which the replacement begins.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The maximum number of characters to be replaced in the operand string.  
  
 *_Pos2*  
 The index of the parameter string at which the copying begins.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The maximum number of characters to be used from the parameter C-string.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The C-string that is to be a source of characters for the operand string.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The character to be copied into the operand string.  
  
 *_First0*  
 An iterator addressing the first character to be removed in the operand string.  
  
 *_Last0*  
 An iterator addressing the last character to be removed in the operand string.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An iterator, const_pointer, or const_iterator addressing the first character to be copied in the parameter string.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An iterator, const_pointer, or const_iterator addressing the last character to be copied in the parameter string.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The number of times <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is copied into the operand string.  
  
## Return Value  
 The operand string with the replacement made.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The operand string s1o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs1p is: CCC**  
**The result of s1o.replace ( 1 , 3 , s1p )**  
 **is the string: ABBBAAAA.**  
**The result of s1o.replace ( 5 , 3 , cs1p )**  
 **is the string: ABBBACCC.**  
**The operand string s2o is: AAAAAAAA**  
**The parameter string s1p is: BBB**  
**The parameter C-string cs2p is: CCC**  
**The result of s2o.replace (1, 3, s2p, 1, 2)**  
 **is the string: ABBAAAA.**  
**The result of s2o.replace (4 ,3 ,cs2p)**  
 **is the string: ABBAC.**  
**The operand string s3o is: AAAAAAAA**  
**The parameter character c1p is: C**  
**The result of s3o.replace(1, 3, 4, ch3p)**  
 **is the string: ACCCCAAAA.**  
**The operand string s4o is: AAAAAAAA**  
**The parameter string s4p is: BBB**  
**The parameter C-string cs4p is: CCC**  
**The result of s1o.replace (IterF0, IterL0, s4p)**  
 **is the string: BBBAAAAA.**  
**The result of s4o.replace (IterF0, IterL0, cs4p)**  
 **is the string: CCCAAAAA.**  
**The operand string s5o is: AAAAAAAF**  
**The parameter C-string cs5p is: CCCBB**  
**The result of s5o.replace (IterF1, IterL1, cs4p ,4)**  
 **is the string: CCCBAAAF.**  
**The operand string s6o is: AAAAAAAG**  
**The parameter character ch6p is: q**  
**The result of s6o.replace (IterF1, IterL1, 4, ch6p)**  
 **is the string: qqqqAAAAG.**  
**The operand string s7o is: OOOOOOO**  
**The parameter string s7p is: PPPP**  
**The result of s7o.replace (IterF3 ,IterL3 ,IterF4 ,IterL4)**  
 **is the string: OPPOOOO.**   
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [basic_string Class](../vs140/basic_string-class.md)