---
title: "sub_match::matched"
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
  - "std.tr1.sub_match.matched"
  - "sub_match.matched"
  - "matched"
  - "sub_match::matched"
  - "std::tr1::sub_match::matched"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "matched method [TR1]"
ms.assetid: c257f1e6-ca59-44a0-9c26-cf4d9f0cfba8
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sub_match::matched
Indicates if match succeeded.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The member holds <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only if the capture group associated with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> was part of the regular expression match.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **matched == true**  
**length == 3**  
**difference == 3**  
**range == aaa**  
**string == aaa**  
**compare("aab") == -1**  
**compare(string) == 1**  
**compare(sub) == 0**   
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)