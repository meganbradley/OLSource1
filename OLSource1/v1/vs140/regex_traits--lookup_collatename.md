---
title: "regex_traits::lookup_collatename"
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
  - "regex_traits::lookup_collatename"
  - "regex_traits.lookup_collatename"
  - "std::tr1::regex_traits::lookup_collatename"
  - "std.tr1.regex_traits.lookup_collatename"
  - "lookup_collatename"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "lookup_collatename method [TR1]"
ms.assetid: 508c7769-4de5-4fc2-bb38-38eab2b1f6b7
caps.latest.revision: 19
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_traits::lookup_collatename
Maps a sequence to a collating element.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Beginning of sequence to look up.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 End of sequence to look up.  
  
## Remarks  
 The member function returns a string object containing the collating element corresponding to the sequence <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, or an empty string if the sequence is not a valid collating element.  
  
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
 [regex_traits::lookup_classname](../vs140/regex_traits--lookup_classname.md)