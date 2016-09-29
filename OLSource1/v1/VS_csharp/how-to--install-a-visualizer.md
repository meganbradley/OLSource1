---
title: "How to: Install a Visualizer"
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
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugger, visualizers"
  - "visualizers, installing"
ms.assetid: 3310ef43-515c-4d97-b0f9-51047247d3da
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Install a Visualizer
After you have created a visualizer, you must install the visualizer so that it will be available in [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. Installing a visualizer is a simple process.  
  
> [!NOTE]
>  In **Store** apps, only the standard text, HTML, XML, and JSON visualizers are supported. Custom (user-created) visualizers are not supported.  
  
### To install a visualizer  
  
1.  Locate the DLL that contains the visualizer you have built.  
  
2.  Copy the DLL to either of the following locations:  
  
    -   *VisualStudioInstallPath* `\Common7\Packages\Debugger\Visualizers`  
  
    -   `My Documents\` *VisualStudioVersion* `\Visualizers`  
  
3.  If you want to use a managed visualizer for remote debugging, copy the DLL to the same path on the remote computer.  
  
4.  Restart the debugging session.  
  
## See Also  
 [Visualizers](../VS_csharp/create-custom-visualizers-of-data.md)   
 [How to: Write a Visualizer](../VS_csharp/how-to--write-a-visualizer.md)