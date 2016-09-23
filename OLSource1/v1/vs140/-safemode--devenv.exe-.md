---
title: "-SafeMode (devenv.exe)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
H1: /SafeMode (devenv.exe)
helpviewer_keywords: 
  - /SafeMode Devenv switch
  - Devenv, /SafeMode switch
  - SafeMode switch
ms.assetid: b191f6a5-8f12-47ec-bcc7-b68149a22aa8
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -SafeMode (devenv.exe)
Starts [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in safe mode, loading only the default environment and services.  
  
## Syntax  
  
```  
devenv /SafeMode   
```  
  
## Remarks  
 This switch prevents all third-party VSPackages from loading when [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] starts, thus ensuring stable execution.  
  
## Description  
 The following example starts [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in safe mode.  
  
## Code  
  
```  
Devenv.exe /SafeMode  
```  
  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)