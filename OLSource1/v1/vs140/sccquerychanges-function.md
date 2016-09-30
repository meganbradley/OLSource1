---
title: "SccQueryChanges Function"
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
  - "SccQueryChanges"
helpviewer_keywords: 
  - "SccQueryChanges function"
ms.assetid: 4cd58eb3-6952-49b1-9620-8682e3eaa604
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# SccQueryChanges Function
This function enumerates a given list of files, providing information about name changes for each file via a callback function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 pContext  
 [in] The source control plug-in context pointer.  
  
 nFiles  
 [in] Number of files in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> array.  
  
 lpFileNames  
 [in] Array of file names to get information about.  
  
 pfnCallback  
 [in] Callback function to call for each file name in the list (see [QUERYCHANGESFUNC](../vs140/querychangesfunc.md) for details).  
  
 pvCallerData  
 [in] Value that will be passed unchanged to the callback function.  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The query process completed successfully.|  
|SCC_E_PROJNOTOPEN|The project has not been opened in source control.|  
|SCC_E_ACCESSFAILURE|There was a problem accessing the source control system, probably due to network or contention issues.|  
|SCC_E_NONSPECIFICERROR|An unspecified or general error occurred.|  
  
## Remarks  
 Changes being queried for are to the namespace: specifically, renaming, adding, and removing a file.  
  
## See Also  
 [Source Control Plug-in API Functions](../vs140/source-control-plug-in-api-functions.md)   
 [QUERYCHANGESFUNC](../vs140/querychangesfunc.md)   
 [Error Codes](../vs140/error-codes.md)