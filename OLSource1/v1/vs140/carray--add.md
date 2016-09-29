---
title: "CArray::Add"
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
  - "CArray::Add"
  - "CArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CArray class, growing the array"
  - "Add method [MFC]"
ms.assetid: 0f790120-ffb2-4e56-b652-eb82517b48be
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArray::Add
Adds a new element to the end of an array, growing the array by 1.  
  
## Syntax  
  
```  
  
      INT_PTR Add(  
   ARG_TYPE newElement   
);  
```  
  
#### Parameters  
 `ARG_TYPE`  
 Template parameter specifying the type of arguments referencing elements in this array.  
  
 `newElement`  
 The element to be added to this array.  
  
## Return Value  
 The index of the added element.  
  
## Remarks  
 If [SetSize](../vs140/carray--setsize.md) has been used with an `nGrowBy` value greater than 1, then extra memory may be allocated. However, the upper bound will increase by only 1.  
  
## Example  
 [!code[NVC_MFCCollections#22](../vs140/codesnippet/CPP/carray--add_1.cpp)]  
  
## Requirements  
 **Header:** afxtempl.h  
  
## See Also  
 [CArray Class](../vs140/carray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArray::SetAt](../vs140/carray--setat.md)   
 [CArray::SetAtGrow](../vs140/carray--setatgrow.md)   
 [CArray::InsertAt](../vs140/carray--insertat.md)   
 [CArray::operator](../vs140/carray--operator.md)