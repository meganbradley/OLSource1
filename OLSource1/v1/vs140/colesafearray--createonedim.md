---
title: "COleSafeArray::CreateOneDim"
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
  - "COleSafeArray::CreateOneDim"
  - "COleSafeArray.CreateOneDim"
  - "CreateOneDim"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateOneDim method"
ms.assetid: bf518930-d58a-4a7e-af40-335f147fd590
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleSafeArray::CreateOneDim
Creates a new one-dimensional `COleSafeArray` object.  
  
## Syntax  
  
```  
  
      void CreateOneDim(  
   VARTYPE vtSrc,  
   DWORD dwElements,  
   const void* pvSrcData = NULL,  
   long nLBound = 0   
);  
```  
  
#### Parameters  
 `vtSrc`  
 The base type of the array (that is, the **VARTYPE** of each element of the array).  
  
 `dwElements`  
 Number of elements in the array. This can be changed after the array is created with [ResizeOneDim](../vs140/colesafearray--resizeonedim.md).  
  
 `pvSrcData`  
 Pointer to the data to copy into the array.  
  
 *nLBound*  
 The lower bound of the array.  
  
## Remarks  
 The function allocates and initializes the data for the array, copying the specified data if the pointer `pvSrcData` is not **NULL**.  
  
 On error, the function throws a [CMemoryException](../vs140/cmemoryexception-class.md).  
  
## Example  
 [!code[NVC_MFCOleContainer#28](../vs140/codesnippet/CPP/colesafearray--createonedim_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleSafeArray Class](../vs140/colesafearray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleSafeArray::GetOneDimSize](../vs140/colesafearray--getonedimsize.md)   
 [COleSafeArray::ResizeOneDim](../vs140/colesafearray--resizeonedim.md)   
 [COleSafeArray::Create](../vs140/colesafearray--create.md)