---
title: "How to: Log Messages When the Application Starts or Shuts Down (Visual Basic)"
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
  - "event logs, shutdown"
  - "My.Application.Log object, logging"
  - "Startup event"
  - "event logs, startup"
  - "Shutdown event"
  - "My.Log object, logging"
ms.assetid: 67624d05-cddf-48b7-8c36-5c99baa4c621
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Log Messages When the Application Starts or Shuts Down (Visual Basic)
You can use the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects to log information about events that occur in your application. This example shows how to use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> events to write tracing information.  
  
### To access the application's event-handler code  
  
1.  Have a project selected in **Solution Explorer**. On the **Project** menu, choose **Properties**.  
  
2.  Click the **Application** tab.  
  
3.  Click the **View Application Events** button to open the Code Editor.  
  
     This opens the ApplicationEvents.vb file.  
  
### To log messages when the application starts  
  
1.  Have the ApplicationEvents.vb file open in the Code Editor. On the **General** menu, choose **MyApplication Events**.  
  
2.  On the **Declarations** menu, choose **Startup**.  
  
     The application raises the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.Startup*> event before the main application runs.  
  
3.  Add the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> event handler.  
  
     [!code[VbVbalrMyApplicationLog#1](../vs140/codesnippet/VisualBasic/how-to--log-messages-when-the-application-starts-or-shuts-down--visual-basic-_1.vb)]  
  
### To log messages when the application shuts down  
  
1.  Have the ApplicationEvents.vb file open in the Code Editor. On the **General** menu, choose **MyApplication Events**.  
  
2.  On the **Declarations** menu, choose **Shutdown**.  
  
     The application raises the \<xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.Shutdown*> event after the main application runs, but before it shuts down.  
  
3.  Add the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> event handler.  
  
     [!code[VbVbalrMyApplicationLog#2](../vs140/codesnippet/VisualBasic/how-to--log-messages-when-the-application-starts-or-shuts-down--visual-basic-_2.vb)]  
  
## Example  
 You can use the **Project Designer** to access the application events in the Code Editor. For more information, see [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md).  
  
 [!code[VbVbalrMyApplicationLog#3](../vs140/codesnippet/VisualBasic/how-to--log-messages-when-the-application-starts-or-shuts-down--visual-basic-_3.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Logging.Log*?displayProperty=fullName>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteEntry*>   
 \<xref:Microsoft.VisualBasic.Logging.Log.WriteException*>   
 [Application Page, Project Designer (Visual Basic)](../vs140/application-page--project-designer--visual-basic-.md)   
 [Working with Application Logs in Visual Basic](../vs140/working-with-application-logs-in-visual-basic.md)