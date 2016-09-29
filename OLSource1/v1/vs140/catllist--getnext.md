---
title: "CAtlList::GetNext"
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
  - "ATL::CAtlList::GetNext"
  - "CAtlList.GetNext"
  - "ATL.CAtlList.GetNext"
  - "CAtlList::GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetNext method"
ms.assetid: 2e489b91-f2cc-4890-8c90-a97be986ace3
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::GetNext
Call this method to return the next element from the list.  
  
## Syntax  
  
```  
  
      E& GetNext(  
   POSITION& pos   
) throw( );  
const E& GetNext(  
   POSITION& pos   
) const throw( );  
```  
  
#### Parameters  
 `pos`  
 A POSITION value, returned by a previous call to `GetNext`, [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md), or other `CAtlList` method.  
  
## Return Value  
 If the list is **const**, `GetNext` returns a copy of the next element of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, `GetNext` returns a reference to the next element of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
## Remarks  
 The POSITION counter, `pos`, is updated to point to the next element in the list, or NULL if there are no more elements. In debug builds, an assertion failure will occur if `pos` is equal to NULL.  
  
## Example  
 See the example for [CAtlList::GetHeadPosition](../vs140/catllist--getheadposition.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetPrev](../vs140/catllist--getprev.md)