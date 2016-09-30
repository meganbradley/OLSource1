---
title: "CDataRecoveryHandler::SetRestartIdentifier"
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
  - "CDataRecoveryHandler.SetRestartIdentifier"
  - "SetRestartIdentifier"
  - "CDataRecoveryHandler::SetRestartIdentifier"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRestartIdentifier method"
ms.assetid: 33c0fea6-e2c7-48a4-9c7e-8cfededaee67
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataRecoveryHandler::SetRestartIdentifier
Sets the unique restart identifier for this instance of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|The unique identifier for the restart manager.|  
  
## Remarks  
 The restart manager records information about the open documents in the registry. This information is stored with the unique restart identifier as the key. Because the restart identifier is unique for each instance of an application, multiple instances of an application may exit unexpectedly and the restart manager can recover each of them.  
  
## Requirements  
 **Header:** afxdatarecovery.h  
  
## See Also  
 [CDataRecoveryHandler Class](../vs140/cdatarecoveryhandler-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataRecoveryHandler::GetRestartIdentifier](../vs140/cdatarecoveryhandler--getrestartidentifier.md)