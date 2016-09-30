---
title: "regex_traits::transform_primary"
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
  - "regex_traits.transform_primary"
  - "std.tr1.regex_traits.transform_primary"
  - "std::tr1::regex_traits::transform_primary"
  - "transform_primary"
  - "regex_traits::transform_primary"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform_primary method [TR1]"
ms.assetid: b02a685e-ad08-4114-9da9-c24beb374f9a
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::transform_primary
Converts to equivalent caseless ordered sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Beginning of sequence to transform.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 End of sequence to transform.  
  
## Remarks  
 The member function returns a string that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. For two character sequences designated by the iterator ranges <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the character sequence designated by the iterator range <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sorts before the character sequence designated by the iterator range <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> without regard for case or accents.  
  
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
 [regex_traits::transform](../vs140/regex_traits--transform.md)