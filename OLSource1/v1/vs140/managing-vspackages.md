---
title: "Managing VSPackages"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "VSPackages, autoloading"
  - "VSPackages, delayed loading"
  - "delay loading"
  - "VSPackages, loading"
ms.assetid: 386e0ce5-4107-4164-b0cd-1cf43eb5e7cf
caps.latest.revision: 39
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Managing VSPackages
In most cases you don’t need to worry about managing VSPackages, since the project and item templates register and load the package automatically. However, in some circumstances you may need to learn a bit more in order to manage your package.  
  
## Using the experimental instance  
 To find out more about the experimental instance, see [The Experimental Instance](../vs140/the-experimental-instance.md).  
  
## Registering and Unregistering VSPackages  
 To find out how to register and unregister VSPackages and other types of extension, see [Registering and Unregistering VSPackages](../vs140/registering-and-unregistering-vspackages.md).  
  
## Loading a VSPackage  
 VSPackages can be set to autoload when a particular CMDUICONTEXT GUID is turned on. For more information, see [Loading VSPackages](../vs140/loading-vspackages.md).  
  
## Using AsyncPackage to Load VSPackages in the Background  
 The AsyncPackage class enables package loading on a background thread for better UI responsiveness in Visual Studio. For more information, see [Use AsyncPackage to Load VSPackages in the Background](../vs140/how-to--use-asyncpackage-to-load-vspackages-in-the-background.md).  
  
## Rule-based UI Context for Extensions  
 Rules-based UI Contexts allows extension authors to define the precise conditions under which a UI Context is activated and associated VSPackages loaded. For more information, see [Rule-base UI Context for Visual Studio Extensions](../vs140/how-to--use-rule-based-ui-context-for-visual-studio-extensions.md).  
  
## Troubleshooting VSPackages  
 Find out the techniques for troubleshooting VSPackages that don’t load or are experiencing errors: [Troubleshooting VSPackages](../vs140/troubleshooting-vspackages.md)  
  
## See Also  
 [VSPackages](../vs140/vspackages.md)