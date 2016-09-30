---
title: "Walkthrough: Autoloading Toolbox Items"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Toolbox [Visual Studio SDK], adding controls using reflection"
  - "reflection, Toolbox"
ms.assetid: b03c0d62-3be0-475f-b1d9-725dee993ad6
caps.latest.revision: 60
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Autoloading Toolbox Items
This walkthrough illustrates how a managed VSPackage can use reflection to automatically load all the \<xref:System.Drawing.Design.ToolboxItem*> items provided by its own assembly.  
  
> [!NOTE]
>  The recommended way to add custom controls to the Toolbox is to use the Toolbox Control templates that come with the Visual Studio SDK, which includes auto-loading support. This topic is retained for backward compatibility, for adding existing controls to the Toolbox, and for advanced Toolbox development.  
>   
>  For more information on creating toolbox controls by using the templates, see [How to: Create a Toolbox Control That Uses Windows Forms](../vs140/how-to--create-a-toolbox-control-that-uses-windows-forms.md) and [How to: Create a Toolbox Control That Uses WPF](../vs140/creating-a-wpf-toolbox-control.md).  
  
 This walkthrough guides you through the following steps:  
  
1.  Add and correctly register all **Toolbox** controls in the VSPackage objects by using \<xref:System.ComponentModel.ToolboxItemAttribute*>, \<xref:System.Drawing.ToolboxBitmapAttribute*>, and \<xref:System.ComponentModel.DisplayNameAttribute*>.  
  
2.  Create the following two controls, and add icons for each to the **Toolbox**:  
  
    -   Add one control by using a default \<xref:System.Drawing.Design.ToolboxItem*> class.  
  
    -   Add another control by using a custom class that is derived from the \<xref:System.Drawing.Design.ToolboxItem*> class.  
  
3.  Register the VSPackage as providing \<xref:System.Drawing.Design.ToolboxItem*> objects that have the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> class.  
  
4.  Use reflection to generate a list of all \<xref:System.Drawing.Design.ToolboxItem*> objects that the VSPackage provides when it is loaded.  
  
5.  Create a handler for the \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events. Doing this guarantees that the \<xref:System.Drawing.Design.ToolboxItem*> objects of the VSPackage are correctly loaded.  
  
6.  Implement a command on the VSPackage to force re-initialization of the **Toolbox**.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Integration SDK](../Topic/Extending%20Visual%20Studio%20Overview_deleted.md).  
  
## Locations for the Visual Studio Package Project Template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1.  Under Visual Basic Extensibility. The default language of the project is Visual Basic.  
  
2.  Under C# Extensibility. The default language of the project is C#.  
  
3.  Under Other Project Types Extensibility. The default language of the project is C++.  
  
## Creating a Managed VSPackage  
  
#### To create the LoadToolboxMembers VSPackage  
  
1.  Create a VSPackage named <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. For more information, see [How to: Create VSPackages (C# and Visual Basic)](../Topic/Walkthrough:%20Creating%20a%20Menu%20Command%20By%20Using%20the%20Visual%20Studio%20Package%20Template_deleted.md).  
  
2.  Add a menu command.  
  
     Name the command <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for Visual Basic or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for Visual C#.  
  
 If you follow this walkthrough for more than one language, you must update the project to disambiguate the generated assemblies.  
  
#### To disambiguate Visual Basic and Visual C# VSPackages  
  
1.  For [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)]:  
  
    -   In **Solution Explorer**, open the project properties, and select the **Application** tab.  
  
         Change the assembly name to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, and change the default namespace to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
2.  For [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)]:  
  
    1.  In **Solution Explorer**, open the project properties, and select the **Application** tab.  
  
         Change the assembly name to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and change the default namespace to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
    2.  Open the LoadToolboxMembersPackage class in the code editor.  
  
         To use the refactoring tools to rename the existing namespace, right-click the existing namespace name, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, point to **Refactor**, and then click **Rename**. Change the name to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
3.  Save all changes.  
  
#### To add supporting references  
  
