---
title: "-FU (Name Forced #using File)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/FU (Name Forced #using File)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.ForcedUsingFiles"
  - "/FU"
  - "VC.Project.VCNMakeTool.ForcedUsingAssemblies"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-FU compiler option [C++]"
  - "FU compiler option [C++]"
  - "/FU compiler option [C++]"
ms.assetid: 698f8603-457f-435a-baff-5ac9243d6ca1
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -FU (Name Forced #using File)
A compiler option that you can use as an alternative to passing a file name to [#using Directive](../vs140/sharpusing-directive--c---.md) in source code.  
  
## Syntax  
  
```  
/FU file  
```  
  
## Arguments  
 `file`  
 Specifies the metadata file to reference in this compilation.  
  
## Remarks  
 The /FU switch takes just one file name. To specify multiple files, use /FU with each one.  
  
 If you are using [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] and are referencing metadata to use the [Friend Assemblies](../vs140/friend-assemblies--c---.md) feature, you can't use **/FU**. You must reference the metadata in code by using `#using`—together with the `[as friend]` attribute. Friend assemblies are not supported in [!INCLUDE[cppwrt](../vs140/includes/cppwrt_md.md)] ([!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)]).  
  
 For information about how to create an assembly or module for the common language runtime (CLR), see [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md). For information about how to build in [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)], see [Building apps and libraries (C++/CX)](assetId:///ec2821a5-3479-4e64-9c2d-c777049f2cdc).  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Advanced** property page.  
  
4.  Modify the **Force #using** property.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.ForcedUsingFiles*>.  
  
## See Also  
 [Output-File (/F) Options](../vs140/output-file---f--options.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)