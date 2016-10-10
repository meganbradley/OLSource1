---
title: "Visual Basic Compiler Options Listed by Category"
ms.custom: na
ms.date: "10/10/2016"
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
ms.assetid: fbe36f7a-7cfa-4f77-a8d4-2be5958568e3
caps.latest.revision: 24
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
# Visual Basic Compiler Options Listed by Category
The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] command-line compiler is provided as an alternative to compiling programs from within the [!INCLUDE[vsprvs](../VS_visualbasic/includes/vsprvs_md.md)] integrated development environment (IDE). The following is a list of the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] command-line compiler options sorted by functional category.  
  
## Compiler Output  
  
|||  
|-|-|  
|Option|Purpose|  
|[/nologo](../VS_visualbasic/-nologo--visual-basic-.md)|Suppresses compiler banner information.|  
|[/utf8output](../VS_visualbasic/-utf8output--visual-basic-.md)|Displays compiler output using UTF-8 encoding.|  
|[/verbose](../VS_visualbasic/-verbose.md)|Outputs extra information during compilation.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/preferreduilang](../Topic/-preferreduilang%20\(C%23%20Compiler%20Options\).md)|Specify a language for compiler output.|  
  
## Optimization  
  
|||  
|-|-|  
|Option|Purpose|  
|[/filealign](../VS_visualbasic/-filealign.md)|Specifies where to align the sections of the output file.|  
|[/optimize](../VS_visualbasic/-optimize.md)|Enables/disables optimizations.|  
  
## Output Files  
  
|||  
|-|-|  
|Option|Purpose|  
|[/doc](../VS_visualbasic/-doc.md)|Process documentation comments to an XML file.|  
|[/netcf](../VS_visualbasic/-netcf.md)|Sets the compiler to target the [!INCLUDE[Compact](../VS_visualbasic/includes/compact_md.md)].|  
|[/out](../VS_visualbasic/-out--visual-basic-.md)|Specifies an output file.|  
|[/target](../VS_visualbasic/-target--visual-basic-.md)|Specifies the format of the output.|  
  
## .NET Assemblies  
  
|||  
|-|-|  
|Option|Purpose|  
|[/addmodule](../VS_visualbasic/-addmodule.md)|Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling.|  
|[/delaysign](../VS_visualbasic/-delaysign.md)|Specifies whether the assembly will be fully or partially signed.|  
|[/imports](../VS_visualbasic/-imports--visual-basic-.md)|Imports a namespace from a specified assembly.|  
|[/keycontainer](../VS_visualbasic/-keycontainer.md)|Specifies a key container name for a key pair to give an assembly a strong name.|  
|[/keyfile](../VS_visualbasic/-keyfile.md)|Specifies a file containing a key or key pair to give an assembly a strong name.|  
|[/libpath](../VS_visualbasic/-libpath.md)|Specifies the location of assemblies referenced by the [/reference](../VS_visualbasic/-reference--visual-basic-.md) option.|  
|[/reference](../VS_visualbasic/-reference--visual-basic-.md)|Imports metadata from an assembly.|  
|[/moduleassemblyname](../VS_visualbasic/-moduleassemblyname.md)|Specifies the name of the assembly that a module will be a part of.|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
  
## Debugging/Error Checking  
  
|||  
|-|-|  
|Option|Purpose|  
|[/bugreport](../VS_visualbasic/-bugreport.md)|Creates a file that contains information that makes it easy to report a bug.|  
|[/debug](../VS_visualbasic/-debug--visual-basic-.md)|Produces debugging information.|  
|[/nowarn](../VS_visualbasic/-nowarn.md)|Suppresses the compiler's ability to generate warnings.|  
|[/quiet](../VS_visualbasic/-quiet.md)|Prevents the compiler from displaying code for syntax-related errors and warnings.|  
|[/removeintchecks](../VS_visualbasic/-removeintchecks.md)|Disables integer overflow checking.|  
|[/warnaserror](../VS_visualbasic/-warnaserror--visual-basic-.md)|Promotes warnings to errors.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
  
## Help  
  
|||  
|-|-|  
|Option|Purpose|  
|[/?](../VS_visualbasic/-help------visual-basic-.md)|Displays the compiler options. This command is the same as specifying the `/help` option. No compilation occurs.|  
|[/help](../VS_visualbasic/-help------visual-basic-.md)|Displays the compiler options. This command is the same as specifying the `/?` option. No compilation occurs.|  
  
