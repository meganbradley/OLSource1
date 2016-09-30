---
title: "match_results::suffix"
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
  - "match_results::suffix"
  - "match_results.suffix"
  - "std.tr1.match_results.suffix"
  - "std::tr1::match_results::suffix"
  - "suffix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "suffix method [TR1]"
ms.assetid: 02b2caf8-b72f-4247-9fe2-d7b849761e88
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# match_results::suffix
Gets sequence after last submatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a reference to an object of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that points to the character sequence that begins at <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and ends at the end of the target sequence, that is, it points to the text that follows the matched subsequence.  
  
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