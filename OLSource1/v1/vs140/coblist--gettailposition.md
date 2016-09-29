---
title: "CObList::GetTailPosition"
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
  - "CObList.GetTailPosition"
  - "CObList::GetTailPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTailPosition method"
  - "CObList class, iteration"
ms.assetid: 66592968-b816-4b83-aa3a-fc0e4de298a4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetTailPosition
Gets the position of the tail element of this list; **NULL** if the list is empty.  
  
## Syntax  
  
```  
  
POSITION GetTailPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to `CObList::GetTailPosition`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION GetTailPosition( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION GetTailPosition( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#102](../vs140/codesnippet/CPP/coblist--gettailposition_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)