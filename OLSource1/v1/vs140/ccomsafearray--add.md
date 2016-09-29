---
title: "CComSafeArray::Add"
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
  - "ATL::CComSafeArray::Add"
  - "CComSafeArray::Add"
  - "ATL.CComSafeArray.Add"
  - "CComSafeArray.Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 46ac986b-493c-48ae-9ecf-e9a1da5d928d
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::Add
Adds one or more elements, or a **SAFEARRAY** structure, to a `CComSafeArray`.  
  
## Syntax  
  
```  
  
      HRESULT Add(  
   const SAFEARRAY * psaSrc   
);  
HRESULT Add(  
   ULONG ulCount,  
   const T * pT,  
   BOOL bCopy = TRUE  
);  
HRESULT Add(  
   const T& t,  
   BOOL bCopy = TRUE  
);  
```  
  
#### Parameters  
 `psaSrc`  
 A pointer to a **SAFEARRAY** object.  
  
 `ulCount`  
 The number of objects to add to the array.  
  
 *pT*  
 A pointer to one or more objects to be added to the array.  
  
 *t*  
 A reference to the object to be added to the array.  
  
 `bCopy`  
 Indicates whether a copy of the data should be created. The default value is **TRUE**.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The new objects are appended to the end of the existing **SAFEARRAY** object. Adding an object to a multidimensional **SAFEARRAY** object is not supported. When adding an existing array of objects, both arrays must contain elements of the same type.  
  
 The `bCopy` flag is taken into account when elements of type `BSTR` or **VARIANT** are added to an array. The default value of **TRUE** ensures that a new copy is made of the data when the element is added to the array.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)