---
title: "How to: Exclude Files from the Build"
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
  - "MSBuild, excluding files"
  - "wildcards, MSBuild"
ms.assetid: 1be36e45-01da-451c-972d-f9fc0e7d663c
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Exclude Files from the Build
In a project file you can use wildcards to include all the files in one directory or a nested set of directories as inputs for a build. However, there might be one file in the directory or one directory in a nested set of directories that you do not want to include as input for a build. You can explicitly exclude that file or directory from the list of inputs. There may also be a file in a project that you only want to include under certain conditions. You can explicitly declare the conditions under which a file is included in a build.  
  
## Excluding a File or Directory from the Inputs for a Build  
 Item lists are the input files for a build. The items that you want to include are declared either separately or as a group using the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> attribute. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If you have used wildcards to include all the files in one directory or a nested set of directories as inputs for a build, there might be one or more files in the directory or one directory in the a nested set of directories that you do not want to include. To exclude an item from the item list, use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> attribute.  
  
#### To include all .cs or .vb files except Form2  
  
-   Use one of the following <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attributes:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
#### To include all .cs or .vb files except Form2 and Form3  
  
-   Use one of the following <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> attributes:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     - or -  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
#### To include all .jpg files in subdirectories of the Images directory except those in the Version2 directory  
  
-   Use the following <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> attributes:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
    > [!NOTE]
    >  You must specify the path for both attributes. If you use an absolute path to specify file locations in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> attribute, you must also use an absolute path in the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attribute; if you use a relative path in the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> attribute, you must also use a relative path in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> attribute.  
  
## Using Conditions to Exclude a File or Directory from the Inputs for a Build  
 If there are items that you want to include, for example, in a Debug build but not a Release build, you can use the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> attribute to specify the conditions under which to include the item.  
  
#### To include the file Formula.vb only in Release builds  
  
-   Use a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute similar to the following:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Example  
 The following code example builds a project with all of the .cs files in the directory except Form2.cs.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [MSBuild Items](../vs140/msbuild-items.md)   
 [MSBuild](../vs140/msbuild.md)   
 [How To: Build All Files in a Directory](../vs140/how-to--select-the-files-to-build.md)