---
title: "Creating a Multi-Instance Tool Window"
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
  - "multi"
  - "tool windows"
ms.assetid: 4a7872f1-acc9-4f43-8932-5a526b36adea
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating a Multi-Instance Tool Window
You can program a tool window so that multiple instances of it can be open simultaneously. By default, tool windows can have only one instance open.  
  
 When you use a multi-instance tool window, you can show several related sources of information at the same time. For example, you could put a multi-line \<xref:System.Windows.Forms.TextBox*> control in a multi-instance tool window so that several code snippets are simultaneously available during a programming session. Also for example, you could put a \<xref:System.Windows.Forms.DataGrid*> control and a drop-down list box in a multi-instance tool window so that several real-time data sources can be tracked simultaneously.  
  
## Creating a Basic (Single-Instance) Tool Window  
  
1.  Create a project named **MultiInstanceToolWindow** using the VSIX template, and add a custom tool window item template named **MIToolWindow**.  
  
    > [!NOTE]
    >  For more information about creating an extension with a tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
## Making a tool window multi-instance  
  
1.  Open the **MIToolWindowPackage.cs** file and find the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attribute. and the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  In the MIToolWindowCommand.cs file, find the ShowToolWindos() method. In this method, call the \<xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow*> method and set its <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> so that it will iterate through existing tool window instances until an available <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is found.  
  
3.  To create a tool window instance, call the \<xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow*> method and set its <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to an available value and its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
     By default, the value of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter of the \<xref:Microsoft.VisualStudio.Shell.Package.FindToolWindow*> method is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. This makes a single-instance tool window. For more than one instance to be hosted, every instance must have its own unique <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
4.  Call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.Show*> method on the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame*> object that is returned by the \<xref:Microsoft.VisualStudio.Shell.ToolWindowPane.Frame*> property of the tool window instance.  
  
5.  By default, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method that is created by the tool window item template creates a single-instance tool window. The following example shows how to modify the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method to create multiple instances.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>