---
title: "Troubleshooting Exceptions: System.DeploymentFramework.DeploymentDownloadException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "DeploymentDownloadException class"
  - "application deployment [C#], DeploymentDownloadException class"
  - "deploying applications [C#], DeploymentDownloadException class"
ms.assetid: 55ec7af5-b1d1-4db2-8af8-3c708f521cc7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.DeploymentFramework.DeploymentDownloadException
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> occurs if a network exception of any kind occurs when an application update is being downloaded.  
  
## Associated Tips  
 **Examine InnerException to determine the underlying System.Net or System.IO exception.**  
 This exception occurs whenever there is a network exception when an application update is being downloaded. Examine the exception's \<xref:System.Exception.InnerException*> property to determine the underlying exception.  
  
## See Also  
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)