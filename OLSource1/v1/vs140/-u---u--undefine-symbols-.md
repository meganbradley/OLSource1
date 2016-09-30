---
title: "-U, -u (Undefine Symbols)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/U, /u (Undefine Symbols)"
f1_keywords: 
  - "VC.Project.VCCLCompilerTool.UndefinePreprocessorDefinitions"
  - "VC.Project.VCCLWCECompilerTool.UndefinePreprocessorDefinitions"
  - "VC.Project.VCCLCompilerTool.UndefineAllPreprocessorDefinitions"
  - "/u"
  - "VC.Project.VCCLWCECompilerTool.UndefineAllPreprocessorDefinitions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-U compiler option [C++]"
  - "Undefine Symbols compiler option"
  - "/U compiler option [C++]"
  - "U compiler option [C++]"
ms.assetid: 7bc0474f-6d1f-419b-807d-0d8816763b2a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -U, -u (Undefine Symbols)
The **/U** compiler option undefines the specified preprocessor symbol. The **/u** compiler option undefines the Microsoft-specific symbols that the compiler defines.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Arguments  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The preprocessor symbol to undefine.  
  
## Remarks  
 Neither the **/U** or **/u** option can undefine a symbol created by using the **#define** directive.  
  
 The **/U** option can undefine a symbol that was previously defined by using the **/D** option.  
  
 By default, the compiler defines the following Microsoft-specific symbols.  
  
|Symbol|Function|  
|------------|--------------|  
|_CHAR_UNSIGNED|Default char type is unsigned. Defined when the [/J](../vs140/-j--default-char-type-is-unsigned-.md) option is specified.|  
|_CPPRTTI|Defined for code compiled with the [/GR](../vs140/-gr--enable-run-time-type-information-.md) option.|  
|_CPPUNWIND|Defined for code compiled with the [/EHsc](../vs140/-eh--exception-handling-model-.md) option.|  
|_DLL|Defined when the [/MD](../vs140/-md---mt---ld--use-run-time-library-.md) option is specified.|  
|_M_IX86|By default, defined to 600 for x86 targets.|  
|_MSC_VER|For more information, see [Predefined Macros](../vs140/predefined-macros.md).|  
|_WIN32|Defined for WIN32 applications. Always defined.|  
|_MT|Defined when the [/MD or /MT](../vs140/-md---mt---ld--use-run-time-library-.md) option is specified.|  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../vs140/how-to--open-project-property-pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Undefine Preprocessor Definitions** or **Undefine All Preprocessor Definitions** properties.  
  
### To set this compiler option programmatically  
  
-   See \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UndefineAllPreprocessorDefinitions*> or \<xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UndefinePreprocessorDefinitions*>.  
  
## See Also  
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)   
 [/J (Default char Type Is unsigned)](../vs140/-j--default-char-type-is-unsigned-.md)   
 [/GR (Enable Run-Time Type Information)](../vs140/-gr--enable-run-time-type-information-.md)   
 [/EH (Exception Handling Model)](../vs140/-eh--exception-handling-model-.md)   
 [/MD, /MT, /LD (Use Run-Time Library)](../vs140/-md---mt---ld--use-run-time-library-.md)