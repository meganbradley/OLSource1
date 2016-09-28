---
title: "Command Contracts in Interop Assemblies"
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
  - "command handling with interop assemblies, command contracts"
  - "interop assemblies, command contracts"
ms.assetid: 57245708-f539-42dc-8963-2754a48f0189
caps.latest.revision: 17
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Command Contracts in Interop Assemblies
The basic contract for handling commands through the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget*> interface is that the environment calls the [QueryStatus](assetId:///M:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus(System.Guid@,System.UInt32,Microsoft.VisualStudio.OLE.Interop.OLECMD[],System.IntPtr)?qualifyHint=False&autoUpgrade=True) method to determine whether the command is supported and, if it is supported, to determine its state and text. Then, the environment calls the [Exec](assetId:///M:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec(System.Guid@,System.UInt32,System.UInt32,System.IntPtr,System.IntPtr)?qualifyHint=False&autoUpgrade=True) method to execute the command.  
  
 The assetId:///M:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.QueryStatus(System.Guid@,System.UInt32,Microsoft.VisualStudio.OLE.Interop.OLECMD[],System.IntPtr)?qualifyHint=False&autoUpgrade=True method is handled identically for all commands. Further communication, if required (for example, with drop-down lists), is managed by calling the assetId:///M:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget.Exec(System.Guid@,System.UInt32,System.UInt32,System.IntPtr,System.IntPtr)?qualifyHint=False&autoUpgrade=True method with appropriate parameters. The interpretation of these parameters depends on the command specified.  
  
 If the command target returns values in the output parameter, the caller is always responsible for freeing any resources that had been allocated. Because this parameter is a variant, clearing the variant frees the resources.  
  
 In cases where commands must operate within a hierarchy window, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy*> interface must be used. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy*> interface has a similar contract with similar methods: [QueryStatusCommand](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.QueryStatusCommand(System.UInt32,System.Guid@,System.UInt32,Microsoft.VisualStudio.OLE.Interop.OLECMD[],System.IntPtr)?qualifyHint=False&autoUpgrade=True) and [ExecCommand](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy.ExecCommand(System.UInt32,System.Guid@,System.UInt32,System.UInt32,System.IntPtr,System.IntPtr)?qualifyHint=False&autoUpgrade=True).  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Command Routing in VSPackages](../vs140/command-routing-in-vspackages.md)   
 [Implementation](../vs140/command-implementation.md)