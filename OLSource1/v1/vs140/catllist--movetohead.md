---
title: "CAtlList::MoveToHead"
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
  - "CAtlList.MoveToHead"
  - "ATL.CAtlList.MoveToHead"
  - "ATL::CAtlList::MoveToHead"
  - "MoveToHead"
  - "CAtlList::MoveToHead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MoveToHead method"
ms.assetid: 42c70ca8-ea4c-4db3-96ae-0f27f15e6c75
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::MoveToHead
Call this method to move the specified element to the head of the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The POSITION value of the element to move.  
  
## Remarks  
 The specified element is moved from its current position to the head of the list. In debug builds, an assertion failure will occur if <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is equal to NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#26](../vs140/codesnippet/CPP/catllist--movetohead_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::MoveToTail](../vs140/catllist--movetotail.md)   
 [CAtlList::SwapElements](../vs140/catllist--swapelements.md)