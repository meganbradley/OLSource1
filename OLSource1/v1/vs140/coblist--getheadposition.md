---
title: "CObList::GetHeadPosition"
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
  - "CObList.GetHeadPosition"
  - "CObList::GetHeadPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHeadPosition method"
  - "CObList class, iteration"
ms.assetid: aeb3f0fb-9c1e-4a84-aeac-436f58ef1b7b
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetHeadPosition
Gets the position of the head element of this list.  
  
## Syntax  
  
```  
  
POSITION GetHeadPosition( ) const;  
```  
  
## Return Value  
 A **POSITION** value that can be used for iteration or object pointer retrieval; **NULL** if the list is empty.  
  
 The following table shows other member functions that are similar to `CObList::GetHeadPosition`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION GetHeadPosition( ) const;**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION GetHeadPosition( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#97](../vs140/codesnippet/CPP/coblist--getheadposition_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)