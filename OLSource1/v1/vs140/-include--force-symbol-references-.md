---
title: "-INCLUDE (Force Symbol References)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/INCLUDE (Force Symbol References)"
f1_keywords: 
  - "/include"
  - "VC.Project.VCLinkerTool.ForceSymbolReferences"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "INCLUDE linker option"
  - "force symbol references linker option"
  - "symbol references linker force"
  - "/INCLUDE linker option"
  - "symbols, add to symbol table"
  - "-INCLUDE linker option"
ms.assetid: 4a039677-360a-480f-bd0b-448e239b449c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -INCLUDE (Force Symbol References)
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a symbol to be added to the symbol table.  
  
## Remarks  
 The /INCLUDE option tells the linker to add a specified symbol to the symbol table.  
  
 To specify multiple symbols, type a comma (,), a semicolon (;), or a space between the symbol names. On the command line, specify /INCLUDE:<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> once for each symbol.  
  
 The linker resolves <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> by adding the object that contains the symbol definition to the program. This feature is useful for including a library object that otherwise would not be linked to the program.  
  
 Specifying a symbol with this option overrides the removal of that symbol by [/OPT:REF](../vs140/-opt--optimizations-.md).  
  
### To set this linker option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [Setting Visual C++ Project Properties](../vs140/working-with-project-properties.md).  
  
2.  Click the **Linker** folder.  
  
3.  Click the **Input** property page.  
  
4.  Modify the **Force Symbol References** property.  
  
### To set this linker option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCLinkerTool.ForceSymbolReferences*>.  
  
## See Also  
 [Setting Linker Options](../vs140/setting-linker-options.md)   
 [Linker Options](../vs140/linker-options.md)