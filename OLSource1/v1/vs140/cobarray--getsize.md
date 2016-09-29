---
title: "CObArray::GetSize"
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
  - "CObArray.GetSize"
  - "CObArray::GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, bounds"
  - "GetSize method"
ms.assetid: 45b201a2-864a-4294-993c-e018788168e9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::GetSize
Returns the size of the array.  
  
## Syntax  
  
```  
  
INT_PTR GetSize( ) const;  
```  
  
## Remarks  
 Since indexes are zero-based, the size is 1 greater than the largest index.  
  
 The following table shows other member functions that are similar to `CObArray::GetSize`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetSize( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetSize( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#82](../vs140/codesnippet/CPP/cobarray--getsize_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetUpperBound](../vs140/cobarray--getupperbound.md)   
 [CObArray::SetSize](../vs140/cobarray--setsize.md)   
 [CObArray::GetCount](../vs140/cobarray--getcount.md)