---
title: "How to: Write Log Messages (Visual Basic)"
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
  - "My.Application.Log object, writing log messags"
ms.assetid: 972a3e0c-2996-4623-a7a9-d7ebc4d207f8
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write Log Messages (Visual Basic)
You can use the `My.Application.Log` and `My.Log` objects to log information about your application. This example shows how to use the `My.Application.Log.WriteEntry` method to log tracing information.  
  
 For logging exception information, use the `My.Application.Log.WriteException` method; see [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md).  
  
## Example  
 This example uses the `My.Application.Log.WriteEntry` method to write out the trace information.  
  
 [!code[VbVbalrMyApplicationLog#11](../vs140/codesnippet/VisualBasic/how-to--write-log-messages--visual-basic-_1.vb)]  
  
## .NET Framework Security  
 Make sure the data you write to the log does not include sensitive information such as user passwords. For more information, see [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md).  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*>   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)   
 [How to: Log Exceptions in Visual Basic](../vs140/how-to--log-exceptions-in-visual-basic.md)   
 [Walkthrough: Determining Where My.Application.Log Writes Information](../vs140/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)   
 [Walkthrough: Changing Where My.Application.Log Writes Information](../vs140/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)   
 [Walkthrough: Filtering My.Application.Log Output](../vs140/walkthrough--filtering-my.application.log-output--visual-basic-.md)