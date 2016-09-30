---
title: "Walkthrough: Using a Shell Command with an Editor Extension"
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
  - "editors [Visual Studio SDK], new - add a menu command"
ms.assetid: 08526848-a442-4cd4-afa1-b2eac2005adb
caps.latest.revision: 50
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using a Shell Command with an Editor Extension
From a VSPackage, you can add features such as menu commands to the editor. This walkthrough shows how to add an adornment to a text view in the editor by invoking a menu command.  
  
 This walkthrough demonstrates the use of a VSPackage together with a Managed Extensibility Framework (MEF) component part. You must use a VSPackage to register the menu command with the Visual Studio shell, and you can use the command to access the MEF component part.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating an Extension with a Menu Command  
 Create a VSPackage that puts a menu command named **Add Adornment** on the **Tools** menu.  
  
1.  Create a C# VSIX project named <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, and add a Custom Command item template name **AddAdornment**. For more information, see [Creating a VSPackage with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md).  
  
2.  A solution named MenuCommandTest is opened. The MenuCommandTestPackage file has the code that creates the menu command and puts it on the **Tools** menu. At this point, the command just causes a message box to be displayed. Later steps show how to change this to display the comment adornment.  
  
3.  Open the source.extension.vsixmanifest file in the VSIX Manifest Editor. The <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> tab should have a row for a Microsoft.VisualStudio.VsPackage named MenuCommandTest.  
  
4.  Save and close the Source.extension.vsixmanifest file.  
  
## Adding a MEF Extension to the Command Extension  
  
1.  In **Solution Explorer**, right-click the solution node, click **Add**, and then click **New Project**. In the **Add New Project** dialog box, click **Extensibility** under **Visual C#**, then **VSIX Project**. Name the project <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
2.  Because this project will interact with the strongly-named VSPackage assembly, you must sign the assembly. You can reuse the key file already created for the VSPackage assembly.  
  
    1.  Open the project properties and select the **Signing** tab.  
  
    2.  Select **Sign the assembly**.  
  
    3.  Under **Choose a strong name key file**, select the Key.snk file that was generated for the MenuCommandTest assembly.  
  
## Referring to the MEF Extension in the VSPackage Project  
 Because you are adding a MEF component to the VSPackage, you must specify both kinds of assets in the manifest.  
  
