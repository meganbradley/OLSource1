---
title: "CComUnkArray::GetUnknown"
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
  - "ATL::CComUnkArray<nMaxSize>::GetUnknown"
  - "CComUnkArray::GetUnknown"
  - "GetUnknown"
  - "ATL::CComUnkArray<1>::GetUnknown"
  - "CComUnkArray<1>::GetUnknown"
  - "CComUnkArray<1>.GetUnknown"
  - "ATL.CComUnkArray<nMaxSize>.GetUnknown"
  - "ATL.CComUnkArray.GetUnknown"
  - "CComUnkArray.GetUnknown"
  - "ATL::CComUnkArray::GetUnknown"
  - "CComUnkArray<nMaxSize>::GetUnknown"
  - "ATL.CComUnkArray<1>.GetUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUnknown method"
ms.assetid: cc921e9f-2d9d-4756-969a-51e740989039
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::GetUnknown
Call this method to get the **IUnknown** pointer associated with a given cookie.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The cookie for which the associated **IUnknown** pointer is required.  
  
## Return Value  
 Returns the **IUnknown** pointer, or NULL if no matching cookie is found.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::GetCookie](../vs140/ccomunkarray--getcookie.md)