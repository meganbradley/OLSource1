---
title: "regex_traits::isctype"
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
  - "isctype"
  - "std.tr1.regex_traits.isctype"
  - "std::tr1::regex_traits::isctype"
  - "regex_traits.isctype"
  - "regex_traits::isctype"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "isctype method [TR1]"
ms.assetid: b94422e4-f11f-412d-beec-4cf54d1579cd
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::isctype
Tests for class membership.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element to test.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The classes to test for.  
  
## Remarks  
 The member function returns true only if the character <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is in the character class designated by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
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