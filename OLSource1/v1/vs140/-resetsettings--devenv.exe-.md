---
title: "-ResetSettings (devenv.exe)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ResetSettings (devenv.exe)"
helpviewer_keywords: 
  - "Devenv, /ResetSettings switch"
  - "ResetSettings switch"
  - "/ResetSettings Devenv switch"
ms.assetid: 1d41021c-6f58-4bd5-b122-d1c995812192
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ResetSettings (devenv.exe)
Restores [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] default settings and automatically launches the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE. Optionally resets the settings to a specified .vssettings file.  
  
 The default settings are determined by the profile that was selected when [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] was first launched.  
  
## Syntax  
  
```  
Devenv /ResetSettings SettingsFile  
```  
  
## Arguments  
 `SettingsFile`  
 The full path and name of the .vssettings file to apply to [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
 To restore the General Development Settings profile, use `General`.  
  
## Remarks  
 If no `SettingsFile` is specified, you will be prompted to select a default collection of settings the next time you start [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
## Example  
 The following command line applies the settings stored in the file `MySettings.vssettings`.  
  
```  
Devenv.exe /ResetSettings "C:\My Files\MySettings.vssettings"  
```  
  
## See Also  
 [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3)   
 [Devenv Command Line Switches](../vs140/devenv-command-line-switches.md)