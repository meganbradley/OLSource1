---
title: "-arch (ARM)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/arch (ARM)"
dev_langs: 
  - "C++"
ms.assetid: 4f1406ff-f174-487c-a126-8ab06cf447c1
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -arch (ARM)
Specifies the architecture for code generation on ARM. See also [/arch (x86)](../vs140/-arch--x86-.md) and [/arch (x64)](../vs140/-arch--x64-.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 **/arch:ARMv7VE**  
 Enables the use of ARMv7VE Virtualization Extensions instructions.  
  
 **/arch:VFPv4**  
 Enables the use of ARM VFPv4 instructions. If this option is not specified, VFPv3 is the default.  
  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro (for ARM only) indicates which, if any, **/arch** compiler option was used. For more information, see [Predefined Macros](../vs140/predefined-macros.md).  
  
 When you use [/clr](../vs140/-clr--common-language-runtime-compilation-.md) to compile, **/arch** has no effect on code generation for managed functions. **/arch** only affects code generation for native functions.  
  
### To set the /arch:ARMv7VE or /arch:VFPv4 compiler option in Visual Studio  
  
1.  Open the **Property Pages** dialog box for the project. For more information, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Select the **C/C++** folder.  
  
3.  Select the **Command Line** property page.  
  
4.  In the **Additional options** box, add <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.EnableEnhancedInstructionSet*>.  
  
## See Also  
 [/arch (Minimum CPU Architecture)](../vs140/-arch--minimum-cpu-architecture-.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)