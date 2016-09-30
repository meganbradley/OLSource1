---
title: "-RELEASE (Set the Checksum)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/RELEASE (Set the Checksum)"
f1_keywords: 
  - "/release"
  - "VC.Project.VCLinkerTool.SetChecksum"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-RELEASE linker option"
  - "/RELEASE linker option"
  - "checksum setting"
  - "RELEASE linker option"
ms.assetid: 93bcadf4-29ac-4824-914b-6997e3751d22
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -RELEASE (Set the Checksum)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The /RELEASE option sets the Checksum in the header of an .exe file.  
  
 The operating system requires the Checksum for device drivers. Set the Checksum for release versions of your device drivers to ensure compatibility with future operating systems.  
  
 The /RELEASE option is set by default when the [/SUBSYSTEM:NATIVE](../vs140/-subsystem--specify-subsystem-.md) option is specified.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Set Checksum** property.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.SetChecksum*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)