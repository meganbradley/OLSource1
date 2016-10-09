---
title: "C# Compiler Options Listed by Category"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "CSharp"
helpviewer_keywords: 
  - "Visual C# compiler, options listed by category"
  - "compiler options [C#], listed by category"
  - "Visual C#, compiler options listed by category"
ms.assetid: 96437ecc-6502-4cd3-b070-e9386a298e83
caps.latest.revision: 17
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
# C# Compiler Options Listed by Category
The following compiler options are sorted by category. For an alphabetical list, see [C# Compiler Options Listed Alphabetically](../VS_csharp/csharp-compiler-options-listed-alphabetically.md).  
  
### Optimization  
  
|Option|Purpose|  
|------------|-------------|  
|[/filealign](../VS_csharp/-filealign--csharp-compiler-options-.md)|Specifies the size of sections in the output file.|  
|[/optimize](../VS_csharp/-optimize--csharp-compiler-options-.md)|Enables/disables optimizations.|  
  
### Output Files  
  
|Option|Purpose|  
|------------|-------------|  
|[/doc](../VS_csharp/-doc--csharp-compiler-options-.md)|Specifies an XML file where processed documentation comments are to be written.|  
|[/out](../VS_csharp/-out--csharp-compiler-options-.md)|Specifies the output file.|  
|[/pdb](../VS_csharp/-pdb--csharp-compiler-options-.md)|Specifies the file name and location of the .pdb file.|  
|[/platform](../VS_csharp/-platform--csharp-compiler-options-.md)|Specify the output platform.|  
|[/preferreduilang](../VS_csharp/-preferreduilang--csharp-compiler-options-.md)|Specify a language for compiler output.|  
|[/target](../VS_csharp/-target--csharp-compiler-options-.md)|Specifies the format of the output file using one of five options: [/target:appcontainerexe](../VS_csharp/-target-appcontainerexe--csharp-compiler-options-.md), [/target:exe](../VS_csharp/-target-exe--csharp-compiler-options-.md), [/target:library](../VS_csharp/-target-library--csharp-compiler-options-.md), [/target:module](../VS_csharp/-target-module--csharp-compiler-options-.md), [/target:winexe](../VS_csharp/-target-winexe--csharp-compiler-options-.md), or [/target:winmdobj](../VS_csharp/-target-winmdobj--csharp-compiler-options-.md).|  
|`/modulename:<string>`|Specify the name of the source module|  
  
### .NET Framework Assemblies  
  
|Option|Purpose|  
|------------|-------------|  
|[/addmodule](../VS_csharp/-addmodule--csharp-compiler-options-.md)|Specifies one or more modules to be part of this assembly.|  
|[/delaysign](../VS_csharp/-delaysign--csharp-compiler-options-.md)|Instructs the compiler to add the public key but to leave the assembly unsigned.|  
|[/keycontainer](../VS_csharp/-keycontainer--csharp-compiler-options-.md)|Specifies the name of the cryptographic key container.|  
|[/keyfile](../VS_csharp/-keyfile--csharp-compiler-options-.md)|Specifies the filename containing the cryptographic key.|  
|[/lib](../VS_csharp/-lib--csharp-compiler-options-.md)|Specifies the location of assemblies referenced by means of [/reference](../VS_csharp/-reference--csharp-compiler-options-.md).|  
|[/nostdlib](../VS_csharp/-nostdlib--csharp-compiler-options-.md)|Instructs the compiler not to import the standard library (mscorlib.dll).|  
|[/reference](../VS_csharp/-reference--csharp-compiler-options-.md)|Imports metadata from a file that contains an assembly.|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
  
### Debugging/Error Checking  
  
|Option|Purpose|  
|------------|-------------|  
|[/bugreport](../VS_csharp/-bugreport--csharp-compiler-options-.md)|Creates a file that contains information that makes it easy to report a bug.|  
|[/checked](../VS_csharp/-checked--csharp-compiler-options-.md)|Specifies whether integer arithmetic that overflows the bounds of the data type will cause an exception at run time.|  
|[/debug](../VS_csharp/-debug--csharp-compiler-options-.md)|Instruct the compiler to emit debugging information.|  
|[/errorreport](../VS_csharp/-errorreport--csharp-compiler-options-.md)|Sets error reporting behavior.|  
|[/fullpaths](../VS_csharp/-fullpaths--csharp-compiler-options-.md)|Specifies the absolute path to the file in compiler output.|  
|[/nowarn](../VS_csharp/-nowarn--csharp-compiler-options-.md)|Suppresses the compiler's generation of specified warnings.|  
|[/warn](../VS_csharp/-warn--csharp-compiler-options-.md)|Sets the warning level.|  
|[/warnaserror](../VS_csharp/-warnaserror--csharp-compiler-options-.md)|Promotes warnings to errors.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
  
### Preprocessor  
  
|Option|Purpose|  
|------------|-------------|  
|[/define](../VS_csharp/-define--csharp-compiler-options-.md)|Defines preprocessor symbols.|  
  
### Resources  
  
|Option|Purpose|  
|------------|-------------|  
|[/link](../VS_csharp/-link--csharp-compiler-options-.md)|Makes COM type information in specified assemblies available to the project.|  
|[/linkresource](../VS_csharp/-linkresource--csharp-compiler-options-.md)|Creates a link to a managed resource.|  
|[/resource](../VS_csharp/-resource--csharp-compiler-options-.md)|Embeds a .NET Framework resource into the output file.|  
|[/win32icon](../VS_csharp/-win32icon--csharp-compiler-options-.md)|Specifies an .ico file to insert into the output file.|  
|[/win32res](../VS_csharp/-win32res--csharp-compiler-options-.md)|Specifies a Win32 resource to insert into the output file.|  
  
### Miscellaneous  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../VS_csharp/@--csharp-compiler-options-.md)|Specifies a response file.|  
|[/?](../VS_csharp/-help------csharp-compiler-options-.md)|Lists compiler options to stdout.|  
|[/baseaddress](../VS_csharp/-baseaddress--csharp-compiler-options-.md)|Specifies the preferred base address at which to load a DLL.|  
|[/codepage](../VS_csharp/-codepage--csharp-compiler-options-.md)|Specifies the code page to use for all source code files in the compilation.|  
|[/help](../VS_csharp/-help------csharp-compiler-options-.md)|Lists compiler options to stdout.|  
|[/highentropyva](../VS_csharp/-highentropyva--csharp-compiler-options-.md)|Specifies that the executable file supports address space layout randomization (ASLR).|  
|[/langversion](../VS_csharp/-langversion--csharp-compiler-options-.md)|Specify language version mode: ISO-1, ISO-2, 3, 4, 5, 6, or Default|  
|[/main](../VS_csharp/-main--csharp-compiler-options-.md)|Specifies the location of the **Main** method.|  
|[/noconfig](../VS_csharp/-noconfig--csharp-compiler-options-.md)|Instructs the compiler not to compile with csc.rsp.|  
|[/nologo](../VS_csharp/-nologo--csharp-compiler-options-.md)|Suppresses compiler banner information.|  
|[/recurse](../VS_csharp/-recurse--csharp-compiler-options-.md)|Searches subdirectories for source files to compile.|  
|[/subsystemversion](../VS_csharp/-subsystemversion--csharp-compiler-options-.md)|Specifies the minimum version of the subsystem that the executable file can use.|  
|[/unsafe](../VS_csharp/-unsafe--csharp-compiler-options-.md)|Enables compilation of code that uses the [unsafe](../VS_csharp/unsafe--csharp-reference-.md) keyword.|  
|[/utf8output](../VS_csharp/-utf8output--csharp-compiler-options-.md)|Displays compiler output using UTF-8 encoding.|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
  
## Obsolete Options  
  
|||  
|-|-|  
|**/incremental**|Enables incremental compilation.|  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [C# Compiler Options Listed Alphabetically](../VS_csharp/csharp-compiler-options-listed-alphabetically.md)   
 [How to: Set Environment Variables for the Visual Studio Command Line](../VS_csharp/how-to--set-environment-variables-for-the-visual-studio-command-line.md)