---
title: "Extending the Output Window"
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
  - "Output window, about Output window"
ms.assetid: b02fa88c-f92a-4ff6-ba5f-2eb4d48a643a
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Extending the Output Window
The **Output** window is a set of read/write text panes. Visual Studio has these built-in panes: **Build**, in which projects communicate messages about builds, and **General**, in which [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] communicates messages about the IDE. Projects get a reference to the **Build** pane automatically through the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildableProjectCfg*> interface methods, and Visual Studio offers direct access to the **General** pane through the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsGeneralOutputWindowPane*> service. In addition to the built-in panes, you can create and manage your own custom panes.  
  
 You can control the **Output** window directly through the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane*> interfaces. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow*> interface, which is offered by the \<xref:Microsoft.VisualStudio.Shell.Interop.SVsOutputWindow*> service, defines methods for creating, retrieving, and destroying **Output** window panes. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow*> interface defines methods for showing panes, hiding panes, and manipulating their text. An alternative way of controlling the **Output** window is through the \<xref:EnvDTE.OutputWindow*> and \<xref:EnvDTE.OutputWindowPane*> objects in the Visual Studio Automation object model. These objects encapsulate nearly all of the functionality of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane*> interfaces. In addition, the \<xref:EnvDTE.OutputWindow*> and \<xref:EnvDTE.OutputWindowPane*> objects add some higher-level functionality to make it easier to enumerate the **Output** window panes and to retrieve text from the panes.  
  
## Creating an Extension that uses the Output Pane  
 You can make an extension that exercises different aspects of the Output pane.  
  
1.  Create a VSIX project named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with a menu command named **TestOutput**. For more information, see [Creating a VSPackage with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
2.  Add the following references:  
  
    1.  EnvDTE  
  
    2.  EnvDTE80  
  
3.  In TestOutput.cs, add the following using statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  In TestOutput.cs, delete the ShowMessageBox method. Add the following method stub:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  In the TestOutput constructor, change the command handler to OutputCommandHandler. Here is the part that adds the commands:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  The sections below have different methods that show different ways of dealing with the Output pane. You can call these methods to body of the OutputCommandHandler() method. For example, the following code adds the CreatePane() method given in the next section.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Creating an Output Window with IVsOutputWindow  
 This example shows how to create a new **Output** window pane by using the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow*> interface.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the **Output** window with a header that says **Show output from: CreatedPane** and the words **This is the Created Pane** in the pane itself.  
  
## Creating an Output Window with OutputWindow  
 This example shows how to create an **Output** window pane by using the \<xref:EnvDTE.OutputWindow*> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Although the \<xref:EnvDTE.OutputWindowPanes*> collection lets you retrieve an **Output** window pane by its title, pane titles are not guaranteed to be unique. When you doubt the uniqueness of a title, use the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsOutputWindow.GetPane*> method to retrieve the correct pane by its GUID.  
  
 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the Output window with a header that says **Show output from: DTEPane** and the words **Added DTE Pane** in the pane itself.  
  
## Deleting an Output Window  
 This example shows how to delete an **Output** window pane.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see the Output window with a header that says **Show output from: New Pane** and the words **Added Created Pane** in the pane itself. If you click the **Invoke TestOutput** command again, the pane is deleted.  
  
## Getting the General Pane of the Output Window  
 This example shows how to get the built-in **General** pane of the **Output** window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 If you add this method to the extension given in the preceding section, when you click the **Invoke TestOutput** command you should see that the **Output** window shows the words **Found General pane** in the pane.  
  
## Getting the Build Pane of the Output Window  
 This example shows how to find the Build pane and write to it. Since the Build pane isn’t activated by default, it activates it also.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>