---
title: "COleSafeArray::GetElement"
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
  - "COleSafeArray.GetElement"
  - "COleSafeArray::GetElement"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetElement method"
ms.assetid: 10567368-822a-40f7-ac4f-7738747b1809
caps.latest.revision: 20
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::GetElement
Retrieves a single element of the safe array.  
  
## Syntax  
  
```  
  
      void GetElement(  
   long* rgIndices,  
   void* pvData   
);  
```  
  
#### Parameters  
 `rgIndices`  
 Pointer to an array of indexes for each dimension of the array.  
  
 `pvData`  
 Pointer to the location to place the element of the array.  
  
## Remarks  
 This function automatically calls the windows functions `SafeArrayLock` and `SafeArrayUnlock` before and after retrieving the element. If the data element is a string, object, or variant, the function copies the element in the correct way. The parameter `pvData` should point to a large enough buffer to contain the element.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#29](../vs140/codesnippet/CPP/colesafearray--getelement_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::PutElement](../vs140/colesafearray--putelement.md)