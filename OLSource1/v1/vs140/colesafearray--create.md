---
title: "COleSafeArray::Create"
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
  - "COleSafeArray.Create"
  - "COleSafeArray::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: b3341152-2774-44ff-b709-3132f26f1311
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::Create
Allocates and initializes the data for the array.  
  
## Syntax  
  
```  
  
      void Create(  
   VARTYPE vtSrc,  
   DWORD dwDims,  
   DWORD* rgElements   
);  
void Create(  
   VARTYPE vtSrc,  
   DWORD dwDims,  
   SAFEARRAYBOUND* rgsabounds   
);  
```  
  
#### Parameters  
 `vtSrc`  
 The base type of the array (that is, the **VARTYPE** of each element of the array). The **VARTYPE** is restricted to a subset of the variant types. Neither the **VT_ARRAY** nor the **VT_BYREF** flag can be set. `VT_EMPTY` and **VT_NULL** are not valid base types for the array. All other types are legal.  
  
 `dwDims`  
 Number of dimensions in the array. This can be changed after the array is created with [Redim](../vs140/colesafearray--redim.md).  
  
 *rgElements*  
 Pointer to an array of the number of elements for each dimension in the array.  
  
 *rgsabounds*  
 Pointer to a vector of bounds (one for each dimension) to allocate for the array.  
  
## Remarks  
 This function will clear the current array data if necessary. On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#27](../vs140/codesnippet/CPP/colesafearray--create_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SafeArrayCreate](assetId:///5b94f1a2-a558-473f-85dd-9545c0464cc7)