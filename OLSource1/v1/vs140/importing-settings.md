---
title: "Importing Settings"
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
  - "user settings [Visual Studio SDK], importing using managed package framework"
  - "IDE settings, importing using managed package framework"
  - "IDE, importing settings using managed package framework"
  - "managed package framework, importing environment settings"
ms.assetid: 943f9a5b-c5a5-45ce-a5a9-8d4c02f15577
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Importing Settings
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) uses the classes that implement the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface and are registered to support a VSPackage implementation. This implementation is used to retrieve the state of a VSPackage.  
  
 Because the IDE instantiates the class that implements the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface to support the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings, the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface should be implemented in an independent class.  
  
> [!NOTE]
>  Do not implement \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> on the class that implements \<xref:Microsoft.VisualStudio.Shell.Package*>.  
  
### To implement Settings Export  
  
1.  Declare the class that implements the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings.  
  
     Declare a class as implementing \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> and provide it with a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  Classes implementing the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface must also implement the \<xref:System.ComponentModel.IComponent*> interface, which can be done by deriving the class from the \<xref:System.ComponentModel.Component*> class.  
  
     For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Ensure that the class that implements the settings retrieves state data from disk.  
  
     This step is performed by implementing the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> method.  
  
     The exact information that is to be persisted and how that information will be obtained and marshaled from the VSPackage differs for each VSPackage.  
  
     Regardless of the information that is to be persisted by the VSPackage, the class implementing \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> must use the supplied \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader*> interface to retrieve data from the settings file.  
  
     Typically, as in the example below, \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> also validates the retrieved data and updates the VSPackage's state.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Implementation details:  
  
    -   Report errors back to the user interactively through the IDE by using the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader.ReportError*> method of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader*> interface:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
    -   Prior to actually retrieving stored settings, an implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> method should use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsReader.ReadFileVersion*> method to verify that version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] that exports the stored settings is supported.  
  
         In the case of the example below, the implementation checks to see if settings were produced by a version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] with a major version number of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and if not, signals an error.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
    -   The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings file supports random data access, so the order of read and writer settings operations is not important. In the example below, the order of writer operations in the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method is opposite of the read operations in the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> method.  
  
    -   The value of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> argument supplied to a method of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface must uniquely identify each of data element saved within a settings category.  
  
        > [!NOTE]
        >  Names need to be unique only within the scope of the implementing class because the IDE uses the GUID of the class that implements the settings and the value of <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> to identify each saved setting. If more than one \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> method is called with the same value of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, the original value is overwritten in the settings file.  
  
3.  Ensure the coherence between VSPackage state and locally stored or cached settings.  
  
     This step is normally performed during the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToStorage*> method (as is seen in the example below). The details of this step are specific to a VSPackage and may involve obtaining the state of the VSPackage from automation, querying the VSPackage, and setting registry keys.  
  
    > [!NOTE]
    >  The \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method should retrieve the information saved by the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToStorage*> method when the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method is called by the IDE during its initialization of the VSPackage that it supports.  
  
     In the example below, the class providing settings support implements the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToStorage*> method to:  
  
    -   Obtain access to the VSPackage's updated state information.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
    -   Use that information to update the VSPackage's registry settings.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
    -   > [!NOTE]
        >  The division of labor between the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> and the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToStorage*> methods is depends on the implementation and is somewhat arbitrary. For example, the implementation could be rewritten with an empty implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method and all registry and state queries performed in the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method.  
  
4.  Register the class the implements the settings as providing support to a VSPackage.  
  
     Apply an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*> constructed by using the \<xref:System.Type*> of the class that implements \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> to the VSPackage's \<xref:Microsoft.VisualStudio.Shell.Package*> implementation.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
     In this case, the attribute informs the IDE that the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class provides a settings implementation to the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class. The Custom Settings Point in the registry is created under HKLM\Software\Microsoft\VisualStudio\\*\<Version>*\UserSettings\ CoreUI_MyPackage, where *\<Version>* is the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], for example 8.0.  
  
     For more information, see [Registering Settings Persistence Support](../vs140/support-for-user-settings.md) and \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*>  
  
## Example  
 The following example implements \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> on a class.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.IProfileManager*>   
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*>   
 [How to: Export Environment Settings Using the Managed Package Framework](../vs140/exporting-settings.md)   
 [Registering Settings Persistence Support](../vs140/support-for-user-settings.md)