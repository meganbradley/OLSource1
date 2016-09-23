---
title: "Legacy Interfaces in the Editor"
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
  - editors [Visual Studio SDK], legacy
ms.assetid: 741d45f5-0ea3-4614-972a-8728fe054e07
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Legacy Interfaces in the Editor
You can access the Visual Studio editor from legacy interfaces. The Visual Studio SDK includes adapters known as *shims*, which enable these interfaces to interact with the new editor. Nevertheless, we recommend that you update your legacy code to use the new editor API. Your code will perform better and you can use new technologies such as the Windows Presentation Foundation (WPF) and the Managed Extensibility Framework (MEF).  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Adapting Legacy Code to the New Editor](../vs140/adapting-legacy-code-to-the-editor.md)|Explains how to adapt your code to the new editor.|  
|[New or Changed Behavior with Editor Adapters](../vs140/new-or-changed-behavior-with-editor-adapters.md)|Explains how the behavior of the editor adapters differs from that of earlier versions of the editor.|  
|[Inside the Core Editor](../vs140/inside-the-core-editor.md)|Describes the different components of earlier versions of the editor.|  
|[Instantiating the Core Editor By Using the Legacy API](../vs140/instantiating-the-core-editor-by-using-the-legacy-api.md)|Explains how to use the legacy API to instantiate the core editor.|  
|[Editor Factories](../vs140/editor-factories.md)|Explains how to use editor factories with the legacy API.|  
|[How to: Register Editor File Types](../vs140/how-to--register-editor-file-types.md)|Explains how to link a file name extension to your editor.|  
|[Walkthrough: Creating a Core Editor and Registering an Editor File Type](../vs140/walkthrough--creating-a-core-editor-and-registering-an-editor-file-type.md)|Explains how to create a core editor and link a file name extension to it.|  
|[How to: Provide Context for Editors](../vs140/how-to--provide-context-for-editors.md)|Explains how to provide context for your editor.|  
|[Language Services and the Core Editor](../vs140/language-services-and-the-core-editor.md)|Explains the interactions between a language service and an editor.|  
|[Accessing the Text Buffer by Using the Legacy API](../vs140/accessing-the-text-buffer-by-using-the-legacy-api.md)|Explains how to access the text buffer by using the legacy API.|  
|[Accessing the Text View by Using the Legacy API](../vs140/accessing-thetext-view-by-using-the-legacy-api.md)|Explains how to access the text view by using the legacy API.|  
|[Customizing Code Windows by Using the Legacy API](../vs140/customizing-code-windows-by-using-the-legacy-api.md)|Explains how to customize code windows by using the legacy API.|  
|[Accessing Text Layers by Using the Legacy API](../vs140/accessing-text-layers-by-using-the-legacy-api.md)|Explains how to access different layers of text by using the legacy API.|  
|[Using Text Markers with the Legacy API](../vs140/using-text-markers-with-the-legacy-api.md)|Explains how to add text markers by using the legacy API.|  
|[Customizing Editor Controls and Menus by Using the Legacy API](../vs140/customizing-editor-controls-and-menus-by-using-the-legacy-api.md)|Explains how to customize editor controls by using the legacy API.|  
|[Managing Undo and Redo by Using the Legacy API](../vs140/managing-undo-and-redo-by-using-the-legacy-api.md)|Explains how to manage undo and redo by using the legacy API.|  
|[How to: Implement the Find and Replace Mechanism](../vs140/how-to--implement-the-find-and-replace-mechanism.md)|Explains how to manage find and replace by using the legacy API.|  
|[How to: Suppress File Change Notifications](../vs140/how-to--suppress-file-change-notifications.md)|Explains how to suppress file change notifications by using the legacy API.|  
|[Creating Custom Text Editors and Designers](../vs140/creating-custom-editors-and-designers.md)|Explains how to create custom editors and designers.|  
|[Developing a Legacy Language Service](../vs140/developing-a-legacy-language-service.md)|Provides links to documents about features that provide customization capabilities to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] core editor by adding support for a language service.|  
|[Using Fonts and Colors](../vs140/using-fonts-and-colors.md)|Explains how to use fonts and colors with legacy interfaces.|