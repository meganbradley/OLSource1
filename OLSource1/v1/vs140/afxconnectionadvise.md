---
title: "AfxConnectionAdvise"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - AfxConnectionAdvise
  - AFXCTL/AfxConnectionAdvise
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxConnectionAdvise function
ms.assetid: 741f9736-551c-4332-bddc-03a4910c7882
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxConnectionAdvise
Call this function to establish a connection between a source, specified by `pUnkSrc`, and a sink, specified by `pUnkSink`.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxConnectionAdvise(  
   LPUNKNOWN pUnkSrc,  
   REFIID iid,  
   LPUNKNOWN pUnkSink,  
   BOOL bRefCount,  
   DWORD FAR* pdwCookie   
);  
```  
  
#### Parameters  
 `pUnkSrc`  
 A pointer to the object that calls the interface.  
  
 `pUnkSink`  
 A pointer to the object that implements the interface.  
  
 `iid`  
 The interface ID of the connection.  
  
 `bRefCount`  
 **TRUE** indicates that creating the connection should cause the reference count of `pUnkSink` to be incremented. **FALSE** indicates that the reference count should not be incremented.  
  
 `pdwCookie`  
 A pointer to a `DWORD` where a connection identifier is returned. This value should be passed as the `dwCookie` parameter to `AfxConnectionUnadvise` when disconnecting the connection.  
  
## Return Value  
 Nonzero if a connection was established; otherwise 0.  
  
## Example  
 [!code[NVC_MFCConnectionPoints#8](../vs140/codesnippet/CPP/afxconnectionadvise_1.cpp)]
  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxConnectionUnadvise](../vs140/afxconnectionunadvise.md)