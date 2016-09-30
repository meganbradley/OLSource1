---
title: "regex_token_iterator::value_type"
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
  - "std.tr1.regex_token_iterator.value_type"
  - "regex_token_iterator.value_type"
  - "std::tr1::regex_token_iterator::value_type"
  - "regex_token_iterator::value_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value_type typedef [TR1]"
ms.assetid: 4d562292-c9d1-4936-b26c-b1a9b85d9960
caps.latest.revision: 21
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_token_iterator::value_type
The type of a submatch.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is the template parameter.  
  
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