---
title: "CObList::GetAt"
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
  - "CObList::GetAt"
  - "CObList.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, retrieval/modification"
  - "GetAt method [MFC]"
ms.assetid: ed615932-3fe2-4a4f-bc96-5c73a23fb18d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetAt
A variable of type **POSITION** is a key for the list.  
  
## Syntax  
  
```  
  
      CObject*& GetAt(  
   POSITION position   
);  
const CObject*& GetAt(   
   POSITION position    
) const;  
```  
  
#### Parameters  
 *position*  
 A **POSITION** value returned by a previous `GetHeadPosition` or **Find** member function call.  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 It is not the same as an index, and you cannot operate on a **POSITION** value yourself. `GetAt` retrieves the `CObject` pointer associated with a given position.  
  
 You must ensure that your **POSITION** value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 The following table shows other member functions that are similar to `CObList::GetAt`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetAt( POSITION**  *position*  **) const;**\<br />\<br /> **void\*& GetAt( POSITION**  *position*  **);**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetAt( POSITION**  *position*  **) const;**\<br />\<br /> **CString& GetAt( POSITION**  *position*  **);**|  
  
## Example  
 See the example for [FindIndex](../vs140/coblist--findindex.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::SetAt](../vs140/coblist--setat.md)   
 [CObList::GetNext](../vs140/coblist--getnext.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)