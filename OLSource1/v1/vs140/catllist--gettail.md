---
title: "CAtlList::GetTail"
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
  - "GetTail"
  - "ATL.CAtlList.GetTail"
  - "ATL::CAtlList::GetTail"
  - "CAtlList.GetTail"
  - "CAtlList::GetTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTail method"
ms.assetid: cc396392-78f6-40ab-8f50-3e55a93030ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlList::GetTail
Call this method to return the element at the tail of the list.  
  
## Syntax  
  
```  
  
      E& GetTail( ) throw( );   
const E& GetTail( ) const throw( );  
```  
  
## Return Value  
 Returns a reference to, or a copy of, the element at the tail of the list.  
  
## Remarks  
 If the list is **const**, `GetTail` returns a copy of the element at the head of the list. This allows the method to be used only on the right side of an assignment statement and protects the list from modification.  
  
 If the list is not **const**, `GetTail` returns a reference to the element at the head of the list. This allows the method to be used on either side of an assignment statement and thus allows the list entries to be modified.  
  
 In debug builds, an assertion failure will occur if the tail of the list points to NULL.  
  
## Example  
 See the example for [CAtlList::AddTail](../vs140/catllist--addtail.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlList Class](../vs140/catllist-class.md)   
 [CAtlList::GetTailPosition](../vs140/catllist--gettailposition.md)   
 [CAtlList::GetHead](../vs140/catllist--gethead.md)