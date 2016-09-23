---
title: "wcregex_token_iterator Typedef"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.tr1.wcregex_token_iterator
  - std::tr1::wcregex_token_iterator
  - wcregex_token_iterator
dev_langs: 
  - C++
helpviewer_keywords: 
  - wcregex_token_iterator typedef [TR1]
ms.assetid: 636c881d-c030-4409-b87f-977514e7673e
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# wcregex_token_iterator Typedef
Type definition for wchar_t regex_token_iterator.  
  
## Syntax  
  
```  
typedef regex_token_iterator<const wchar_t*> wcregex_token_iterator;  
```  
  
## Remarks  
 The type describes a specialization of template class [regex_token_iterator](../vs140/regex_token_iterator-class.md) for iterators of type `const wchar_t*`.  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_token_iterator](../vs140/regex_token_iterator-class.md)   
 [cregex_token_iterator](../vs140/cregex_token_iterator-typedef.md)   
 [sregex_token_iterator](../vs140/sregex_token_iterator-typedef.md)   
 [wsregex_token_iterator](../vs140/wsregex_token_iterator-typedef.md)