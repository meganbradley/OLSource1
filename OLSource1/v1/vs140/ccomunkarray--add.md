---
title: "CComUnkArray::Add"
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
  - "CComUnkArray<1>::Add"
  - "CComUnkArray<nMaxSize>.Add"
  - "ATL::CComUnkArray<1>::Add"
  - "ATL.CComUnkArray.Add"
  - "CComUnkArray.Add"
  - "CComUnkArray<1>.Add"
  - "ATL::CComUnkArray::Add"
  - "CComUnkArray<nMaxSize>::Add"
  - "ATL::CComUnkArray<nMaxSize>::Add"
  - "ATL.CComUnkArray<1>.Add"
  - "ATL.CComUnkArray<nMaxSize>.Add"
  - "CComUnkArray::Add"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Add method [ATL]"
ms.assetid: 1dd5d4df-aeae-4c9a-8c74-171191ebac76
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::Add
Call this method to add an **IUnknown** pointer to the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pUnk*  
 Call this method to add an **IUnknown** pointer to the array.  
  
## Return Value  
 Returns the cookie associated with the newly added pointer, or 0 if the array is not large enough to contain the new pointer.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::Remove](../vs140/ccomunkarray--remove.md)