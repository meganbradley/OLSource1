---
title: "CComDynamicUnkArray::Remove"
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
  - "CComDynamicUnkArray.Remove"
  - "ATL::CComDynamicUnkArray::Remove"
  - "ATL.CComDynamicUnkArray.Remove"
  - "CComDynamicUnkArray::Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: a8538d3d-29a6-4b83-98d1-85cecb65a890
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComDynamicUnkArray::Remove
Call this method to remove an **IUnknown** pointer from the array.  
  
## Syntax  
  
```  
  
      BOOL Remove(  
   DWORD dwCookie   
);  
```  
  
#### Parameters  
 `dwCookie`  
 The cookie referencing the **IUnknown** pointer to be removed from the array.  
  
## Return Value  
 Returns TRUE if the pointer is removed; otherwise FALSE.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComDynamicUnkArray Class](../vs140/ccomdynamicunkarray-class.md)   
 [CComDynamicUnkArray::Add](../vs140/ccomdynamicunkarray--add.md)   
 [CComDynamicUnkArray::GetCookie](../vs140/ccomdynamicunkarray--getcookie.md)