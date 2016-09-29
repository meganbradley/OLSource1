---
title: "Managing Undo and Redo by Using the Legacy API"
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
  - "editors [Visual Studio SDK], legacy - undo management"
ms.assetid: 838c0ddf-fdf3-4df1-8d21-79610b8ba0b1
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Managing Undo and Redo by Using the Legacy API
Editors must support undo operations that let users reverse their recent changes when they modify code. Most editors implemented under [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] can have undo support automatically provided by the integrated development environment (IDE).  
  
## In This Section  
 [How to: Implement Undo Management](../vs140/how-to--implement-undo-management.md)  
 Provides undo capability for editors with single or multiple views.  
  
 [How to: Clear the Undo Stack](../vs140/how-to--clear-the-undo-stack.md)  
 Describes how to clear an undo stack.  
  
 [How to: Use Linked Undo Management](../vs140/how-to--use-linked-undo-management.md)  
 Incorporates linked undo management into your editor.  
  
## Reference  
 <xref:Microsoft.VisualStudio.TextManager.Interop.IVsChangeTrackingUndoManager*>  
 Provides undo management for an editor that supports multiple views.  
  
## Related Sections