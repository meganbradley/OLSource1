---
title: "Linker Property Pages"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - VC.Project.VCLinkerTool.RegisterOutput
  - VC.Project.VCLinkerTool.IgnoreImportLibrary
  - VC.Project.VCLinkerTool.UseLibraryDependencyInputs
  - VC.Project.VCLinkerTool.LinkLibraryDependencies
dev_langs: 
  - C++
helpviewer_keywords: 
  - per-user redirection
  - Linker property pages
ms.assetid: 7e7671e5-a35a-4e67-9bdb-661d75c4d11e
caps.latest.revision: 17
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Linker Property Pages
This topic discusses the following properties on the **General** linker property page:  
  
 **Ignore Import Library**  
 Tells the linker not to try to link any .lib output generated from this build into any dependent project. This allows the project system to handle .dll files that do not produce a .lib file when built. If a project depends on another project that produces a DLL, the project system automatically will link the .lib file produced by that child project. This may not be needed by projects that are producing COM DLLs or resource-only DLLs; these DLLs do not have any meaningful exports. If a DLL has no exports, the linker will not generate a .lib file. If no export .lib file is present on the disk, and the project system tells the linker to link with this (missing) DLL, the link will fail.  
  
 Use **Ignore Import Library** to resolve this problem. When set to `Yes`, the project system will ignore the presence or absence of that .lib file and cause any project that depends on this project to not link with the nonexistent .lib file.  
  
 To programmatically access this property, see <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.IgnoreImportLibrary?qualifyHint=False>.  
  
 **Register Output**  
 Run regsvr32.exe /s $(TargetPath), which is valid only on .dll projects. For .exe projects, this property is ignored. If you want to register an .exe output, set a postbuild event on the configuration to do the custom registration that is always required for registered .exe files.  
  
 To programmatically access this property, see <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.RegisterOutput?qualifyHint=False>.  
  
 **Per-user Redirection**  
 Registration in [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] has traditionally been done in HKEY_CLASSES_ROOT (HKCR). With [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], to access HKCR you must run [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] in elevated mode. Developers do not always want to run in elevated mode but still must work with registration. Per-user redirection allows you to register without having to run in this mode.  
  
 Per-user redirection will force any writes to HKCR to be redirected to HKEY_CURRENT_USER (HKCU). If per-user redirection is turned off, it can cause [Project Build Error PRJ0050](../vs140/project-build-error-prj0050.md) when the program tries to write to HKCR.  
  
 **Link Library Dependencies**  
 Gives you the choice of linking in the .lib files that are produced by dependent projects. Typically, you will want to link in the .lib file.  
  
 You can also specify a .obj file by providing the file name and relative path, for example **..\\..\MyLibProject\MyObjFile.obj**. If the source code for the .obj file #includes a precompiled header, for example pch.h, then pch.obj file is located in the same folder as **MyObjFile.obj** and you must also add **pch.obj** as an additional dependency.  
  
 **Use Library Dependency Inputs**  
 In a large project, when a dependent project produces a .lib file, incremental linking is disabled. If there are many dependent projects that produce .lib files, building the application can take a long time. When this property is set to `Yes`, the project system links in the .obj files for .libs produced by dependent projects, thus enabling incremental linking.  
  
 For information about how to access the **General** linker property page, see [How To: Specify Project Properties with Property Pages](../vs140/how-to--specify-project-properties-with-property-pages.md).  
  
## See Also  
 [VC++ Directories, Projects and Solutions, Options Dialog Box](assetId:///e027448b-c811-4c3d-8531-4325ad3f6e02)   
 [Property Pages](../vs140/property-pages--visual-c---.md)