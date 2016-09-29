---
title: "Property Pages (Visual C++)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "VC.Project.NotAProp.Edit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "project-file macro"
  - "project properties [C++], default values"
  - "user-defined values"
  - "project properties [C++], setting"
  - "macros, project-file"
  - "property pages, project settings"
  - "Visual C++ projects, properties"
  - "build macro"
  - "user-defined macros"
ms.assetid: 13ffe3ea-1bc3-4bee-be5e-053a8a99cce4
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Property Pages (Visual C++)
By using property pages, you can specify settings for Visual Studio projects. To open the **Property Pages** dialog box for a Visual Studio project, on the **Project** menu, click **Properties**.  
  
 You can specify project settings so that they apply all build configurations, or you can specify different project properties for each build configuration. For example, you can specify certain settings for the Release configuration and other settings for the Debug configuration.  
  
 Not all available pages are necessarily displayed in the **Property Pages** dialog box. Which pages are displayed depends on the file types in the project.  
  
 For more information, see [Working with Project Properties](../VS_csharp/working-with-project-properties.md).  
  
## Default Properties vs. Modified Properties  
 When you use the **New Project** dialog box to create a project, [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] uses the specified project template to initialize the project properties. Therefore, the property values in the template can be thought of as default values for that project type. In other project types, the properties may have different default values.  
  
 A project property value appears in bold if it is modified. A project property can be modified for the following reasons:  
  
-   The application wizard changes the property because it requires a different property value than the one that is specified in the project template.  
  
-   You specify a different property value in the **New Project** dialog box.  
  
-   You specify a different property value on a project property page.  
  
> [!TIP]
>  To see the final set of property values that MSBuild uses to build your project, examine the preprocessor output file, which you can produce by using this command line: **MSBuild /preprocess:***preprocessor_output_filename*opt*project_filename*opt  
  
## Resetting Properties  
 When you view the **Property Pages** dialog box for a project and the project node is selected in **Solution Explorer**, for many properties, you can select **inherit from parent or project defaults** or modify the value another way.  
  
 When you view the **Property Pages** dialog box for a project and a file is selected in **Solution Explorer**, for many properties, you can select **inherit from parent or project defaults** or modify the value another way. However, if the project contains many files that have property values that differ from the project default values, the project will take longer to build.  
  
> [!TIP]
>  To refresh the **Property Pages** dialog box so that it displays the latest selections, click **Apply**.  
  
 Most project defaults are system (platform) defaults. Some project defaults derive from the style sheets that are applied when you update properties in the **Project Defaults** section of the **General** configuration properties page for the project. For more information, see [General Property Page (Project)](../VS_csharp/general-property-page--project-.md).  
  
## Specifying User-Defined Values  
 You must define the value for certain properties. A user-defined value can contain one or more alphanumeric characters or project-file macro names. Some of these properties can take only one user-defined value, but others can take a semicolon-delimited list of multiple values.  
  
 To specify a user-defined value for a property, or a list if the property can take multiple user-defined values, in the column to the right of the property name, perform one of the following actions:  
  
-   Type the value or the list of values.  
  
-   Click the drop-down arrow. If **Edit** is available, click it and then in the text box, type the value or list of values. An alternate way to specify a list is to type each value on a separate line in the text box. On the property page, the values will be displayed as a semicolon-delimited list.  
  
     To insert a project-file macro as a value, click **Macros** and then double-click the macro name.  
  
