---
title: "CAtlList::GetTailPosition"
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
  - "GetTailPosition"
  - "CAtlList.GetTailPosition"
  - "ATL.CAtlList.GetTailPosition"
  - "ATL::CAtlList::GetTailPosition"
  - "CAtlList::GetTailPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTailPosition method"
ms.assetid: b8d91f5e-c4a1-43c0-855f-c6d5aa3be8dd
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::GetTailPosition
Call this method to obtain the position of the tail of the list.  
  
## Syntax  
  
```  
  
POSITION GetTailPosition( ) const throw( );  
  
```  
  
## Return Value  
 Returns the POSITION value corresponding to the element at the tail of the list.  
  
## Remarks  
 If the list is empty, the value returned is NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#22](../vs140/codesnippet/CPP/catllist--gettailposition_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetTail](../vs140/catllist--gettail.md)   
 [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md)