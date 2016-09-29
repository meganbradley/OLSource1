---
title: "wcregex_iterator Typedef"
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
  - "std::tr1::wcregex_iterator"
  - "std.tr1.wcregex_iterator"
  - "wcregex_iterator"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wcregex_iterator typedef [TR1]"
ms.assetid: 90103d1a-71ae-4a37-8236-8231b5a05f9b
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# wcregex_iterator Typedef
Type definition for wchar_t regex_iterator.  
  
## Syntax  
  
```  
typedef regex_iterator<const wchar_t*> wcregex_iterator;  
```  
  
## Remarks  
 The type describes a specialization of template class [regex_iterator](../vs140/regex_iterator-class.md) for iterators of type `const wchar_t*`.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_iterator](../vs140/regex_iterator-class.md)   
 [cregex_iterator](../vs140/cregex_iterator-typedef.md)   
 [sregex_iterator](../vs140/sregex_iterator-typedef.md)   
 [wsregex_iterator](../vs140/wsregex_iterator-typedef.md)