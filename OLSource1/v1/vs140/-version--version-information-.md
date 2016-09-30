---
title: "-VERSION (Version Information)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/VERSION (Version Information)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.Version"
  - "/version"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-VERSION linker option"
  - "Version Information linker option"
  - "version numbers, specifying in .exe"
  - "/VERSION linker option"
  - "VERSION linker option"
ms.assetid: b86d0e86-dca6-4316-aee2-d863ccb9f223
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -VERSION (Version Information)
```  
/VERSION:major[.minor]  
```  
  
## Remarks  
 where:  
  
 *major*and *minor*  
 The version number you want in the header of the .exe or .dll file.  
  
## Remarks  
 The /VERSION option tells the linker to put a version number in the header of the .exe or .dll file. Use DUMPBIN [/HEADERS](../vs140/-headers.md) to see the image version field of the OPTIONAL HEADER VALUES to see the effect of /VERSION.  
  
 The *major* and *minor* arguments are decimal numbers in the range 0 through 65,535. The default is version 0.0.  
  
 The information specified with /VERSION does not affect the version information that appears for an application when you view its properties in File Explorer. That version information comes from a resource file that is used to build the application. See [Version Information Editor](../vs140/version-information-editor.md) for more information.  
  
 Another way to insert a version number is with the [VERSION](../vs140/version--c-c---.md) module-definition statement.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **General** property page.  
  
4.  Modify the **Version** property.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.Version*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)