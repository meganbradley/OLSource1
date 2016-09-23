---
title: "Application Control"
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
  - vc.mfc.macros
dev_langs: 
  - C++
helpviewer_keywords: 
  - application control
ms.assetid: c1f69f15-e0fe-4515-9f36-d63d31869deb
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Application Control
OLE requires substantial control over applications and their objects. The OLE system DLLs must be able to launch and release applications automatically, coordinate their production and modification of objects, and so on. The functions in this topic meet those requirements. In addition to being called by the OLE system DLLs, these functions must sometimes be called by applications as well.  
  
### Application Control  
  
|||  
|-|-|  
|[AfxOleCanExitApp](../vs140/afxolecanexitapp.md)|Indicates whether the application can terminate.|  
|[AfxOleGetMessageFilter](../vs140/afxolegetmessagefilter.md)|Retrieves the application's current message filter.|  
|[AfxOleGetUserCtrl](../vs140/afxolegetuserctrl.md)|Retrieves the current user-control flag.|  
|[AfxOleSetUserCtrl](../vs140/afxolesetuserctrl.md)|Sets or clears the user-control flag.|  
|[AfxOleLockApp](../vs140/afxolelockapp.md)|Increments the framework's global count of the number of active objects in an application.|  
|[AfxOleUnlockApp](../vs140/afxoleunlockapp.md)|Decrements the framework's count of the number of active objects in an application.|  
|[AfxOleRegisterServerClass](../vs140/afxoleregisterserverclass.md)|Registers a server in the OLE system registry.|  
|[AfxOleSetEditMenu](../vs140/afxoleseteditmenu.md)|Implements the user interface for the *typename* Object command.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)