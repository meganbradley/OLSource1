---
title: "CObArray::GetCount"
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
  - "CObArray::GetCount"
  - "CObArray.GetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCount method [MFC]"
ms.assetid: f399ab7e-2976-4546-abc7-effb0ab1cf0f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::GetCount
Returns the number of array elements.  
  
## Syntax  
  
```  
  
INT_PTR GetCount( ) const;  
```  
  
## Return Value  
 The number of items in the array.  
  
## Remarks  
 Call this method to retrieve the number of elements in the array. Because indexes are zero-based, the size is 1 greater than the largest index.  
  
 The following table shows other member functions that are similar to `CObArray::GetCount`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetCount( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetCount( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#80](../vs140/codesnippet/CPP/cobarray--getcount_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetUpperBound](../vs140/cobarray--getupperbound.md)   
 [CObArray::SetSize](../vs140/cobarray--setsize.md)   
 [CObArray::GetSize](../vs140/cobarray--getsize.md)