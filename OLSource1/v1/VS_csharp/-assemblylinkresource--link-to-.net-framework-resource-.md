---
title: "-ASSEMBLYLINKRESOURCE (Link to .NET Framework Resource)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ASSEMBLYLINKRESOURCE (Link to .NET Framework Resource)"
f1_keywords: 
  - "/ASSEMBLYLINKRESOURCE"
  - "VC.Project.VCLinkerTool.AssemblyLinkResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-ASSEMBLYLINKRESOURCE linker option"
  - "ASSEMBLYLINKRESOURCE linker option"
  - "/ASSEMBLYLINKRESOURCE linker option"
ms.assetid: 8b6ad184-1b33-47a4-8513-4803cf915b64
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ASSEMBLYLINKRESOURCE (Link to .NET Framework Resource)
```  
/ASSEMBLYLINKRESOURCE:filename  
```  
  
## Remarks  
 where:  
  
 *filename*  
 The .NET Framework resource file to which you want to link from the assembly.  
  
## Remarks  
 The /ASSEMBLYLINKRESOURCE option creates a link to a .NET Framework resource in the output file; the resource file is not placed in the output file. [/ASSEMBLYRESOURCE](../VS_csharp/-assemblyresource--embed-a-managed-resource-.md) embeds a resource file in the output file.  
  
 Linked resources are public in the assembly when created with the linker.  
  
 /ASSEMBLYLINKRESOURCE requires that the compilation include [/clr](../VS_csharp/-clr--common-language-runtime-compilation-.md); [/LN](../VS_csharp/-ln--create-msil-module-.md) or [/NOASSEMBLY](../VS_csharp/-noassembly--create-a-msil-module-.md) is not allowed with /ASSEMBLYLINKRESOURCE.  
  
 If *filename* is a .NET Framework resource file created, for example, by [Resgen.exe](assetId:///8ef159de-b660-4bec-9213-c3fbc4d1c6f4) or in the development environment, it can be accessed with members in the **System.Resources** namespace. For more information, see [System.Resources.ResourceManager](https://msdn.microsoft.com/en-us/library/system.resources.resourcemanager.aspx). For all other resources, use the **GetManifestResource**\* methods in the **System.Reflection.Assembly** class to access the resource at run time.  
  
 *filename* can be any file format. For example, you may want to make a native DLL part of the assembly, so it can be installed into the Global Assembly Cache and accessed from managed code in the assembly.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../VS_csharp/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYMODULE](../VS_csharp/-assemblymodule--add-a-msil-module-to-the-assembly-.md)  
  
-   [/ASSEMBLYRESOURCE](../VS_csharp/-assemblyresource--embed-a-managed-resource-.md)  
  
-   [/DELAYSIGN](../VS_csharp/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER](../VS_csharp/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
-   [/KEYFILE](../VS_csharp/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/NOASSEMBLY](../VS_csharp/-noassembly--create-a-msil-module-.md)  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../VS_csharp/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option into the **Additional Options** box.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.AdditionalOptions*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)