---
title: "Using Options Pages"
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
  - "Tools Options pages [Visual Studio SDK], usage"
ms.assetid: 5ae6b995-3aeb-43a7-9786-4cf69faa101c
caps.latest.revision: 40
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Options Pages
The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] automation model provides the \<xref:EnvDTE.DTE*> object to enable VSPackages to access the **Options** dialog box on the **Tools** menu.  
  
 Typically, pages in the **Options** dialog box can be accessed by using the automation model, whether the pages are provided by the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE) or by a VSPackage. However, there are some exceptions, as follows:  
  
-   The settings of the **Dynamic Help** page cannot be accessed programmatically. The **Dynamic Help** feature can be controlled by using the automation model, but control must be accomplished directly in code. For more information, see [How to: Control the Dynamic Help Window](assetId:///7f5777aa-c270-4058-a175-8ce8a4ed25eb).  
  
-   Control of the **Fonts and Color** page settings is provided through its own API, not through the automation model. For more information, see [Text Font and Color Control](../vs140/using-fonts-and-colors.md).  
  
-   Language-specific properties cannot be obtained through the automation model.  
  
 **Options** pages that do not support the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] automation model may not return an automation \<xref:EnvDTE.Properties*> collection when queried. If the collection is returned, not all features are present. For information about how to manage these features, see [DTE Properties Collections](assetId:///c062b48c-d104-4560-a3fe-f9e2f56ca4c6).  
  
## Managing Options Pages  
 To manage **Options** pages, a VSPackage must get a \<xref:EnvDTE.DTE*> object from the automation model.  
  
> [!NOTE]
>  When a VSPackage uses the automation model to query and change settings on installed **Options** pages, it does not extend the IDE functionality. Therefore, the package does not have to implement an automation object.  
  
 To obtain a \<xref:EnvDTE.DTE*> object through the automation model, call the \<xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService*> method and provide a service ID argument of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and an interface argument of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, as follows.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To obtain a \<xref:EnvDTE.DTE*> object by using the Managed Package Framework (MPF), call the \<xref:Microsoft.VisualStudio.Shell.Package.GetService*> method and provide a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter of type \<xref:Microsoft.VisualStudio.Shell.Interop.SDTE*>.  
  
 [!code[UI_UserSettings_ToolsOptionPages#01](../vs140/codesnippet/CSharp/using-options-pages_1.cs)]
[!code[UI_UserSettings_ToolsOptionPages#01](../vs140/codesnippet/VisualBasic/using-options-pages_1.vb)]  
  
 An **Options** page is specified by two identifiers. The first identifier is a string that indicates the folder that contains the **Options** page. The second identifier is a string that indicates the specific item in that folder. These are referred to as an **Options** page category and subcategory, or its topic and subtopic.  
  
 For example, the text editor settings for handling Basic code are on the navigation pane as the **Basic** member of the **Text Editor** folder. The identifier for the category is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and its subcategory is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the **Options** page itself is referred to as the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> page.  
  
> [!NOTE]
>  For localization and other reasons, the names displayed on **Options** pages may differ from the strings used as category and subcategory identifiers. You may have to use automation to query the IDE to obtain the correct identifiers, if they are not documented elsewhere. The registry location is HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<VS Version>*\AutomationProperties, where *\<VS Version>* is the version number of the release of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see [Registering Custom Tools Options Pages](../vs140/registering-custom-options-pages.md).  
  
 You can obtain the properties for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> page through the automation model by using the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To obtain the properties by using the MPF, use the \<xref:EnvDTE._DTE.Properties*> method.  
  
 [!code[UI_UserSettings_ToolsOptionPages#02](../vs140/codesnippet/CSharp/using-options-pages_2.cs)]
[!code[UI_UserSettings_ToolsOptionPages#02](../vs140/codesnippet/VisualBasic/using-options-pages_2.vb)]  
  
 The \<xref:EnvDTE.Properties.Item*> method returns individual settings from the \<xref:EnvDTE.Properties*> collection as a \<xref:EnvDTE.Property*> object.  
  
 As with categories and subcategories, each setting has an identifier that is a unique string. For example, the **Tab Size** setting on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> page is identified by the string, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  For localization and other reasons, the names displayed on **Options** pages may differ from the strings used as setting identifiers. You may have to use automation to query the IDE to obtain the correct identifiers, if they are not documented elsewhere.  
  
 You can use the \<xref:EnvDTE.Property.Value*> of the \<xref:EnvDTE.Property*> object that is returned by the \<xref:EnvDTE.Properties.Item*> method of the \<xref:EnvDTE.Properties*> collection to query and change the settings state.  
  
 For example, to set the **Tab Size** setting on the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> page through the automation model, use the \<xref:EnvDTE.Properties*> object returned in the following example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following example demonstrates how to update the **Tab Size** setting by using the MPF.  
  
 [!code[UI_UserSettings_ToolsOptionPages#03](../vs140/codesnippet/CSharp/using-options-pages_3.cs)]
[!code[UI_UserSettings_ToolsOptionPages#03](../vs140/codesnippet/VisualBasic/using-options-pages_3.vb)]  
  
 For more information, see [Controlling Tools Options Settings](assetId:///a09ed242-7494-4cde-bbd1-7a8ec617965d).  
  
## Persisting Options Page Settings  
 The IDE implements state persistence of **Options** pages that fully support the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] automation model.  
  
 Settings on pages that are included in the IDE are automatically saved (or retrieved) when a user clicks the **Import/Export Settings** command on the **Tools** menu.  
  
 You can enable your custom **Options** page to use this automatic persistence support by adding the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> flag to the custom **Options** page registry entry under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<VS Version>*\AutomationProperties, where *\<VS Version>* is the version number of the release of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see [Registering Custom Tools Options Pages](../vs140/registering-custom-options-pages.md).  
  
## See Also  
 [Creating Tools Options Pages with Interop Assemblies](../vs140/creating-options-pages-by-using-interop-assemblies.md)   
 [Creating Options Pages By Using Managed Package Framework Classes](../vs140/creating-options-pages.md)   
 [Creating Options Pages By Using Automation](../vs140/creating-options-pages-by-using-automation.md)   
 [Controlling Tools Options Settings](assetId:///a09ed242-7494-4cde-bbd1-7a8ec617965d)   
 [Registering Custom Tools Options Pages](../vs140/registering-custom-options-pages.md)   
 [How to: Open an Options Page](../vs140/opening-an-options-page.md)   
 [User Settings and Options](../vs140/extending-user-settings-and-options.md)