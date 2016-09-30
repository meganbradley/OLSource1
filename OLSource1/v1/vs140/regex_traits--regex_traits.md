---
title: "regex_traits::regex_traits"
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
  - "regex_traits.regex_traits"
  - "regex_traits"
  - "std.tr1.regex_traits.regex_traits"
  - "regex_traits::regex_traits"
  - "std::tr1::regex_traits::regex_traits"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_traits constructor [TR1]"
ms.assetid: f18f03a8-bc56-4c23-a027-fb0cb3f379dc
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::regex_traits
Constructs the object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The constructor constructs an object whose stored <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object is initialized to the default locale.  
  
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