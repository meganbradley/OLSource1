---
title: "COleSafeArray::PtrOfIndex"
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
  - "COleSafeArray::PtrOfIndex"
  - "COleSafeArray.PtrOfIndex"
  - "PtrOfIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PtrOfIndex method"
ms.assetid: 2a7b20a4-6c6c-4f12-92df-f92ff07ec54f
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::PtrOfIndex
Returns a pointer to the element specified by the index values.  
  
## Syntax  
  
```  
  
      void PtrOfIndex(  
   long* rgIndices,  
   void** ppvData   
);  
```  
  
#### Parameters  
 `rgIndices`  
 An array of index values that identify an element of the array. All indexes for the element must be specified.  
  
 `ppvData`  
 On return, pointer to the element identified by the values in `rgIndices`.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)