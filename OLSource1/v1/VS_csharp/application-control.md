---
title: "Application Control"
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
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "application control"
ms.assetid: c1f69f15-e0fe-4515-9f36-d63d31869deb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Application Control
OLE requires substantial control over applications and their objects. The OLE system DLLs must be able to launch and release applications automatically, coordinate their production and modification of objects, and so on. The functions in this topic meet those requirements. In addition to being called by the OLE system DLLs, these functions must sometimes be called by applications as well.  
  
### Application Control  
  
|||  
|-|-|  
|[AfxOleCanExitApp](../VS_csharp/afxolecanexitapp.md)|Indicates whether the application can terminate.|  
|[AfxOleGetMessageFilter](../VS_csharp/afxolegetmessagefilter.md)|Retrieves the application's current message filter.|  
|[AfxOleGetUserCtrl](../VS_csharp/afxolegetuserctrl.md)|Retrieves the current user-control flag.|  
|[AfxOleSetUserCtrl](../VS_csharp/afxolesetuserctrl.md)|Sets or clears the user-control flag.|  
|[AfxOleLockApp](../VS_csharp/afxolelockapp.md)|Increments the framework's global count of the number of active objects in an application.|  
|[AfxOleUnlockApp](../VS_csharp/afxoleunlockapp.md)|Decrements the framework's count of the number of active objects in an application.|  
|[AfxOleRegisterServerClass](../VS_csharp/afxoleregisterserverclass.md)|Registers a server in the OLE system registry.|  
|[AfxOleSetEditMenu](../VS_csharp/afxoleseteditmenu.md)|Implements the user interface for the *typename* Object command.|  
  
## See Also  
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)