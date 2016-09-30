---
title: "SccCloseProject Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "SccCloseProject"
helpviewer_keywords: 
  - "SccCloseProject function"
ms.assetid: 259c2069-d349-4814-810f-1c3151b7fb84
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccCloseProject Function
This function closes a project, marking the end of a particular session.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pvContext  
 The source control plug-in context structure.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The project was successfully closed.|  
|SCC_E_PROJNOTOPEN|No project is currently open.|  
|SCC_E_NOTAUTHORIZED|The user is not allowed to perform this operation.|  
|SCC_E_NONSPECIFICERROR|Nonspecific failure.|  
  
## Remarks  
 The [SccOpenProject Function](../vs140/sccopenproject-function.md) is always called before this function. A call to this function is then followed by a call to either the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function or the [SccUninitialize Function](../vs140/sccuninitialize-function.md), which ends the connection to the source control system completely.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [SccOpenProject Function](../vs140/sccopenproject-function.md)   
 [SccInitialize Function](../vs140/sccinitialize-function.md)