---
title: "regex_iterator::operator="
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
  - "std::tr1::regex_iterator::operator="
  - "regex_iterator::operator="
  - "std.tr1.regex_iterator.operator="
  - "regex_iterator.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator= operator [TR1]"
ms.assetid: 01bd872c-28f8-4eb6-8aac-c7a2bda743e0
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_iterator::operator=
Compares iterators for equality.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The iterator to compare to.  
  
## Remarks  
 The member function returns true if <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are both end-of-sequence iterators or if neither is an end-of-sequence iterator and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Otherwise it returns false.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **match == a**  
**match == a**  
**match == a**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)   
 [regex_iterator::operator_ne](../vs140/regex_iterator--operator!=.md)