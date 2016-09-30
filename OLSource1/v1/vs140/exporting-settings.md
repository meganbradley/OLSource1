---
title: "Exporting Settings"
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
  - "IDE, exporting settings using managed package framework"
  - "managed package framework, exporting environment settings"
  - "user settings [Visual Studio SDK], exporting using managed package framework"
  - "IDE settings, exporting using managed package framework"
ms.assetid: cb3ddb38-4e75-4f05-a83a-8396345bc36c
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exporting Settings
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) uses classes that implement the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface and classes that are registered as supporting a given VSPackage implementation to save the state of a VSPackage.  
  
 Because the IDE instantiates the class that implements the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface to support the settings, \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> should be implemented in an independent class.  
  
> [!NOTE]
>  Do not implement \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> on the class that implements \<xref:Microsoft.VisualStudio.Shell.Package*>.  
  
### To implement the export of settings  
  
1.  Declare the class that implements the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] settings.  
  
     Declare a class as implementing the \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> interface and provide it with a GUID.  
  
    > [!NOTE]
    >  Classes that implement \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> must also implement \<xref:System.ComponentModel.IComponent*>. This can be done by deriving the class from \<xref:System.ComponentModel.Component*>.  
  
     For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Ensure that the class that implements the settings obtains correct state information. This procedure is specific to each VSPackage, and may involve obtaining state from automation, querying registry keys, or querying the VSPackage.  
  
     Typically, as in the following example, use the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method to validate and stage VSPackage state information.  
  
    > [!NOTE]
    >  The \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method is also called by the IDE when it initializes the VSPackage that it supports.  
  
     In this case, the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method does these things:  
  
    -   Obtains access to the state information in the VSPackage current configuration and configuration information stored in the registry.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
    -   Depending on the value returned by the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method of the VSPackage, it either updates the registry settings by using the current VSPackage state, or the state by using the registry settings.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
         For simplicity in this example, unless the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method returns <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the current state is always reset to the default that is stored in the registry.  
  
3.  Ensure that the class that implements the settings also persists the state to disk.  
  
     The actual writing of state information to the settings disk file must always be performed by the class implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method. The specifics of a settings writer operation depend on the implementation.  
  
     However, the class must obtain access to state information and must use the supplied \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface to save data to the setting file.  
  
     Typically, as in the following example, the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method does not validate state information. The validation is performed in the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method. Instead, the implementation merely obtains access to the state information and writes it, in this case, as string data.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Implementation details are as follows:  
  
    -   In addition to data explicitly written and transparent to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsUserSettings.ExportSettings*> method implementation, the settings API also saves [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] version information. Therefore, saved settings can be compared against the version of the IDE that generated them during settings importation.  
  
    -   The value of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> argument supplied to a method of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> interface must uniquely identify each data element saved in a settings category.  
  
        > [!NOTE]
        >  Names must only be unique within the scope of the implementing class. The IDE uses the GUID of the class that implements the settings and the value of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to identify each saved setting. If more than one \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*> method that have the same <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> value are called, the original value is overwritten in the settings file.  
  
    -   The settings file supports random data access, so the order of read and write operations is not important. In the following example, the order of writer operations in the implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method is opposite of the read operations in the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromXml*> method.  
  
    -   If the implementation can map data into one of the four supported formats, then there is no restriction on how much or what type of data can be written.  
  
        > [!NOTE]
        >  The division of labor between the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> and \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> methods depends on the implementation and is somewhat arbitrary. For example, the implementation could be rewritten by using an empty implementation of the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.LoadSettingsFromStorage*> method and by having all registry and state queries performed in the \<xref:Microsoft.VisualStudio.Shell.IProfileManager.SaveSettingsToXml*> method.  
  
4.  Register the settings implementing class as providing support to a VSPackage.  
  
     Apply an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*> that is constructed by using the \<xref:System.Type*> of the class that implements \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> to the VSPackage \<xref:Microsoft.VisualStudio.Shell.Package*> implementation.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     In this case, the attribute informs the IDE that the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class provides a settings implementation to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class. The Custom Settings Point in the registry is created under HKLM\Software\Microsoft\VisualStudio\\*Version*\UserSettings\ CoreUI_MyPackage, where *Version* is the version of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], for example, 10.0.  
  
     For more information, see [Registering Settings Persistence Support](../vs140/support-for-user-settings.md) and \<xref:Microsoft.VisualStudio.Shell.ProvideProfileAttribute*>.  
  
## Example  
 The following example implements \<xref:Microsoft.VisualStudio.Shell.IProfileManager*> on a class.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.IProfileManager*>   
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsWriter*>   
 [How to: Import Environment Settings Using the Managed Package Framework](../vs140/importing-settings.md)   
 [Registering Settings Persistence Support](../vs140/support-for-user-settings.md)