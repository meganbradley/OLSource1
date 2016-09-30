---
title: "match_results::operator"
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
  - "match_results.operator[]"
  - "match_results::operator[]"
  - "std.tr1.match_results.operator[]"
  - "std::tr1::match_results::operator[]"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator[] operator [TR1]"
ms.assetid: 7862ce99-df94-4db8-ad02-11dde9b153bb
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# match_results::operator
Access a subobject.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Index of the submatch.  
  
## Remarks  
 The member function returns a reference to element <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the controlled sequence, or a reference to an empty <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or if capture group <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> was not part of the match.  
  
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