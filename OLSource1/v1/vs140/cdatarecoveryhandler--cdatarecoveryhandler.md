---
title: "CDataRecoveryHandler::CDataRecoveryHandler"
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
  - "CDataRecoveryHandler::CDataRecoveryHandler"
  - "CDataRecoveryHandler"
  - "CDataRecoveryHandler.CDataRecoveryHandler"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDataRecoveryHandler constructor"
ms.assetid: 3984a1ff-68d3-4184-b6dd-7e3eb724bf83
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::CDataRecoveryHandler
Constructs a `CDataRecoveryHandler` object.  
  
## Syntax  
  
```  
CDataRecoveryHandler(  
   DWORD dwRestartManagerSupportFlags,  
   int nAutosaveInterval  
);  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `dwRestartManagerSupportFlags`|Indicates which options of the restart manager are supported.|  
|[in] `nAutosaveInterval`|The time between autosaves. This parameter is in milliseconds.|  
  
## Remarks  
 The MFC framework automatically creates a `CDataRecoveryHandler` object for your application when you use the **New Project** wizard. Unless you are customizing the data recovery behavior or the restart manager, you should not create a `CDataRecoveryHandler` object.  
  
 For more information about the support flags, see [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md).  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)