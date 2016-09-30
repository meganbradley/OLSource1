---
title: "Extend your DSL by using MEF"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 3e7be79a-53ab-4d79-863a-bef8d27839bd
caps.latest.revision: 18
---
# Extend your DSL by using MEF
You can extend your domain-specific language (DSL) by using Managed Extensibility Framework (MEF). You or other developers will be able to write extensions for the DSL without changing the DSL definition and program code. Such extensions include menu commands, drag-and-drop handlers, and validation. Users will be able to install your DSL, and then optionally install extensions for it.  
  
 In addition, when you enable MEF in your DSL, it can be easier for you to write some of the features of your DSL, even if they are all built together with the DSL.  
  
 For more information about MEF, see [Managed Extensibility Framework](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde).  
  
### To enable your DSL to be extended by MEF  
  
1.  Create a new folder named **MefExtension** inside the **DslPackage** project. Add the following files to it:  
  
     File name: <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
    > [!IMPORTANT]
    >  Set the GUID in this file to be the same as the GUID CommandSetId that is defined in DslPackage\GeneratedCode\Constants.tt  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
     If you add this file, you must enable validation in your DSL by using at least one of the switches in **EditorValidation** in DSL Explorer.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  Create a new folder named **MefExtension** inside the **Dsl** project. Add the following files to it:  
  
     File name: <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     File name: <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
3.  Add the following line to the existing file that is named **DslPackage\Commands.vsct**:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
     Insert the line after the existing <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directive.  
  
4.  <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
5.  In DSL Explorer, select **Editor\Validation**.  
  
6.  In the Properties window, make sure that at least one of the properties named **Uses...** is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
7.  In the Solution Explorer toolbar, click **Transform All Templates**.  
  
     Subsidiary files appear underneath each of the files that you added.  
  
8.  Build and run the solution to verify that it is still working.  
  
 Your DSL is now MEF-enabled. You can write menu commands, gestures handlers, and validation constraints as MEF extensions. You can write these extensions in your DSL solution together with other custom code. In addition, you or other developers can write separate [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extensions that extend your DSL.  
  
## Creating an extension for a MEF-enabled DSL  
 If you have access to a MEF-enabled DSL created by yourself or someone else, you can write extensions for it. The extensions can be used to add menu commands, gestures handlers, or validation constraints. To author these extensions, you use a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Extension (VSIX) solution. The solution has two parts: a class library project that builds the code assembly, and a VSIX project that packages the assembly.  
  
#### To create a DSL extension VSIX  
  
1.  Create a new class library project. To do this, in the **New Project** dialog box, select **Visual Basic** or **Visual C#** and then select **Class Library**.  
  
2.  In the new class library project, add a reference to the assembly of the DSL.  
  
    -   This assembly usually has a name that ends with ".Dsl.dll".  
  
    -   If you have access to the DSL project, you can find the assembly file under the directory **Dsl\bin\\\***  
  
    -   If you have access to the DSL VSIX file, you can find the assembly by changing the file name extension of the VSIX file to ".zip". Decompress the .zip file.  
  
3.  Add references to the following .NET assemblies:  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.11.0.dll  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.Diagrams.11.0.dll  
  
    -   Microsoft.VisualStudio.Modeling.Sdk.Shell.11.0.dll  
  
    -   System.ComponentModel.Composition.dll  
  
    -   System.Windows.Forms.dll  
  
4.  Create a VSIX project in the same solution. To do this, in the **New Project** dialog box, expand **Visual Basic** or **Visual C#**, click **Extensibility**, and then select **VSIX project**.  
  
5.  In Solution Explorer, right-click the VSIX project and then click **Set as StartUp Project**.  
  
6.  In the new project, open **source.extension.vsixmanifest**.  
  
7.  Click **Add Content**. In the dialog box, set **Content Type** to **MEF Component**, and **Source Project** to your class library project.  
  
8.  Add a VSIX reference to the DSL.  
  
    1.  In **source.extension.vsixmanifest**, click **Add Reference**  
  
    2.  In the dialog box, click **Add Payload** and then locate the VSIX file of the DSL. The VSIX file is built in the DSL solution, in **DslPackage\bin\\\***.  
  
         This lets users install the DSL and your extension at the same time. If the user has already installed the DSL, only your extension will be installed.  
  
9. Review and update the other fields of **source.extension.vsixmanifest**. Click **Select Editions** and verify that the correct [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] editions are set.  
  
10. Add code to the class library project. Use the examples in the next section as a guide.  
  
     You can add any number of command, gesture, and validation classes.  
  
11. To test the extension, press **F5**. In the experimental instance of [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], create or open an example file of the DSL.  
  
## Writing MEF extensions for DSLs  
 You can write extensions in the assembly code project of a separate DSL extension solution. You can also use MEF in your DslPackage project, as a convenient way to write commands, gestures, and validation code as part of the DSL.  
  
### Menu Commands  
 To write a menu command, define a class that implements \<xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ICommandExtension*> and prefix the class with the attribute that is defined in your DSL, named *YourDsl*<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. You can write more than one menu command class.  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is called whenever the user right-clicks the diagram. It should inspect the current selection and set <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> to indicate when the command is applicable.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Gesture Handlers  
 A gesture handler can deal with objects dragged onto the diagram from anywhere, inside or outside [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. The following example lets the user drag files from Windows Explorer onto the diagram. It creates elements that contain the file names.  
  
 You can write handlers to deal with drags from other DSL models and UML models. For more information, see [How to Add a Drag-and-Drop Handler](../vs140/how-to--add-a-drag-and-drop-handler.md).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Validation constraints  
 Validation methods are marked by the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute that is generated by the DSL, and also by \<xref:Microsoft.VisualStudio.Modeling.Validation.ValidationMethodAttribute*>. The method can appear in any class that is not marked by an attribute.  
  
 For more information, see [Validation in a Domain-Specific Language](../vs140/validation-in-a-domain-specific-language.md).  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [VSIX Deployment](../vs140/shipping-visual-studio-extensions.md)   
 [Managed Extensibility Framework](assetId:///6c61b4ec-c6df-4651-80f1-4854f8b14dde)   
 [How to Add a Drag-and-Drop Handler](../vs140/how-to--add-a-drag-and-drop-handler.md)   
 [Validation in a Domain-Specific Language](../vs140/validation-in-a-domain-specific-language.md)