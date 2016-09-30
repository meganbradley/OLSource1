---
title: "-MERGE (Combine Sections)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MERGE (Combine Sections)"
f1_keywords: 
  - "/merge"
  - "VC.Project.VCLinkerTool.MergeSections"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sections, combining"
  - "/MERGE linker option"
  - "sections, naming"
  - "sections"
  - "-MERGE linker option"
  - "MERGE linker option"
ms.assetid: 10fb20c2-0b3f-4c8d-98a8-f69aedf03d52
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MERGE (Combine Sections)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The /MERGE option combines the first section (*from*) with the second section (*to*), naming the resulting section *to*. For example, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
 If the second section does not exist, LINK renames the section *from* as *to*.  
  
 The /MERGE option is useful for creating VxDs and overriding the compiler-generated section names.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Merge Sections** property.  
  
### To set this linker option programmatically  
  
1.  See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.MergeSections*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)