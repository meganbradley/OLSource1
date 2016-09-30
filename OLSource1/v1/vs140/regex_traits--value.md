---
title: "regex_traits::value"
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
  - "std.tr1.regex_traits.value"
  - "regex_traits.value"
  - "regex_traits::value"
  - "std::tr1::regex_traits::value"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "value method [TR1]"
ms.assetid: a9016a9a-9bea-4a62-811f-6667a240a762
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::value
Converts an element to a digit value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element to convert.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The arithmetic base to use.  
  
## Remarks  
 The member function returns the value represented by the character <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the base <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or -1 if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is not a valid digit in the base <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The function will only be called with a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> argument of 8, 10, or 16.  
  
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