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
  
```  
/U[ ]symbol  
/u  
```  
  
## Arguments  
 `symbol`  
 The preprocessor symbol to undefine.  
  
## Remarks  
 Neither the **/U** or **/u** option can undefine a symbol created by using the **#define** directive.  
  
 The **/U** option can undefine a symbol that was previously defined by using the **/D** option.  
  
 By default, the compiler defines the following Microsoft-specific symbols.  
  
|Symbol|Function|  
|------------|--------------|  
|_CHAR_UNSIGNED|Default char type is unsigned. Defined when the [/J](../VS_csharp/-j--default-char-type-is-unsigned-.md) option is specified.|  
|_CPPRTTI|Defined for code compiled with the [/GR](../VS_csharp/-gr--enable-run-time-type-information-.md) option.|  
|_CPPUNWIND|Defined for code compiled with the [/EHsc](../VS_csharp/-eh--exception-handling-model-.md) option.|  
|_DLL|Defined when the [/MD](../VS_csharp/-md---mt---ld--use-run-time-library-.md) option is specified.|  
|_M_IX86|By default, defined to 600 for x86 targets.|  
|_MSC_VER|For more information, see [Predefined Macros](../VS_csharp/predefined-macros.md).|  
|_WIN32|Defined for WIN32 applications. Always defined.|  
|_MT|Defined when the [/MD or /MT](../VS_csharp/-md---mt---ld--use-run-time-library-.md) option is specified.|  
  
### To set this compiler option in the Visual Studio development environment  
  
1.  Open the project's **Property Pages** dialog box. For details, see [How to: Open Project Property Pages](../Topic/How%20to:%20Open%20Project%20Property%20Pages.md).  
  
2.  Click the **C/C++** folder.  
  
3.  Click the **Advanced** property page.  
  
4.  Modify the **Undefine Preprocessor Definitions** or **Undefine All Preprocessor Definitions** properties.  
  
### To set this compiler option programmatically  
  
-   See <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UndefineAllPreprocessorDefinitions*> or <xref:Microsoft.VisualStudio.VCProjectEngine.VCCLCompilerTool.UndefinePreprocessorDefinitions*>.  
  
## See Also  
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)   
 [/J (Default char Type Is unsigned)](../VS_csharp/-j--default-char-type-is-unsigned-.md)   
 [/GR (Enable Run-Time Type Information)](../VS_csharp/-gr--enable-run-time-type-information-.md)   
 [/EH (Exception Handling Model)](../VS_csharp/-eh--exception-handling-model-.md)   
 [/MD, /MT, /LD (Use Run-Time Library)](../VS_csharp/-md---mt---ld--use-run-time-library-.md)