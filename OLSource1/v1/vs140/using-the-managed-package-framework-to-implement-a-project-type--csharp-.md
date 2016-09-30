---
title: "Using the Managed Package Framework to Implement a Project Type (C#)"
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
  - "projects [Visual Studio SDK], creating with MPF"
  - "MPF projects"
  - "managed package framework, creating projects"
ms.assetid: 926de536-eead-415b-9451-f1ddc8c44630
caps.latest.revision: 24
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Using the Managed Package Framework to Implement a Project Type (C#)
The Managed Package Framework (MPF) provides C# classes you can use or inherit from to implement your own project types. The MPF implements many of the interfaces Visual Studio expects a project type to provide, leaving you free to concentrate on implementing the particulars of your project type.  
  
## Using the MPF Project Source Code  
 The Managed Package Framework for Projects (MPFProj) provides helper classes for creating and managing new project system. Unlike other classes in the MPF, the project classes are not included in the assemblies shipped with Visual Studio. Instead, the project classes are provided as source code at [MPF for Projects 2013](http://mpfproj12.codeplex.com).  
  
 To add this project to your VSPackage solution, do the following:  
  
1.  Download the MPFProj files to *MPFProjectDir*.  
  
2.  In the *MPFProjectDir*\Dev10\Src\CSharp\ProjectBase.file, change the following block:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
1.  Create a VSPackage project.  
  
2.  Unload the VSPackage project.  
  
3.  Edit the VSPackage .csproj file by adding the following block before the other <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> blocks:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
1.  Save the project.  
  
2.  Close and reopen the VSPackage solution.  
  
3.  Reopen the VSPackage project. You should see a new directory named ProjectBase.  
  
4.  Add the following reference to the VSPackage project:  
  
     Microsoft.Build.Tasks.4.0  
  
5.  Build the project.  
  
## Hierarchy Classes  
 The following table summarizes the classes in the MPFProj that support project hierarchies. For more information, see [Hierarchies and Selection](../vs140/hierarchies-and-selection.md).  
  
|Class name|  
|----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|  
  
## Document-Handling Classes  
 The following table lists the classes in the MPF that support document handling. For more information, see [Opening and Saving Project Items](../vs140/opening-and-saving-project-items.md).  
  
|Class name|  
|----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|  
  
## Configuration and Output Classes  
 The following table lists the classes in the MPF that let project types support multiple configurations, such as debug and release, and collections of project output. For more information, see [Managing Configuration Options](../vs140/managing-configuration-options.md).  
  
|Class name|  
|----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|  
  
## Automation-Support Classes  
 The following table lists the classes in the MPF that support automation so that users of your project type can write add-ins.  
  
|Class name|  
|----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
  
## Properties Classes  
 The following table lists the classes in the MPF that let project types add properties that users can browse and modify in a property browser.  
  
|Class name|  
|----------------|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|