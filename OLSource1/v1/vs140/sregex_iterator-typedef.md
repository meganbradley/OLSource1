---
title: "sregex_iterator Typedef"
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
  - "std::tr1::sregex_iterator"
  - "sregex_iterator"
  - "std.tr1.sregex_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sregex_iterator typedef [TR1]"
ms.assetid: 9683b0d2-5cd3-4219-8ed3-3234617738ec
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# sregex_iterator Typedef
Type definition for string regex_iterator.  
  
## Syntax  
  
```  
typedef regex_iterator<string::const_iterator> sregex_iterator;  
```  
  
## Remarks  
 The type describes a specialization of template class [regex_iterator](../vs140/regex_iterator-class.md) for iterators of type `string::const_iterator`.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)   
 [cregex_iterator](../vs140/cregex_iterator-typedef.md)   
 [wcregex_iterator](../vs140/wcregex_iterator-typedef.md)   
 [wsregex_iterator](../vs140/wsregex_iterator-typedef.md)