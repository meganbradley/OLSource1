---
title: "Opening an Options Page"
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
  - "open an options page"
  - "tools options"
  - "options page"
ms.assetid: 6f24cbfa-288a-4a57-831b-bc82587de255
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Opening an Options Page
You can display an options page programmatically so that users of your package can configure it during setup. To change settings after the package is installed, a user can still access the options page by using the **Options** dialog box.  
  
### To display a custom options page  
  
1.  Create an options page. For more information, see [Creating Options Pages By Using Managed Package Framework Classes](../vs140/creating-options-pages.md).  
  
2.  Get the <xref:System.Type*> of the options page by applying the `typeof` keyword to the name of the class that defines the options page.  
  
3.  Call the [ShowOptionPage](assetId:///M:Microsoft.VisualStudio.Shell.Package.ShowOptionPage(System.Type)?qualifyHint=False&autoUpgrade=True) method by using the <xref:System.Type*> of the options page as a parameter.  
  
     The following example displays an options page named **HelloWorldOptions**.  
  
     [!code[UI_UserSettings_ToolsOptionPages#5](../vs140/codesnippet/CSharp/opening-an-options-page_1.cs)][!code[UI_UserSettings_ToolsOptionPages#5](../vs140/codesnippet/VisualBasic/opening-an-options-page_1.vb)]  
  
### To display an options page that is defined by Visual Studio  
  
1.  In the registry subkey HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0\ToolsOptionsPages\\, find the node for the options page that you want to display and then copy its GUID, which is the value of the Page key.  
  
2.  Create a <xref:System.ComponentModel.Design.CommandID*> instance that has the constants <xref:Microsoft.VisualStudio.VSConstants.GUID_VSStandardCommandSet97*> and <xref:Microsoft.VisualStudio.VSConstants.VSStd97CmdID.ToolsOptions*> as parameters.  
  
     This specifies the **Options** dialog box.  
  
3.  Call the [GlobalInvoke](assetId:///M:System.ComponentModel.Design.MenuCommandService.GlobalInvoke(System.ComponentModel.Design.CommandID)?qualifyHint=False&autoUpgrade=True) method by using the <xref:System.ComponentModel.Design.CommandID*> instance and the GUID string as parameters.  
  
     The following example displays the **General** tab of the **Text Editor** options page.  
  
     [!code[UI_UserSettings_ToolsOptionPages#6](../vs140/codesnippet/CSharp/opening-an-options-page_2.cs)][!code[UI_UserSettings_ToolsOptionPages#6](../vs140/codesnippet/VisualBasic/opening-an-options-page_2.vb)]