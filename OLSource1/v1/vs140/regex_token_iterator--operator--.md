---
title: "regex_token_iterator::operator-&gt;"
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
  - "std::tr1::regex_token_iterator::operator->"
  - "regex_token_iterator.operator->"
  - "std.tr1.regex_token_iterator.operator->"
  - "regex_token_iterator::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator-> operator [TR1]"
ms.assetid: 4a38bd4d-91b6-4887-90f0-399dfedc3857
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator::operator-&gt;
Accesses the designated submatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member function returns a pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object representing the capture group identified by the index value <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == aa**  
**match == aa**  
**match == aa**  
**match ==**   
**match == x**  
**match == y**  
**match == z**  
**match == a**  
**match == a**  
**match == a**  
**match ==**   
**match == a**  
**match == x**  
**match == a**  
**match == y**  
**match == a**  
**match == z**  
**match ==**   
**match == aa**  
**match == x**  
**match == aa**  
**match == y**  
**match == aa**  
**match == z**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)   
 [regex_token_iterator::operator_st](../vs140/regex_token_iterator--operator-.md)