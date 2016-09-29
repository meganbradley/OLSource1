---
title: "CWinApp::Unregister"
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
  - "Unregister"
  - "CWinApp::Unregister"
  - "CWinApp.Unregister"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unregister method"
ms.assetid: 09689545-56a7-49f5-8151-8a7a5c1bd6be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::Unregister
Unregisters all files registered by the application object.  
  
## Syntax  
  
```  
  
virtual BOOL Unregister( );  
  
```  
  
## Return Value  
 Nonzero on success; otherwise 0.  
  
## Remarks  
 The `Unregister` function undoes the registration performed by the application object and the [Register](../vs140/cwinapp--register.md) function. Normally, both functions are called implicitly by MFC and therefore will not appear in your code.  
  
 Override this function to perform custom unregistration steps.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::RegisterShellFileTypes](../vs140/cwinapp--registershellfiletypes.md)