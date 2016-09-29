---
title: "sregex_token_iterator Typedef"
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
  - "std.tr1.sregex_token_iterator"
  - "std::tr1::sregex_token_iterator"
  - "sregex_token_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sregex_token_iterator typedef [TR1]"
ms.assetid: f968ddf2-056b-4fef-aeb8-0d91a119a049
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sregex_token_iterator Typedef
Type definition for string regex_token_iterator.  
  
## Syntax  
  
```  
typedef regex_token_iterator<string::const_iterator> sregex_token_iterator;  
```  
  
## Remarks  
 The type describes a specialization of template class [regex_token_iterator](../vs140/regex_token_iterator-class.md) for iterators of type `string::const_iterator`.  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)   
 [cregex_token_iterator](../vs140/cregex_token_iterator-typedef.md)   
 [wcregex_token_iterator](../vs140/wcregex_token_iterator-typedef.md)   
 [wsregex_token_iterator](../vs140/wsregex_token_iterator-typedef.md)