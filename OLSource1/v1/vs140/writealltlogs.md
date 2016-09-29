---
title: "WriteAllTLogs"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "WriteAllTLogs"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "WriteAllTLogs"
ms.assetid: 1fa3e10b-263c-4960-a9ad-485c02a7a872
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WriteAllTLogs
Writes tracking logs for all threads and contexts.  
  
## Syntax  
  
```  
HRESULT WINAPI WriteAllTLogs(LPCTSTR intermediateDirectory, LPCTSTR tlogRootName);  
```  
  
#### Parameters  
 [in] `intermediateDirectory`  
 The directory in which to store the tracking log.  
  
 [in] `tlogRootName`  
 The root name of the log file name.  
  
## Return Value  
 An [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if the tracking context was created.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [WriteContextTLogs](../vs140/writecontexttlogs.md)