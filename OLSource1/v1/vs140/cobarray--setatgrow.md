---
title: "CObArray::SetAtGrow"
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
  - "CObArray.SetAtGrow"
  - "CObArray::SetAtGrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAtGrow method"
  - "CObArray class, growing the array"
ms.assetid: df6881c7-fc98-44e6-9301-4379def32c70
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::SetAtGrow
Sets the array element at the specified index.  
  
## Syntax  
  
```  
  
      void SetAtGrow(  
   INT_PTR nIndex,  
   CObject* newElement   
);  
```  
  
#### Parameters  
 `nIndex`  
 An integer index that is greater than or equal to 0.  
  
 `newElement`  
 The object pointer to be added to this array. A **NULL** value is allowed.  
  
## Remarks  
 The array grows automatically if necessary (that is, the upper bound is adjusted to accommodate the new element).  
  
 The following table shows other member functions that are similar to `CObArray::SetAtGrow`.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, BYTE**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, DWORD**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, void\***  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CStringArray](../vs140/cstringarray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, LPCTSTR**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, UINT**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
|[CWordArray](../vs140/cwordarray-class.md)|**void SetAtGrow( INT_PTR**  `nIndex` **, WORD**  `newElement`  **);**<br /><br /> **throw( CMemoryException\* );**|  
  
## Example  
 See [CObList::CObList](../vs140/coblist--coblist.md) for a listing of the `CAge` class used in all collection examples.  
  
 [!code[NVC_MFCCollections#87](../vs140/codesnippet/CPP/cobarray--setatgrow_1.cpp)]  
  
 The results from this program are as follows:  
  
 `SetAtGrow example: A CObArray with 4 elements`  
  
 `[0] = a CAge at $47C0 21`  
  
 `[1] = a CAge at $4800 40`  
  
 `[2] = NULL`  
  
 `[3] = a CAge at $4840 65`  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::GetAt](../vs140/cobarray--getat.md)   
 [CObArray::SetAt](../vs140/cobarray--setat.md)   
 [CObArray::ElementAt](../vs140/cobarray--elementat.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)