---
title: "CObList::AddTail"
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
  - "CObList::AddTail"
  - "CObList.AddTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, operations"
  - "AddTail method"
ms.assetid: 2653bf9e-0957-4870-bc4d-2279237acba1
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::AddTail
Adds a new element or list of elements to the tail of this list.  
  
## Syntax  
  
```  
  
      POSITION AddTail(  
   CObject* newElement   
);  
void AddTail(  
   CObList* pNewList   
);  
```  
  
#### Parameters  
 `newElement`  
 The `CObject` pointer to be added to this list.  
  
 `pNewList`  
 A pointer to another `CObList` list. The elements in `pNewList` will be added to this list.  
  
## Return Value  
 The first version returns the **POSITION** value of the newly inserted element.  
  
## Remarks  
 The list can be empty before the operation.  
  
 The following table shows other member functions that are similar to `CObList::AddTail`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**POSITION AddTail( void\***  `newElement`  **);**<br /><br /> **void AddTail( CPtrList\***  `pNewList`  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**POSITION AddTail( const CString&**  `newElement`  **);**<br /><br /> **POSITION AddTail( LPCTSTR**  `newElement`  **);**<br /><br /> **void AddTail( CStringList\***  `pNewList`  **);**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#90](../vs140/codesnippet/CPP/coblist--addtail_1.cpp)]  
  
 The results from this program are as follows:  
  
 `AddTail example: A CObList with 2 elements`  
  
 `a CAge at $444A 21`  
  
 `a CAge at $4526 40`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::GetTail](../vs140/coblist--gettail.md)   
 [CObList::RemoveTail](../vs140/coblist--removetail.md)