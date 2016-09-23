---
title: "-SWAPRUN (Load Linker Output to Swap File)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: /SWAPRUN (Load Linker Output to Swap File)
f1_keywords: 
  - VC.Project.VCLinkerTool.SwapRunFromNet
  - /swaprun
  - VC.Project.VCLinkerTool.SwapRunFromCD
dev_langs: 
  - C++
helpviewer_keywords: 
  - -SWAPRUN linker option
  - files [C++], LINK
  - LINK tool [C++], output
  - linker [C++], copying output to swap file
  - swap file for linker output
  - output files, linker
  - /SWAPRUN linker option
  - SWAPRUN linker option
ms.assetid: 4a1e7f46-4399-4161-8dfc-d6a71beaf683
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# -SWAPRUN (Load Linker Output to Swap File)
```  
/SWAPRUN:{NET|CD}  
```  
  
## Remarks  
 The /SWAPRUN option tells the operating system to first copy the linker output to a swap file, and then run the image from there. This is a Windows NT 4.0 (and later) feature.  
  
 If NET is specified, the operating system will first copy the binary image from the network to a swap file and load it from there. This option is useful for running applications over the network. When CD is specified, the operating system will copy the image on a removable disk to a page file and then load it.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **System** property page.  
  
4.  Modify one of the following properties:  
  
    -   **Swap Run From CD**  
  
    -   **Swap Run From Network**  
  
### To set this linker option programmatically  
  
1.  See <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.SwapRunFromCD?qualifyHint=False> and <xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.SwapRunFromNet?qualifyHint=False> properties.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)