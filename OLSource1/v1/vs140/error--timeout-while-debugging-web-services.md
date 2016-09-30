---
title: "Error: Timeout While Debugging Web Services"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, Web application errors"
  - "XML Web services, timeout while debugging"
ms.assetid: 4b7df112-788a-4429-9a0c-4c6dac4fb609
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Error: Timeout While Debugging Web Services
When you are stepping into an XML Web service from calling code, the call may sometimes time out, with the result being that you cannot continue debugging. You may see an error message such as this.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Solution  
 To avoid this problem, set the timeout value for the call to the XML Web service to infinite, as shown in this example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Debugging Web Applications: Errors and Troubleshooting](../vs140/debugging-web-applications--errors-and-troubleshooting.md)