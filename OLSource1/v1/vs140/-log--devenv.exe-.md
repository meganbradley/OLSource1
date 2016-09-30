---
title: "-Log (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/Log (devenv.exe)"
helpviewer_keywords: 
  - "Devenv, /Log switch"
  - "Log switch [devenv.exe]"
  - "/Log Devenv switch"
ms.assetid: ae23c4ae-2376-4fe3-b8d2-81d34e61c8ba
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -Log (devenv.exe)
Logs all activity to the log file for troubleshooting. This file appears after you've called <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> at least once. By default, the log file is:  
  
 *%APPDATA%*\Microsoft\VisualStudio\\*Version*\ActivityLog.xml  
  
 where *Version* is the Visual Studio version. However, you may specify a different path and file name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This switch must appear at the end of the command line, after all other switches.  
  
 The log is written for all instances of Visual Studio that you've invoked with the /log switch. It doesn't log instances of Visual Studio that you've invoked without the switch.  
  
## See Also  
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)