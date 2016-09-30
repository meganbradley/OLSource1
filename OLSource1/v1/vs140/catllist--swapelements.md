---
title: "CAtlList::SwapElements"
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
  - "CAtlList.SwapElements"
  - "SwapElements"
  - "ATL.CAtlList.SwapElements"
  - "CAtlList::SwapElements"
  - "ATL::CAtlList::SwapElements"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SwapElements method"
ms.assetid: e8d7e2dd-52f1-43f1-9a48-b882392af52e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::SwapElements
Call this method to swap elements in the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pos1*  
 The first POSITION value.  
  
 *pos2*  
 The second POSITION value.  
  
## Remarks  
 Swaps the elements at the two positions specified. In debug builds, an assertion failure will occur if either position value is equal to NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#31](../vs140/codesnippet/CPP/catllist--swapelements_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::MoveToHead](../vs140/catllist--movetohead.md)   
 [CAtlList::MoveToTail](../vs140/catllist--movetotail.md)