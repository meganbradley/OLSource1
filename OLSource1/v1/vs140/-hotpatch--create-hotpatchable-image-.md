---
title: "-hotpatch (Create Hotpatchable Image)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/hotpatch (Create Hotpatchable Image)"
f1_keywords: 
  - "/hotpatch"
  - "VC.Project.VCCLCompilerTool.CreateHotpatchableImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hot patching"
  - "-hotpatch compiler option [C++]"
  - "/hotpatch compiler option [C++]"
  - "hotpatching"
ms.assetid: aad539b6-c053-4c78-8682-853d98327798
caps.latest.revision: 22
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -hotpatch (Create Hotpatchable Image)
Prepares an image for hot patching.  
  
## Syntax  
  
```  
/hotpatch  
```  
  
## Remarks  
 When **/hotpatch** is used in a compilation, the compiler ensures that first instruction of each function is at least two bytes, which is required for hot patching.  
  
 To complete the preparation for making an image hotpatchable, after you use **/hotpatch** to compile, you must use [/functionpadmin](../vs140/-functionpadmin--create-hotpatchable-image-.md) to link. When you compile and link an image by using one invocation of cl.exe, **/hotpatch** implies **/functionpadmin**.  
  
 Because instructions are always two bytes or larger on the ARM architecture, and because x64 compilation is always treated as if **/hotpatch** has been specified, you don't have to specify **/hotpatch** when you compile for these targets; however, you must still link by using **/functionpadmin** to create hotpatchable images for them. The **/hotpatch** compiler option only affects x86 compilation.  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  Add the compiler option to the **Additional Options** box.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.AdditionalOptions*>.  
  
## Guidance  
 For more information about update management, see "Security Guidance for Update Management" at [http://www.microsoft.com/technet/security/guidance/PatchManagement.mspx](http://www.microsoft.com/technet/security/guidance/PatchManagement.mspx).  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)