---
title: "AfxConnectionUnadvise"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFXCTL/AfxConnectionUnadvise"
  - "AfxConnectionUnadvise"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxConnectionUnadvise function"
ms.assetid: fbb8abb6-5921-439e-9636-d53e99a72118
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxConnectionUnadvise
Call this function to disconnect a connection between a source, specified by `pUnkSrc`, and a sink, specified by `pUnkSink`.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxConnectionUnadvise(  
   LPUNKNOWN pUnkSrc,  
   REFIID iid,  
   LPUNKNOWN pUnkSink,  
   BOOL bRefCount,  
   DWORD dwCookie   
);  
```  
  
#### Parameters  
 `pUnkSrc`  
 A pointer to the object that calls the interface.  
  
 `pUnkSink`  
 A pointer to the object that implements the interface.  
  
 `iid`  
 The interface ID of the connection point interface.  
  
 `bRefCount`  
 **TRUE** indicates that disconnecting the connection should cause the reference count of `pUnkSink` to be decremented. **FALSE** indicates that the reference count should not be decremented.  
  
 `dwCookie`  
 The connection identifier returned by `AfxConnectionAdvise`.  
  
## Return Value  
 Nonzero if a connection was disconnected; otherwise 0.  
  
## Example  
 [!code[NVC_MFCConnectionPoints#9](../VS_csharp/codesnippet/CPP/afxconnectionunadvise_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [AfxConnectionAdvise](../VS_csharp/afxconnectionadvise.md)