---
title: "File Tracking"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - msbuild, file tracking
ms.assetid: e6c66ac0-3464-451f-9192-3b98dca21b4a
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# File Tracking
File tracking logs calls to the Windows file system for a process and its child processes. By calling the functions listed below, programs control when to turn this logging on and off and specify the log file to use.  
  
## In This Section  
 [EndTrackingContext](../vs140/endtrackingcontext.md)  
 Stop tracking the current context.  
  
 [ResumeTracking](../vs140/resumetracking.md)  
 Resume tracking after a call to [SuspendTracking](../vs140/suspendtracking.md).  
  
 [SetThreadCount](../vs140/setthreadcount.md)  
 Set the number of threads to use for tracking.  
  
 [StartTrackingContext](../vs140/starttrackingcontext.md)  
 Begin a new tracking context.  
  
 [StartTrackingContextWithRoot](../vs140/starttrackingcontextwithroot.md)  
 Begin a new tracking context with a specified root.  
  
 [StopTrackingAndCleanup](../vs140/stoptrackingandcleanup.md)  
 End tracking and release resources used.  
  
 [SuspendTracking](../vs140/suspendtracking.md)  
 Temporarily suspend tracking.  
  
 [WriteAllTLogs](../vs140/writealltlogs.md)  
 Write out the tracking logs for all contexts.  
  
 [WriteContextTLogs](../vs140/writecontexttlogs.md)  
 Write out the tracking log for the current context.