---
title: "Adding User Control to the Start Page"
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
  - "start page dll"
  - "custom start page"
  - "start page assembly"
ms.assetid: 5b7997db-af6f-4fa9-a128-bceb42bddaf1
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding User Control to the Start Page
This walkthrough shows how to add a DLL reference to a custom Start Page. The example adds a user control to the solution, builds the user control, and then references the built assembly from the Start Page .xaml file. A new tab hosts the user control, which functions as a basic Web browser.  
  
 You can use the same process to add any assembly that can be called from a .xaml file.  
  
## Adding a WPF User Control to the Solution  
 First, add a Windows Presentation Foundation (WPF) user control to the Start Page solution.  
  
1.  Create a Start Page by using we created in [Creating a Custom Start Page](../vs140/creating-a-custom-start-page.md).  
  
2.  In **Solution Explorer**, right-click the solution, click **Add**, and then click **New Project**.  
  
3.  In the left pane of the **New Project** dialog box, expand either the **Visual Basic** or **Visual C#** node, and click **Windows**. In the middle pane, select **WPF User Control Library**.  
  
4.  Name the control <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and then click **OK**.  
  
## Implementing the User Control  
 To implement a WPF user control, build the user interface (UI) in XAML and then write the code-behind events in C# or another .NET language.  
  
#### To write the XAML for the user control  
  
1.  Open the XAML file for the user control. In the \<Grid> element, add the following row definitions to the control.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  In the main <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, add the following new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element, which contains a text box for typing Web addresses and a button for setting the new address.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Add the following frame to the top-level <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element just after the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element that contains the button and textbox.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  The following example shows the completed XAML for the user control.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To write the code-behind events for the user control  
  
1.  In the XAML designer, double-click the **Set Address** button you added to the control.  
  
     The UserControl1.cs file opens in the code editor.  
  
2.  Fill in the SetButton_Click Event Handler as follows.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This code sets the Web address that is typed in the text box as the target for the Web browser. If the address is not valid, the code throws an error.  
  
3.  You must also handle the WebFrame_Navigated event:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Build the solution.  
  
## Adding the User Control to the Start Page  
 To make this control available to the Start Page project, in the Start Page project file, add a reference to the new control library. Then you can add the control to the Start Page XAML markup.  
  
1.  In **Solution Explorer**, in the Start Page project, right-click **References** and then click **Add Reference**.  
  
2.  On the **Projects** tab, select **WebUserControl** and then click **OK**.  
  
3.  On the **Build** menu, click **Build Solution**.  
  
     Building the solution makes the user control available to IntelliSense for other files in the solution.  
  
 To add the control to the Start Page XAML markup, add a namespace reference to the assembly, then put the control on the page.  
  
#### To add the control to the markup  
  
1.  In **Solution Explorer**, open the Start Page .xaml file.  
  
2.  In the **XAML** pane, add the following namespace declaration to the top-level \<xref:System.Windows.Controls.Grid*> element.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
3.  In the **XAML** pane, scroll to the \<Grid> section.  
  
     The section contains a \<xref:System.Windows.Controls.TabControl*> element in a \<xref:System.Windows.Controls.Grid*> element.  
  
4.  Add a \<TabControl> element containing a \<TabItem> that contains a reference to your user control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Now you can test the control.  
  
## Testing a manually created custom Start Page  
  
1.  Copy your XAML file, and any supporting text files or markup files, to the **%USERPROFILE%\My Documents\Visual Studio 2015\StartPages\\** folder.  
  
2.  If your start page references any controls or types in assemblies that are not installed by Visual Studio, copy the assemblies and then paste them in *Visual Studio installation folder***\Common7\IDE\PrivateAssemblies\\**.  
  
3.  At a Visual Studio command prompt, type **devenv /rootsuffix Exp** to open an experimental instance of Visual Studio.  
  
4.  In the experimental instance, go to the **Tools / Options / Environment / Startup** page and select your XAML file from the **Customize Start Page** dropdown.  
  
5.  On the **View** menu, click **Start Page**.  
  
     Your custom start page should be displayed. If you want to change any files, you must close the experimental instance, make the changes, copy and paste the changed files, and then re-open the experimental instance to view the changes.  
  
## See Also  
 [WPF Container Controls](assetId:///a0177167-d7db-4205-9607-8ae316952566)   
 [Walkthrough: Adding Custom XAML to the Start Page](../vs140/walkthrough--adding-custom-xaml-to-the-start-page.md)