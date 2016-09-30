---
title: "Registering a Tool Window"
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
  - "tool windows, registering managed"
  - "tool windows, registering"
ms.assetid: 8c8c4a24-3da4-497b-9db2-0ddd7cfbfdd2
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering a Tool Window
You can register your tool windows using \<xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute*> and  \<xref:Microsoft.VisualStudio.Shell.ProvideToolWindowVisibilityAttribute*>  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the code above, the \<xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute*> registers the PersistedWindowPane and DynamicWindowPane tool windows with Visual Studio. The persisted tool window is docked and tabbed with **Solution Explorer**, and the dynamic window is given a default starting position and size. The dynamic window is made transient, which indicates that it is not created on startup. This writes a DontForceCreate value in the ToolWindows key in the system registry. For more information, see [Tool Window Display Configuration](../vs140/tool-window-display-configuration.md).