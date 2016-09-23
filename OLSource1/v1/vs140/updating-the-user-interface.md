---
title: "Updating the User Interface"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - user interfaces, updating
  - commands, updating UI
ms.assetid: 376e2f56-e7bf-4e62-89f5-3dada84a404b
caps.latest.revision: 45
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Updating the User Interface
After you implement a command, you can add code to update the user interface with the state of your new commands.  
  
 In a typical Win32 application, the command set can be continuously polled and the state of individual commands can be adjusted as the user views them. However, because the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] shell can host an unlimited number of VSPackages, extensive polling might decrease responsiveness, especially polling across interop assemblies between managed code and COM.  
  
### To update the UI  
  
1.  Perform one of the following steps:  
  
    -   Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI?qualifyHint=False> method.  
  
         An <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> interface can be obtained from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell?qualifyHint=False> service, as follows.  
  
        ```c#  
        void UpdateUI(Microsoft.VisualStudio.Shell.ServiceProvider sp)  
        {  
            IVsUIShell vsShell = (IVsUIShell)sp.GetService(typeof(IVsUIShell));  
            if (vsShell != null)  
            {  
                int hr = vsShell.UpdateCommandUI(0);  
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr);  
            }  
        }  
  
        ```  
  
         If the parameter of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI?qualifyHint=False> is non-zero (`TRUE`), then the update is performed synchronously and immediately. We recommend that you pass zero (`FALSE`) for this parameter to help maintain good performance. If you want to avoid caching, apply the `DontCache` flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously or performance might decrease. For more information about command flags, see the [Command Flag Element](../vs140/command-flag-element.md) documentation.  
  
    -   In VSPackages that host an ActiveX control by using the in-place activation model in a window, it might be more convenient to use the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI?qualifyHint=False> method. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.UpdateCommandUI?qualifyHint=False> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> interface and the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager.UpdateUI?qualifyHint=False> method in the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager?qualifyHint=False> interface are functionally equivalent. Both cause the environment to re-query the state of all commands. Typically, an update is not performed immediately. Instead, an update is delayed until idle time. The shell caches the command state to help maintain good performance. If you want to avoid caching, apply the `DontCache` flag when you create the command in the .vsct file. Nevertheless, use the flag cautiously because performance might decrease.  
  
         Notice that you can obtain the <xref:Microsoft.VisualStudio.Shell.Interop.IOleInPlaceComponentUIManager?qualifyHint=False> interface by calling the `QueryInterface` method on an <xref:Microsoft.VisualStudio.Shell.Interop.IOleComponentUIManager?qualifyHint=False> object or by obtaining the interface from the <xref:Microsoft.VisualStudio.Shell.Interop.SOleComponentUIManager?qualifyHint=False> service.  
  
## See Also  
 [How VSPackages Contribute User Interface Elements](../vs140/how-vspackages-add-user-interface-elements.md)   
 [Implementation](../vs140/command-implementation.md)