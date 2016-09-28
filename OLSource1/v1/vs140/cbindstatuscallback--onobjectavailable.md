---
title: "CBindStatusCallback::OnObjectAvailable"
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
  - "CBindStatusCallback::OnObjectAvailable"
  - "OnObjectAvailable"
  - "CBindStatusCallback.OnObjectAvailable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnObjectAvailable method"
ms.assetid: 69f9a72c-15c3-45ca-a7dc-5afa6e853cf0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBindStatusCallback::OnObjectAvailable
Called by the asynchronous moniker to pass an object interface pointer to your application.  
  
## Syntax  
  
```  
  
      STDMETHOD(OnObjectAvailable)(  
   REFID /* riid */,  
   IUnknown* /* punk */   
);  
```  
  
#### Parameters  
 `riid`  
 Interface identifier of the requested interface. Unused.  
  
 `punk`  
 Address of the IUnknown interface. Unused.  
  
## Return Value  
 Returns `S_OK`.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CBindStatusCallback Class](../vs140/cbindstatuscallback-class.md)