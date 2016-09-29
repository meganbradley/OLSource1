---
title: "Troubleshooting: Log Listeners (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "event logs, troubleshooting"
  - "troubleshooting Visual Basic, event logs"
  - "troubleshooting event logs"
ms.assetid: ac6eb760-3d5d-461e-aedd-40599ee22e49
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting: Log Listeners (Visual Basic)
You can use the `My.Application.Log` and `My.Log` objects to log information about events that occur in your application.  
  
 To determine which log listeners receive those messages, see [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md).  
  
 The `Log` object can use log filtering to limit the amount of information that it logs. If the filters are misconfigured, the logs might contain the wrong information. For more information about filtering, see [Walkthrough: Filtering My.Application.Log Output](../vs140/walkthrough--filtering-my.application.log-output--visual-basic-.md).  
  
 However, if a log is configured incorrectly, you may need more information about its current configuration. You can get to this information through the log's advanced `TraceSource` property.  
  
### To determine the log listeners for the Log object in code  
  
1.  Import the <xref:System.Diagnostics*> namespace at the beginning of the code file. For more information, see [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md).  
  
     [!code[VbVbalrMyApplicationLog#13](../vs140/codesnippet/VisualBasic/troubleshooting--log-listeners--visual-basic-_1.vb)]  
  
2.  Create a function that returns a string consisting of information for each of the log's listeners.  
  
     [!code[VbVbalrMyApplicationLog#14](../vs140/codesnippet/VisualBasic/troubleshooting--log-listeners--visual-basic-_2.vb)]  
  
3.  Pass the collection of the log's trace listeners to the `GetListeners` function, and display the return value.  
  
     [!code[VbVbalrMyApplicationLog#19](../vs140/codesnippet/VisualBasic/troubleshooting--log-listeners--visual-basic-_3.vb)]  
  
     For more information, see <xref:Microsoft.VisualBasic.Logging.Log.TraceSource*>.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)