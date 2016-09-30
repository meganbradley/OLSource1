---
title: "match_results::format"
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
  - "std.tr1.match_results.format"
  - "std::tr1::match_results::format"
  - "match_results.format"
  - "match_results::format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "format method [TR1]"
ms.assetid: bf21d6eb-ffdf-48bb-a387-543081b9d30f
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# match_results::format
Formats submatches.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The output iterator type.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The output stream to write to.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The format string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The format flags.  
  
## Remarks  
 Each member function generates formatted text under the control of the format <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The first member function writes the formatted text to the sequence defined by its argument <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The second member function returns a string object holding a copy of the formatted text.  
  
 To generate formatted text. literal text in the format string is ordinarily copied to the target sequence. Each escape sequence in the format string is replaced by the text that it represents. The details of the copying and replacement are controlled by the format flags passed to the function.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **prefix: matched == true, value == x**  
**whole match: 4 chars, value == caaa**  
**suffix: matched == true, value == y**  
**"c(a\*)&#124;(b)" matched "caaa"**  
**"(a\*)" matched "aaa"**  
**"(b)" matched ""**  
**submatch[0]: matched == true at position 1**  
 **4 chars, value == caaa**  
**submatch[1]: matched == true at position 2**  
 **3 chars, value == aaa**  
**submatch[2]: matched == false at position 6**  
 **0 chars, value ==**   
**next submatch: matched == true**  
 **4 chars, value == caaa**  
**next submatch: matched == true**  
 **3 chars, value == aaa**  
**next submatch: matched == false**  
 **0 chars, value ==**   
**\<caaa>**  
**empty == false**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [match_results](../vs140/match_results-class.md)   
 [Format Flags](../vs140/regular-expressions--c---.md)