---
title: "How to: Embed a Manifest Inside a C-C++ Application"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Embed a Manifest Inside a C/C++ Application"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "manifests [C++]"
  - "embedding manifests"
  - "makefiles, updating to embed manifest"
ms.assetid: ec0bac69-2fdc-466c-ab0d-710a22974e5d
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Embed a Manifest Inside a C-C++ Application
It is recommended that a C/C++ application (or library) have its manifest embedded inside the final binary because this guarantees correct runtime behavior in most scenarios. By default, [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] tries to embed the manifest when it builds a project from source files; see [Manifest Generation in Visual Studio](../vs140/manifest-generation-in-visual-studio.md) for more information. However if an application is built by using nmake, some changes to the existing makefile are necessary. This section demonstrates how to change existing makefiles to automatically embed the manifest inside the final binary.  
  
## Two approaches  
 There are two ways to embed the manifest inside an application or library.  
  
-   If you are not doing an incremental build you can directly embed the manifest using a command line similar to the following as a post-build step:  
  
     **mt.exe –manifest MyApp.exe.manifest -outputresource:MyApp.exe;1**  
  
     or  
  
     **mt.exe –manifest MyLibrary.dll.manifest -outputresource:MyLibrary.dll;2**  
  
     (1 for an EXE, 2 for a DLL.)  
  
-   If you are doing an incremental build, directly editing the resource as shown here will disable incremental building and cause a full rebuild; therefore a different approach should be taken:  
  
    -   Link the binary to generate the MyApp.exe.manifest file.  
  
    -   Convert the manifest to a resource file.  
  
    -   Re-link (incrementally) to embed the manifest resource into the binary.  
  
 The following examples show how to change makefiles to incorporate both techniques.  
  
## Makefiles (Before)  
 Consider the nmake script for MyApp.exe, a simple application built from one file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If this script is run unchanged with Visual C++, it successfully creates MyApp.exe. It also creates the external manifest file MyApp.exe.manifest, for use by the operating system to load dependent assemblies at runtime.  
  
 The nmake script for MyLibrary.dll looks very similar:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Makefiles (After)  
 To build with embedded manifests you have to make four small changes to the original makefiles. For the MyApp.exe makefile:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For the MyLibrary.dll makefile:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The makefiles now include two files that do the real work, makefile.inc and makefile.targ.inc.  
  
 Create makefile.inc and copy the following into it:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Now create makefile.targ.inc and copy the following into it:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [Understanding Manifest Generation for C/C++ Programs](../vs140/understanding-manifest-generation-for-c-c---programs.md)