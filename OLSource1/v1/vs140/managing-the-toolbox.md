---
title: "Managing the Toolbox"
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
  - Toolbox [Visual Studio SDK], automatic tab selection
  - Toolbox [Visual Studio SDK], managing
ms.assetid: 3b052047-f6db-46dd-b3bf-da1c348ee410
caps.latest.revision: 37
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Managing the Toolbox
The [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] allows a VSPackage, such as an editor or designer, to manage the membership and appearance of the **Toolbox**.  
  
 In addition, The **Toolbox** itself can be managed using automation. For more information on managing a Toolbox through automation, see [How to: Control the Toolbox](assetId:///c9d8a18a-d2bc-43d4-a803-601bfc6a6599).  
  
## Automatic Toolbox Tab Selection  
 A particular **Toolbox** tab or category can be automatically made active based on which editor or designer is currently active. For example, if a forms designer is activated, you may want the **All Windows Forms** tab selected.  
  
 This support is limited to editors and designers requiring:  
  
1.  The implementation of a factory object to provide instances of the editor or designer. For more information on implementing a designer or editor factory object, see [Editor Factories](../vs140/editor-factories.md).  
  
2.  Registration of the toolbox tab that automatically is activated if the editor or designer is present.  
  
## Controlling the Toolbox  
 Supplementing automation support, the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] provides the following interfaces to provide VSPackages greater control over how the **Toolbox** is managed.  
  
|Interface|Description|  
|---------------|-----------------|  
|<xref:System.Drawing.Design.IToolboxService?qualifyHint=False>|Allows applications to manage, add, and remove <xref:System.Drawing.Design.ToolboxItem?qualifyHint=False> objects from the **Toolbox**. Also enables configuration of appearance and **Toolbox** categories.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False>|Allows applications to manage, add, and remove Active-based **Toolbox** controls, as well as configure **Toolbox** categories and appearance.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3?qualifyHint=False>|Extends functionality found in <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False> by providing complete support for persistence and localization.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox4?qualifyHint=False>||  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox5?qualifyHint=False>||  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox6?qualifyHint=False>||  
  
 There are several important points to keep in mind when working with these interfaces:  
  
-   <xref:System.Drawing.Design.IToolboxService?qualifyHint=False> is available only to Managed Package Framework-based VSPackages.  
  
-   Controls cannot be directly added to the **Toolbox** using <xref:System.Drawing.Design.IToolboxService?qualifyHint=False>.  
  
-   A VSPackage must either use <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False> to add controls or host the control in a wrapper control that derives from <xref:System.Windows.Forms.AxHost?qualifyHint=False>.  
  
     Visual Studio provides the `Aximp.exe` tool for automating the wrapping of an ActiveX control in a control derived from <xref:System.Windows.Forms.AxHost?qualifyHint=False>. For more information, see [Windows Forms ActiveX Control Importer (Aximp.exe)](assetId:///482c0d83-7144-4497-b626-87d2351b78d0).  
  
-   <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox?qualifyHint=False>, <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False>, and <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3?qualifyHint=False> are COM-based interfaces available through the interop assemblies.  
  
-   <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False> derives from <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox?qualifyHint=False> and implements all its methods.  
  
     Objects only obtain an instance of <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False>.  
  
-   <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3?qualifyHint=False> does not derive from <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False> and does not implement its methods.  
  
     Objects needing functionality in both interfaces must obtain instances of both interfaces from the environment.  
  
-   When working with <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox2?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3?qualifyHint=False>, information about the canonical (non-localized) names of tabs is handled by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3.GetIDOfTab?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsToolbox3.SetIDOfTab?qualifyHint=False> methods.  
  
-   When using <xref:System.Drawing.Design.IToolboxService?qualifyHint=False>, it is up to the implementer to manage localized information, such as names of categories.  
  
 Use the settings mechanism to enable users to save **Toolbox** settings accessed by users from the **Import/Export Settings** command, found on the IDE's **Tools** menu. For more information on how to use settings, see [Extending User Settings and Options](../vs140/extending-user-settings-and-options.md).  
  
## See Also  
 [Toolbox Overview](../vs140/extending-the-toolbox.md)