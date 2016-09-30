---
title: "CAtlList::GetHeadPosition"
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
  - "CAtlList.GetHeadPosition"
  - "ATL::CAtlList::GetHeadPosition"
  - "ATL.CAtlList.GetHeadPosition"
  - "CAtlList::GetHeadPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHeadPosition method"
ms.assetid: a60cd4b1-6e77-4315-a833-689d2a477223
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::GetHeadPosition
Call this method to obtain the position of the head of the list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the POSITION value corresponding to the element at the head of the list.  
  
## Remarks  
 If the list is empty, the value returned is NULL.  
  
## Example  
 [!code[NVC_ATL_Utilities#21](../vs140/codesnippet/CPP/catllist--getheadposition_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetHead](../vs140/catllist--gethead.md)   
 [CAtlList::GetTailPosition](../vs140/catllist--gettailposition.md)