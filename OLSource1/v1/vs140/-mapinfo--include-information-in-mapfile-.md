---
title: "-MAPINFO (Include Information in Mapfile)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/MAPINFO (Include Information in Mapfile)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.MapLines"
  - "VC.Project.VCLinkerTool.MapInfoFixups"
  - "VC.Project.VCLinkerTool.MapExports"
  - "/mapinfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/MAPINFO linker option"
  - "MAPINFO linker option"
  - "-MAPINFO linker option"
ms.assetid: 533d2bce-f9b7-4fea-ae1c-0b4864c9d10b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -MAPINFO (Include Information in Mapfile)
```  
/MAPINFO:EXPORTS  
```  
  
## Remarks  
 The /MAPINFO option tells the linker to include the specified information in a mapfile, which is created if you specify the [/MAP](../vs140/-map--generate-mapfile-.md) option.  EXPORTS tells the linker to include exported functions.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Debug** property page.  
  
4.  Modify of the **Map Exports** properties:  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.MapExports*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)