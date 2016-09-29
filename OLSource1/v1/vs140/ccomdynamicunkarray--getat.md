---
title: "CComDynamicUnkArray::GetAt"
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
  - "CComDynamicUnkArray.GetAt"
  - "CComDynamicUnkArray::GetAt"
  - "ATL::CComDynamicUnkArray::GetAt"
  - "ATL.CComDynamicUnkArray.GetAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAt method [ATL]"
ms.assetid: e68a25ed-5cc0-4fd5-bcb0-b074413a2212
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComDynamicUnkArray::GetAt
Retrieves the element at the specified index.  
  
## Syntax  
  
```  
  
      IUnknown* GetAt(  
   int nIndex   
);  
```  
  
#### Parameters  
 `nIndex`  
 The index of the element to retrieve.  
  
## Return Value  
 A pointer to an [IUnknown](http://msdn.microsoft.com/library/windows/desktop/ms680509) interface.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)