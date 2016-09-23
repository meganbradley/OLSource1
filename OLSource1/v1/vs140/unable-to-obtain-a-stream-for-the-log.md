---
title: "Unable to obtain a stream for the log"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbrApplicationLog_ExhaustedPossibleStreamNames
ms.assetid: 33994f52-8efb-4790-a459-033e5c1db632
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Unable to obtain a stream for the log
Unable to obtain a stream for the log. Potential file names based on <name\> are already in use.  
  
 The <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False> class could not create a new log file because all potential log file names based on <name\> are already in use.  
  
 Having too many log files may indicate an architectural problem with the application. See the documentation for the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False> class for more information.  
  
### To correct this error  
  
1.  Set the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.LogFileCreationSchedule?qualifyHint=False> property to <xref:Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption.Daily?qualifyHint=False> or <xref:Microsoft.VisualBasic.Logging.LogFileCreationScheduleOption.Weekly?qualifyHint=False> to include a date-stamp in the log file name.  
  
2.  Archive the existing logs and remove them from the computer to allow the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False> object to create new logs.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener?qualifyHint=False>   
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.LogFileCreationSchedule?qualifyHint=False>   
 [My.Application.Log Object](../vs140/my.application.log-object.md)   
 [My.Log Object](../vs140/my.log-object.md)