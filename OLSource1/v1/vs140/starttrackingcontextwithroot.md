---
title: "StartTrackingContextWithRoot"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
apiname: 
  - StartTrackingContextWithRoot
apilocation: 
  - filetracker.dll
apitype: COM
helpviewer_keywords: 
  - StartTrackingContextWithRoot
ms.assetid: f6ef2b76-8035-4a14-8195-aa221c46ef48
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# StartTrackingContextWithRoot
Starts a tracking context using a response file specifying a root marker.  
  
## Syntax  
  
```  
HRESULT WINAPI StartTrackingContextWithRoot(LPCTSTR intermediateDirectory, LPCTSTR taskName, LPCTSTR rootMarkerResponseFile);  
```  
  
#### Parameters  
 [in] `intermediateDirectory`  
 The directory in which to store the tracking log.  
  
 [in] `taskName`  
 Identifies the tracking context. This name is used to create the log file name.  
  
 [in] `rootMarkerResponseFile`  
 The pathname of a response file containing a root marker. The root name is used to group all tracking for a context together.  
  
## Return Value  
 An [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if the tracking context was created.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [StartTrackingContext](../vs140/starttrackingcontext.md)