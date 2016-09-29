---
title: "-MANIFESTFILE (Name Manifest File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MANIFESTFILE (Name Manifest File)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.ManifestFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MANIFESTFILE linker option"
  - "-MANIFESTFILE linker option"
  - "/MANIFESTFILE linker option"
ms.assetid: befa5ab2-a9cf-4c9b-969a-e7b4a930f08d
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MANIFESTFILE (Name Manifest File)
```  
/MANIFESTFILE:filename  
```  
  
## Remarks  
 /MANIFESTFILE lets you change the default name of the manifest file.  The default name of the manifest file is the file name with .manifest appended.  
  
 /MANIFESTFILE will have no effect if you do not also link with [/MANIFEST](../vs140/-manifest--create-side-by-side-assembly-manifest-.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Expand the **Configuration Properties** node.  
  
3.  Expand the **Linker** node.  
  
4.  Select the **Manifest File** property page.  
  
5.  Modify the **Manifest File** property.  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ManifestFile*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)