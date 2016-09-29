---
title: "Unable to write to log file because writing to it would reduce free disk space below ReservedSpace value"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbrApplicationLog_ReservedSpaceEncroached"
ms.assetid: 95832e70-4ecc-47aa-90c1-f35c4d468151
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unable to write to log file because writing to it would reduce free disk space below ReservedSpace value
The <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener*> class could not write to the log file because:  
  
-   The amount of free disk space (in bytes) is less than the value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.ReserveDiskSpace*> property  
  
     —and—  
  
-   The value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior*> property was <xref:Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption.ThrowException*>.  
  
### To correct this error  
  
1.  Archive the existing logs and remove them from the computer to allow the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener*> object to create new logs.  
  
2.  Change the value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.ReserveDiskSpace*> property to a smaller number to reserve less disk space.  
  
3.  Set the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior*> property to <xref:Microsoft.VisualBasic.Logging.DiskSpaceExhaustedOption.DiscardMessages*> to discard messages without warning if there is not enough free disk space.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.ReserveDiskSpace*>   
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.DiskSpaceExhaustedBehavior*>   
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener*>   
 [My.Application.Log Object](../vs140/my.application.log-object.md)   
 [My.Log Object](../vs140/my.log-object.md)