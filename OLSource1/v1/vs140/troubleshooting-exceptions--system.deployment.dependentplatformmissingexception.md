---
title: "Troubleshooting Exceptions: System.Deployment.DependentPlatformMissingException"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "DependentPlatformMissingException class"
ms.assetid: 2343eb4f-f23f-4b6c-a65c-1f93c3e6ea36
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Troubleshooting Exceptions: System.Deployment.DependentPlatformMissingException
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> exception is thrown when an attempt is made to run an application on a computer that is incompatible. This may occur when the wrong operating system or version of the .NET Framework is installed on the target computer.  
  
## Associated Tips  
 **Make sure that all assemblies required by the application are installed on the target computer.**  
 Every installation that attempts to use the Windows Installer begins by checking whether the installer is present on the user's computer, and, if it is not present, whether the computer is ready to install Windows Installer.  
  
## See Also  
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)