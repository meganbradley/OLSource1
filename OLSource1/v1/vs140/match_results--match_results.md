---
title: "match_results::match_results"
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
  - "std::tr1::match_results::match_results"
  - "match_results::match_results"
  - "std.tr1.match_results.match_results"
  - "match_results.match_results"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "match_results constructor [TR1]"
ms.assetid: dbbd82c3-577b-49e2-8563-5805f4ef6430
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# match_results::match_results
Constructs the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The allocator object to store.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The match_results object to copy.  
  
## Remarks  
 The first constructor constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object that holds no submatches. The second constructor constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that is a copy of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
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