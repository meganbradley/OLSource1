---
title: "CComSafeArray::MultiDimSetAt"
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
  - "CComSafeArray::MultiDimSetAt"
  - "CComSafeArray.MultiDimSetAt"
  - "MultiDimSetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MultiDimSetAt method"
ms.assetid: 92d7b0af-147b-42d4-a37c-d60c5a8d162e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::MultiDimSetAt
Sets the value of an element in a multidimensional array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a vector of indexes for each dimension in the array. The rightmost (least significant) dimension is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>[0].  
  
 *T*  
 Specifies the value of the new element.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 This is a multidimensional version of [CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md).  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md)   
 [CComSafeArray::GetAt](../vs140/ccomsafearray--getat.md)   
 [CComSafeArray::MultiDimGetAt](../vs140/ccomsafearray--multidimgetat.md)