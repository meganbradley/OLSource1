---
title: "CComUnkArray::GetCookie"
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
  - "GetCookie"
  - "ATL::CComUnkArray::GetCookie"
  - "ATL::CComUnkArray<nMaxSize>::GetCookie"
  - "ATL.CComUnkArray.GetCookie"
  - "ATL.CComUnkArray<nMaxSize>.GetCookie"
  - "CComUnkArray<nMaxSize>::GetCookie"
  - "CComUnkArray.GetCookie"
  - "CComUnkArray::GetCookie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCookie method"
ms.assetid: 58574125-e969-425b-971d-c5dcee4c7911
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::GetCookie
Call this method to get the cookie associated with a given **IUnknown** pointer.  
  
## Syntax  
  
```  
  
      DWORD WINAPI GetCookie(  
   IUnknown** ppFind   
);  
```  
  
#### Parameters  
 `ppFind`  
 The **IUnknown** pointer for which the associated cookie is required.  
  
## Return Value  
 Returns the cookie associated with the **IUnknown** pointer, or 0 if no matching **IUnknown** pointer is found.  
  
## Remarks  
 If there is more than one instance of the same **IUnknown** pointer, this function returns the cookie for the first one.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::GetUnknown](../vs140/ccomunkarray--getunknown.md)