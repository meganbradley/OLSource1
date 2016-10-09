---
title: "C# Compiler Options Listed Alphabetically"
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
  - "compiler options [C#], listed alpabetically"
  - "C# language, compiler options listed alphabitically"
  - "Visual C# compiler, options listed alphabetically"
  - "Visual C#, compiler options listed alphabetically"
ms.assetid: 43535ea0-ca47-4a15-b528-615087a86092
caps.latest.revision: 25
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
# C# Compiler Options Listed Alphabetically
The following compiler options are sorted alphabetically. For a categorical list, see [C# Compiler Options Listed by Category](../VS_csharp/csharp-compiler-options-listed-by-category.md).  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../VS_csharp/@--csharp-compiler-options-.md)|Reads a response file for more options.|  
|[/?](../VS_csharp/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
|[/addmodule](../VS_csharp/-addmodule--csharp-compiler-options-.md)|Links the specified modules into this assembly|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|[/appconfig](../VS_csharp/-appconfig--csharp-compiler-options-.md)|Specifies the location of app.config at assembly binding time.|  
|[/baseaddress](../VS_csharp/-baseaddress--csharp-compiler-options-.md)|Specifies the base address for the library to be built.|  
|[/bugreport](../VS_csharp/-bugreport--csharp-compiler-options-.md)|Creates a 'Bug Report' file. This file will be sent together with any crash information if it is used with **/errorreport:prompt** or **/errorreport:send**.|  
|[/checked](../VS_csharp/-checked--csharp-compiler-options-.md)|Causes the compiler to generate overflow checks.|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
|[/codepage](../VS_csharp/-codepage--csharp-compiler-options-.md)|Specifies the codepage to use when opening source files.|  
|[/debug](../VS_csharp/-debug--csharp-compiler-options-.md)|Emits debugging information.|  
|[/define](../VS_csharp/-define--csharp-compiler-options-.md)|Defines conditional compilation symbols.|  
|[/delaysign](../VS_csharp/-delaysign--csharp-compiler-options-.md)|Delay-signs the assembly by using only the public part of the strong name key.|  
|[/doc](../VS_csharp/-doc--csharp-compiler-options-.md)|Specifies an XML Documentation file to generate.|  
|[/errorreport](../VS_csharp/-errorreport--csharp-compiler-options-.md)|Specifies how to handle internal compiler errors: prompt, send, or none. The default is none.|  
|[/filealign](../VS_csharp/-filealign--csharp-compiler-options-.md)|Specifies the alignment used for output file sections.|  
|[/fullpaths](../VS_csharp/-fullpaths--csharp-compiler-options-.md)|Causes the compiler to generate fully qualified paths.|  
|[/help](../VS_csharp/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|[/highentropyva](../VS_csharp/-highentropyva--csharp-compiler-options-.md)|Specifies that high entropy ASLR is supported.|  
|**/incremental**|Enables incremental compilation [obsolete].|  
|[/keycontainer](../VS_csharp/-keycontainer--csharp-compiler-options-.md)|Specifies a strong name key container.|  
|[/keyfile](../VS_csharp/-keyfile--csharp-compiler-options-.md)|Specifies a strong name key file.|  
|[/langversion:\<string>](../VS_csharp/-langversion--csharp-compiler-options-.md)|Specify language version mode: ISO-1, ISO-2, 3, 4, 5, 6, or Default|  
|[/lib](../VS_csharp/-lib--csharp-compiler-options-.md)|Specifies additional directories in which to search for references.|  
|[/link](../VS_csharp/-link--csharp-compiler-options-.md)|Makes COM type information in specified assemblies available to the project.|  
|[/linkresource](../VS_csharp/-linkresource--csharp-compiler-options-.md)|Links the specified resource to this assembly.|  
|[/main](../VS_csharp/-main--csharp-compiler-options-.md)|Specifies the type that contains the entry point (ignore all other possible entry points).|  
|[/moduleassemblyname](../VS_csharp/-moduleassemblyname--csharp-compiler-option-.md)|Specifies an assembly whose non-public types a .netmodule can access.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/noconfig](../VS_csharp/-noconfig--csharp-compiler-options-.md)|Instructs the compiler not to auto include CSC.RSP file.|  
|[/nologo](../VS_csharp/-nologo--csharp-compiler-options-.md)|Suppresses compiler copyright message.|  
|[/nostdlib](../VS_csharp/-nostdlib--csharp-compiler-options-.md)|Instructs the compiler not to reference standard library (mscorlib.dll).|  
|[/nowarn](../VS_csharp/-nowarn--csharp-compiler-options-.md)|Disables specific warning messages|  
|[/nowin32manifest](../VS_csharp/-nowin32manifest--csharp-compiler-options-.md)|Instructs the compiler not to embed an application manifest in the executable file.|  
|[/optimize](../VS_csharp/-optimize--csharp-compiler-options-.md)|Enables/disables optimizations.|  
|[/out](../VS_csharp/-out--csharp-compiler-options-.md)|Specifies the output file name (default: base name of file with main class or first file).|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|[/pdb](../VS_csharp/-pdb--csharp-compiler-options-.md)|Specifies the file name and location of the .pdb file.|  
|[/platform](../VS_csharp/-platform--csharp-compiler-options-.md)|Limits which platforms this code can run on: x86, Itanium, x64, anycpu, or anycpu32bitpreferred. The default is anycpu.|  
|[/preferreduilang](../VS_csharp/-preferreduilang--csharp-compiler-options-.md)|Specifies the language to be used for compiler output.|  
|[/recurse](../VS_csharp/-recurse--csharp-compiler-options-.md)|Includes all files in the current directory and subdirectories according to the wildcard specifications.|  
|[/reference](../VS_csharp/-reference--csharp-compiler-options-.md)|References metadata from the specified assembly files.|  
|[/resource](../VS_csharp/-resource--csharp-compiler-options-.md)|Embeds the specified resource.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
|[/subsystemversion](../VS_csharp/-subsystemversion--csharp-compiler-options-.md)|Specifies the minimum version of the subsystem that the executable file can use.|  
|[/target](../VS_csharp/-target--csharp-compiler-options-.md)|Specifies the format of the output file by using one of four options:[/target:appcontainerexe](../VS_csharp/-target-appcontainerexe--csharp-compiler-options-.md), [/target:exe](../VS_csharp/-target-exe--csharp-compiler-options-.md), [/target:library](../VS_csharp/-target-library--csharp-compiler-options-.md), [/target:module](../VS_csharp/-target-module--csharp-compiler-options-.md), [/target:winexe](../VS_csharp/-target-winexe--csharp-compiler-options-.md),  [/target:winmdobj](../VS_csharp/-target-winmdobj--csharp-compiler-options-.md).|  
|[/unsafe](../VS_csharp/-unsafe--csharp-compiler-options-.md)|Allows [unsafe](../VS_csharp/unsafe--csharp-reference-.md) code.|  
|[/utf8output](../VS_csharp/-utf8output--csharp-compiler-options-.md)|Outputs compiler messages in UTF-8 encoding.|  
|[/warn](../VS_csharp/-warn--csharp-compiler-options-.md)|Sets the warning level (0-4).|  
|[/warnaserror](../VS_csharp/-warnaserror--csharp-compiler-options-.md)|Reports specific warnings as errors.|  
|[/win32icon](../VS_csharp/-win32icon--csharp-compiler-options-.md)|Uses this icon for the output.|  
|[/win32manifest](../VS_csharp/-win32manifest--csharp-compiler-options-.md)|Specifies a custom win32 manifest file.|  
|[/win32res](../VS_csharp/-win32res--csharp-compiler-options-.md)|Specifies the win32 resource file (.res).|  
  
## See Also  
 [C# Compiler Options](../VS_csharp/csharp-compiler-options.md)   
 [C# Compiler Options Listed by Category](../VS_csharp/csharp-compiler-options-listed-by-category.md)   
 [How to: Set Environment Variables for the Visual Studio Command Line](../VS_csharp/how-to--set-environment-variables-for-the-visual-studio-command-line.md)   
 [\<compiler> Element](../Topic/%3Ccompiler%3E%20Element.md)