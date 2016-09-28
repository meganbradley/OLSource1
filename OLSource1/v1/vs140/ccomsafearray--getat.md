---
title: "CComSafeArray::GetAt"
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
  - "CComSafeArray::GetAt"
  - "CComSafeArray.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [ATL]"
ms.assetid: dbc38d74-7d18-4c6b-91b3-9c01fa5220fe
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComSafeArray::GetAt
Retrieves a single element from a single-dimensional array.  
  
## Syntax  
  
```  
  
      T& GetAt(  
   LONG lIndex   
) const;  
```  
  
#### Parameters  
 `lIndex`  
 The index number of the value in the array to return.  
  
## Return Value  
 Returns a reference to the required array element.  
  
## Requirements  
 **Header:** atlsafe.h  
  
## See Also  
 [CComSafeArray Class](../vs140/ccomsafearray-class.md)   
 [CComSafeArray::MultiDimGetAt](../vs140/ccomsafearray--multidimgetat.md)   
 [CComSafeArray::SetAt](../vs140/ccomsafearray--setat.md)