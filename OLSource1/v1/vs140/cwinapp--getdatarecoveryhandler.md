---
title: "CWinApp::GetDataRecoveryHandler"
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
  - "GetDataRecoveryHandler"
  - "CWinApp.GetDataRecoveryHandler"
  - "CWinApp::GetDataRecoveryHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDataRecoveryHandler method"
ms.assetid: e011b4f9-4a2f-4a43-b5e0-54e876a54ee0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinApp::GetDataRecoveryHandler
Gets the data recovery handler for this instance of the application.  
  
## Syntax  
  
```  
virtual CDataRecoveryHandler *GetDataRecoveryHandler();  
```  
  
## Return Value  
 The data recovery handler for this instance of the application.  
  
## Remarks  
 Each application that uses the restart manager must have one instance of the [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md). This class is responsible for monitoring open documents and autosaving files. The behavior of the `CDataRecoveryHandler` depends on the configuration of the restart manager. For more information, see [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md).  
  
 This method returns `NULL` on operating systems earlier than [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. The restart manager is not supported on operating systems earlier than [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 If the application does not currently have a data recovery handler, this method creates one and returns a pointer to it.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWinApp Class](../vs140/cwinapp-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)