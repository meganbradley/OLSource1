---
title: "CAtlList::Find"
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
  - "ATL::CAtlList::Find"
  - "CAtlList.Find"
  - "CAtlList::Find"
  - "ATL.CAtlList.Find"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Find method"
ms.assetid: 6e3b3cd9-a304-40f0-a887-a9961235fa37
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::Find
Call this method to search the list for the specified element.  
  
## Syntax  
  
```  
  
      POSITION Find(  
   INARGTYPE element,  
   POSITION posStartAfter = NULL   
) const throw( );  
```  
  
#### Parameters  
 `element`  
 The element to be found in the list.  
  
 `posStartAfter`  
 The start position for the search. If no value is specified, the search begins with the head element.  
  
## Return Value  
 Returns the POSITION value of the element if found, otherwise returns NULL.  
  
## Remarks  
 In debug builds, an assertion failure will occur if the list object is not valid, or if the `posStartAfter` value is out of range.  
  
## Example  
 [!code[NVC_ATL_Utilities#19](../vs140/codesnippet/CPP/catllist--find_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::FindIndex](../vs140/catllist--findindex.md)