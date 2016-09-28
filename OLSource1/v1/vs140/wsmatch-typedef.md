---
title: "wsmatch Typedef"
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
  - "wsmatch"
  - "std.tr1.wsmatch"
  - "std::tr1::wsmatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wsmatch typedef [TR1]"
ms.assetid: 834ec92d-e1f9-49c5-b731-b387ec04c3bb
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wsmatch Typedef
Type definition for wstring match_results.  
  
## Syntax  
  
```  
typedef match_results<wstring::const_iterator> wsmatch;  
```  
  
## Remarks  
 The type describes a specialization of template class [match_results](../vs140/match_results-class.md) for iterators of type `wstring::const_iterator`.  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [match_results](../vs140/match_results-class.md)   
 [cmatch](../vs140/cmatch-typedef.md)   
 [smatch](../vs140/smatch-typedef.md)   
 [wcmatch](../vs140/wcmatch-typedef.md)