---
title: "Visual Basic Compiler Options Listed Alphabetically"
ms.custom: na
ms.date: "10/07/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Visual Basic compiler, options"
ms.assetid: e67febba-bacf-4e1f-a143-c141e063f90e
caps.latest.revision: 27
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Visual Basic Compiler Options Listed Alphabetically
The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] command-line compiler is provided as an alternative to compiling programs from the [!INCLUDE[vsprvs](../VS_visualbasic/includes/vsprvs_md.md)] integrated development environment (IDE). The following is a list of the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] command-line compiler options sorted alphabetically.  
  
|Option|Purpose|  
|------------|-------------|  
|[@ (Specify Response File)](../VS_visualbasic/@--specify-response-file---visual-basic-.md)|Specifies a response file.|  
|[/?](../VS_visualbasic/-help------visual-basic-.md)|Displays compiler options. This command is the same as specifying the `/help` option. No compilation occurs.|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
|[/addmodule](../VS_visualbasic/-addmodule.md)|Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling.|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|[/baseaddress](../VS_visualbasic/-baseaddress.md)|Specifies the base address of a DLL.|  
|[/bugreport](../VS_visualbasic/-bugreport.md)|Creates a file that contains information that makes it easy to report a bug.|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
|[/codepage](../VS_visualbasic/-codepage--visual-basic-.md)|Specifies the code page to use for all source code files in the compilation.|  
|[/debug](../VS_visualbasic/-debug--visual-basic-.md)|Produces debugging information.|  
|[/define](../VS_visualbasic/-define--visual-basic-.md)|Defines symbols for conditional compilation.|  
|[/delaysign](../VS_visualbasic/-delaysign.md)|Specifies whether the assembly will be fully or partially signed.|  
|[/doc](../VS_visualbasic/-doc.md)|Processes documentation comments to an XML file.|  
|[/errorreport](../VS_visualbasic/-errorreport.md)|Specifies how the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler should report internal compiler errors.|  
|[/filealign](../VS_visualbasic/-filealign.md)|Specifies where to align the sections of the output file.|  
|[/help](../VS_visualbasic/-help------visual-basic-.md)|Displays compiler options. This command is the same as specifying the `/?` option. No compilation occurs.|  
|[/highentropyva](../VS_visualbasic/-highentropyva--visual-basic-.md)|Indicates whether a particular executable supports high entropy Address Space Layout Randomization (ASLR).|  
|[/imports](../VS_visualbasic/-imports--visual-basic-.md)|Imports a namespace from a specified assembly.|  
|[/keycontainer](../VS_visualbasic/-keycontainer.md)|Specifies a key container name for a key pair to give an assembly a strong name.|  
|[/keyfile](../VS_visualbasic/-keyfile.md)|Specifies a file that contains a key or key pair to give an assembly a strong name.|  
|[/langversion](../VS_visualbasic/-langversion--visual-basic-.md)|Specify language version: 9&#124;9.0&#124;10&#124;10.0&#124;11&#124;11.0.|  
|[/libpath](../VS_visualbasic/-libpath.md)|Specifies the location of assemblies referenced by the [/reference](../VS_visualbasic/-reference--visual-basic-.md) option.|  
|[/linkresource](../VS_visualbasic/-linkresource--visual-basic-.md)|Creates a link to a managed resource.|  
|[/main](../VS_visualbasic/-main.md)|Specifies the class that contains the `Sub``Main` procedure to use at startup.|  
|[/moduleassemblyname](../VS_visualbasic/-moduleassemblyname.md)|Specifies the name of the assembly that a module will be a part of.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/netcf](../VS_visualbasic/-netcf.md)|Sets the compiler to target the [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)].|  
|[/noconfig](../VS_visualbasic/-noconfig.md)|Do not compile with Vbc.rsp.|  
|[/nologo](../VS_visualbasic/-nologo--visual-basic-.md)|Suppresses compiler banner information.|  
|[/nostdlib](../VS_visualbasic/-nostdlib--visual-basic-.md)|Causes the compiler not to reference the standard libraries.|  
|[/nowarn](../VS_visualbasic/-nowarn.md)|Suppresses the compiler's ability to generate warnings.|  
|[/nowin32manifest](../VS_visualbasic/-nowin32manifest--visual-basic-.md)|Instructs the compiler not to embed any application manifest into the executable file.|  
|[/optimize](../VS_visualbasic/-optimize.md)|Enables/disables code optimization.|  
|[/optioncompare](../VS_visualbasic/-optioncompare.md)|Specifies whether string comparisons should be binary or use locale-specific text semantics.|  
|[/optionexplicit](../VS_visualbasic/-optionexplicit.md)|Enforces explicit declaration of variables.|  
|[/optioninfer](../VS_visualbasic/-optioninfer.md)|Enables the use of local type inference in variable declarations.|  
|[/optionstrict](../VS_visualbasic/-optionstrict.md)|Enforces strict language semantics.|  
|[/out](../VS_visualbasic/-out--visual-basic-.md)|Specifies an output file.|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|[/platform](../VS_visualbasic/-platform--visual-basic-.md)|Specifies the processor platform the compiler targets for the output file.|  
|`/preferreduilang`|Specify the preferred output language name.|  
|[/quiet](../VS_visualbasic/-quiet.md)|Prevents the compiler from displaying code for syntax-related errors and warnings.|  
|[/recurse](../VS_visualbasic/-recurse.md)|Searches subdirectories for source files to compile.|  
|[/reference](../VS_visualbasic/-reference--visual-basic-.md)|Imports metadata from an assembly.|  
|[/removeintchecks](../VS_visualbasic/-removeintchecks.md)|Disables integer overflow checking.|  
|[/resource](../VS_visualbasic/-resource--visual-basic-.md)|Embeds a managed resource in an assembly.|  
|[/rootnamespace](../VS_visualbasic/-rootnamespace.md)|Specifies a namespace for all type declarations.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
|[/sdkpath](../VS_visualbasic/-sdkpath.md)|Specifies the location of Mscorlib.dll and Microsoft.VisualBasic.dll.|  
|[/subsystemversion](../VS_visualbasic/-subsystemversion--visual-basic-.md)|Specifies the minimum version of the subsystem that the generated executable file can use.|  
|[/target](../VS_visualbasic/-target--visual-basic-.md)|Specifies the format of the output file.|  
|[/utf8output](../VS_visualbasic/-utf8output--visual-basic-.md)|Displays compiler output using UTF-8 encoding.|  
|[/vbruntime](../VS_visualbasic/-vbruntime.md)|Specifies that the compiler should compile without a reference to the Visual Basic Runtime Library, or with a reference to a specific runtime library.|  
|[/verbose](../VS_visualbasic/-verbose.md)|Outputs extra information during compilation.|  
|[/warnaserror](../VS_visualbasic/-warnaserror--visual-basic-.md)|Promotes warnings to errors.|  
|[/win32icon](../VS_visualbasic/-win32icon.md)|Inserts an .ico file into the output file.|  
|[/win32manifest](../VS_visualbasic/-win32manifest--visual-basic-.md)|Identifies a user-defined Win32 application manifest file to be embedded into a project's portable executable (PE) file.|  
|[/win32resource](../VS_visualbasic/-win32resource.md)|Inserts a Win32 resource into the output file.|  
  
## See Also  
 [Visual Basic Compiler Options Listed by Category](../VS_visualbasic/visual-basic-compiler-options-listed-by-category.md)   
 [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7)   
 [C# Compiler Options Listed Alphabetically](../Topic/C%23%20Compiler%20Options%20Listed%20Alphabetically.md)   
 [C# Compiler Options Listed by Category](../Topic/C%23%20Compiler%20Options%20Listed%20by%20Category.md)