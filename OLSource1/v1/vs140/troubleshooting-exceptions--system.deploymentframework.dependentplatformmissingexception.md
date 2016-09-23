---
title: "Troubleshooting Exceptions: System.DeploymentFramework.DependentPlatformMissingException"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - DependentPlatformMissingException class, troubleshooting
ms.assetid: fee1ca1c-0f0b-483b-b8ab-3743dfdda038
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Troubleshooting Exceptions: System.DeploymentFramework.DependentPlatformMissingException
A `T:System.DeploymentFramework.DependentPlatformMissingException` exception is thrown when an application depends on something not installed on this client. Possible causes include the wrong operating system or version of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] on the machine to which the application is being deployed.  
  
## Associated Tips  
 **Check that all assemblies required by the application are installed on the target computer.**  
 Every installation that attempts to use the Windows Installer begins by checking whether the installer is present on the user's computer, and, if it is not present, whether the computer is ready to install Windows Installer.  
  
## See Also  
 [How to: Find Out More About an Exception with the Exception Assistant](../vs140/how-to--use-the-exception-assistant.md)