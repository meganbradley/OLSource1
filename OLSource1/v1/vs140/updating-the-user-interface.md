---
title: "Updating the User Interface"
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
  - "user interfaces, updating"
  - "commands, updating UI"
ms.assetid: 376e2f56-e7bf-4e62-89f5-3dada84a404b
caps.latest.revision: 45
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Updating the User Interface
After you implement a command, you can add code to update the user interface with the state of your new commands.  
  
 In a typical Win32 application, the command set can be continuously polled and the state of individual commands can be adjusted as the user views them. However, because the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] shell can host an unlimited number of VSPackages, extensive polling might decrease responsiveness, especially polling across interop assemblies between managed code and COM.  
  
### To update the UI  
  
1.  Perform one of the following steps:  
  
    -   Call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI*> method.  
  
         An \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell*> interface can be obtained from the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell*> service, as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
         If the parameter of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI*> is non-zero (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>), then the update is performed synchronously and immediately. We recommend that you pass zero (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) for this parameter to help maintain good performance. If you want to avoid caching, apply the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously or performance might decrease. For more information about command flags, see the [Command Flag Element](../vs140/command-flag-element.md) documentation.  
  
    -   In VSPackages that host an ActiveX control by using the in-place activation model in a window, it might be more convenient to use the \<xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI*> method. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI*> method in the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell*> interface and the \<xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI*> method in the \<xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager*> interface are functionally equivalent. Both cause the environment to re-query the state of all commands. Typically, an update is not performed immediately. Instead, an update is delayed until idle time. The shell caches the command state to help maintain good performance. If you want to avoid caching, apply the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously because performance might decrease.  
  
         Notice that you can obtain the \<xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager*> interface by calling the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method on an \<xref:Microsoft.VisualStudio.Shell.Interop.IOleComponentUIManager*> object or by obtaining the interface from the \<xref:Microsoft.VisualStudio.Shell.Interop.SOleComponentUIManager*> service.  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Implementation](../vs140/command-implementation.md)