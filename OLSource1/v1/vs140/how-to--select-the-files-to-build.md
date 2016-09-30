---
title: "How to: Select the Files to Build"
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
  - "MSBuild, wildcards"
  - "MSBuild, including files"
  - "Include attribute [MSBuild]"
ms.assetid: f5ff182f-7b3a-46fb-9335-37df54cfb8eb
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Select the Files to Build
When you build a project that contains several files, you can list each file separately in the project file, or you can use wildcards to include all the files in one directory or a nested set of directories.  
  
## Specifying Inputs  
 Items represent the inputs for a build. For more information on items, see [MSBuild Items](../vs140/msbuild-items.md).  
  
 To include files for a build, they must be included in an item list in the [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] project file. Multiple files can be added to item lists by either including the files individually or using wildcards to include many files at once.  
  
#### To declare items individually  
  
-   Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attributes similar to following:  
  
     <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
     – or –  
  
     <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
    > [!NOTE]
    >  If items in an item collection are not in the same directory as the project file, you must specify the full or relative path to the item. For example: <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
#### To declare multiple items  
  
-   Use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attributes similar to following:  
  
     <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
     – or –  
  
     <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Specifying Inputs with Wildcards  
 You can also use wildcards to recursively include all files or only specific files from subdirectories as inputs for a build. For more information about wildcards, see [MSBuild Items](../vs140/msbuild-items.md)  
  
 The following examples are based on a project that contains graphics files in the following directories and subdirectories, with the project file located in the Project directory:  
  
 Project\Images\BestJpgs  
  
 Project\Images\ImgJpgs  
  
 Project\Images\ImgJpgs\Img1  
  
#### To include all .jpg files in the Images directory and subdirectories  
  
-   Use the following <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute:  
  
     <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
#### To include all .jpg files starting with "img"  
  
-   Use the following <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute:  
  
     <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
#### To include all files in directories with names ending in "jpgs"  
  
-   Use one of the following <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attributes:  
  
     <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
     – or –  
  
     <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Passing Items to a Task  
 In a project file, you can use the @() notation in tasks to specify an entire item list as the input for a build. You can use this notation whether you list all files separately or use wildcards.  
  
#### To use all Visual C# or Visual Basic files as inputs  
  
-   Use the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attributes similar to the following:  
  
     <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
     – or –  
  
     <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  You must use wildcards with items to specifiy the inputs for a build; you cannot specify the inputs using the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute in [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] tasks such as [Csc](../vs140/csc-task.md) or [Vbc](../vs140/vbc-task.md). The following example is not valid in a project file:  
>   
>  <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Example  
 The following code example shows a project that includes all of the input files separately.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following code example uses a wildcard to include all the .cs files.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [How To: Build all Files in a Directory Except One](../vs140/how-to--exclude-files-from-the-build.md)   
 [MSBuild Items](../vs140/msbuild-items.md)