---
title: "How to: Log Exceptions in Visual Basic"
ms.custom: na
ms.date: "10/03/2016"
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
  - "exceptions, logging"
  - "exceptions, tracking"
ms.assetid: a26c60e2-ae39-444a-aebb-33eccadc0eeb
caps.latest.revision: 19
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Log Exceptions in Visual Basic
You can use the `My.Application.Log` and `My.Log` objects to log information about exceptions that occur in your application. These examples show how to use the `My.Application.Log.WriteException` method to log exceptions that you catch explicitly and exceptions that are unhandled.  
  
 For logging tracing information, use the `My.Application.Log.WriteEntry` method. For more information, see \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>  
  
### To log a handled exception  
  
1.  Create the method that will generate the exception information.  
  
     [!code[VbVbalrMyApplicationLog#9](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_1.vb)]  
  
2.  Use a `Try...Catch` block to catch the exception.  
  
     [!code[VbVbalrMyApplicationLog#6](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_2.vb)]  
  
3.  Put the code that could generate an exception in the `Try` block.  
  
     Uncomment the `Dim` and `MsgBox` lines to cause a \<xref:System.NullReferenceException> exception.  
  
     [!code[VbVbalrMyApplicationLog#7](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_3.vb)]  
  
4.  In the `Catch` block, use the `My.Application.Log.WriteException` method to write the exception information.  
  
     [!code[VbVbalrMyApplicationLog#8](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_4.vb)]  
  
     The following example shows the complete code for logging a handled exception.  
  
     [!code[VbVbalrMyApplicationLog#10](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_5.vb)]  
  
### To log an unhandled exception  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, choose **Properties**.  
  
2.  Click the **Application** tab.  
  
3.  Click the **View Application Events** button to open the Code Editor.  
  
     This opens the ApplicationEvents.vb file.  
  
4.  Have the ApplicationEvents.vb file open in the Code Editor. On the **General** menu, choose **MyApplication Events**.  
  
5.  On the **Declarations** menu, choose **UnhandledException**.  
  
     The application raises the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.UnhandledException> event before the main application runs.  
  
6.  Add the `My.Application.Log.WriteException` method to the `UnhandledException` event handler.  
  
     [!code[VbVbalrMyApplicationLog#4](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_6.vb)]  
  
     The following example shows the complete code for logging an unhandled exception.  
  
     [!code[VbVbalrMyApplicationLog#5](../VS_visualbasic/codesnippet/VisualBasic/how-to--log-exceptions-in-visual-basic_7.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*>   
 [Working with Application Logs](../VS_visualbasic/working-with-application-logs-in-visual-basic.md)   
 [How to: Write Log Messages](../VS_visualbasic/how-to--write-log-messages--visual-basic-.md)   
 [Walkthrough: Determining Where My.Application.Log Writes Information](../VS_visualbasic/walkthrough--determining-where-my.application.log-writes-information--visual-basic-.md)   
 [Walkthrough: Changing Where My.Application.Log Writes Information](../VS_visualbasic/walkthrough--changing-where-my.application.log-writes-information--visual-basic-.md)