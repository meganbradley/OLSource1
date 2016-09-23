---
title: "StopTrackingAndCleanup"
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
  - StopTrackingAndCleanup
apilocation: 
  - filetracker.dll
apitype: COM
helpviewer_keywords: 
  - StopTrackingAndCleanup
ms.assetid: 9f8c5994-2dfc-43c3-a5fb-89b2f8990429
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# StopTrackingAndCleanup
Stops all tracking and frees any memory used by the tracking session.  
  
## Syntax  
  
```  
HRESULT WINAPI StopTrackingAndCleanup(void);  
```  
  
## Return Value  
 Returns an [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if tracking was stopped.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [StartTrackingContext](../vs140/starttrackingcontext.md)