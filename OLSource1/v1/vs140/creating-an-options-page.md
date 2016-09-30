---
title: "Creating an Options Page"
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
  - "Tools Options pages [Visual Studio SDK], creating"
ms.assetid: 9f4e210c-4b47-4daa-91fa-1c301c4587f9
caps.latest.revision: 66
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Creating an Options Page
This walkthrough creates a simple Tools/Options page that uses a property grid to examine and set properties.  
  
 To save these properties to and restore them from a settings file, follow these steps, and then see [Walkthrough: Creating a Settings Category (C#)](../vs140/creating-a-settings-category.md).  
  
 The MPF provides two classes to help you create Tools Options pages, the \<xref:Microsoft.VisualStudio.Shell.Package*> class and the \<xref:Microsoft.VisualStudio.Shell.DialogPage*> class. You create a VSPackage to provide a container for these pages by subclassing the Package class. You create each tools options page by deriving from the DialogPage class.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Creating a Tools Options Grid Page  
 In this section, you create a simple Tools Options property grid. You use this grid to display and change the value of a property.  
  
#### To create the VSIX project and add a VSPackage  
  
1.  Every Visual Studio extension starts with a VSIX deployment project which will contain the extension assets. Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] VSIX project named <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  Add a VSPackage by adding a Visual Studio Package item template named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. In the **Solution Explorer**, right-click the project node and select **Add / New Item**. In the **Add New Item dialog**, go to **Visual C# Items / Extensibility** and select **Visual Studio Package**. In the **Name** field at the bottom of the dialog, change the file name to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information about how to create a VSPackage, see [Creating an Extension with a VSPackage](../vs140/creating-an-extension-with-a-vspackage.md).  
  
#### To create the Tools Options property grid  
  
1.  Open the MyToolsOptionsPackage file in the code editor.  
  
2.  Add the following using statement.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Declare an OptionPageGrid class and derive it from \<xref:Microsoft.VisualStudio.Shell.DialogPage*>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Apply a \<xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute*> to the VSPackage class to assign to the class an options category and options page name for the OptionPageGrid. The result should look like this:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
5.  Add an <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> property to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> class.  
  
    -   Apply a \<xref:System.ComponentModel.CategoryAttribute*?displayProperty=fullName> to assign to the property a property grid category.  
  
    -   Apply a \<xref:System.ComponentModel.DisplayNameAttribute*?displayProperty=fullName> to assign to the property a name.  
  
    -   Apply a \<xref:System.ComponentModel.DescriptionAttribute*?displayProperty=fullName> to assign to the property a description.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The default implementation of \<xref:Microsoft.VisualStudio.Shell.DialogPage*> supports properties that have appropriate converters or that are structures or arrays that can be expanded into properties that have appropriate converters. For a list of converters, see the \<xref:System.ComponentModel*> namespace.  
  
6.  Build the project and start debugging.  
  
7.  In the experimental instance of Visual Studio, on the **Tools** menu click **Options**.  
  
     In the left pane you should see **My Category**. (Options categories are listed in alphabetical order, so it should appear about halfway down the list.) Open **My Category** and then click **My Grid Page**.The options grid appears in the right pane. The property category is **My Options**, and the property name is **My Integer Option**. The property description, **My integer option**, appears at the bottom of the pane. Change the value from its initial value of 256 to something else. Click **OK**, and then reopen **My Grid Page**. You can see that the new value persists.  
  
     Your options page is also available through Visual Studio’s Quick Launch. In the Quick Launch window in the upper right corner of the IDE, type **My Category** and you will see **My Category –> My Grid Page** listed in the dropdown.  
  
## Creating a Tools Options Custom Page  
 In this section, you create a Tools Options page with a custom UI. You use this page to display and change the value of a property.  
  
1.  Open the MyToolsOptionsPackage file in the code editor.  
  
2.  Add the following using statement.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
3.  Add an <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> class, just before the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class. Derive the new class from <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
4.  Add a GUID attribute. Add an OptionString property:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
5.  Apply a second \<xref:Microsoft.VisualStudio.Shell.ProvideOptionPageAttribute*> to the VSPackage class. This attribute assigns the class an options category and options page name.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
6.  Add a new **User Control** named MyUserControl to the project.  
  
7.  Add a **TextBox** control to the user control.  
  
     In the **Properties** window, on the toolbar, click the **Events** button, and then double-click the **Leave** event. The new event handler appears in the MyUserControl.cs code.  
  
8.  Add a public <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> field, an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method to the control class, and update the event handler to set the option value to the contents of the text box:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> field holds a reference to the parent <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> instance. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method displays <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> in the **TextBox**. The event handler writes the current value of the **TextBox** to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> when focus leaves the **TextBox**.  
  
9. In the package code file, add an override for the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> property to the OptionPageCustom class to create, initialize, and return an instance of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The class should now look like this:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
10. Build and run the project.  
  
11. In the experimental instance, click **Tools / Options**.  
  
12. Find **My Category** and then **My Custom Page**.  
  
13. Change the value of **OptionString**. Click **OK**, and then reopen **My Custom Page**. You can see that the new value has persisted.  
  
## Accessing Options  
 In this section, you get the value of an option from the VSPackage that hosts the associated Tools Options page. The same technique can be used to obtain the value of any public property.  
  
1.  In the package code file, add a public property called **OptionInteger** to the **MyToolsOptionsPackage** class.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     This code calls \<xref:Microsoft.VisualStudio.Shell.Package.GetDialogPage*> to create or retrieve an <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> instance. <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> calls \<xref:Microsoft.VisualStudio.Shell.DialogPage.LoadSettingsFromStorage*> to load its options, which are public properties.  
  
2.  Now add a custom command item template named **MyToolsOptionsCommand** to display the value. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to **MyToolsOptionsCommand.cs**.  
  
3.  In the MyToolsOptionsCommand file, replace the body of the command’s <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method with the following:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
4.  Build the project and start debugging.  
  
5.  In the experimental instance, on the **Tools** menu, click **Invoke MyToolsOptionsCommand**.  
  
     A message box displays the current value of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>.  
  
## See Also  
 [Support for Tools/Options Pages](../vs140/options-and-options-pages.md)