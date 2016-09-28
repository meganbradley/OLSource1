---
title: "Project Property User Interface"
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
  - "project properties [Visual Studio], user interface"
  - "projects [Visual Studio SDK], properties UI"
  - "project properties UI"
ms.assetid: b6aec634-8533-476c-9ebd-36536a2288e2
caps.latest.revision: 20
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Project Property User Interface
A project subtype can use the items in the project **Property Pages** dialog box as they are supplied by the base project, hide or make read-only controls and whole pages as supplied, or add project subtype-specific pages to the **Property Pages** dialog box.  
  
## Extending the Project Property Dialog Box  
 A project subtype implements automation extenders and project configuration browse objects. These extenders implement the <xref:EnvDTE.IFilterProperties*> interface to make particular properties hidden or read-only. The **Property Pages** dialog box of the base project, implemented by the base project, honors the filtering performed by the Automation Extenders.  
  
 The process of extending a **Project Property** dialog box is outlined below:  
  
-   The base project retrieves the extenders from the project subtype by implementing the <xref:EnvDTE80.IInternalExtenderProvider*> interface. The browse, project automation, and project configuration browse objects of the base project all implement this interface.  
  
-   The implementation of <xref:EnvDTE80.IInternalExtenderProvider*> for the project browse object and the project automation object delegate to the <xref:EnvDTE80.IInternalExtenderProvider*> implementation of the project subtype aggregator (that is, they `QueryInterface` for <xref:EnvDTE80.IInternalExtenderProvider*> on the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> project object).  
  
-   The base project configuration browse object also implements <xref:EnvDTE80.IInternalExtenderProvider*> to directly wire in the Automation Extender from the project subtype configuration object. Its implementation delegates to the <xref:EnvDTE80.IInternalExtenderProvider*> interface implemented by the project subtype aggregator.  
  
-   [GetProjectItem](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsCfgBrowseObject.GetProjectItem(Microsoft.VisualStudio.Shell.Interop.IVsHierarchy@,System.UInt32@)?qualifyHint=False&autoUpgrade=True), implemented by the project configuration browse object, returns the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> object.  
  
-   [GetCfg](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsCfgBrowseObject.GetCfg(Microsoft.VisualStudio.Shell.Interop.IVsCfg@)?qualifyHint=False&autoUpgrade=True), also implemented by the project configuration browse object, returns the <xref:Microsoft.VisualStudio.Shell.Interop.IVsCfg*> object.  
  
-   A project subtype can determine the appropriate CATIDs for the various extendable objects of the base project at runtime by retrieving the following <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2*> values:  
  
    -   <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_ExtObjectCATID*>  
  
    -   <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_BrowseObjectCATID*>  
  
    -   <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID2.VSHPROPID_CfgBrowseObjectCATID*>  
  
 To determine the CATIDs for the project scope, the project subtype retrieves the above properties for <xref:Microsoft.VisualStudio.VSConstants.VSITEMID_ROOT*> from the `VSITEMID``typedef`. A project subtype may also want to control which **Property Pages** dialog box pages are displayed for the project, both configuration dependent and configuration independent. Some project subtypes may need to remove built-in pages and add project subtype specific pages. In order to enable this, the managed client project calls the [GetProperty](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty(System.UInt32,System.Int32,System.Object@)?qualifyHint=False&autoUpgrade=True) method for the following properties:  
  
-   `VSHPROPID_PropertyPagesCLSIDList` — a semicolon-delimited list of CLSIDs of configuration-independent property pages.  
  
-   `VSHPROPID_CfgPropertyPagesCLSIDList —` a semicolon-delimited list of CLSIDs of configuration-dependent property pages.  
  
 Because the project subtype aggregates the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> object, it can override the definition of these properties to control which **Property Pages** dialog boxes are displayed. The project subtype can retrieve these properties from the inner base project and then add or remove CLSIDs as necessary.  
  
 New property pages added by a project subtype are handed a project configuration browse object from the base project implementation. This project configuration browse object supports Automation Extenders. For more information on AutomationExtenders, see [Implementing and Using Automation Extenders](assetId:///0d5c218c-f412-4b28-ab0c-33a611f62356). The property pages implemented by the project subtype call [Extender](assetId:///P:EnvDTE.Project.Extender(System.String)?qualifyHint=False&autoUpgrade=True) to retrieve their own project subtype configuration browse object that extends the configuration browse object of the base project.  
  
## See Also  
 <xref:EnvDTE.IFilterProperties*>   
 [Property Pages Dialog Box](assetId:///4a3d34ac-ed03-45e8-ae60-a0e1aad300e4)