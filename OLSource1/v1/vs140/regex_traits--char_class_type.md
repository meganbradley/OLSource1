---
title: "regex_traits::char_class_type"
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
  - "char_class_type"
  - "regex_traits::char_class_type"
  - "std.tr1.regex_traits.char_class_type"
  - "std::tr1::regex_traits::char_class_type"
  - "regex_traits.char_class_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "char_class_type typedef [TR1]"
ms.assetid: 7dea1125-d961-4a78-ba27-7dcc9bf95252
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::char_class_type
The type of character class designators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a synonym for an unspecified type that designates character classes. Values of this type can be combined using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator to designate character classes that are the union of the classes designated by the operands.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **translate('a') == 'a' == true**  
**nocase 'a' == 'A' == true**  
**length("abc") == 3**  
**transform("abc") < "abc" == false**  
**primary "ABC" < "abc" == false**  
**class digit == d == true**  
**'3' is digit == true**  
**hex C == 12**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_traits](../vs140/regex_traits-class.md)