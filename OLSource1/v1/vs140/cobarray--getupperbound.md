---
title: "CObArray::GetUpperBound"
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
  - "CObArray.GetUpperBound"
  - "CObArray::GetUpperBound"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, bounds"
  - "GetUpperBound method"
ms.assetid: 89c486ea-fbaf-4d07-b29b-2953e1a1f2d6
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::GetUpperBound
Returns the current upper bound of this array.  
  
## Syntax  
  
```  
  
INT_PTR GetUpperBound( ) const;  
```  
  
## Return Value  
 The index of the upper bound (zero-based).  
  
## Remarks  
 Because array indexes are zero-based, this function returns a value 1 less than `GetSize`.  
  
 The condition **GetUpperBound( )** = –1 indicates that the array contains no elements.  
  
 The following table shows other member functions that are similar to `CObArray::GetUpperBound`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR GetUpperBound( ) const;**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#83](../vs140/codesnippet/CPP/cobarray--getupperbound_1.cpp)]  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetSize](../vs140/cobarray--getsize.md)   
 [CObArray::SetSize](../vs140/cobarray--setsize.md)