---
title: "regex_traits::locale_type"
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
  - "std::tr1::regex_traits::locale_type"
  - "std.tr1.regex_traits.locale_type"
  - "locale_type"
  - "regex_traits.locale_type"
  - "regex_traits::locale_type"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "locale_type typedef [TR1]"
ms.assetid: 2530f101-3f95-4d06-8487-f7f0de111065
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::locale_type
The type of the stored locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The typedef is a synonym for a type that encapsulates locales. In the specializations <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> it is a synonym for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
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