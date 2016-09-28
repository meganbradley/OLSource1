---
title: "CDataRecoveryHandler::SetShutdownByRestartManager"
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
  - "SetShutdownByRestartManager"
  - "CDataRecoveryHandler.SetShutdownByRestartManager"
  - "CDataRecoveryHandler::SetShutdownByRestartManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetShutdownByRestartManager method"
ms.assetid: 81222c7c-f75f-4f02-bd50-9264e8b9bea2
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::SetShutdownByRestartManager
Sets whether the previous exit of the application was caused by the restart manager.  
  
## Syntax  
  
```  
virtual void SetShutdownByRestartManager(  
   BOOL bShutdownByRestartManager  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `bShutdownByRestartManager`|`TRUE` to indicate that the restart manager caused the application to exit; `FALSE` to indicate that the application exited for another reason.|  
  
## Remarks  
 The framework behaves differently based on whether the previous exit was unexpected or whether it was initiated by the restart manager.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::GetShutdownByRestartManager](../vs140/cdatarecoveryhandler--getshutdownbyrestartmanager.md)