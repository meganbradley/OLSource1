---
title: "AfxSocketInit"
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
  - AFXSOCK/AfxSocketInit
  - AfxSocketInit
dev_langs: 
  - C++
helpviewer_keywords: 
  - AfxSocketInit function
ms.assetid: a0ef181b-fd25-4866-ae9b-86cf06cb5ca5
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AfxSocketInit
Call this function in your `CWinApp::InitInstance` override to initialize Windows Sockets.  
  
## Syntax  
  
```  
  
      BOOL AfxSocketInit(  
   WSADATA* lpwsaData = NULL   
);  
```  
  
#### Parameters  
 `lpwsaData`  
 A pointer to a [WSADATA](../vs140/wsadata-structure.md) structure. If `lpwsaData` is not equal to `NULL`, then the address of the `WSADATA` structure is filled by the call to `WSAStartup`. This function also ensures that `WSACleanup` is called for you before the application terminates.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 When using MFC sockets in secondary threads in a statically linked MFC application, you must call `AfxSocketInit` in each thread that uses sockets to initialize the socket libraries. By default, `AfxSocketInit` is called only in the primary thread.  
  
## Code  
 [!code[NVC_MFCAsyncSocket#4](../vs140/codesnippet/CPP/afxsocketinit_1.cpp)]
  
  
## Requirements  
 **Header:** afxsock.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)