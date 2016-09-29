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
author: ""
ms.author: ""
manager: ""
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
  
 By default, an assembly is created. You can also use the [/LN (Create MSIL Module)](../vs140/-ln--create-msil-module-.md) compiler option to create a module.  
  
 Other linker options that affect assembly generation are:  
  
-   [/ASSEMBLYDEBUG](../vs140/-assemblydebug--add-debuggableattribute-.md)  
  
-   [/ASSEMBLYLINKRESOURCE](../vs140/-assemblylinkresource--link-to-.net-framework-resource-.md)  
  
-   [/ASSEMBLYMODULE](../vs140/-assemblymodule--add-a-msil-module-to-the-assembly-.md)  
  
-   [/ASSEMBLYRESOURCE](../vs140/-assemblyresource--embed-a-managed-resource-.md)  
  
-   [/DELAYSIGN](../vs140/-delaysign--partially-sign-an-assembly-.md)  
  
-   [/KEYFILE](../vs140/-keyfile--specify-key-or-key-pair-to-sign-an-assembly-.md)  
  
-   [/KEYCONTAINER](../vs140/-keycontainer--specify-a-key-container-to-sign-an-assembly-.md)  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Turn Off Assembly Generation** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.TurnOffAssemblyGeneration*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)