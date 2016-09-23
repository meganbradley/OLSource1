---
title: "Services Used in Samples"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - services, appearing in samples
  - samples, services
ms.assetid: 04864feb-9b8b-45c4-8233-fc2ed9273987
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Services Used in Samples
The samples included in the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] make use of many services. The following list shows several commonly used services and the samples that use them.  
  
> [!NOTE]
>  If both reference and unsupported samples are available, only the reference sample is listed.  
  
|Service|Sample|  
|-------------|------------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SLocalRegistry?qualifyHint=False>|BscEdit, ProjectSubtype|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog?qualifyHint=False>|[How to: Write to the Activity Log](../vs140/how-to--use-the-activity-log.md)|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsAddProjectItemDlg?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsCreateAggregateProject?qualifyHint=False>|BscPrj|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChange?qualifyHint=False>|Deprecated. Use <xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChangeEx?qualifyHint=False> instead.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsFileChangeEx?qualifyHint=False>|BscEdit, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsMonitorUserContext?qualifyHint=False>|Reference.HelpIntegration sample.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave?qualifyHint=False>|SingleViewEditor sample.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRegisterEditors?qualifyHint=False>|SingleViewEditor sample.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRegisterProjectTypes?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsResourceManager?qualifyHint=False>|Reference.Package, Reference.ToolWindow, and many other samples|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable?qualifyHint=False>|SingleViewEditor sample.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSccManager?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShell?qualifyHint=False>|Reference.Package, Reference.ToolWindow, and many other samples|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellDebugger?qualifyHint=False>|BscEdt, BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsShellMonitorSelection?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackProjectDocuments?qualifyHint=False>|BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsTrackSelectionEx?qualifyHint=False>|SingleViewEditor, BscPrj, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell?qualifyHint=False>|Reference.ToolWindow, BscEdit, and many other samples|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShellOpenDocument?qualifyHint=False>|BscEdit, FigPkg|  
|<xref:Microsoft.VisualStudio.Shell.Interop.SVsWindowFrame?qualifyHint=False>|Reference.ToolWindow|  
  
## See Also  
 [List of Available Services](../vs140/list-of-available-services.md)   
 [Service Essentials](../vs140/service-essentials.md)