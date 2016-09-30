---
title: "Walkthrough: Saving User Settings on a Start Page"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 754b9bf3-8681-4c77-b0a4-09146a4e1d2d
caps.latest.revision: 22
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Saving User Settings on a Start Page
You can persist user settings for your start page. By following this walkthrough, you can create a control that saves a setting to the registry when the user clicks a button, and then retrieves that setting every time the Start Page loads. Because the Start Page project template includes a customizable user control, and the default Start Page XAML calls that control, you do not have to modify the Start Page itself.  
  
 The settings store that is instantiated in this walkthrough is an instance of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsWritableSettingsStore*> interface, which reads and writes to the following registry location when it is called: HKCU\Software\Microsoft\VisualStudio\14.0\\*CollectionName*  
  
 When it is running in the experimental instance of Visual Studio, the settings store reads and writes to HKCU\Software\Microsoft\VisualStudio\14.0Exp\\*CollectionName.*  
  
 For more information about how to persist settings, see [Extending User Settings and Options](../vs140/extending-user-settings-and-options.md).  
  
## Prerequisites  
  
> [!NOTE]
>  To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Software Development Kit (SDK)](../vs140/visual-studio-sdk.md).  
>   
>  You can download the Start Page project template by using **Extension Manager**.  
  
## Setting Up the Project  
  
#### To configure the project for this walkthrough  
  
1.  Create a Start Page project by using the Start Page project template, as described in [Start Pages](../vs140/creating-your-own-start-page.md). Name the project **SaveMySettings**.  
  
2.  In **Solution Explorer**, add the following assembly references to the StartPageControl project:  
  
    -   EnvDTE  
  
    -   EnvDTE80  
  
    -   Microsoft.VisualStudio.OLE.Interop  
  
    -   Microsoft.VisualStudio.Shell.Interop.11.0  
  
3.  Open MyControl.xaml.  
  
4.  From the XAML pane, in the top-level \<xref:System.Windows.Controls.UserControl*> element definition, add the following event declaration after the namespace declarations.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
5.  In the design pane, click the main area of the control, and then press DELETE.  
  
     This removes the \<xref:System.Windows.Controls.Border*> element and everything in it, and leaves only the top-level \<xref:System.Windows.Controls.Grid*> element.  
  
6.  From the **Toolbox**, drag a \<xref:System.Windows.Controls.StackPanel*> control to the grid.  
  
7.  Now drag a \<xref:System.Windows.Controls.TextBlock*>, a \<xref:System.Windows.Controls.TextBox*>, and a Button to the \<xref:System.Windows.Controls.StackPanel*>.  
  
8.  Add an **x:Name** attribute for the \<xref:System.Windows.Controls.TextBox*>, and a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> event for the \<xref:System.Windows.Controls.Button*>, as shown in the following example.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Implementing the User Control  
  
#### To implement the user control  
  
1.  In the XAML pane, right-click the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute of the \<xref:System.Windows.Controls.Button*> element, and then click **Navigate to Event Handler**.  
  
     This opens MyControl.xaml.cs, and creates a stub handler for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event.  
  
2.  Add the following <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> statements to the top of the file.  
  
     [!code[StartPageDTE#11](../vs140/codesnippet/CSharp/walkthrough--saving-user-settings-on-a-start-page_1.cs)]  
  
3.  Add a private <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> property, as shown in the following example.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     This property first gets a reference to the \<xref:EnvDTE80.DTE2*> interface, which contains the Automation object model, from the \<xref:System.Windows.FrameworkElement.DataContext*> of the user control, and then uses the DTE to get an instance of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsSettingsManager*> interface. Then it uses that instance to return the current user settings.  
  
4.  Fill in the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event as follows.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     This writes the content of the text box to a "MySetting" field in a "MySettings" collection in the registry. If the collection does not exist, it is created.  
  
5.  Add the following handler for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> event of the user control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This sets the text of the text box to the current value of "MySetting".  
  
6.  Build the user control.  
  
7.  In **Solution Explorer**, open source.extension.vsixmanifest.  
  
8.  In the manifest editor, set **Product Name** to **Save My Settings Start Page**.  
  
     This sets the name of the Start Page as it is to appear in the **Customize Start Page** list in the **Options** dialog box.  
  
9. Build StartPage.xaml.  
  
## Testing the Control  
  
#### To test the user control  
  
1.  Press F5.  
  
     The experimental instance of Visual Studio opens.  
  
2.  In the experimental instance, on the **Tools** menu, click **Options**.  
  
3.  In the **Environment** node, click **Startup**, and then, in the **Customize Start Page** list, select **[Installed Extension] Save My Settings Start Page**.  
  
     Click **OK**.  
  
4.  Close the Start Page if it is open, and then, on the **View** menu, click **Start Page**.  
  
5.  On the Start Page, click the **MyControl** tab.  
  
6.  In the text box, type **Cat**, and then click **Save My Setting**.  
  
7.  Close the Start Page and then open it again.  
  
     The word "Cat" should be displayed in the text box.  
  
8.  Replace the word "Cat" with the word "Dog". Do not click the button.  
  
9. Close the Start Page and then open it again.  
  
     The word "Dog" should be displayed in the text box, even though the setting was not saved. This happens because Visual Studio keeps tool windows in memory, even if they are closed, until Visual Studio itself is closed.  
  
10. Close the experimental instance of Visual Studio.  
  
11. Press F5 to re-open the experimental instance.  
  
12. The word "Cat" should be displayed in the text box.  
  
## Next Steps  
 You can modify this user control to save and retrieve any number of custom settings by using different values from different event handlers to get and set the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> property. As long as you use a different <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter for each call to \<xref:Microsoft.VisualStudio.Shell.Interop.IVsWritableSettingsStore.SetString*>, the values will not overwrite one another in the registry.  
  
## See Also  
 \<xref:EnvDTE80.DTE2*?displayProperty=fullName>   
 [Start Pages](../vs140/creating-your-own-start-page.md)   
 [Adding Visual Studio Commands to a Start Page](../vs140/adding-visual-studio-commands-to-a-start-page.md)