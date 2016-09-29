---
title: "wcmatch Typedef"
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
  - "std::tr1::wcmatch"
  - "std.tr1.wcmatch"
  - "wcmatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wcmatch typedef [TR1]"
ms.assetid: 69205378-2ab2-49e6-a6c4-b16d6b504ebe
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wcmatch Typedef
Type definition for wchar_t match_results.  
  
## Syntax  
  
```  
typedef match_results<const wchar_t *> wcmatch;  
```  
  
## Remarks  
 The type describes a specialization of template class [match_results](../vs140/match_results-class.md) for iterators of type `const wchar_t*`.  
  
## Requirements  
 **Header:** <regex\>  
  
 **Namespace:** std  
  
## See Also  
 [<regex\>](../vs140/-regex-.md)   
 [match_results](../vs140/match_results-class.md)   
 [cmatch](../vs140/cmatch-typedef.md)   
 [smatch](../vs140/smatch-typedef.md)   
 [wsmatch](../vs140/wsmatch-typedef.md)