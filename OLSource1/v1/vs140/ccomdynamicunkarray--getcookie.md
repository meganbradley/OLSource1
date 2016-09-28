---
title: "CComDynamicUnkArray::GetCookie"
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
  - "ATL.CComDynamicUnkArray.GetCookie"
  - "CComDynamicUnkArray::GetCookie"
  - "ATL::CComDynamicUnkArray::GetCookie"
  - "CComDynamicUnkArray.GetCookie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCookie method"
ms.assetid: 52779134-9f6e-4e11-b7ed-03b18bbb257b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComDynamicUnkArray::GetCookie
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
 Returns the cookie associated with the **IUnknown** pointer, or zero if no matching **IUnknown** pointer is found.  
  
## Remarks  
 If there is more than one instance of the same **IUnknown** pointer, this function returns the cookie for the first one.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [CComDynamicUnkArray::Add](../vs140/ccomdynamicunkarray--add.md)   
 [CComDynamicUnkArray::Remove](../vs140/ccomdynamicunkarray--remove.md)   
 [CComDynamicUnkArray::GetUnknown](../vs140/ccomdynamicunkarray--getunknown.md)