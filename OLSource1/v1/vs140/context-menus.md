---
title: "Context Menus"
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
  - "editors [Visual Studio SDK], legacy - context menus"
ms.assetid: 44fd9e6a-6d42-4aba-80ba-f37fa0070f1d
caps.latest.revision: 16
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Context Menus
Context menus are displayed when a user right-clicks in an active region of the client area and clear when the right mouse button is released.  
  
## Editor Context Menus  
 By intercepting `ECMD_SHOWCONTEXTMENU`, your language service can control the context menus that will display in the editor. To display your own context menu, handle this command when it is passed into your <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*> by calling [ShowContextMenu](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowContextMenu(System.UInt32,System.Guid@,System.Int32,Microsoft.VisualStudio.Shell.Interop.POINTS[],Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget)?qualifyHint=False&autoUpgrade=True). If you do not handle this command, then the IDE displays a standard context menu provided for the editor. You can also control the content of the context menu on a per-marker basis. For more information about this, see [Text Markers in the Editor](../vs140/using-text-markers-with-the-legacy-api.md) and [Language Service Command Interception](../vs140/intercepting-legacy-language-service-commands.md).  
  
## See Also  
 [Developing a Legacy Language Service](../vs140/developing-a-legacy-language-service.md)   
 [Common Menu Tasks](../vs140/extending-menus-and-commands.md)