-   Click the drop-down arrow. If **Browse** is available, click it and then select one or more values.  
  
 For a multi-valued property, the **inherit from parent or project defaults** option is available when you click the drop-down arrow in the column to the right of the property name and then click **Edit**. By default, the option is selected.  
  
 Notice that a property page only displays the settings at the current level for a multi-valued property that inherits from another level. For example, if a file is selected in **Solution Explorer** and you select the C/C++ **Preprocessor Definitions** property, file-level definitions are displayed but inherited project-level definitions are not displayed. To view both current-level and inherited values, click the drop-down arrow in the column to the right of the property name and then click **Edit**. If you use the [Visual C++ project model](assetId:///06c1bbd9-4c79-4f97-ad6d-2b1dea8ecd1f), this behavior is also in effect for the objects on files and projects. That is, when you query for the values on a property at the file level, you will not get the values for that same property at the project level. You must explicitly get the values of the property at the project level. Also, some inherited values of a property may come from a style sheet, which is not accessible programmatically.  
  
## In This Section  
  
1.  [NIB: Add Reference Search Path Dialog Box](assetId:///4520d80d-aa9f-4d11-b92b-2f64a1fd5cb2)  
  
2.  [Advanced, Manifest Tool, Configuration Properties, <Projectname\> Property Pages Dialog Box](../VS_csharp/advanced--manifest-tool--configuration-properties---projectname--property-pages-dialog-box.md)  
  
3.  [Command Line Property Pages](../VS_csharp/command-line-property-pages.md)  
  
4.  [Custom Build Step Property Page: General](../VS_csharp/custom-build-step-property-page--general.md)  
  
5.  [Framework and References, Common Properties, <Projectname\> Property Pages Dialog Box](../VS_csharp/adding-references-in-visual-c---projects.md)  
  
6.  [General Property Page (File)](../VS_csharp/general-property-page--file-.md)  
  
7.  [General Property Page (Project)](../VS_csharp/general-property-page--project-.md)  
  
8.  [General, Manifest Tool, Configuration Properties, <Projectname\> Property Pages Dialog Box](../VS_csharp/general--manifest-tool--configuration-properties---projectname--property-pages-dialog-box.md)  
  
9. [HLSL Property Pages](../VS_csharp/hlsl-property-pages.md)  
  
10. [HLSL Property Pages: Advanced](../VS_csharp/hlsl-property-pages--advanced.md)  
  
11. [HLSL Property Pages: General](../VS_csharp/hlsl-property-pages--general.md)  
  
12. [HLSL Property Pages: Output Files](../VS_csharp/hlsl-property-pages--output-files.md)  
  
13. [Input and Output, Manifest Tool, Configuration Properties, <Projectname\> Property Pages Dialog Box](../VS_csharp/input-and-output--manifest-tool--configuration-properties---projectname--property-pages-dialog-box.md)  
  
14. [Isolated COM, Manifest Tool, Configuration Properties, <Projectname\> Property Pages Dialog Box](../VS_csharp/isolated-com--manifest-tool--configuration-properties---projectname--property-pages-dialog-box.md)  
  
15. [Linker Property Pages](../VS_csharp/linker-property-pages.md)  
  
16. [Managed Resources Property Page](../VS_csharp/managed-resources-property-page.md)  
  
17. [Manifest Tool Property Pages](../VS_csharp/manifest-tool-property-pages.md)  
  
18. [MIDL Property Pages](../VS_csharp/midl-property-pages.md)  
  
19. [MIDL Property Pages: Advanced](../VS_csharp/midl-property-pages--advanced.md)  
  
20. [MIDL Property Pages: General](../VS_csharp/midl-property-pages--general.md)  
  
21. [MIDL Property Pages: Output](../VS_csharp/midl-property-pages--output.md)  
  
22. [NMake Property Page](../VS_csharp/nmake-property-page.md)  
  
23. [Resources Property Pages](../VS_csharp/resources-property-pages.md)  
  
24. [VC++ Directories Property Page](../VS_csharp/vc---directories-property-page.md)  
  
25. [Web References Property Page](../VS_csharp/web-references-property-page.md)  
  
26. [XML Data Generator Tool Property Page](../VS_csharp/xml-data-generator-tool-property-page.md)  
  
27. [XML Document Generator Tool Property Pages](../VS_csharp/xml-document-generator-tool-property-pages.md)  
  
## See Also  
 [How to: Create and Remove Project Dependencies](../VS_csharp/how-to--create-and-remove-project-dependencies.md)   
 [How to: Create and Edit Configurations](../VS_csharp/how-to--create-and-edit-configurations.md)   
 [Deploying Applications](assetId:///4ff8881d-0daf-47e7-bfe7-774c625031b4)