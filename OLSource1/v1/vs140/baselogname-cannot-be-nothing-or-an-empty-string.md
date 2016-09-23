---
title: "BaseLogName cannot be Nothing or an empty String"
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
  - vbrApplicationLogBaseNameNull
ms.assetid: 8e7665e3-5343-45fa-bc79-64e235a0477f
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BaseLogName cannot be Nothing or an empty String
The value of the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.BaseFileName?qualifyHint=False> property cannot be `Nothing` or an empty string.  
  
 The <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.BaseFileName?qualifyHint=False> property specifies the base name for the log files.  
  
### To correct this error  
  
-   Set the <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.BaseFileName?qualifyHint=False> property to a string that contains at least one character.  
  
## See Also  
 <xref:Microsoft.VisualBasic.Logging.FileLogTraceListener.BaseFileName?qualifyHint=False>   
 [My.Application.Log Object](../vs140/my.application.log-object.md)   
 [My.Log Object](../vs140/my.log-object.md)