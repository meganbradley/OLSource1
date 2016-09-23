---
title: "ResumeTracking"
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
  - ResumeTracking
apilocation: 
  - filetracker.dll
apitype: COM
helpviewer_keywords: 
  - ResumeTracking
ms.assetid: d637e019-7c50-4b0a-812e-bc822001e697
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# ResumeTracking
Resumes tracking in the current context.  
  
## Syntax  
  
```  
HRESULT WINAPI ResumeTracking();  
```  
  
## Return Value  
 An [HRESULT](assetId:///HRESULT?qualifyHint=False&autoUpgrade=True) with the [SUCCEEDED](assetId:///SUCCEEDED?qualifyHint=False&autoUpgrade=True) bit set if tracking was resumed. [E_FAIL](assetId:///E_FAIL?qualifyHint=False&autoUpgrade=True) is returned if tracking cannot be resumed because the context was not available.  
  
## Requirements  
 **Header:** FileTracker.h  
  
## See Also  
 [SuspendTracking](../vs140/suspendtracking.md)