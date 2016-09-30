---
title: "regex_traits::translate_nocase"
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
  - "std.tr1.regex_traits.translate_nocase"
  - "translate_nocase"
  - "std::tr1::regex_traits::translate_nocase"
  - "regex_traits.translate_nocase"
  - "regex_traits::translate_nocase"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "translate_nocase method [TR1]"
ms.assetid: 843f919b-2ff1-4ccd-af03-e5a9d6701fa5
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::translate_nocase
Converts to equivalent caseless matching element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The element to convert.  
  
## Remarks  
 The member function returns a character that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. For two <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> only if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> should match when one occurs in the regular expression definition and the other occurs at a corresponding position in the target sequence for a case-insensitive match.  
  
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
 [regex_traits::translate](../vs140/regex_traits--translate.md)