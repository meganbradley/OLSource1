---
title: "Project Files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ".vcproj files"
  - "Visual C++ projects, project file format"
  - "VCPROJ (Visual C++ project file) format"
  - "project files [C++], .vcproj file format"
ms.assetid: 5261cf45-3136-40a6-899e-dc1339551401
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Project Files
A Visual C++ project file is an XML-based file that has the .vcxproj file name extension and contains information that is required to build a Visual C++ project.  
  
## Example  
 The following sample .vcxproj file was produced by specifying a **Win32 Console Application** in the **New Project** dialog box. To process a project file use either the msbuild.exe tool at the command line, or the **Build** command in the [!INCLUDE[TLA2#tla_ide](../vs140/includes/tla2sharptla_ide_md.md)]. (This sample cannot be processed because the required source and header files are not provided.) For more information about the XML elements in a project file, see [MSBuild Project File Schema Reference](../vs140/msbuild-project-file-schema-reference.md).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Building C++ Projects in Visual Studio](../vs140/building-c---projects-in-visual-studio.md)   
 [Working with Project Properties](../vs140/working-with-project-properties.md)