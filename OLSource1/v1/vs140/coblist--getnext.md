---
title: "CObList::GetNext"
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
  - "CObList::GetNext"
  - "CObList.GetNext"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObList class, iteration"
  - "GetNext method"
ms.assetid: 0e556a22-cb5e-4f01-964f-eb44c9786ae6
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObList::GetNext
Gets the list element identified by `rPosition`, then sets `rPosition` to the `POSITION` value of the next entry in the list.  
  
## Syntax  
  
```  
CObject*& GetNext(  
   POSITION& rPosition   
);  
const CObject* GetNext(   
   POSITION& rPosition    
) const;  
```  
  
#### Parameters  
 `rPosition`  
 A reference to a `POSITION` value returned by a previous `GetNext`, `GetHeadPosition`, or other member function call.  
  
## Return Value  
 See the return value description for [GetHead](../vs140/coblist--gethead.md).  
  
## Remarks  
 You can use `GetNext` in a forward iteration loop if you establish the initial position with a call to `GetHeadPosition` or `Find`.  
  
 You must ensure that your `POSITION` value represents a valid position in the list. If it is invalid, then the Debug version of the Microsoft Foundation Class Library asserts.  
  
 If the retrieved element is the last in the list, then the new value of `rPosition` is set to `NULL`.  
  
 It is possible to remove an element during an iteration. See the example for [RemoveAt](../vs140/coblist--removeat.md).  
  
> [!NOTE]
>  As of MFC 8.0 the const version of this method has changed to return `const CObject*` instead of `const CObject*&`.  This change was made to bring the compiler into conformance with the C++ standard.  
  
 The following table shows other member functions that are similar to `CObList::GetNext`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CPtrList](../vs140/cptrlist-class.md)|`void*& GetNext( POSITION&`  `rPosition`  `);`<br /><br /> `const void* GetNext( POSITION&`  `rPosition`  `) const;`|  
|[CStringList](../vs140/cstringlist-class.md)|`CString& GetNext( POSITION&`  `rPosition`  `);`<br /><br /> `const CString& GetNext( POSITION&`  `rPosition`  `) const;`|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class.  
  
 [!code[NVC_MFCCollections#98](../vs140/codesnippet/CPP/coblist--getnext_1.cpp)]  
  
 The results from this program are as follows:  
  
 `a CAge at $479C 40`  
  
 `a CAge at $46C0 21`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObList Class](../vs140/coblist-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObList::Find](../vs140/coblist--find.md)   
 [CObList::GetHeadPosition](../vs140/coblist--getheadposition.md)   
 [CObList::GetTailPosition](../vs140/coblist--gettailposition.md)   
 [CObList::GetPrev](../vs140/coblist--getprev.md)   
 [CObList::GetHead](../vs140/coblist--gethead.md)