---
title: "CAtlList::RemoveTail"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CAtlList::RemoveTail"
  - "CAtlList::RemoveTail"
  - "CAtlList.RemoveTail"
  - "RemoveTail"
  - "ATL.CAtlList.RemoveTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RemoveTail method"
ms.assetid: 9de7cbbe-7a8b-45ad-8d56-77550de78357
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::RemoveTail
Call this method to remove the element at the tail of the list.  
  
## Syntax  
  
```  
  
E RemoveTail( );  
  
```  
  
## Return Value  
 Returns the element at the tail of the list.  
  
## Remarks  
 The tail element is deleted from the list, and memory is freed. A copy of the element is returned. In debug builds, an assertion failure will occur if the list is empty.  
  
## Example  
 [!code[NVC_ATL_Utilities#29](../vs140/codesnippet/CPP/catllist--removetail_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::RemoveTailNoReturn](../vs140/catllist--removetailnoreturn.md)   
 [CAtlList::RemoveHead](../vs140/catllist--removehead.md)   
 [CAtlList::RemoveHeadNoReturn](../vs140/catllist--removeheadnoreturn.md)