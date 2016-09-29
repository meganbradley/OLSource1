---
title: "How to: Create a .Vsct File"
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
  - "VSCT files, creating"
ms.assetid: b955f51c-f9f9-49c3-a8e4-63b6eb0e0341
caps.latest.revision: 23
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a .Vsct File
There are several ways to create an XML-based Visual Studio Command Table configuration (.vsct) file.  
  
-   You can create a new VSPackage in the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] Package Template.  
  
-   You can use the XML-based command table configuration compiler, Vsct.exe, to generate a file from an existing .ctc file.  
  
-   You can use Vsct.exe to generate a .vsct file from an existing .cto file.  
  
-   You can manually create a new .vsct file.  
  
 This topic explains how to manually create a new .vsct file.  
  
### To manually create a new .vsct file  
  
1.  Start [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)].  
  
2.  On the **File** menu, point to **New**, and then click **File**.  
  
3.  In the **Templates** pane, click **XML File** and then click **Open**.  
  
4.  On the **View** menu, click **Properties Window** to display the properties of the XML file.  
  
5.  In the **Properties** window, click the Browse (…) button on the Schemas property.  
  
6.  In the list of XSD schemas, select the vsct.xsd schema. If it is not in the list, click **Add** and then find the file on a local drive. Click **OK** when you are finished.  
  
7.  In the XML file, type `<CommandTable` and then press TAB. Close the tag by typing `>`.  
  
     This creates a basic .vsct file.  
  
8.  Fill in the elements of the XML file that you want to add, according to the [VSCT Schema](../VS_csharp/vsct-xml-schema-reference.md). For more information, see [Manually Authoring .Vsct Files](../VS_csharp/authoring-.vsct-files.md)  
  
## Compiling the Code  
 Simply adding a .vsct file to a project does not cause it to compile. You must incorporate it in the build process.  
  
### To add a .vsct file to project compilation  
  
1.  Open your project file in the editor. If the project is loaded, you must unload it first.  
  
2.  Add an [ItemGroup element](../VS_csharp/itemgroup-element--msbuild-.md) that contains a VSCTCompile element, as shown in the following example.  
  
    ```xml  
    <ItemGroup>  
      <VSCTCompile Include="TopLevelMenu.vsct">  
        <ResourceName>Menus.ctmenu</ResourceName>  
      </VSCTCompile>  
    </ItemGroup>  
  
    ```  
  
     The ResourceName element should always be set to `Menus.ctmenu`.  
  
3.  If your project contains a .resx file, add an EmbeddedResource element that contains a MergeWithCTO element, as shown in the following example.  
  
    ```xml  
    <EmbeddedResource Include="VSPackage.resx">  
      <MergeWithCTO>true</MergeWithCTO>  
      <ManifestResourceName>VSPackage</ManifestResourceName>  
    </EmbeddedResource>  
  
    ```  
  
     This markup should go inside the ItemGroup element that contains embedded resources.  
  
4.  Open the package file, usually named *ProjectName*Package.cs or *ProjectName*Package.vb, in the editor.  
  
5.  Add a ProvideMenuResource attribute to the package class, as shown in the following example.  
  
    ```c#  
    [ProvideMenuResource("Menus.ctmenu", 1)]  
    ```  
  
     The first parameter value must match the value of the ResourceName attribute you defined in the project file.  
  
## See Also  
 [Manually Authoring .Vsct Files](../VS_csharp/authoring-.vsct-files.md)   
 [XML-Based Command Table Configuration (.vsct) Files](../VS_csharp/visual-studio-command-table--.vsct--files.md)   
 [How To: Create a .vsct File From an Existing .ctc File](../Topic/How%20to:%20Create%20a%20.Vsct%20File%20from%20an%20Existing%20.Ctc%20File.md)   
 [How To: Create a .vsct File From an Existing .cto File](../Topic/How%20to:%20Create%20a%20.Vsct%20File%20from%20an%20Existing%20.Cto%20File.md)   
 [Command Table Compiler  XML Schema Reference](../VS_csharp/vsct-xml-schema-reference.md)