## Language  
  
|||  
|-|-|  
|Option|Purpose|  
|[/langversion](../VS_visualbasic/-langversion--visual-basic-.md)|Specify language version: 9&#124;9.0&#124;10&#124;10.0&#124;11&#124;11.0.|  
|[/optionexplicit](../VS_visualbasic/-optionexplicit.md)|Enforces explicit declaration of variables.|  
|[/optionstrict](../VS_visualbasic/-optionstrict.md)|Enforces strict type semantics.|  
|[/optioncompare](../VS_visualbasic/-optioncompare.md)|Specifies whether string comparisons should be binary or use locale-specific text semantics.|  
|[/optioninfer](../VS_visualbasic/-optioninfer.md)|Enables the use of local type inference in variable declarations.|  
  
## Preprocessor  
  
|||  
|-|-|  
|Option|Purpose|  
|[/define](../VS_visualbasic/-define--visual-basic-.md)|Defines symbols for conditional compilation.|  
  
## Resources  
  
|||  
|-|-|  
|Option|Purpose|  
|[/linkresource](../VS_visualbasic/-linkresource--visual-basic-.md)|Creates a link to a managed resource.|  
|[/resource](../VS_visualbasic/-resource--visual-basic-.md)|Embeds a managed resource in an assembly.|  
|[/win32icon](../VS_visualbasic/-win32icon.md)|Inserts an .ico file into the output file.|  
|[/win32resource](../VS_visualbasic/-win32resource.md)|Inserts a Win32 resource into the output file.|  
  
## Miscellaneous  
  
|||  
|-|-|  
|Option|Purpose|  
|[@ (Specify Response File)](../VS_visualbasic/@--specify-response-file---visual-basic-.md)|Specifies a response file.|  
|[/baseaddress](../VS_visualbasic/-baseaddress.md)|Specifies the base address of a DLL.|  
|[/codepage](../VS_visualbasic/-codepage--visual-basic-.md)|Specifies the code page to use for all source code files in the compilation.|  
|[/errorreport](../VS_visualbasic/-errorreport.md)|Specifies how the [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] compiler should report internal compiler errors.|  
|[/highentropyva](../VS_visualbasic/-highentropyva--visual-basic-.md)|Tells the Windows kernel whether a particular executable supports high entropy Address Space Layout Randomization (ASLR).|  
|[/main](../VS_visualbasic/-main.md)|Specifies the class that contains the `Sub``Main` procedure to use at startup.|  
|[/noconfig](../VS_visualbasic/-noconfig.md)|Do not compile with Vbc.rsp|  
|[/nostdlib](../VS_visualbasic/-nostdlib--visual-basic-.md)|Causes the compiler not to reference the standard libraries.|  
|[/nowin32manifest](../VS_visualbasic/-nowin32manifest--visual-basic-.md)|Instructs the compiler not to embed any application manifest into the executable file.|  
|[/platform](../VS_visualbasic/-platform--visual-basic-.md)|Specifies the processor platform the compiler targets for the output file.|  
|[/recurse](../VS_visualbasic/-recurse.md)|Searches subdirectories for source files to compile.|  
|[/rootnamespace](../VS_visualbasic/-rootnamespace.md)|Specifies a namespace for all type declarations.|  
|[/sdkpath](../VS_visualbasic/-sdkpath.md)|Specifies the location of Mscorlib.dll and Microsoft.VisualBasic.dll.|  
|[/vbruntime](../VS_visualbasic/-vbruntime.md)|Specifies that the compiler should compile without a reference to the Visual Basic Runtime Library, or with a reference to a specific runtime library.|  
|[/win32manifest](../VS_visualbasic/-win32manifest--visual-basic-.md)|Identifies a user-defined Win32 application manifest file to be embedded into a project's portable executable (PE) file.|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
  
## See Also  
 [Visual Basic Compiler Options Listed Alphabetically](../VS_visualbasic/visual-basic-compiler-options-listed-alphabetically.md)   
 [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7)   
 [C# Compiler Options Listed Alphabetically](../Topic/C%23%20Compiler%20Options%20Listed%20Alphabetically.md)   
 [C# Compiler Options Listed by Category](../Topic/C%23%20Compiler%20Options%20Listed%20by%20Category.md)