---
title: "CObList::GetTail"
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
  - "CObList.GetTail"
  - "GetTail"
  - "CObList::GetTail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, head/tail access"
  - "GetTail method"
ms.assetid: d49712f3-d7c7-4559-a73b-4577496c6c5b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetTail
Gets the `CObject` pointer that represents the tail element of this list.  
  
## Syntax  
  
```  
  
      CObject*& GetTail( );  
const CObject*& GetTail( ) const;  
```  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 You must ensure that the list is not empty before calling `GetTail`. If the list is empty, then the Debug version of the Microsoft Foundation Class Library asserts. Use [IsEmpty](../vs140/coblist--isempty.md) to verify that the list contains elements.  
  
 The following table shows other member functions that are similar to `CObList::GetTail`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|**const void\*& GetTail( ) const; void\*& GetTail( );**|  
|[CStringList](../vs140/cstringlist-class.md)|**const CString& GetTail( ) const; CString& GetTail( );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#101](../vs140/codesnippet/CPP/coblist--gettail_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::AddTail](../vs140/coblist--addtail.md)   
 [CObList::AddHead](../vs140/coblist--addhead.md)   
 [CObList::RemoveHead](../vs140/coblist--removehead.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)