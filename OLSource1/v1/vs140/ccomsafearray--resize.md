---
title: "CComSafeArray::Resize"
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
  - "ATL.CComSafeArray.Resize"
  - "Resize"
  - "CComSafeArray::Resize"
  - "CComSafeArray.Resize"
  - "ATL::CComSafeArray::Resize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Resize method"
ms.assetid: 5bcea9a7-c161-4eea-a407-eabd8b1cd087
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::Resize
Resizes a `CComSafeArray` object.  
  
## Syntax  
  
```  
  
      HRESULT Resize(  
   const SAFEARRAYBOUND * pBound   
);  
HRESULT Resize(  
   ULONG ulCount,  
   LONG lLBound = 0   
);  
```  
  
#### Parameters  
 `pBound`  
 A pointer to a **SAFEARRAYBOUND** structure that contains information on the number of elements and the lower bound of an array.  
  
 `ulCount`  
 The requested number of objects in the resized array.  
  
 `lLBound`  
 The lower bound.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This method only resizes the rightmost dimension. It will not resize arrays that return **IsResizable** as **false**.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::IsSizable](../vs140/ccomsafearray--issizable.md)