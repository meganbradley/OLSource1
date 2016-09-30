---
title: "Advanced Toolbox Control Development"
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
  - "Toolbox [Visual Studio SDK], adding items using MPF"
ms.assetid: d22479a8-6d95-400c-a115-f46d10c10d2f
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Advanced Toolbox Control Development
> [!NOTE]
>  The recommended way to add custom controls to the Toolbox is to use the Toolbox Control templates that come with the Visual Studio 10 SDK. This topic is retained for backward compatibility, for adding existing controls to the Toolbox, and for advanced Toolbox control development.  
>   
>  For more information on creating toolbox controls by using the templates, see [How to: Create a Toolbox Control That Uses Windows Forms](../vs140/how-to--create-a-toolbox-control-that-uses-windows-forms.md) and [How to: Create a Toolbox Control That Uses WPF](../vs140/creating-a-wpf-toolbox-control.md).  
  
 A VSPackage based on the Managed Package Framework can extend [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Toolbox functionality by adding controls, objects derived from \<xref:System.Drawing.Design.ToolboxItem*> objects. Each \<xref:System.Drawing.Design.ToolboxItem*> is implemented by an object derived from \<xref:System.ComponentModel.Component*>.  
  
## Toolbox Item Provider VSPackage  
 A VSPackage based on the Managed Package Framework must register itself as a Toolbox control provider through [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] attributes and handle Toolbox-related events.  
  
#### To configure a VSPackage as a Toolbox Item Provider  
  
1.  Create an instance of the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> applied to the class implementing \<xref:Microsoft.VisualStudio.Shell.Package*>. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  The constructor for \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemsAttribute*> takes an integer version number as an argument. The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment uses this version number to determine if a VSPackage providing \<xref:System.Drawing.Design.ToolboxItem*> objects must be reloaded or if cached information can be used by the Toolbox. To guarantee reloading of a VSPackage when providing a \<xref:System.Drawing.Design.ToolboxItem*> that is under development, always increment this version number after any modification.  
  
2.  If the \<xref:System.Drawing.Design.ToolboxItem*> objects provide non-standard Toolbox Clipboard formats, an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute*> must be applied to the class implementing the \<xref:Microsoft.VisualStudio.Shell.Package*> object for each Clipboard format supported by the \<xref:System.Drawing.Design.ToolboxItem*> objects that the VSPackage provides.  
  
     For more information on supported Toolbox Clipboard formats, see [Toolbox Overview](../vs140/extending-the-toolbox.md).  
  
    > [!NOTE]
    >  If a VSPackage indicates that it provides any \<xref:System.Drawing.Design.ToolboxItem*> objects with non-standard Clipboard formats, the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment assumes that only those formats indicated by the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute*> instances applied to a VSPackage's \<xref:Microsoft.VisualStudio.Shell.Package*> class implementation are supported by the VSPackage. If a VSPackage needs to support the default Clipboard formats as well as a non-standard format, it must apply an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute*> for each default format as well as the non-standard format.  
  
3.  If the VSPackage provides the dynamic configuration of \<xref:System.Drawing.Design.ToolboxItem*>, it must:  
  
    1.  Apply an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute*> constructed using the \<xref:System.Type*> that the package uses to implement the \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> interface.  
  
    2.  On a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class independent of the VSPackage's \<xref:Microsoft.VisualStudio.Shell.Package*>, the VSPackage must implement the \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> interface.  
  
         An instance of the \<xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute*> must be applied to the class implementing \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*>, using a string containing a selection criteria (filter) as the argument to the \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute*> instance's constructor.  
  
 For information on how to notify the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment that a VSPackage provides Toolbox controls, see [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md).  
  
 For an example illustrating how one might implement \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> support, see [Walkthrough: Dynamic Customization of ToolboxItem Configuration](../vs140/walkthrough--customizing-toolbox-item-configuration-dynamically.md).  
  
1.  VSPackages providing a \<xref:System.Drawing.Design.ToolboxItem*> must handle \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events.  
  
    1.  Implement handlers for the \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
    2.  Subscribe to the \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events.  
  
         This is typically done in the \<xref:Microsoft.VisualStudio.Shell.Package*> implementation's \<xref:Microsoft.VisualStudio.Shell.Package.Initialize*> method:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     For an example of how to implement handlers for \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxInitialized*> and \<xref:Microsoft.VisualStudio.Shell.Package.ToolboxUpgraded*> events, see [Walkthrough: Autoloading Toolbox Items](../vs140/walkthrough--autoloading-toolbox-items.md).  
  
## Toolbox Control Creation  
 The underlying implementation of a Toolbox control must be derived from \<xref:System.ComponentModel.Component*> and encapsulated in the default or a derived implementation of the \<xref:System.Drawing.Design.ToolboxItem*> object.  
  
 The easiest way to provide a \<xref:System.ComponentModel.Component*>-derived implementation of Toolbox controls is by extending an object derived from \<xref:System.Windows.Forms.Control*>, in particular, the \<xref:System.Windows.Forms.UserControl*> class.  
  
#### To create Toolbox controls  
  
1.  Use **Solution Explorer**'s **Add New Item** command to create a Toolbox object that implements \<xref:System.Windows.Forms.UserControl*>.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
     For more information on authoring Windows Forms controls and toolbox controls, see [Developing Custom Windows Forms Controls with the .NET Framework](assetId:///236cebc0-bd71-4f18-9fd6-5d0e592375df) or [Walkthrough: Autoloading Toolbox Items](../vs140/walkthrough--autoloading-toolbox-items.md).  
  
2.  (Optional) An application can choose to use a custom object derived from the \<xref:System.Drawing.Design.ToolboxItem*> object to provide its Toolbox control to the **Toolbox**.  
  
    > [!NOTE]
    >  Any class derived from the \<xref:System.Drawing.Design.ToolboxItem*> object must have an instance of the \<xref:System.SerializableAttribute*> applied to it.  
  
     A custom implementation derived from \<xref:System.Drawing.Design.ToolboxItem*> can extend an application by providing greater control over how the \<xref:System.Drawing.Design.ToolboxItem*> data is serialized, enhanced handling of designer metadata, support for non-standard Clipboard formats, and functionality that allows end-user interaction.  
  
     In the example, users are prompted by a dialog box to select features:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
> [!NOTE]
>  It is also possible for a class derived from the \<xref:System.Drawing.Design.ToolboxItem*> object to provide its own self-contained implementation of the underlying control. That class is then responsible for creating and supplying all underlying components.  
  
## Explicit Addition of Toolbox Items  
 To be added to the Toolbox, a control must be contained in an instance of \<xref:System.Drawing.Design.ToolboxItem*> or of an object derived from \<xref:System.Drawing.Design.ToolboxItem*> and then be added to the **Toolbox** using the \<xref:System.Drawing.Design.IToolboxService*> interface.  
  
#### To encapsulate and add Toolbox controls  
  
1.  Encapsulate the \<xref:System.ComponentModel.Component*> implementation in an instance of a \<xref:System.Drawing.Design.ToolboxItem*> object or a \<xref:System.Drawing.Design.ToolboxItem*>-derived object by calling that object's \<xref:System.Drawing.Design.ToolboxItem.Initialize*> method with the implementing component's \<xref:System.Type*?displayProperty=fullName>:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
     Above is an example of an object <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> derived from \<xref:System.Windows.Forms.UserControl*> (an instance of the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object shown above) being used to construct a new \<xref:System.Drawing.Design.ToolboxItem*>.  
  
    > [!NOTE]
    >  The default implementation of the \<xref:System.Drawing.Design.ToolboxItem*> constructor taking a \<xref:System.Type*?displayProperty=fullName> argument (\<xref:System.Drawing.Design.ToolboxItem.#ctor(System.Type)> constructor calls the \<xref:System.Drawing.Design.ToolboxItem*> object's \<xref:System.Drawing.Design.ToolboxItem.Initialize*> method.  
  
2.  Use the Toolbox service (\<xref:System.Drawing.Design.IToolboxService*>) to add the \<xref:System.Drawing.Design.ToolboxItem*> object constructed from the underlying control implementation.  
  
     In the example below, access to the Toolbox service is obtained, some of the properties of the \<xref:System.Drawing.Design.ToolboxItem*> instance <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> are set, and then <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is added to the **Toolbox**:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
## Using Reflection to Add Toolbox Controls  
 Applying attributes to the class implementing a toolbox control allows the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment or a [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] based application to use reflection to automatically detect and properly add controls to the **Toolbox**.  
  
#### To apply reflection and attributes to Toolbox controls  
  
1.  Identify all objects used to implement Toolbox controls with instances of \<xref:System.ComponentModel.ToolboxItemAttribute*>.  
  
     The type of instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> to an object will determines if and how a \<xref:System.Drawing.Design.ToolboxItem*> is constructed from it.  
  
    1.  Applying an instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> constructed with a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to an object makes that object unavailable to the Toolbox through reflection.  
  
         This can be useful to isolate an object, such as a \<xref:System.Windows.Forms.UserControl*> from the **Toolbox** during development.  
  
    2.  Applying an instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> constructed with a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> value of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to an object makes that object available to the Toolbox through reflection and requires that the object be added to the Toolbox using a default \<xref:System.Drawing.Design.ToolboxItem*> object.  
  
    3.  Applying an instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> constructed with the \<xref:System.Type*> of a custom object derived from \<xref:System.Drawing.Design.ToolboxItem*> makes the object available to the **Toolbox** through reflection and requires that the object be added to the Toolbox using this custom object derived from \<xref:System.Drawing.Design.ToolboxItem*>.  
  
2.  Specify (to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment's reflection mechanism) the bitmap to use for displaying the Toolbox control in the **Toolbox** by adding an instance of \<xref:System.Drawing.ToolboxBitmapAttribute*> to the Toolbox control implementation.  
  
3.  If needed, apply instances of \<xref:System.ComponentModel.ToolboxItemFilterAttribute*> to \<xref:System.Drawing.Design.ToolboxItem*> objects to use reflection to statically mark them for use with objects that have a matching attribute.  
  
     In the example below, a Toolbox control's implementation has an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute*> applied to it, which makes that control available in the **Toolbox** only when the current working document is a \<xref:System.Windows.Forms.UserControl*> designers  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 There are three basic techniques for using reflection to autoloading \<xref:System.Drawing.Design.ToolboxItem*>.  
  
### Using the ToolService Functionality to Retrieve Toolbox Controls  
 The \<xref:System.Drawing.Design.ToolboxService*> provides VSPackages with the static \<xref:System.Drawing.Design.ToolboxService.GetToolboxItems*> methods that use reflection to scan assemblies for all types that support toolbox items, and return items for those types. To be returned, a toolbox item must:  
  
-   Be public.  
  
-   Implement the \<xref:System.ComponentModel.IComponent*> class.  
  
-   Not be abstract.  
  
-   Have a \<xref:System.ComponentModel.ToolboxItemAttribute*> on its type.  
  
-   Not have a \<xref:System.ComponentModel.ToolboxItemAttribute*> set to <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> on its type  
  
-   Not contain generic parameters.  
  
##### To obtain this list  
  
1.  Create an instance of \<xref:System.Reflection.Assembly*> referring to the assembly that is to be scanned for \<xref:System.Drawing.Design.ToolboxItem*> objects.  
  
    > [!NOTE]
    >  To obtain an instance of \<xref:System.Reflection.Assembly*> for the current assembly, use the static method \<xref:System.Reflection.Assembly.GetExecutingAssembly*>.  
  
2.  Call \<xref:System.Drawing.Design.ToolboxService.GetToolboxItems*>, returning an \<xref:System.Collections.ICollection*> object containing a list of the appropriate objects.  
  
    > [!NOTE]
    >  If an object in the returned \<xref:System.Collections.ICollection*> has a valid instance of \<xref:System.Drawing.ToolboxBitmapAttribute*> assigned to its implementation, the \<xref:System.Drawing.Design.ToolboxService.GetToolboxItems*> method will set the \<xref:System.Drawing.Design.ToolboxItem*> object's \<xref:System.Drawing.Design.ToolboxItem.Bitmap*> property.  
  
3.  Use \<xref:Microsoft.VisualStudio.Shell.Package.GetService*> to obtain access to \<xref:System.Drawing.Design.IToolboxService*>, and use its \<xref:System.Drawing.Design.IToolboxService.AddToolboxItem*> method to add items from the returned \<xref:System.Collections.ICollection*> object to the Toolbox.  
  
     The code below queries the running application and obtains a list of all its \<xref:System.Drawing.Design.ToolboxItem*> objects and loads them. For an example illustrating this in running code, see the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method in [Walkthrough: Dynamic Customization of ToolboxItem Configuration](../vs140/walkthrough--customizing-toolbox-item-configuration-dynamically.md).  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Using Embedded Text Resources to Autoload Toolbox Controls  
 A text resource in an assembly containing a properly formatted list of Toolbox controls can be used by \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> to automatically load a Toolbox control if properly formatted.  
  
 A text resource containing a list of objects to load must be available in an assembly accessible to the VSPackage.  
  
##### To add and make available a text resource to the assembly  
  
1.  In **Solution Explorer**, right-click a the project.  
  
2.  Point to **Add**, then click **New Item**.  
  
3.  In the **Add New Item** dialog box, select **Text File** and supply a name.  
  
4.  In **Solution Explorer**, right-click the newly created text file and set the **Build Action** property to **Embedded Resource**.  
  
     Entries for the **Toolbox** control to be loaded must contain the name of the implementing class, the name of the assembly containing it.  
  
     For information on the format of Toolbox controls entries to the embedded text resource, see the \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> reference page.  
  
5.  Set up a search path for the files containing the assemblies hosting Toolbox control objects.  
  
     \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*>, searches only directories specified in the registry entry HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\\*\<version>*\AssemblyFolders, where *\<version>* is the version number of the release of Visual Studio (for example, 8.0).  
  
    > [!NOTE]
    >  The root path of HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*\<Version>* can be overridden with an alternate root when the Visual Studio shell is initialized, or use of \<xref:Microsoft.VisualStudio.Shell.DefaultRegistryRootAttribute*>. For more information see, [Command-Line Switches (VS SDK)](../vs140/command-line-switches--visual-studio-sdk-.md).  
  
     For details on the correct format of the AssemblyFolder registry entries, see the \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> reference page.  
  
6.  Obtain an instance of \<xref:System.IO.TextReader.Synchronized*> accessing the embedded text resource, and, if localization support is needed for category names, an instance of \<xref:System.Resources.ResourceManager*>, and use these to invoke the \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> method.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
     In the example above, a list contained in an embedded text resource in the assembly containing the class <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is passed to \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> along with the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> string resources.  
  
     The method will search all the files containing assemblies in the directories specified under the AssemblyFolders registry entry for the Toolbox controls listed in the resource and load them.  
  
    > [!NOTE]
    >  If a Toolbox control found by \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> has a valid instance of \<xref:System.Drawing.ToolboxBitmapAttribute*> assigned to its implementation, \<xref:Microsoft.VisualStudio.Shell.Package.ParseToolboxResource*> will set the bitmap used to display the Toolbox control.  
  
### Explicitly Using Reflection to Autoload Toolbox Controls  
 If it is necessary to explicitly query assemblies for information about the **Toolbox** controls they contain, rather than delegating the task to \<xref:System.Drawing.Design.ToolboxService.GetToolboxItems*>, this can be done.  
  
##### To explicitly use reflection to autoload Toolbox controls  
  
1.  Create an instance of \<xref:System.Reflection.Assembly*>, referring to each assembly that is to be scanned for \<xref:System.Drawing.Design.ToolboxItem*> objects.  
  
    > [!NOTE]
    >  To obtain an instance of \<xref:System.Reflection.Assembly*> for the current assembly, use the static method \<xref:System.Reflection.Assembly.GetExecutingAssembly*>.  
  
2.  For each assembly to be scanned, use the \<xref:System.Reflection.Assembly*> object's \<xref:System.Reflection.Assembly.GetTypes*> method to obtain a list of each \<xref:System.Type*?displayProperty=fullName> in the assembly.  
  
3.  Verify that the type is not abstract and supports the \<xref:System.ComponentModel.IComponent*> interface (all implementations of Toolbox controls used to instantiate a \<xref:System.Drawing.Design.ToolboxItem*> object must implement this interface).  
  
4.  Obtain the attributes of \<xref:System.Type*> and use this information to determine if the VSPackage wishes to load the object.  
  
    > [!NOTE]
    >  Although in principal it is possible to create a \<xref:System.Drawing.Design.ToolboxItem*> object from an \<xref:System.ComponentModel.IComponent*> interface implementation without an instance of \<xref:System.ComponentModel.ToolboxItemAttribute*> not set to <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> applied to it, we do not recommend doing so.  
  
5.  Use \<xref:System.Type.GetConstructor*> to obtain constructors for the \<xref:System.Drawing.Design.ToolboxItem*> objects that the Toolbox controls require.  
  
6.  Construct the \<xref:System.Drawing.Design.ToolboxItem*> objects and add them to the **Toolbox**.  
  
 To see an example illustrating explicit use of reflection to obtain and autoload Toolbox controls, see the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> described in [Walkthrough: Autoloading Toolbox Items](../vs140/walkthrough--autoloading-toolbox-items.md).  
  
## Additional Toolbox Control Configuration  
 A VSPackage can exercise additional control over when and how a Toolbox control is displayed by the **Toolbox**, through the implementation of \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*>, and use of \<xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute*>, and \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute*>.  
  
 Applying \<xref:System.ComponentModel.ToolboxItemFilterAttribute*> instances to a class provides only static control over when and how a **Toolbox** control is available.  
  
#### To create dynamic configuration support for Toolbox controls  
  
1.  Construct a class implementing the \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> interface as part of a VSPackage.  
  
    > [!NOTE]
    >  The \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> interface must not be implemented on the same class which provides a VSPackage's implementation of \<xref:Microsoft.VisualStudio.Shell.Package*>.  
  
2.  Associate the implementation of \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> with the objects in specific assemblies by applying an instance of the \<xref:Microsoft.VisualStudio.Shell.ProvideAssemblyFilterAttribute*> to it.  
  
     The example below supplies a dynamic configuration for Toolbox control object assemblies within the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> namespace and requiring that certain \<xref:System.Drawing.Design.ToolboxItem*> objects be visible only with \<xref:System.Windows.Forms.UserControl*>-based designers and other never visible with \<xref:System.Windows.Forms.UserControl*>-based designers.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
3.  Register a VSPackage as providing a specific implementation of \<xref:Microsoft.VisualStudio.Shell.IConfigureToolboxItem*> by applying an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxItemConfigurationAttribute*> to the VSPackage's implementation of \<xref:Microsoft.VisualStudio.Shell.Package*>.  
  
     The example below would inform the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] environment that the package implemented by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> provides the class <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> to support dynamic \<xref:System.Drawing.Design.ToolboxItem*>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
## Custom Drag-and-Drop Support  
 In addition to being added to the **Toolbox** itself, \<xref:System.Drawing.Design.ToolboxItem*> objects and their implementations can be used to extend the drag-and-drop support in the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] IDE. This can allow arbitrary Clipboard formats to be exposed to the **Toolbox** and in editors.  
  
 VSPackages based on the Managed Package Framework must register as providing custom **Toolbox** item Clipboard formats, by applying an instance of \<xref:Microsoft.VisualStudio.Shell.ProvideToolboxFormatAttribute*> to the class implementing \<xref:Microsoft.VisualStudio.Shell.Package*>.  
  
 For more information on registering as a **Toolbox** provider, see [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md).  
  
#### To provide custom Clipboard formats and drag-and-drop support with Toolbox controls  
  
1.  Create an implementation of the \<xref:System.Drawing.Design.ToolboxItemCreatorCallback*> delegate.  
  
     This implementation should return a \<xref:System.Drawing.Design.ToolboxItem*> object that supports the non-standard Clipboard format.  
  
     For an example implementation of a \<xref:System.Drawing.Design.ToolboxItemCreatorCallback*> delegate, see the \<xref:System.Drawing.Design.ToolboxItem*> and \<xref:System.Drawing.Design.ToolboxItemCreatorCallback*> reference pages.  
  
2.  Make this implementation of the \<xref:System.Drawing.Design.ToolboxItemCreatorCallback*> delegate available to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Toolbox** for a non-standard toolbox by calling \<xref:System.Drawing.Design.IToolboxService.AddCreator*>.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### In This Section  
 [How To: Support Toolbox Drag and Drop](../vs140/how-to--support-toolbox-drag-and-drop-functionality.md)  
 Describes how to implement drag-and-drop support on a document view.  
  
 [How To: Provide Custom Toolbox Items Using Interop Assemblies](../vs140/how-to--provide-custom-toolbox-items-by-using-interop-assemblies.md)  
 Describes adding new ActiveX controls and new items to the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] **Toolbox**. These new items can either have a standard Clipboard format or a custom format supported by the VSPackage.  
  
 [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md)  
 Describes how to register a VSPackage as a toolbox provider. Also talks about supporting or using other toolbox features.  
  
## See Also  
 [Toolbox Overview](../vs140/extending-the-toolbox.md)   
 [Toolbox Walkthroughs](../vs140/toolbox-walkthroughs.md)   
 [Registering Toolbox Support Features](../vs140/registering-toolbox-support-features.md)   
 [How To: Provide Custom Toolbox Items Using Interop Assemblies](../vs140/how-to--provide-custom-toolbox-items-by-using-interop-assemblies.md)   
 [Managing the Toolbox](../vs140/managing-the-toolbox.md)   
 [How to: Control the Toolbox](assetId:///c9d8a18a-d2bc-43d4-a803-601bfc6a6599)