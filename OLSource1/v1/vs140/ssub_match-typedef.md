---
title: "ssub_match Typedef"
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
  - "ssub_match"
  - "std::tr1::ssub_match"
  - "std.tr1.ssub_match"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ssub_match typedef [TR1]"
ms.assetid: da31af84-d370-4ae1-b188-5c03ae9325ad
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ssub_match Typedef
Type definition for string sub_match.  
  
## Syntax  
  
```  
typedef sub_match<string::const_iterator> ssub_match;  
```  
  
## Remarks  
 The type describes a specialization of template class [sub_match](../vs140/sub_match-class.md) for iterators of type `string::const_iterator`.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [sub_match](../vs140/sub_match-class.md)   
 [csub_match](../vs140/csub_match-typedef.md)   
 [wcsub_match](../vs140/wcsub_match-typedef.md)   
 [wssub_match](../vs140/wssub_match-typedef.md)