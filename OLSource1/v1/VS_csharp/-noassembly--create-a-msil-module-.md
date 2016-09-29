---
title: "-NOASSEMBLY (Create a MSIL Module)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/NOASSEMBLY (Create a MSIL Module)"
f1_keywords: 
  - "/NOASSEMBLY"
  - "VC.Project.VCLinkerTool.TurnOffAssemblyGeneration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "assemblies [C++]"
  - "-NOASSEMBLY linker option"
  - "/NOASSEMBLY linker option"
  - "NOASSEMBLY linker option"
  - "assemblies [C++], not creating an assembly"
ms.assetid: 3cea4e70-f451-4395-a626-1930b1b127fe
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -NOASSEMBLY (Create a MSIL Module)
```  
/NOASSEMBLY  
```  
  
## Remarks  
 The /NOASSEMBLY option tells the linker to create an image for the current output file without a .NET Framework assembly. An MSIL output file without an assembly manifest is called a module.  
  
 By default, an assembly is created. You can also use the [/LN (Create MSIL Module)](../VS_csharp/-ln--create-msil-module-.md) compiler option to create a module.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../VS_csharp/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYLINKRESOURCE](../VS_csharp/-assemblylinkresource--link-to-.net-framework-resource-.md)  
  
-   [/ASSEMBLYMODULE](../VS_csharp/-assemblymodule--add-a-msil-module-to-the-assembly-.md)  
  
-   [/ASSEMBLYRESOURCE](../VS_csharp/-assemblyresource--embed-a-managed-resource-.md)  
  
-   [/DELAYSIGN](../VS_csharp/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/KEYFILE](../VS_csharp/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER](../VS_csharp/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../VS_csharp/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Turn Off Assembly Generation** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.TurnOffAssemblyGeneration*>.  
  
## See Also  
 [Setting Linker Options](../VS_csharp/setting-linker-options.md)   
 [Linker Options](../VS_csharp/linker-options.md)