> [!NOTE]
>  For more information about MEF, see [Managed Extensibility Framework Overview](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
#### To refer to the MEF component in the VSPackage project  
  
1.  In the MenuCommandTest project, open the source.extension.vsixmanifest file in the VSIX Manifest Editor.  
  
2.  On the **Assets** tab, click **New**.  
  
3.  In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.  
  
4.  In the **Source** list, choose **A project in current solution**.  
  
5.  In the **Project** list, choose **CommentAdornmentTest**.  
  
6.  Save and close the source.extension.vsixmanifest file.  
  
7.  Make sure that the MenuCommandTest project has a reference to the CommentAdornmentTest project.  
  
8.  In the CommentAdornmentTest project, set the project to produce an assembly. In the **Solution Explorer**, select the project and look in the **Properties** window for the **Copy Build Output to OutputDirectory** property, and set it to **true**.  
  
## Defining a Comment Adornment  
 The comment adornment itself consists of an \<xref:Microsoft.VisualStudio.Text.ITrackingSpan*> that tracks the selected text, and some strings that represent the author and the description of the text.  
  
#### To define a comment adornment  
  
1.  In the CommentAdornmentTest project, add a new class file and name it <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
2.  Add the following references:  
  
    1.  Microsoft.VisualStudio.CoreUtility  
  
    2.  Microsoft.VisualStudio.Text.Data  
  
    3.  Microsoft.VisualStudio.Text.Logic  
  
    4.  Microsoft.VisualStudio.Text.UI  
  
    5.  Microsoft.VisualStudio.Text.UI.Wpf  
  
    6.  System.ComponentModel.Composition  
  
    7.  PresentationCore  
  
    8.  PresentationFramework  
  
    9. WindowsBase  
  
3.  Add the following <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  The file should contain a class named <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Add three fields to the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class for the \<xref:Microsoft.VisualStudio.Text.ITrackingSpan*>, the author, and the description.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  Add a constructor that initializes the fields.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Creating a Visual Element for the Adornment  
 You must also define a visual element for your adornment. For this walkthrough, define a control that inherits from the Windows Presentation Foundation (WPF) class \<xref:System.Windows.Controls.Canvas*>.  
  
1.  Create a class in the CommentAdornmentTest project, and name it <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
2.  Add the following <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Make the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> class inherit from \<xref:System.Windows.Controls.Canvas*>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Add some private fields to define the visual aspects of the adornment.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
5.  Add a constructor that defines the comment adornment and adds the relevant text.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
6.  Also implement an \<xref:System.Windows.Controls.Panel.OnRender*> event handler that draws the adornment.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Adding an IWpfTextViewCreationListener  
 The \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener*> is a MEF component part that you can use to listen to view creation events.  
  
1.  Add a class file to the CommentAdornmentTest project and name it <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
2.  Add the following <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
3.  Declare a class that implements \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener*>, and export it with a \<xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute*> of "text" and a \<xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute*> of \<xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Document*>. The content type attribute specifies the kind of content to which the component applies. The text type is the base type for all non-binary file types. Therefore, almost every text view that is created will be of this type. The text view role attribute specifies the kind of text view to which the component applies. Document text view roles generally show text that is composed of lines and is stored in a file.  
  
     [!code[VSSDKMenuCommandTest#11](../vs140/codesnippet/VisualBasic/walkthrough--using-a-shell-command-with-an-editor-extension_1.vb)]
[!code[VSSDKMenuCommandTest#11](../vs140/codesnippet/CSharp/walkthrough--using-a-shell-command-with-an-editor-extension_1.cs)]  
  
4.  Implement the \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated*> method so that it calls the static <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> event of the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
5.  Add a method that you can use to execute the command.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## Defining an Adornment Layer  
 To add a new adornment, you must define an adornment layer.  
  
#### To define an adornment layer  
  
1.  In the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> class, declare a public field of type \<xref:Microsoft.VisualStudio.Text.Editor.AdornmentLayerDefinition*>, and export it with a \<xref:Microsoft.VisualStudio.Utilities.NameAttribute*> that specifies a unique name for the adornment layer and an \<xref:Microsoft.VisualStudio.Utilities.OrderAttribute*> that defines the Z-order relationship of this adornment layer to the other text view layers (text, caret, and selection).  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
## Providing Comment Adornments  
 When you define an adornment, also implement a comment adornment provider and a comment adornment manager. The comment adornment provider keeps a list of comment adornments, listens to \<xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed*> events on the underlying text buffer, and deletes comment adornments when the underlying text is deleted.  
  
1.  Add a new class file to the CommentAdornmentTest project and name it <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>.  
  
2.  Add the following <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
3.  Add a class named <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
4.  Add private fields for the text buffer and the list of comment adornments related to the buffer.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
5.  Add a constructor for <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. This constructor should have private access because the provider is instantiated by the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> method. The constructor adds the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> event handler to the \<xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed*> event.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
6.  Add the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
7.  Add the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
8.  Add the <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> event handler.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
     [!code[VSSDKMenuCommandTest#21](../vs140/codesnippet/CSharp/walkthrough--using-a-shell-command-with-an-editor-extension_2.cs)]
[!code[VSSDKMenuCommandTest#21](../vs140/codesnippet/VisualBasic/walkthrough--using-a-shell-command-with-an-editor-extension_2.vb)]  
  
9. Add a declaration for a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> event.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
10. Create an <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> method to add the adornment.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
11. Add a <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
12. Add a <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> method that returns all the comments in a given snapshot span.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
13. Add a class named <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, as follows.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
## Managing Comment Adornments  
 The comment adornment manager creates the adornment and adds it to the adornment layer. It listens to the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> and \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed*> events so that it can move or delete the adornment. It also listens to the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> event that is fired by the comment adornment provider when comments are added or removed.  
  
1.  Add a class file to the CommentAdornmentTest project and name it <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>.  
  
2.  Add the following <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
3.  Add a class named <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
4.  Add some private fields.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
5.  Add a constructor that subscribes the manager to the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> and \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed*> events, and also to the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> event. The constructor is private because the manager is instantiated by the static <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> method.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
6.  Add the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> method that gets a provider or creates one if required.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
7.  Add the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> handler.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
8.  Add the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed*> handler.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
9. Add the \<xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged*> handler.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
10. Add the private method that draws the comment.  
  
     [!code[VSSDKMenuCommandTest#35](../vs140/codesnippet/CSharp/walkthrough--using-a-shell-command-with-an-editor-extension_3.cs)]
[!code[VSSDKMenuCommandTest#35](../vs140/codesnippet/VisualBasic/walkthrough--using-a-shell-command-with-an-editor-extension_3.vb)]  
  
## Using the Menu Command to Add the Comment Adornment  
 You can use the menu command to create a comment adornment by implementing the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> method of the VSPackage.  
  
1.  Add the following references to the MenuCommandTest project:  
  
    -   Microsoft.VisualStudio.TextManager.Interop  
  
    -   Microsoft.VisualStudio.Editor  
  
    -   Microsoft.VisualStudio.Text.UI.Wpf  
  
2.  Open the AddAdornment.cs file and add the following <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> statements.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
3.  Delete the ShowMessageBox() method and add the following command handler.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
4.  Add code to get the active view. You must get the <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> of the Visual Studio shell to get the active <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
5.  If this text view is an instance of an editor text view, you can cast it to the \<xref:Microsoft.VisualStudio.TextManager.Interop.IVsUserData*> interface and then get the \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost*> and its associated \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView*>. Use the \<xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost*> to call the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> method, which gets the comment adornment provider and adds the adornment. The command handler should now look like this:  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
6.  Set the AddAdornmentHandler method as the handler for the AddAdornment command in the AddAdornment constructor.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
## Building and Testing the Code  
  
1.  Build the solution and start debugging. The experimental instance should appear.  
  
2.  Create a text file. Type some text and then select it.  
  
3.  On the **Tools** menu, click **Invoke Add Adornment**. A balloon should be displayed on the right side of the text window, and should contain text that resembles the following text.  
  
     YourUserName  
  
     Fourscore…  
  
## See Also  
 [How to: Link a Content Type to a File Extension](../vs140/walkthrough--linking-a-content-type-to-a-file-name-extension.md)