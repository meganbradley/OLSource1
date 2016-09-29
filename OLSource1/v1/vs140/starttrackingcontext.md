---
title: "StartTrackingContext"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "StartTrackingContext"
apilocation: 
  - "filetracker.dll"
apitype: "COM"
helpviewer_keywords: 
  - "StartTrackingContext"
ms.assetid: 720cd295-38e7-4974-86db-b8106b1207ba
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# StartTrackingContext
Start a tracking context.  
  
## Syntax  
  
```  
HRESULT WINAPI StartTrackingContext(LPCTSTR intermediateDirectory, LPCTSTR taskName);  
```  
  
#### Parameters  
 [in] `intermediateDirectory`  
 The directory in which to store the tracking log.  
  
 [in] `taskName`  
 Identifies the tracking context. This name is used to create the log file name.  
  
## Return Value  
 An [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if the tracking context was created.  
  
## Requirements  
 **Header:** FileTracker.h