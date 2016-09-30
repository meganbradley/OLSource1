---
title: "match_results::size_type"
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
  - "std::tr1::match_results::size_type"
  - "std.tr1.match_results.size_type"
  - "size_type"
  - "match_results.size_type"
  - "match_results::size_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "size_type typedef [TR1]"
ms.assetid: 3d2ccda9-460c-4d14-b5ee-d389d8e8bad6
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# match_results::size_type
The type of a submatch count.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for the type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
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