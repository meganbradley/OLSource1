---
title: "Library Naming Conventions"
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
  - "NAFXCW.LIB"
  - "libraries [C++], static"
  - "coding conventions, MFC library names"
  - "NAFXCWD.LIB"
  - "console applications, MFC library versions"
  - "naming conventions [C++], MFC object code libraries"
  - "object code libraries, MFC naming conventions"
  - "object code libraries"
  - "conventions [C++], MFC library names"
  - "MFC libraries, naming conventions"
ms.assetid: 39fe7d93-5a14-4c6a-b16c-bf318fa01278
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Library Naming Conventions
Object-code libraries for MFC use the following naming conventions. The library names have the form  
  
 *u*AFX<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>W<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.LIB  
  
 where the letters shown in italic lowercase are placeholders for specifiers whose meanings are shown in the following table:  
  
### Library Naming Conventions  
  
|Specifier|Values and meanings|  
|---------------|-------------------------|  
|*u*|ANSI (N) or Unicode (U)|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Type of program to create: C=all|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Debug or Release: D=Debug; omit specifier for Release|  
  
 The default is to build a debug Windows ANSI application for the Intel platform: NAFXCWD.Lib. All libraries listed in the following table are included prebuilt in the \atlmfc\lib directory on the Visual C++ CD-ROM.  
  
### Static-Link Library Naming Conventions  
  
|Library|Description|  
|-------------|-----------------|  
|NAFXCW.LIB|MFC Static-Link Library, Release version|  
|NAFXCWD.LIB|MFC Static-Link Library, Debug version|  
|UAFXCW.LIB|MFC Static-Link Library with Unicode support, Release version|  
|UAFXCWD.LIB|MFC Static-Link Library with Unicode support, Debug version|  
  
> [!NOTE]
>  If you need to build a library version, see the Readme.Txt file in the \atlmfc\src\mfc directory. This file describes using the supplied makefile with NMAKE.  
  
 For more information, see [Naming Conventions for MFC DLLs](../vs140/naming-conventions-for-mfc-dlls.md) and [Unicode Versions of the MFC Libraries](../vs140/unicode-in-mfc.md).  
  
## See Also  
 [MFC Library Versions](../vs140/mfc-library-versions.md)