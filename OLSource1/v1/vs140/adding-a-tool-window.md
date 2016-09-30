---
title: "Adding a Tool Window"
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
  - "tutorials"
  - "tool windows"
ms.assetid: 8e16c381-03c8-404e-92ef-3614cdf3150a
caps.latest.revision: 56
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Adding a Tool Window
In this walkthrough you learn how to create a tool window and integrate it into Visual Studio in the following ways:  
  
-   Add a control to the tool window.  
  
-   Add a toolbar to a tool window.  
  
-   Add a command to the toolbar.  
  
-   Implement the commands.  
  
-   Set the default position for the tool window.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Tool Window  
  
1.  Create a project named **FirstToolWin** using the VSIX template, and add a custom tool window item template named **FirstToolWindow**.  
  
    > [!NOTE]
    >  For more information about creating an extension with a tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
## Add a Control to the Tool Window  
  
1.  Remove the default control. Open FirstToolWindowControl.xaml and delete the **Click Me!** button.  
  
2.  In the **Toolbox**, expand the **All WPF Controls** section and drag the **Media Element** control to the **FirstToolWindowControl** form. Select the control, and in the **Properties** window, name this element **mediaElement1**.  
  
## Add a Toolbar to the Tool Window  
 By adding a toolbar in the following manner, you guarantee that its gradients and colors are consistent with the rest of the IDE.  
  
1.  In **Solution Explorer**, open FirstToolWindowPackage.vsct. The .vsct file defines the graphical user interface (GUI) elements in your tool window by using XML.  
  
2.  In the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> section, find the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> node whose <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>. Add the following two <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> elements to the list of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> elements in this node to define a toolbar and a toolbar group.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Just above the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> section, create a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> section that resembles this:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     There are several different kinds of menu. This menu is a toolbar in a tool window, defined by its <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute. The <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> and  <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> settings make up the fully qualified ID of the toolbar. Typically, the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> of a menu is the containing group. However, a toolbar is defined as its own parent. Therefore, the same identifier is used for the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> elements. The <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> attribute is just '0'.  
  
4.  Toolbars resemble menus in many ways. For example, just as a menu may have groups of commands, toolbars may also have groups. (On menus, the command groups are separated by horizontal lines. On toolbars, the groups are not separated by visual dividers.)  
  
     Add a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> section that contains a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element. This defines the group whose ID you declared in the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> section. Add the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> section just after the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> section.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     By setting the parent GUID and ID to the GUID and ID of the toolbar, you add the group to the toolbar.  
  
## Add a Command to the Toolbar  
 Add a command to the toolbar, which is displayed as a button.  
  
1.  In the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> section, declare the following IDSymbol elements just after the toolbar and toolbar group declarations.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
2.  Add a Button element inside the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> section. This element will appear on the toolbar in the tool window, with a Search (magnifying glass) icon.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Open FirstToolWindowCommand.cs and add the following lines in the class just after the existing fields.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     Doing this makes your commands available in code.  
  
## Add a MediaPlayer Property to FirstToolWindowControl  
 From the event handlers for the toolbar controls, your code must be able to access the Media Player control, which is a child of the FirstToolWindowControl class.  
  
 In **Solution Explorer**, right-click FirstToolWindowControl.xaml, click **View Code**, and add the following code to the FirstToolWindowControl Class.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Instantiate the Tool Window and Toolbar  
 Add a toolbar and a menu command that invokes the **Open File** dialog and plays the selected media file.  
  
1.  Open FirstToolWindow.cs and add the following <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
2.  Inside the FirstToolWindow class, add a public reference to the FirstToolWindowControl control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
3.  At the end of the constructor, set this control variable to the newly-created control.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
4.  Instantiate the toolbar inside the constructor.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
5.  At this point the FirstToolWindow constructor should look like this:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
6.  Add the menu command to the toolbar. In the FirstToolWindowCommand.cs class, add the following using statement  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
7.  In the FirstToolWindowCommand class, add the following code at the end of the ShowToolWindow() method. The ButtonHandler command will be implemented in the next section.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
#### To implement a menu command in the tool window  
  
1.  In the FirstToolWindowCommand class, add a ButtonHandler method that invokes the **Open File** dialog. When a file has been selected, it plays the media file.  
  
2.  In the FirstToolWindowCommand class, add a private reference to the FirstToolWindow window that gets created in the FindToolWindow() method.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
3.  Change the ShowToolWindow() method to set the window you defined above (so that the ButtonHandler command handler can access the window control. Here is the complete ShowToolWindow() method.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
4.  Add the ButtonHandler method. It creates an OpenFileDialog for the user to specify the media file to play, and then plays the selected file.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
## Set the Default Position for the Tool Window  
 Next, specify a default location in the IDE for the tool window. Configuration information for the tool window is in the FirstToolWindowPackage.cs file.  
  
1.  In FirstToolWindowPackage.cs, find the \<xref:Microsoft.VisualStudio.Shell.ProvideToolWindowAttribute*> attribute on the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> class, which passes the FirstToolWindow type to the constructor. To specify a default position, you must add more parameters to the constructor following example.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
     The first named parameter is <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and its value is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, which means that the window will be a tab in an existing window. The docking position is specified by the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> parameter, n this case, the GUID of the **Solution Explorer**.  
  
    > [!NOTE]
    >  For more information about the types of windows in the IDE, see \<xref:EnvDTE.vsWindowType*>.  
  
## Testing the Tool Window  
  
1.  Press F5 to open a new instance of the Visual Studio experimental build.  
  
2.  On the **View** menu, point to **Other Windows** and then click **First Tool Window**.  
  
     The media player tool window should open in the same position as **Solution Explorer**. If it still appears in the same position as before, reset the window layout (**Window / Reset Window Layout**).  
  
3.  Click the button (it has the Search icon) in the tool window. Select a supported sound or video file, for example, C:\windows\media\chimes.wav, then press **Open**.  
  
     You should hear the chime sound.  
  
## See Also  
 [Menus and Toolbars](../vs140/commands--menus--and-toolbars.md)