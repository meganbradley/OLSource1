---
title: "-OUT (Output File Name)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/OUT (Output File Name)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.OutputFile"
  - "/out"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "output files, name linker option"
  - "-OUT linker option"
  - "OUT linker option"
  - "/OUT C++ linker option"
  - "linker [C++], output files"
ms.assetid: 976210a4-e51f-4cfb-af5e-c16344455834
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -OUT (Output File Name)
```  
/OUT:filename  
```  
  
## Remarks  
 where:  
  
 *filename*  
 A user-specified name for the output file. It replaces the default name.  
  
## Remarks  
 The /OUT option overrides the default name and location of the program that the linker creates.  
  
 By default, the linker forms the file name using the base name of the first .obj file specified and the appropriate extension (.exe or .dll).  
  
 This option the default base name for a .mapfile or import library. For details, see [Generate Mapfile](../vs140/-map--generate-mapfile-.md) (/MAP) and [/IMPLIB](../vs140/-implib--name-import-library-.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **General** property page.  
  
4.  Modify the **Output File** property.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.OutputFile*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)