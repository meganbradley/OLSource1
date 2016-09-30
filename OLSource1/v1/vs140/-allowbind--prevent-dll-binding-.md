---
title: "-ALLOWBIND (Prevent DLL Binding)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/ALLOWBIND (Prevent DLL Binding)"
f1_keywords: 
  - "VC.Project.VCLinkerTool.PreventDLLBinding"
  - "/allowbind"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/ALLOWBIND linker option"
  - "binding DLLs"
  - "preventing DLL binding"
  - "ALLOWBIND linker option"
  - "-ALLOWBIND linker option"
  - "DLLs [C++], preventing binding"
ms.assetid: 30e37e24-12e4-407e-988a-39d357403598
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -ALLOWBIND (Prevent DLL Binding)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 /ALLOWBIND:NO sets a bit in a DLL's header that indicates to Bind.exe that the image is not allowed to be bound. You may not want a DLL to be bound if it has been digitally signed (binding invalidates the signature).  
  
 You can edit an existing DLL for /ALLOWBIND functionality with the [/ALLOWBIND](../vs140/-allowbind.md) option of the EDITBIN utility.  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Working with Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Expand **Configuration Properties**, **Linker**, and select **Command Line**.  
  
3.  Enter <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> into **Additional Options**.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)   
 [BindImage function](http://msdn.microsoft.com/library/windows/desktop/ms679278.aspx)   
 [BindImageEx function](http://msdn.microsoft.com/library/windows/desktop/ms679279.aspx)