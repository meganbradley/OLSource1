---
title: "Walkthrough: Creating a Core Editor and Registering an Editor File Type"
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
  - "editors [Visual Studio SDK], legacy - walkthrough"
ms.assetid: 24d2bffd-a35c-46db-8515-fd60b884b7fb
caps.latest.revision: 33
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Creating a Core Editor and Registering an Editor File Type
This walkthrough demonstrates how to create a VSPackage that starts the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] core editor when a file that has the .myext file name extension is loaded.  
  
## Prerequisites  
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio Software Development Kit (SDK)](../vs140/visual-studio-sdk.md).  
  
## Locations for the Visual Studio Package Project template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1.  Under Visual Basic Extensibility. The default language of the project is Visual Basic.  
  
2.  Under C# Extensibility. The default language of the project is C#.  
  
3.  Under Other Project Types Extensibility. The default language of the project is C++.  
  
### To create the VSPackage  
  
-   Start [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and create a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] VSPackage named <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, as outlined in [Walkthrough: Creating a Menu Command VSPackage](assetId:///d699c149-5d1e-47ff-94c7-e1222af02c32).  
  
### To add the editor factory  
  
1.  Right-click the **MyPackage** project, point to **Add** and then click **Class**.  
  
2.  In the **Add New Item** dialog box, make sure the **Class** template is selected, type <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> for the name, and then click **Add** to add the class to your project.  
  
     The EditorFactory.cs file should be automatically opened.  
  
3.  Reference the following assemblies from your code.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Add a GUID to the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class by adding the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> attribute immediately before the class declaration.  
  
     You can generate a new GUID by using the guidgen.exe program at the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] command prompt, or by clicking **Create GUID** on the **Tools** menu. The GUID used here is only an example; do not use it in your project.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
5.  In the class definition, add two private variables to contain the parent package and a service provider.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
6.  Add a public class constructor that takes one parameter of type \<xref:Microsoft.VisualStudio.Shell.Package*>:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
7.  Modify the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> class declaration to derive from the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory*> interface.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
8.  Right-click \<xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory*>, click **Implement Interface**, and then click **Implement Interface Explicitly**.  
  
     This adds the four methods that must be implemented in the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsEditorFactory*> interface.  
  
9. Replace the contents of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method with the following code.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
10. Replace the contents of the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> with the following code.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
11. Replace the contents of the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method with the following code.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
12. Replace the contents of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method with the following code.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
13. Compile the project and make sure there are no errors.  
  
### To register the editor factory  
  
1.  In **Solution Explorer**, double-click the Resources.resx file to open it to the string table, in which the entry **String1 is** selected.  
  
2.  Change the name of the identifier to <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and the text to **MyPackage Editor.** This string will appear as the name of your editor.  
  
3.  Open the VSPackage.resx file and add a new string, set the name to **101** and the value to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This provides the package with a resource ID to access the string you just created.  
  
    > [!NOTE]
    >  If the VSPackage.resx file contains another string that the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> attribute set to **101**, substitute another unique, numeric value, here and in the following steps.  
  
4.  In **Solution Explorer**, open the MyPackagePackage.cs file.  
  
     This is the main package file.  
  
5.  Add the following user attributes just before the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> attribute.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
     The \<xref:Microsoft.VisualStudio.Shell.ProvideEditorExtensionAttribute*> attribute associates the .myext file extension with your editor factory so that any time a file that has that extension is loaded, your editor factory is invoked.  
  
6.  Add a private variable to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class, just before the constructor, and give it the type <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
7.  Find the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> method (you may have to open the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> hidden region) and add the following code after the call to <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
8.  Compile the program and make sure there are no errors.  
  
     This step registers the editor factory in the experimental registry hive for [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. If you are prompted to override the resource.h file, click **OK**.  
  
9. Create a sample file named TextFile1.myext.  
  
10. Press **F5** to open an instance of the experimental [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].  
  
11. In the experimental [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], on the **File** menu, point to **Open** and then click **File**.  
  
12. Find TextFile1.myext and then click **Open**.  
  
     The file should now be loaded.  
  
## Robust Programming  
 The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] core editor handles a wide range of text-based file types and works closely with language services to provide a rich set of features such as syntax highlighting, brace matching, and IntelliSense word-completion and member-completion lists. If you are working with text-based files, then you can use the core editor together with a custom language service that supports your specific file types.  
  
 A VSPackage can invoke the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] core editor by supplying an editor factory. This editor factory is used any time a file that is associated with it is loaded. If the file is part of a project, then the core editor is automatically invoked unless overridden by your VSPackage. However, if the file is loaded outside of a project, then the core editor must be explicitly invoked by your VSPackage.  
  
 For more information about the core editor, see [Working With The Core Editor](../vs140/inside-the-core-editor.md).  
  
## See Also  
 [Working With The Core Editor](../vs140/inside-the-core-editor.md)   
 [Instantiating the Visual Studio Core Editor](../vs140/instantiating-the-core-editor-by-using-the-legacy-api.md)