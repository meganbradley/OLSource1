---
title: "How to: Export Settings By Using Interop Assemblies"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDE settings, exporting using interop assemblies"
  - "user settings [Visual Studio SDK], exporting using interop assemblies"
  - "IDE, exporting settings using interop assemblies"
ms.assetid: d470d4f9-3006-40c3-99db-21abcd5003b8
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Export Settings By Using Interop Assemblies
A VSPackage may export settings from the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE). The IDE uses a VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface. If the package also provides the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*> interface, then the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*> interface is used to determine how the VSPackage's configuration is to be saved.  
  
> [!NOTE]
>  The Managed Package Framework (MPF) provides a set of managed classes to facilitate the creation of Visual Studio extensions. To perform this task using the MPF, see [How to: Export Settings By Using the Managed Package Framework](../vs140/exporting-settings.md).  
  
### To implement settings export on a VSPackage  
  
1.  Implement basic support for the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism.  
  
    -   Register the VSPackage as supporting the settings mechanism by defining one or more Custom Settings Points.  
  
         For more information, see [Registering Settings Persistence Support](../vs140/support-for-user-settings.md).  
  
    -   Declare that the VSPackage implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*>. If desired, the VSPackage can also implement \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*> interface. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    -   Ensure that the VSPackage's implementation of the \<xref:System.Runtime.InteropServices.Marshal.QueryInterface*> method supplies an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface when called with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
         Optionally, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> can supply an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*> interface when called with the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Optionally, alert the IDE of the need to export a particular setting.  
  
     A VSPackage can choose to conditionally save a setting that the Custom Settings Point state defines. For example, save only if the user explicitly indicates a setting to be saved.  
  
     In this case, the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*> interface must be implemented.  
  
     If a VSPackage does not implement \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery*>, all its state information is saved during a settings export.  
  
     A VSPackage can support more than one Custom Settings Point (settings category). Implementations of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettingsQuery.NeedExport*> method must check the supplied Custom Settings Point's GUID or settings category argument to determine if a particular group of settings must be saved.  
  
     In the example below, the VSPackage always requests that its command bar state is saved, but only requests that its key binding state is saved if a flag has been set.  
  
3.  Write settings data to the settings file.  
  
     To support exporting settings, a VSPackage must always implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ExportSettings*> method.  
  
     The implementation must handle the arguments passed by the IDE, the GUID of that Custom Settings Point's category, and an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface.  
  
    1.  A VSPackage can support more than one Custom Settings Point (settings category). In the example below, the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ExportSettings*> method calls a different implementation for persisting command bar state as opposed to persisting key binding state.  
  
    2.  A VSPackage must use the supplied \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface to save data to the setting file.  
  
         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
         The value of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument supplied to an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface must uniquely identify each data element saved within a settings category.  
  
        > [!NOTE]
        >  Names must be unique within a Custom Settings Point because the IDE uses its GUID and the value of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to identify each saved setting. If more than one \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> method is called with the same value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the original value is overwritten in the settings file.  
  
         The settings file supports random data access. Consequently, the order of read and write settings operations is not important.  
  
         This is illustrated in the implementations of exporting and importing command bar state (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>r and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) in the example below.  
  
         If the implementation can map data into one of the four supported formats, there is no restriction on how much or what type of data can be written.  
  
        > [!NOTE]
        >  In addition to data explicitly written and transparent to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ExportSettings*> implementation, the settings API also saves [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] version information. Saved settings can be compared against the version of the IDE that generated them during settings import.  
  
## Example  
 The following example demonstrates how to import and export settings data.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Registering Settings Persistence Support](../vs140/support-for-user-settings.md)   
 [User Settings Overview](../vs140/extending-user-settings-and-options.md)   
 [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3)   
 [How to: Import Environment Settings Using Interop Assemblies](../vs140/how-to--use-interop-assemblies-to-import-settings.md)