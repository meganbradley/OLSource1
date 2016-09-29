---
title: "CArray::GetAt"
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
  - "CArray::GetAt"
  - "CArray.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, element access"
  - "GetAt method [MFC]"
ms.assetid: 09ba11c4-8167-41a4-9d78-cfa0116063f5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::GetAt
Returns the array element at the specified index.  
  
## Syntax  
  
```  
  
      TYPE  
      & GetAt(   
   INT_PTR nIndex    
);  
const TYPE& GetAt(   
   INT_PTR nIndex  
) const;  
```  
  
#### Parameters  
 *TYPE*  
 Template parameter specifying the type of the array elements.  
  
 `nIndex`  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by [GetUpperBound](../vs140/carray--getupperbound.md).  
  
## Return Value  
 The array element currently at this index.  
  
## Remarks  
 Passing a negative value or a value greater than the value returned by `GetUpperBound` will result in a failed assertion.  
  
## Example  
 [!code[NVC_MFCCollections#26](../vs140/codesnippet/CPP/carray--getat_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::operator](../vs140/carray--operator.md)