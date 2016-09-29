---
title: "cmatch Typedef"
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
  - "std::tr1::cmatch"
  - "std.tr1.cmatch"
  - "cmatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cmatch typedef [TR1]"
ms.assetid: 9d41218e-28a1-4c5b-9bbb-fca1067fb1f5
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# cmatch Typedef
Type definition for char match_results.  
  
## Syntax  
  
```  
typedef match_results<const char*> cmatch;  
```  
  
## Remarks  
 The type describes a specialization of template class [match_results](../vs140/match_results-class.md) for iterators of type `const char*`.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [match_results](../vs140/match_results-class.md)   
 [smatch](../vs140/smatch-typedef.md)   
 [wcmatch](../vs140/wcmatch-typedef.md)   
 [wsmatch](../vs140/wsmatch-typedef.md)