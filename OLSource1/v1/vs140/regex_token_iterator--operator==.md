---
title: "regex_token_iterator::operator=="
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
  - "regex_token_iterator.operator=="
  - "regex_token_iterator::operator=="
  - "std.tr1.regex_token_iterator.operator=="
  - "std::tr1::regex_token_iterator::operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator== operator [TR1]"
ms.assetid: 9164ca0d-825e-43f7-b2a6-02bf35269801
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator::operator==
Compares iterators for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 right  
 The iterator to compare to.  
  
## Remarks  
 The member function returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
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