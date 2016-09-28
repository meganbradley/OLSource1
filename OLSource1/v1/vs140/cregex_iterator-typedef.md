---
title: "cregex_iterator Typedef"
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
  - "std.tr1.cregex_iterator"
  - "cregex_iterator"
  - "std::tr1::cregex_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cregex_iterator typedef [TR1]"
ms.assetid: a23a317e-aaa6-4148-a142-a1e93a3e5d17
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# cregex_iterator Typedef
Type definition for char regex_iterator.  
  
## Syntax  
  
```  
typedef regex_iterator<const char*> cregex_iterator;  
```  
  
## Remarks  
 The type describes a specialization of template class [regex_iterator](../vs140/regex_iterator-class.md) for iterators of type `const char*`.  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)   
 [sregex_iterator](../vs140/sregex_iterator-typedef.md)   
 [wcregex_iterator](../vs140/wcregex_iterator-typedef.md)   
 [wsregex_iterator](../vs140/wsregex_iterator-typedef.md)