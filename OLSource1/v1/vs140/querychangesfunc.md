---
title: "QUERYCHANGESFUNC"
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
  - "QUERYCHANGESFUNC"
helpviewer_keywords: 
  - "QUERYCHANGESFUNC callback function"
  - "QUERYCHANGESDATA structure"
ms.assetid: 9d383e2c-eee1-4996-973a-0652d4c5951c
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# QUERYCHANGESFUNC
This is a callback function used by the [SccQueryChanges](../vs140/sccquerychanges-function.md) operation to enumerate a collection of file names and determine each file's status.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> function is given a list of files and a pointer to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> callback. The source control plug-in enumerates over the given list and provides status (via this callback) for each file in the list.  
  
## Signature  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parameters  
 pvCallerData  
 [in] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter passed by the caller (the IDE) to [SccQueryChanges](../vs140/sccquerychanges-function.md). The source control plug-in should make no assumptions about the contents of this value.  
  
 pChangesData  
 [in] Pointer to a [QUERYCHANGESDATA](#LinkQUERYCHANGESDATA) structure describing the changes to a file.  
  
## Return Value  
 The IDE returns an appropriate error code:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|Continue processing.|  
|SCC_I_OPERATIONCANCELED|Stop processing.|  
|SCC_E_xxx|Any appropriate SCC error should stop processing.|  
  
##  \<a name="LinkQUERYCHANGESDATA">\</a> QUERYCHANGESDATA Structure  
 The structure passed in for each file looks like the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 dwSize  
 Size of this structure (in bytes).  
  
 lpFileName  
 The original file name for this item.  
  
 dwChangeType  
 Code indicating status of the file:  
  
|Code|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Cannot tell what has changed.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|No name changes for this file.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|File with a different identity, but the same name exists in the database.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|File does not exist either in the database or locally.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|File deleted in the database.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|File deleted locally but the file still exists in the database. If this cannot be determined, return <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|File added to the database but does not exist locally.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|File does not exist in database and is a new local file.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|File renamed or moved in the database as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|File renamed or moved in the database from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>; if this is too expensive to track, return a different flag, such as <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
 lpLatestName  
 The current file name for this item.  
  
## See Also  
 [Callback Functions Implemented by the IDE](../vs140/callback-functions-implemented-by-the-ide.md)   
 [SccQueryChanges](../vs140/sccquerychanges-function.md)   
 [Error Codes](../vs140/error-codes.md)