1.  In the LoadToolboxMembers project, add a reference to the \<xref:System.Drawing.Design*?displayProperty=fullName> .NET Framework component, as follows.  
  
    1.  In **Solution Explorer**, right-click the LoadToolboxMembers project, and then click **Add**, **Reference**.  
  
    2.  On the **.NET** tab of the **References** dialog box, double-click **System.Drawing.Design**.  
  
2.  For Visual Basic, add the following namespaces to the imported namespaces list in the project:  
  
    -   Company.LoadToolboxMembersVB  
  
    -   System  
  
    -   System.ComponentModel  
  
    -   System.Drawing  
  
    -   System.Windows.Forms  
  
#### To test the generated code  
  
1.  Compile and start the VSPackage in the Visual Studio experimental hive.  
  
2.  On the **Tools** menu, click **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS**.  
  
     This opens a message box that contains text that indicates that the package's menu item handler was called.  
  
3.  Close the experimental version of [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)].  
  
## Creating a Toolbox Control  
 In this section, you create and register a user control, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, that declares an associated default **Toolbox** item. For more information about how to author Windows Form controls and the \<xref:System.Drawing.Design.ToolboxItem*> class, see [Developing Windows Forms Controls at Design Time](assetId:///e5a8e088-7ec8-4fd9-bcb3-9078fd134829).  
  
#### To create a Toolbox control that will be used with a default ToolboxItem  
  
1.  In **Solution Explorer**, add a \<xref:System.Windows.Forms.UserControl*> object to the LoadToolboxMembers project, as follows:  
  
    1.  In **Solution Explorer**, right-click the **LoadToolboxMembers** project, point to **Add**, and then click **User Control**.  
  
    2.  In the **Add New Item** dialog box, change the name to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> for [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)].  
  
         For more information about how to add new items to a project, see [NIB:How to: Add New Project Items](assetId:///63d3e16b-de6e-4bb5-a0e3-ecec762201ce).  
  
     The new control opens in Design view.  
  
2.  From the **Toolbox**, drag a **Button** control (located in the **Common Controls** category) to the designer.  
  
3.  Double-click the button you just created. Doing this generates an event handler for the button's \<xref:System.Windows.Forms.Control.Click*> event. Update the event handler by using the following code:  
  
     [!code[LoadToolboxMembers#01](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_1.cs)]
[!code[LoadToolboxMembers#01](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_1.vb)]  
  
4.  Modify the constructor of the control to set the button text after the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method is called:  
  
     [!code[LoadToolboxMembers#02](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_2.cs)]
[!code[LoadToolboxMembers#02](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_2.vb)]  
  
5.  Add attributes to the file to enable the VSPackage to query the supplied \<xref:System.Drawing.Design.ToolboxItem*> class:  
  
     [!code[LoadToolboxMembers#03](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_3.cs)]
[!code[LoadToolboxMembers#03](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_3.vb)]  
  
6.  Save the file.  
  
 In the following procedure, you create and register a second user control, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and an associated custom **Toolbox** item, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, that is derived from the \<xref:System.Drawing.Design.ToolboxItem*> class.  
  
#### To create a Toolbox control for using a custom ToolboxItem-derived class  
  
1.  Create a second user control named <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. Double click on the form to bring up the code file.  
  
2.  Add <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to the namespaces that are used in the class.  
  
     [!code[LoadToolboxMembers#04](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_4.cs)]
[!code[LoadToolboxMembers#04](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_4.vb)]  
  
3.  Add a button and button click event handler and update the control's constructor just like you updated the first control.  
  
4.  Add the \<xref:System.ComponentModel.DisplayNameAttribute*>, \<xref:System.ComponentModel.DescriptionAttribute*>, \<xref:System.ComponentModel.ToolboxItemAttribute*>, and \<xref:System.Drawing.ToolboxBitmapAttribute*> attributes to the file.  
  
     These attributes enable the VSPackage to query for a \<xref:System.Drawing.Design.ToolboxItem*> class.  
  
     For more information and examples about how to write custom \<xref:System.Drawing.Design.ToolboxItem*> objects, see the discussion in the \<xref:System.Drawing.Design.ToolboxItem*> reference page.  
  
     Together with the previous changes, your second control class should resemble the following code. The symbol <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> will be undefined until after the next step.  
  
     [!code[LoadToolboxMembers#05](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_5.cs)]
[!code[LoadToolboxMembers#05](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_5.vb)]  
  
5.  Create a class named <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. This \<xref:System.Drawing.Design.ToolboxItem*> is constructed for the second control and added to the **Toolbox**. The class must have <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> applied to it.  
  
     [!code[LoadToolboxMembers#06](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_6.cs)]
[!code[LoadToolboxMembers#06](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_6.vb)]  
  
6.  Save the file.  
  
## Embedding Bitmap Icons  
 The two instances of \<xref:System.Drawing.ToolboxBitmapAttribute*> used earlier indicate that the project represents the two controls by using the following icons:  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, located in the namespace that contains the first control.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, located in the namespace that contains the second control.  
  
#### To embed bitmap icons for the ToolboxItem  
  
1.  Add two new bitmaps to the project, as follows.  
  
    1.  Right-click the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> project.  
  
    2.  Point to **Add**, and then click **New Item**.  
  
    3.  In the **Add New Item** dialog box, select **Bitmap File**, and name the file <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
    4.  Repeat these steps for the second bitmap and name it <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
         Doing this opens each bitmap in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] bitmap editor.  
  
2.  Set the size of each icon to 16 x 16, as follows.  
  
    1.  For each bitmap, click **Properties Window** on the **View** menu.  
  
    2.  In the **Properties** window, set **Height** and **Width** to 16.  
  
3.  Use the bitmap editor in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to create an image for each icon.  
  
4.  In **Solution Explorer**, click each bitmap file, and then, in the **Properties** window, set the **Build Action** property to **Embedded Resource**.  
  
5.  Save all open files.  
  
## Modifying the VSPackage Implementation  
 The default implementation of the VSPackage must be modified to do the following things:  
  
-   Register support for being a **Toolbox** item provider.  
  
-   Obtain a list of \<xref:System.Drawing.Design.ToolboxItem*> objects that the VSPackage supports.  
  
-   Load the \<xref:System.Drawing.Design.ToolboxItem*> object in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Toolbox** when \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events are handled.  
  
 The next procedure shows how to modify the package implementation.  
  
#### To modify the package implementation to be a Toolbox item provider for the VSPackage  
  
1.  Open the LoadToolboxMembersPackage.cs or LoadToolboxMembersPackage.vb file in the code editor.  
  
2.  Modify the declaration of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class, which is the implementation of the \<xref:Microsoft.VisualStudio.Shell.Package*> class in the solution, as follows.  
  
    1.  Add the following namespace directives to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class file.  
  
         [!code[LoadToolboxMembers#07](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_7.cs)]
[!code[LoadToolboxMembers#07](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_7.vb)]  
  
    2.  Register the VSPackage as a \<xref:System.Drawing.Design.ToolboxItem*> class by adding an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*>.  
  
        > [!NOTE]
        >  The sole argument of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> is the version of \<xref:System.Drawing.Design.ToolboxItem*> that is provided by the VSPackage. Changing this value forces the IDE to load the VSPackage even if it has an earlier cached version of \<xref:System.Drawing.Design.ToolboxItem*> class.  
  
    3.  Add the following two new <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> fields to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class:  
  
         An \<xref:System.Collections.ArrayList*> member, named <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, to hold a list of the \<xref:System.Drawing.Design.ToolboxItem*> objects that the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class manages.  
  
         A \<xref:System.String*>, named <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, that contains the **Toolbox** category or tab that is used to hold the \<xref:System.Drawing.Design.ToolboxItem*> objects that are managed by the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> class.  
  
     The result of this modification resembles the following code:  
  
     [!code[LoadToolboxMembers#08](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_8.cs)]
[!code[LoadToolboxMembers#08](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_8.vb)]  
  
3.  Expand the Package Members region to modify the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method to do the following things:  
  
    -   For [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)], subscribe to the \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events.  
  
    -   Call the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method to fill the \<xref:System.Collections.ArrayList*> object <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> will contain a list of all the toolbox items that <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> manages.  
  
     [!code[LoadToolboxMembers#09](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_9.cs)]
[!code[LoadToolboxMembers#09](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_9.vb)]  
  
4.  Add two methods, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, to construct, by using metadata, instances of the \<xref:System.Drawing.Design.ToolboxItem*> objects that are available in the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> assembly, as follows:  
  
     [!code[LoadToolboxMembers#10](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_10.cs)]
[!code[LoadToolboxMembers#10](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_10.vb)]  
  
5.  Implement the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method to handle the \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events.  
  
     The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method uses the list of \<xref:System.Drawing.Design.ToolboxItem*> objects that is contained in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> member of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class. It also does the following things:  
  
    -   Removes all \<xref:System.Drawing.Design.ToolboxItem*> objects that are already present in the Toolbox category that is defined by the variable <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>.  
  
    -   Adds new instances of all \<xref:System.Drawing.Design.ToolboxItem*> objects that are listed in <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> to the category tab for the VSProject.  
  
    -   Sets the **Toolbox** active tab to the category tab for the VSProject.  
  
     [!code[LoadToolboxMembers#11](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_11.cs)]
[!code[LoadToolboxMembers#11](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_11.vb)]  
  
    > [!NOTE]
    >  As an exercise, one could develop a mechanism for testing the version of the VSPackage or the items, and only update if the version of the VSPackage has changed, or if the version of the \<xref:System.Drawing.Design.ToolboxItem*> has changed.  
  
## Initializing the Toolbox  
  
#### To implement a command to initialize the Toolbox  
  
-   Change the menu item command handler method, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, as follows.  
  
    1.  Replace the existing implementation of <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> with the following code:  
  
         [!code[LoadToolboxMembers#12](../vs140/codesnippet/CSharp/walkthrough--autoloading-toolbox-items_12.cs)]
[!code[LoadToolboxMembers#12](../vs140/codesnippet/VisualBasic/walkthrough--autoloading-toolbox-items_12.vb)]  
  
## Building and Running the Solution  
 You can exercise the product of this walkthrough by using an instance of Visual Studio that is running in the experimental hive.  
  
#### To exercise this walkthrough  
  
1.  In Visual Studio, on the **Build** menu, click **Rebuild Solution**.  
  
2.  Press F5 to start a second instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in the experimental registry hive.  
  
     For more information about how to use the experimental hive, see [Experimental Build](../vs140/the-experimental-instance.md).  
  
3.  Click the **Tools** menu.  
  
     A command named **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS** should appear at the top of the menu, together with an icon that has the numeral 1.  
  
4.  Create a new [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] or [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] Windows Forms application.  
  
     A \<xref:System.Windows.Forms.Form*>-based designer should appear.  
  
5.  Drag one or both of the new controls in the **LoadToolboxMembers Walkthrough VB** or **LoadToolboxMembers Walkthrough CS** category of the **Toolbox** to the form in the designer.  
  
    > [!NOTE]
    >  If the **Toolbox** is not displayed, click **Toolbox** on the **View** menu. If the category tab for the VSPackage does not appear in the **Toolbox**, re-initialize the **Toolbox** by clicking **Initialize LoadToolboxMembers VB** or **Initialize LoadToolboxMembers CS** on the **Tools** menu.  
  
6.  Build the windows application by clicking **Rebuild Solution** on the **Build** menu.  
  
7.  Run the application by clicking either **Start** or **Start with Debugging** on the **Debug** menu.  
  
8.  When the application runs, click one of the controls that you added to the application.  
  
     A message box appears and displays either <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>.  
  
## Analysis of the Implementation  
  
### Creating Toolbox Controls  
 The attributes assigned to <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> are used by the method <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> when it queries the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> for available **Toolbox** controls.  
  
-   The \<xref:System.ComponentModel.ToolboxItemAttribute*> performs the following two functions:  
  
    -   The assignment of \<xref:System.ComponentModel.ToolboxItemAttribute*> to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, which indicates that each is a toolbox control.  
  
    -   The argument to the \<xref:System.ComponentModel.ToolboxItemAttribute*> constructor, which indicates whether the default \<xref:System.Drawing.Design.ToolboxItem*> or a custom class derived from \<xref:System.Drawing.Design.ToolboxItem*> is used when the control is added to the **Toolbox**.  
  
         The instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> that is assigned to <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is created by using an argument of <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>, which indicates that it uses a default \<xref:System.Drawing.Design.ToolboxItem*> class when it is added to the **Toolbox**.  
  
         The instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> that is assigned to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is created by using the \<xref:System.Type*> of a class that is derived from \<xref:System.Drawing.Design.ToolboxItem*>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>.  
  
-   The \<xref:System.Drawing.ToolboxBitmapAttribute*> class specifies bitmaps that are used by the environment to identify the controls.  
  
     Embedding a bitmap in an assembly by setting its **Build Action** property to **Embedded Resource** puts the bitmap in the namespace of the assembly. Therefore, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> can be referred to as <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>.  
  
     \<xref:System.Drawing.ToolboxBitmapAttribute*> supports a constructor that takes this full path as an argument. For example, a \<xref:System.Drawing.ToolboxBitmapAttribute*> class could be applied to <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> by using <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>.  
  
     To support flexibility, this walkthrough uses a constructor that takes a \<xref:System.Type*> class as the first argument to the \<xref:System.Drawing.ToolboxBitmapAttribute*> constructor. The namespace that is used to identify the bitmap file is obtained from the \<xref:System.Type*> and inserted in front of the base name of the bitmap.  
  
     Because the \<xref:System.Type*> object that implements \<xref:Microsoft.VisualStudio.Shell.Package*>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, is in the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> namespace <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is equivalent to <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>.  
  
-   \<xref:System.ComponentModel.DisplayNameAttribute*> specifies the name of the control in the **Toolbox**.  
  
### Registering a Toolbox Control Provider  
 Applying the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> class to the class that implements \<xref:Microsoft.VisualStudio.Shell.Package*> affects the registry settings of the resulting VSPackage. For more information about the registry settings for a \<xref:System.Drawing.Design.ToolboxItem*> provider, see [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md).  
  
 The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment uses the version argument to the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> constructor to manage the caching of VSPackages that provide items to the **Toolbox**. After a VSPackage has been loaded to provide **Toolbox** items, a cached version of the VSPackage is used until the registered version of the provider changes. Therefore, if you want to modify the product of this walkthrough after you build it, make sure to change the version argument of the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> constructor that is applied to <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>. For example, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> should be changed to <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. If the version is not changed, then the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment does not load any modifications that are made.  
  
 In this walkthrough, the VSPackage is configured to provide only **Toolbox** controls that support the default Clipboard format. For a list of default Clipboard formats, see [Toolbox Overview](../vs140/extending-the-toolbox.md). If you want to support other Clipboard formats, or decide not to support a default format, apply the attribute \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute*> to the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> class. For more information about registering a **Toolbox** control provider, see [How to: Provide Custom Toolbox Items Using the Managed Package Framework](../vs140/advanced-toolbox-control-development.md).  
  
### Adding Controls to the Toolbox  
 The functionality in <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> emulates what is available in \<xref:System.Drawing.Design.ToolboxService.System#Drawing#Design#IToolboxService#GetToolboxItems*>.  
  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> method only examines non-abstract \<xref:System.Type*> objects that implement the \<xref:System.ComponentModel.IComponent*> interfaces.  
  
## Next Steps  
 Using \<xref:System.Drawing.Design.ToolboxService.System#Drawing#Design#IToolboxService#GetToolboxItems*> rather than <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> would make the product of this walkthrough more robust.  
  
 You could also modify <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> to use \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> to load controls into the **Toolbox** based on a text list that is embedded in the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> assembly.  
  
## See Also  
 [Toolbox Overview](../vs140/extending-the-toolbox.md)   
 [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md)   
 [How to: Provide Custom Toolbox Items Using the Managed Package Framework](../vs140/advanced-toolbox-control-development.md)   
 [Toolbox Walkthroughs](../vs140/toolbox-walkthroughs.md)