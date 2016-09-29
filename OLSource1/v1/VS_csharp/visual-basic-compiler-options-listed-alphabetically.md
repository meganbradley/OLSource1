---
title: "Visual Basic Compiler Options Listed Alphabetically"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Visual Basic Compiler Options Listed Alphabetically
The [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] command-line compiler is provided as an alternative to compiling programs from the [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] integrated development environment (IDE). The following is a list of the [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] command-line compiler options sorted alphabetically.  
  
|Option|Purpose|  
|------------|-------------|  
|[@ (Specify Response File)](../VS_csharp/@--specify-response-file---visual-basic-.md)|Specifies a response file.|  
|[/?](../VS_csharp/-help------visual-basic-.md)|Displays compiler options. This command is the same as specifying the `/help` option. No compilation occurs.|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
|[/addmodule](../VS_csharp/-addmodule.md)|Causes the compiler to make all type information from the specified file(s) available to the project you are currently compiling.|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|[/baseaddress](../VS_csharp/-baseaddress.md)|Specifies the base address of a DLL.|  
|[/bugreport](../VS_csharp/-bugreport.md)|Creates a file that contains information that makes it easy to report a bug.|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
|[/codepage](../VS_csharp/-codepage--visual-basic-.md)|Specifies the code page to use for all source code files in the compilation.|  
|[/debug](../VS_csharp/-debug--visual-basic-.md)|Produces debugging information.|  
|[/define](../VS_csharp/-define--visual-basic-.md)|Defines symbols for conditional compilation.|  
|[/delaysign](../VS_csharp/-delaysign.md)|Specifies whether the assembly will be fully or partially signed.|  
|[/doc](../VS_csharp/-doc.md)|Processes documentation comments to an XML file.|  
|[/errorreport](../VS_csharp/-errorreport.md)|Specifies how the [!INCLUDE[vbprvb](../VS_csharp/includes/vbprvb_md.md)] compiler should report internal compiler errors.|  
|[/filealign](../VS_csharp/-filealign.md)|Specifies where to align the sections of the output file.|  
|[/help](../VS_csharp/-help------visual-basic-.md)|Displays compiler options. This command is the same as specifying the `/?` option. No compilation occurs.|  
|[/highentropyva](../VS_csharp/-highentropyva--visual-basic-.md)|Indicates whether a particular executable supports high entropy Address Space Layout Randomization (ASLR).|  
|[/imports](../VS_csharp/-imports--visual-basic-.md)|Imports a namespace from a specified assembly.|  
|[/keycontainer](../VS_csharp/-keycontainer.md)|Specifies a key container name for a key pair to give an assembly a strong name.|  
|[/keyfile](../VS_csharp/-keyfile.md)|Specifies a file that contains a key or key pair to give an assembly a strong name.|  
|[/langversion](../VS_csharp/-langversion--visual-basic-.md)|Specify language version: 9&#124;9.0&#124;10&#124;10.0&#124;11&#124;11.0.|  
|[/libpath](../VS_csharp/-libpath.md)|Specifies the location of assemblies referenced by the [/reference](../VS_csharp/-reference--visual-basic-.md) option.|  
|[/linkresource](../VS_csharp/-linkresource--visual-basic-.md)|Creates a link to a managed resource.|  
|[/main](../VS_csharp/-main.md)|Specifies the class that contains the `Sub``Main` procedure to use at startup.|  
|[/moduleassemblyname](../VS_csharp/-moduleassemblyname.md)|Specifies the name of the assembly that a module will be a part of.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/netcf](../VS_csharp/-netcf.md)|Sets the compiler to target the [!INCLUDE[Compact](../VS_csharp/includes/compact_md.md)].|  
|[/noconfig](../VS_csharp/-noconfig.md)|Do not compile with Vbc.rsp.|  
|[/nologo](../VS_csharp/-nologo--visual-basic-.md)|Suppresses compiler banner information.|  
|[/nostdlib](../VS_csharp/-nostdlib--visual-basic-.md)|Causes the compiler not to reference the standard libraries.|  
|[/nowarn](../VS_csharp/-nowarn.md)|Suppresses the compiler's ability to generate warnings.|  
|[/nowin32manifest](../VS_csharp/-nowin32manifest--visual-basic-.md)|Instructs the compiler not to embed any application manifest into the executable file.|  
|[/optimize](../VS_csharp/-optimize.md)|Enables/disables code optimization.|  
|[/optioncompare](../VS_csharp/-optioncompare.md)|Specifies whether string comparisons should be binary or use locale-specific text semantics.|  
|[/optionexplicit](../VS_csharp/-optionexplicit.md)|Enforces explicit declaration of variables.|  
|[/optioninfer](../VS_csharp/-optioninfer.md)|Enables the use of local type inference in variable declarations.|  
|[/optionstrict](../VS_csharp/-optionstrict.md)|Enforces strict language semantics.|  
|[/out](../VS_csharp/-out--visual-basic-.md)|Specifies an output file.|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|[/platform](../VS_csharp/-platform--visual-basic-.md)|Specifies the processor platform the compiler targets for the output file.|  
|`/preferreduilang`|Specify the preferred output language name.|  
|[/quiet](../VS_csharp/-quiet.md)|Prevents the compiler from displaying code for syntax-related errors and warnings.|  
|[/recurse](../VS_csharp/-recurse.md)|Searches subdirectories for source files to compile.|  
|[/reference](../VS_csharp/-reference--visual-basic-.md)|Imports metadata from an assembly.|  
|[/removeintchecks](../VS_csharp/-removeintchecks.md)|Disables integer overflow checking.|  
|[/resource](../VS_csharp/-resource--visual-basic-.md)|Embeds a managed resource in an assembly.|  
|[/rootnamespace](../VS_csharp/-rootnamespace.md)|Specifies a namespace for all type declarations.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
|[/sdkpath](../VS_csharp/-sdkpath.md)|Specifies the location of Mscorlib.dll and Microsoft.VisualBasic.dll.|  
|[/subsystemversion](../VS_csharp/-subsystemversion--visual-basic-.md)|Specifies the minimum version of the subsystem that the generated executable file can use.|  
|[/target](../VS_csharp/-target--visual-basic-.md)|Specifies the format of the output file.|  
|[/utf8output](../VS_csharp/-utf8output--visual-basic-.md)|Displays compiler output using UTF-8 encoding.|  
|[/vbruntime](../VS_csharp/-vbruntime.md)|Specifies that the compiler should compile without a reference to the Visual Basic Runtime Library, or with a reference to a specific runtime library.|  
|[/verbose](../VS_csharp/-verbose.md)|Outputs extra information during compilation.|  
|[/warnaserror](../VS_csharp/-warnaserror--visual-basic-.md)|Promotes warnings to errors.|  
|[/win32icon](../VS_csharp/-win32icon.md)|Inserts an .ico file into the output file.|  
|[/win32manifest](../VS_csharp/-win32manifest--visual-basic-.md)|Identifies a user-defined Win32 application manifest file to be embedded into a project's portable executable (PE) file.|  
|[/win32resource](../VS_csharp/-win32resource.md)|Inserts a Win32 resource into the output file.|  
  
## See Also  
 [Visual Basic Compiler Options Listed by Category](../VS_csharp/visual-basic-compiler-options-listed-by-category.md)   
 [Introduction to the Project Designer](assetId:///898dd854-c98d-430c-ba1b-a913ce3c73d7)   
 [C# Compiler Options Listed Alphabetically](../VS_csharp/csharp-compiler-options-listed-alphabetically.md)   
 [C# Compiler Options Listed by Category](../VS_csharp/csharp-compiler-options-listed-by-category.md)