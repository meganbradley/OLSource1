---
title: "COleSafeArray::PutElement"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - PutElement
  - COleSafeArray.PutElement
  - COleSafeArray::PutElement
dev_langs: 
  - C++
helpviewer_keywords: 
  - PutElement method
ms.assetid: c2a3ca24-10d6-4ee8-b9cf-8d3fd7908fd3
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleSafeArray::PutElement
Assigns a single element into the array.  
  
## Syntax  
  
```  
  
      void PutElement(  
   long* rgIndices,  
   void* pvData   
);  
```  
  
#### Parameters  
 `rgIndices`  
 Pointer to an array of indexes for each dimension of the array.  
  
 `pvData`  
 Pointer to the data to assign to the array. **VT_DISPATCH**, **VT_UNKNOWN**, and `VT_BSTR` variant types are pointers and do not require another level of indirection.  
  
## Remarks  
 This function automatically calls the Windows functions [SafeArrayLock](https://msdn.microsoft.com/library/windows/desktop/ms221492.aspx) and [SafeArrayUnlock](https://msdn.microsoft.com/library/windows/desktop/ms221246.aspx) before and after assigning the element. If the data element is a string, object, or variant, the function copies it correctly, and if the existing element is a string, object, or variant, it is cleared correctly.  
  
 Note that you can have multiple locks on an array, so you can put elements into an array while the array is locked by other operations.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md) or [COleException](../vs140/coleexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#32](../vs140/codesnippet/CPP/colesafearray--putelement_1.cpp)]
  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::GetElement](../vs140/colesafearray--getelement.md)   
 [SafeArrayPutElement](http://msdn.microsoft.com/library/windows/desktop/ms221283.aspx)