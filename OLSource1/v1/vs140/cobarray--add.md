---
title: "CObArray::Add"
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
  - "CObArray::Add"
  - "CObArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CObArray class, growing the array"
  - "Add method [MFC]"
ms.assetid: e17b99be-c6c2-4eb5-b7b7-f7c73cd014c4
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::Add
Adds a new element to the end of an array, growing the array by 1.  
  
## Syntax  
  
```  
  
      INT_PTR Add(  
   CObject* newElement   
);  
```  
  
#### Parameters  
 `newElement`  
 The `CObject` pointer to be added to this array.  
  
## Return Value  
 The index of the added element.  
  
## Remarks  
 If [SetSize](../vs140/cobarray--setsize.md) has been used with an `nGrowBy` value greater than 1, then extra memory may be allocated. However, the upper bound will increase by only 1.  
  
 The following table shows other member functions that are similar to `CObArray::Add`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**INT_PTR Add( BYTE**  `newElement` **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**INT_PTR Add( DWORD**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**INT_PTR Add( void\***  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**INT_PTR Add( LPCTSTR**  `newElement`  **); throw( CMemoryException\* );**<br /><br /> **INT_PTR Add(const CString&**  `newElement` **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**INT_PTR Add( UINT**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**INT_PTR Add( WORD**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#75](../vs140/codesnippet/CPP/cobarray--add_1.cpp)]  
  
 The results from this program are as follows:  
  
 `Add example: A CObArray with 2 elements`  
  
 `[0] = a CAge at $442A 21`  
  
 `[1] = a CAge at $4468 40`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::SetAtGrow](../vs140/cobarray--setatgrow.md)   
 [CObArray::InsertAt](../vs140/cobarray--insertat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)