---
title: "How to: Use Interop Assemblies to Import Settings"
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
  - "IDE settings, importing using interop assemblies"
  - "IDE, importing settings using interop assemblies"
  - "user settings [Visual Studio SDK], importing using interop assemblies"
ms.assetid: 8a43dbe2-fdc0-471b-8235-3f489b77db0f
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Interop Assemblies to Import Settings
A VSPackage may import settings from the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE). The IDE uses a VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface to determine how the VSPackage's configuration is to be retrieved.  
  
> [!NOTE]
>  The Managed Package Framework (MPF) provides a set of managed classes to facilitate the creation of Visual Studio extensions. To perform this task using the MPF, see [How to: Import Settings By Using the Managed Package Framework](../vs140/importing-settings.md).  
  
### To implement settings import on a VSPackage  
  
1.  Implement basic support for the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings mechanism.  
  
    -   Register the VSPackage as supporting the settings mechanism by defining one or more Custom Settings Points.  
  
         For more information, see [Registering Settings Persistence Support](../vs140/support-for-user-settings.md).  
  
    -   Declare that the VSPackage implements the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface, for instance:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
    -   Ensure that the VSPackage's implementation of the \<xref:System.Runtime.InteropServices.Marshal.QueryInterface*> method supplies a \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface when called with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Retrieve settings information.  
  
     To support retrieving settings information, a VSPackage must implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method.  
  
     To read data, a VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings*> interface must use the first two arguments passed in by the IDE: the GUID of that Custom Settings Point's category, and an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader*> interface.  
  
    1.  A VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method must check the category GUID passed in and choose the correct mechanism for the retrieving state.  
  
         In the example below, the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method calls a different implementation for retrieving the command bar state as opposed to retrieving the key-binding state.  
  
    2.  A VSPackage must use the supplied \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader*> interface to retrieve data to the settings file.  
  
        > [!NOTE]
        >  If the settings information changes as a function of a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] version, a VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method must use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader.ReadFileVersion*> method prior to reading data to check the IDE version.  
  
         The interface provides methods for reading different data types from the settings file.  
  
         <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
         <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
     The settings file supports random data access, so the order of read and write settings operations is not important.  
  
     This is illustrated in the exporting and importing command bar state (<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>r and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) of the implementation in the example below.  
  
3.  Validate retrieved data.  
  
     The settings information is contained in XML files, which can be edited manually.  
  
> [!IMPORTANT]
>  The settings information may become corrupt on disk, may contain version-specific settings, and could be used as a vehicle for malicious attack. The validity of each data item returned by the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader*> method should be validated.  
  
-   To verify support of the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] used to produce the retrieved settings, call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader.ReadFileVersion*> method to retrieve the version.  
  
-   To cause the IDE to notify a user that an imported data element does not validate, a VSPackage calls the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader.ReportError*> method.  
  
1.  Apply settings information.  
  
    1.  The implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method must respect the value of the third argument that the IDE passed to it. The supported values are members of the \<xref:Microsoft.VisualStudio.Shell.Interop.__UserSettingsFlags*> enumeration. For more information, see \<xref:Microsoft.VisualStudio.Shell.Interop.__UserSettingsFlags*>.  
  
         In the example below, the implementation for importing command bar settings (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) uses the value of this argument to determine whether to apply settings to overwrite existing values or to additively update them.  
  
    2.  You must implement a write-through cache methodology when applying imported settings.  
  
         State information in the registry or the file system must be updated at the same time as settings are applied to the IDE. This guarantees configuration coherence and supports multi-instance IDE scenarios.  
  
2.  Alert IDE how to handle settings import.  
  
     Use the returned <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method to advise the IDE if a restart is required to apply the imported settings.  
  
     If the VSPackage's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ImportSettings*> method returns <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, the user is prompted to restart the IDE.  
  
## Example  
 This example demonstrates how to import and export settings data.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [How to: Export Environment Settings Using Interop Assemblies](../vs140/how-to--export-settings-by-using-interop-assemblies.md)   
 [Registering Settings Persistence Support](../vs140/support-for-user-settings.md)   
 [User Settings Overview](../vs140/extending-user-settings-and-options.md)   
 [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3)