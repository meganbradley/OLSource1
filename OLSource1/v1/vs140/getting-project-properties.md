---
title: "Getting Project Properties"
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
  - "project properties, displaying in tool window"
  - "tool windows, displaying project propeties"
ms.assetid: 96ba07ca-0811-4013-8602-12550ac4ba79
caps.latest.revision: 33
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Getting Project Properties
This walkthrough shows how to displays project properties in a tool window.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
### To create a VSIX Project and add a Tool Window  
  
1.  Every Visual Studio extension starts with a VSIX deployment project which will contain the extension assets. Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] VSIX project named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  Add a tool window by adding a Custom Tool Window item template named <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item dialog**, go to **Visual C# Items / Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the dialog, change the file name to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For more information about how to create a custom tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
3.  Build the solution and verify that it compiles without errors.  
  
### To display project properties in a tool window  
  
1.  In the ProjectPropertiesToolWindowCommand.cs file add the following using statements.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  In ProjectPropertiesToolWindowControl.xaml, remove the existing button and add a TreeView from the Toolbox. You can also remove the click event handler from the ProjectPropertiesToolWindowControl.xaml.cs file.  
  
3.  In ProjectPropertiesToolWindowCommand.cs, use the ShowToolWindow() method to open the project and read its properties, then add the properties to the TreeView. The code for ShowToolWindow should look like the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Build the project and start debugging. The experimental instance should appear.  
  
5.  In the experimental instance open a project.  
  
6.  In the **View / Other Windows** click **ProjectPropertiesToolWindow**.  
  
     You should see the tree control in the tool window together with the name of the first project and of all its project properties.