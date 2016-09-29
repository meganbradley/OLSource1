---
title: "-FUNCTIONPADMIN (Create Hotpatchable Image)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/FUNCTIONPADMIN (Create Hotpatchable Image)"
f1_keywords: 
  - "/functionpadmin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-FUNCTIONPADMIN linker option"
  - "/FUNCTIONPADMIN linker option"
ms.assetid: 25b02c13-1add-4fbd-add9-fcb30eb2cae7
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -FUNCTIONPADMIN (Create Hotpatchable Image)
Prepares an image for hotpatching.  
  
## Syntax  
  
```  
/FUNCTIONPADMIN[:space]  
```  
  
## Remarks  
 where,  
  
 `space` (optional)  
 The amount of padding to add to the beginning of each function, 5, 6, or 16.  x86 images require five bytes of padding, x64 images require 6 bytes, and images built for the Itanium Processor Family require 16 bytes of padding at the beginning of each function.  
  
 By default, the compiler will add the correct amount of space to the image, based on the machine type of the image.  
  
 In order for the linker to produce a hotpatchable image, the .obj files must have been compiled with [/hotpatch](../vs140/-hotpatch--create-hotpatchable-image-.md).  
  
 When you compile and link an image with a single invocation of cl.exe, **/hotpatch** implies **/functionpadmin**.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Command Line** property page.  
  
4.  Type the option into the **Additional Options** box.  
  
### To set this linker option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.AdditionalOptions*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)