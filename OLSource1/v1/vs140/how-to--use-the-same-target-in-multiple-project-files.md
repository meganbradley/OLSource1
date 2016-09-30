---
title: "How to: Use the Same Target in Multiple Project Files"
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
  - "MSBuild, importing"
  - "MSBuild, using the same target in multiple project files"
ms.assetid: 163734bd-1bfd-4093-a730-7741fc21742d
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use the Same Target in Multiple Project Files
If you have authored several [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project files, you might have discovered that you need to use the same tasks and targets in different project files. Instead of including the complete description of those tasks or targets in every project file, you can save a target in a separate project file and then import that project into any other project that needs to use the target.  
  
## Using the Import Element  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element is used to insert one project file into another project file. The project file that is being imported must be a valid [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file and contain well-formed XML. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute specifies the path to the imported project file. For more information on the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element, see [Import Element (MSBuild)](../vs140/import-element--msbuild-.md).  
  
#### To import a project  
  
1.  Define, in the importing project file, all properties and items that are used as parameters for properties and items in the imported project.  
  
2.  Use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element to import the project. For example:  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
3.  Following the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element, define all properties and items that must override default definitions of properties and items in the imported project.  
  
## Order of Evaluation  
 When [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] reaches an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element, the imported project is effectively inserted into the importing project at the location of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element. Therefore, the location of the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element can affect the values of properties and items. It is important to understand the properties and items that are set by the imported project, and the properties and items that the imported project uses.  
  
 When the project builds, all properties are evaluated first, followed by items. For example, the following XML defines the imported project file MyCommon.targets:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The following XML defines MyApp.proj, which imports MyCommon.targets:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 When the project builds, the following message is displayed:  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 Because the project is imported after the property <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> has been defined in MyApp.proj, the definition of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> in MyCommon.targets overrides the definition in MyApp.proj. If, the project is imported before the property Name is defined, the build would display the following message:  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
#### Use the following approach when importing projects  
  
1.  Define, in the project file, all properties and items that are used as parameters for properties and items in the imported project.  
  
2.  Import the project.  
  
3.  Define in the project file all properties and items that must override default definitions of properties and items in the imported project.  
  
## Example  
 The following code example shows the MyCommon.targets file that the second code example imports. The .targets file evaluates properties from the importing project to configure the build.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following code example imports the MyCommon.targets file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Import Element (MSBuild)](../vs140/import-element--msbuild-.md)   
 [MSBuild Targets](../vs140/msbuild-targets.md)