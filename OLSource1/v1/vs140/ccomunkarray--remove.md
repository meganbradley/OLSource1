---
title: "CComUnkArray::Remove"
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
  - "ATL.CComUnkArray<1>.Remove"
  - "CComUnkArray<1>::Remove"
  - "ATL::CComUnkArray::Remove"
  - "CComUnkArray<nMaxSize>.Remove"
  - "ATL::CComUnkArray<1>::Remove"
  - "CComUnkArray<nMaxSize>::Remove"
  - "CComUnkArray.Remove"
  - "ATL::CComUnkArray<nMaxSize>::Remove"
  - "CComUnkArray::Remove"
  - "ATL.CComUnkArray<nMaxSize>.Remove"
  - "ATL.CComUnkArray.Remove"
  - "CComUnkArray<1>.Remove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remove method"
ms.assetid: 017bb3e7-c9ba-44cb-a570-fc306140fe96
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComUnkArray::Remove
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
 Returns **TRUE** if the pointer is removed, **FALSE** otherwise.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComUnkArray Class](../vs140/ccomunkarray-class.md)   
 [CComUnkArray::Add](../vs140/ccomunkarray--add.md)