---
title: "How to: Extend the Domain-Specific Language Designer"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: fa807f1b-2780-491e-925b-abbfd31b2bfa
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Extend the Domain-Specific Language Designer
You can make extensions to the designer that you use to edit DSL Definitions. Types of extension that you can make include adding menu commands, adding handlers for drag and double-click gestures, and rules that are triggered when particular types of values or relationships change. The extensions can be packaged as a Visual Studio Integration Extension (VSIX) and distributed to other users.  
  
 For sample code and more information about this feature, see the Visual Studio [Visualization and Modeling SDK (VMSDK) Web site](http://go.microsoft.com/fwlink/?LinkID=186128).  
  
## Setting up the Solution  
 Set up a project that contains the code of your extension, and a VSIX project that exports the project. Your solution can contain other projects that are incorporated into the same VSIX.  
  
#### To create a DSL Designer Extension Solution  
  
1.  Create a new project using the Class Library project template. In the **New Project** dialog box, click **Visual C#** and then in the middle window click **Class Library**.  
  
     This project will contain the code of your extensions.  
  
2.  Create a new project using the VSIX project template. In the **New Project** dialog box, expand **Visual C#**, click **Extensibility**, and then in the middle window select **VSIX Project**.  
  
     Select **Add to Solution**.  
  
     Source.extension.vsixmanifest opens in the VSIX manifest editor.  
  
3.  Above the Content field, click **Add Content**.  
  
4.  In the **Add Content** dialog box, set **Select a Content Type** to **MEF Component**, and set **Project** to your class library project.  
  
5.  Click **Select Editions** and make sure that **Visual Studio Enterprise** is checked.  
  
6.  Make sure that the VSIX project is the Startup project of the solution.  
  
7.  In the class library project, add references to the following assemblies:  
  
     Microsoft.VisualStudio.CoreUtility  
  
     Microsoft.VisualStudio.Modeling.Sdk.11.0  
  
     Microsoft.VisualStudio.Modeling.Sdk.Diagrams.11.0  
  
     Microsoft.VisualStudio.Modeling.Sdk.DslDefinition.11.0  
  
     Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0  
  
     System.ComponentModel.Composition  
  
     System.Drawing  
  
     System.Drawing.Design  
  
     System.Windows.Forms  
  
## Testing and Deployment  
 To test any of the extensions in this topic, build and run the solution. An experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] opens. In this instance, open a DSL solution. Edit the DslDefinition diagram. The extension behavior can be seen.  
  
 To deploy the extensions to the main [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], and to other computers, follow these steps:  
  
1.  Find the VSIX installation file, in your VSIX project in bin\\*\\\*.vsix  
  
2.  Copy this file to the target computer, and then in Windows Explorer (or File Explorer), double-click it.  
  
     The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension Manager opens to confirm that the extension has been installed.  
  
 To uninstall the extension, follow these steps:  
  
1.  in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], on the **Tools** menu, click **Extension Manager**.  
  
2.  Select the extension and delete it.  
  
## Adding a Shortcut Menu Command  
 To make a shortcut menu command appear on the DSL Designer surface or in the DSL Explorer window, write a class resembling the following.  
  
 The class must implement <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and must have the attribute <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Handling Mouse Gestures  
 The code is similar to the code of the menu command.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Responding to Value Changes  
 This handler needs a domain model to work correctly. We provide a simple domain model.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The following code implements a simple model. Create a new GUID to replace the placeholder.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>