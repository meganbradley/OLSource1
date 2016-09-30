---
title: "regex_traits::imbue"
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
  - "regex_traits::imbue"
  - "std.tr1.regex_traits.imbue"
  - "regex_traits.imbue"
  - "std::tr1::regex_traits::imbue"
  - "imbue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "imbue method [TR1]"
ms.assetid: 4371ba00-981f-4f3a-aa55-39654180f121
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::imbue
Alters the stored locale object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The locale object to store.  
  
## Remarks  
 The member function copies <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to the stored <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object and returns a copy of the previous value of the stored <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
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