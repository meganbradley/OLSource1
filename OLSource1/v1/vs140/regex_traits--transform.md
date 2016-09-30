---
title: "regex_traits::transform"
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
  - "std::tr1::regex_traits::transform"
  - "std.tr1.regex_traits.transform"
  - "regex_traits::transform"
  - "regex_traits.transform"
  - "transform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "transform method [TR1]"
ms.assetid: 099f258b-6cc8-49aa-8db9-3a8ed054807f
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::transform
Converts to equivalent ordered sequence.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Beginning of sequence to transform.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 End of sequence to transform.  
  
## Remarks  
 The member function returns a string that it generates by using a transformation rule that depends on the stored <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object. For two character sequences designated by the iterator ranges <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the character sequence designated by the iterator range <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> sorts before the character sequence designated by the iterator range <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
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
 [regex_traits::transform_primary](../vs140/regex_traits--transform_primary.md)