---
title: "Help Content Manager Overrides"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 95fe6396-276b-4ee5-b03d-faacec42765f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Help Content Manager Overrides
You can modify the registry to change the default behavior of the Help Viewer and Help-related features in the Visual Studio IDE.  
  
|Task|Registry Key|Value and Definition|  
|----------|------------------|--------------------------|  
|Define unique service endpoint|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VSWinExpress\14.0\Help|NewContentAndUpdateService--*HTTPValueForTheServiceEndpoint*.|  
|Define online/offline default|HKEY_LOCAL_MACHINE\Software\Microsoft\VSWinExpress\14.0\help|UseOnlineHelp--Enter `0` to specify local Help, and enter `1` to specify online Help.|  
|Define unique F1 endpoint|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VSWinExpress\14.0\Help|OnlineBaseUrl--*HTTPValueForTheServiceEndpoint*|  
|Override BITS job priority|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\Help\v2.2|BITSPriority--Use one of the following values: **foreground**, **high**, **normal**, or **low**.|  
|Disable Online (and IDE Online option)|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\VisualStudio\14.0\Help|OnlineHelpPreferenceDisabled--Set to 1 to disable access of online Help content.|  
|Disable Manage Content|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\VisualStudio\14.0\Help|ContentManagementDisabled--Set to 1 to disable the **Manage Content** tab in Help Viewer.|  
|Point to local content store on network share|HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Help\v2.2\Catalogs\VisualStudio11|LocationPath=”*ContentStoreNetworkShare*”|  
|Disable installation of content at first launch of Visual Studio feature.|HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node (on a 64-bit machine)\Microsoft\VisualStudio\14.0\Help|DisableFirstRunHelpSelection--Set to 1 to disable help features that are configured the first time that Visual Studio starts.|  
  
## See Also  
 [Help Viewer Administrator Guide](../vs140/help-viewer-administrator-guide.md)