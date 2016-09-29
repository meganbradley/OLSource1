---
title: "-ASSEMBLYMODULE (Add a MSIL Module to the Assembly)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ASSEMBLYMODULE (Add a MSIL Module to the Assembly)"
f1_keywords: 
  - "/assemblymodule"
  - "VC.Project.VCLinkerTool.AddModuleNamesToAssembly"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ASSEMBLYMODULE linker option"
  - "assemblies [C++], adding modules to"
  - "assemblies [C++]"
  - "/ASSEMBLYMODULE linker option"
  - "-ASSEMBLYMODULE linker option"
ms.assetid: 67357da8-e4b6-49fd-932c-329a5777f143
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ASSEMBLYMODULE (Add a MSIL Module to the Assembly)
```  
/ASSEMBLYMODULE:filename  
```  
  
## Remarks  
 where:  
  
 *filename*  
 The module you want to include in this assembly.  
  
## Remarks  
 The /ASSEMBLYMODULE option allows you to add a module reference to an assembly. Type information in the module will not be available to the assembly program that added the module reference. However, type information in the module will be available to any program that references the assembly.  
  
 Use [#using](../vs140/sharpusing-directive--c---.md) to both add a module reference to an assembly and make the module's type information available to the assembly program.  
  
 For example, consider the following scenario:  
  
1.  Create a module with [/LN](../vs140/-ln--create-msil-module-.md).  
  
2.  Use /ASSEMBLYMODULE in a different project to include the module in the current compilation, which will create an assembly. This project will not reference the module with `#using`.  
  
3.  Any project that references this assembly can now also use types from the module.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../vs140/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYLINKRESOURCE](../vs140/-assemblylinkresource--link-to-.net-framework-resource-.md)  
  
-   [/ASSEMBLYRESOURCE](../vs140/-assemblyresource--embed-a-managed-resource-.md)  
  
-   [/DELAYSIGN](../vs140/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/NOASSEMBLY](../vs140/-noassembly--create-a-msil-module-.md)  
  
-   [/KEYFILE](../vs140/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER](../vs140/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
 The Visual C++ linker accepts .netmodule files as input and the output file produced by the linker will be an assembly or .netmodule with no run-time dependence on any of the .netmodules that were input to the linker.  For more information, see [.netmodule Files as Linker Input](../vs140/.netmodule-files-as-linker-input.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Input** property page.  
  
4.  Modify the **Add Module to Assembly** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.AddModuleNamesToAssembly*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)