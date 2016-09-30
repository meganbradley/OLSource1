---
title: "CComDynamicUnkArray::GetUnknown"
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
  - "CComDynamicUnkArray::GetUnknown"
  - "GetUnknown"
  - "CComDynamicUnkArray.GetUnknown"
  - "ATL::CComDynamicUnkArray::GetUnknown"
  - "ATL.CComDynamicUnkArray.GetUnknown"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUnknown method"
ms.assetid: c1fad18b-43f7-4035-8f15-8658c595c0c0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComDynamicUnkArray::GetUnknown
Call this method to get the **IUnknown** pointer associated with a given cookie.  
  
## Syntax  
  
```  
  
      IUnknown* WINAPI GetUnknown(  
   DWORD dwCookie   
);  
```  
  
#### Parameters  
 `dwCookie`  
 The cookie for which the associated **IUnknown** pointer is required.  
  
## Return Value  
 Returns the **IUnknown** pointer, or NULL if no matching cookie is found.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [CComDynamicUnkArray::GetCookie](../vs140/ccomdynamicunkarray--getcookie.md)