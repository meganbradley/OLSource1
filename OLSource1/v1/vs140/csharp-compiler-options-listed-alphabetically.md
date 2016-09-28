---
title: "C# Compiler Options Listed Alphabetically"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 29
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Compiler Options Listed Alphabetically
The following compiler options are sorted alphabetically. For a categorical list, see [C# Compiler Options Listed by Category](../vs140/csharp-compiler-options-listed-by-category.md).  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../vs140/@--csharp-compiler-options-.md)|Reads a response file for more options.|  
|[/?](../vs140/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|`/additionalfile`|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
|[/addmodule](../vs140/-addmodule--csharp-compiler-options-.md)|Links the specified modules into this assembly|  
|`/analyzer`|Run the analyzers from this assembly (Short form: /a)|  
|[/appconfig](../vs140/-appconfig--csharp-compiler-options-.md)|Specifies the location of app.config at assembly binding time.|  
|[/baseaddress](../vs140/-baseaddress--csharp-compiler-options-.md)|Specifies the base address for the library to be built.|  
|[/bugreport](../vs140/-bugreport--csharp-compiler-options-.md)|Creates a 'Bug Report' file. This file will be sent together with any crash information if it is used with **/errorreport:prompt** or **/errorreport:send**.|  
|[/checked](../vs140/-checked--csharp-compiler-options-.md)|Causes the compiler to generate overflow checks.|  
|`/checksumalgorithm:<alg>`|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
|[/codepage](../vs140/-codepage--csharp-compiler-options-.md)|Specifies the codepage to use when opening source files.|  
|[/debug](../vs140/-debug--csharp-compiler-options-.md)|Emits debugging information.|  
|[/define](../vs140/-define--csharp-compiler-options-.md)|Defines conditional compilation symbols.|  
|[/delaysign](../vs140/-delaysign--csharp-compiler-options-.md)|Delay-signs the assembly by using only the public part of the strong name key.|  
|[/doc](../vs140/-doc--csharp-compiler-options-.md)|Specifies an XML Documentation file to generate.|  
|[/errorreport](../vs140/-errorreport--csharp-compiler-options-.md)|Specifies how to handle internal compiler errors: prompt, send, or none. The default is none.|  
|[/filealign](../vs140/-filealign--csharp-compiler-options-.md)|Specifies the alignment used for output file sections.|  
|[/fullpaths](../vs140/-fullpaths--csharp-compiler-options-.md)|Causes the compiler to generate fully qualified paths.|  
|[/help](../vs140/-help------csharp-compiler-options-.md)|Displays a usage message to stdout.|  
|[/highentropyva](../vs140/-highentropyva--csharp-compiler-options-.md)|Specifies that high entropy ASLR is supported.|  
|**/incremental**|Enables incremental compilation [obsolete].|  
|[/keycontainer](../vs140/-keycontainer--csharp-compiler-options-.md)|Specifies a strong name key container.|  
|[/keyfile](../vs140/-keyfile--csharp-compiler-options-.md)|Specifies a strong name key file.|  
|[/langversion:<string\>](../vs140/-langversion--csharp-compiler-options-.md)|Specify language version mode: ISO-1, ISO-2, 3, 4, 5, 6, or Default|  
|[/lib](../vs140/-lib--csharp-compiler-options-.md)|Specifies additional directories in which to search for references.|  
|[/link](../vs140/-link--csharp-compiler-options-.md)|Makes COM type information in specified assemblies available to the project.|  
|[/linkresource](../vs140/-linkresource--csharp-compiler-options-.md)|Links the specified resource to this assembly.|  
|[/main](../vs140/-main--csharp-compiler-options-.md)|Specifies the type that contains the entry point (ignore all other possible entry points).|  
|[/moduleassemblyname](../vs140/-moduleassemblyname--csharp-compiler-option-.md)|Specifies an assembly whose non-public types a .netmodule can access.|  
|`/modulename:<string>`|Specify the name of the source module|  
|[/noconfig](../vs140/-noconfig--csharp-compiler-options-.md)|Instructs the compiler not to auto include CSC.RSP file.|  
|[/nologo](../vs140/-nologo--csharp-compiler-options-.md)|Suppresses compiler copyright message.|  
|[/nostdlib](../vs140/-nostdlib--csharp-compiler-options-.md)|Instructs the compiler not to reference standard library (mscorlib.dll).|  
|[/nowarn](../vs140/-nowarn--csharp-compiler-options-.md)|Disables specific warning messages|  
|[/nowin32manifest](../vs140/-nowin32manifest--csharp-compiler-options-.md)|Instructs the compiler not to embed an application manifest in the executable file.|  
|[/optimize](../vs140/-optimize--csharp-compiler-options-.md)|Enables/disables optimizations.|  
|[/out](../vs140/-out--csharp-compiler-options-.md)|Specifies the output file name (default: base name of file with main class or first file).|  
|`/parallel[+&#124;-]`|Specifies whether to use concurrent build (+).|  
|[/pdb](../vs140/-pdb--csharp-compiler-options-.md)|Specifies the file name and location of the .pdb file.|  
|[/platform](../vs140/-platform--csharp-compiler-options-.md)|Limits which platforms this code can run on: x86, Itanium, x64, anycpu, or anycpu32bitpreferred. The default is anycpu.|  
|[/preferreduilang](../vs140/-preferreduilang--csharp-compiler-options-.md)|Specifies the language to be used for compiler output.|  
|[/recurse](../vs140/-recurse--csharp-compiler-options-.md)|Includes all files in the current directory and subdirectories according to the wildcard specifications.|  
|[/reference](../vs140/-reference--csharp-compiler-options-.md)|References metadata from the specified assembly files.|  
|[/resource](../vs140/-resource--csharp-compiler-options-.md)|Embeds the specified resource.|  
|`/ruleset:<file>`|Specify a ruleset file that disables specific diagnostics.|  
|[/subsystemversion](../vs140/-subsystemversion--csharp-compiler-options-.md)|Specifies the minimum version of the subsystem that the executable file can use.|  
|[/target](../vs140/-target--csharp-compiler-options-.md)|Specifies the format of the output file by using one of four options:[/target:appcontainerexe](../vs140/-target-appcontainerexe--csharp-compiler-options-.md), [/target:exe](../vs140/-target-exe--csharp-compiler-options-.md), [/target:library](../vs140/-target-library--csharp-compiler-options-.md), [/target:module](../vs140/-target-module--csharp-compiler-options-.md), [/target:winexe](../vs140/-target-winexe--csharp-compiler-options-.md),  [/target:winmdobj](../vs140/-target-winmdobj--csharp-compiler-options-.md).|  
|[/unsafe](../vs140/-unsafe--csharp-compiler-options-.md)|Allows [unsafe](../vs140/unsafe--csharp-reference-.md) code.|  
|[/utf8output](../vs140/-utf8output--csharp-compiler-options-.md)|Outputs compiler messages in UTF-8 encoding.|  
|[/warn](../vs140/-warn--csharp-compiler-options-.md)|Sets the warning level (0-4).|  
|[/warnaserror](../vs140/-warnaserror--csharp-compiler-options-.md)|Reports specific warnings as errors.|  
|[/win32icon](../vs140/-win32icon--csharp-compiler-options-.md)|Uses this icon for the output.|  
|[/win32manifest](../vs140/-win32manifest--csharp-compiler-options-.md)|Specifies a custom win32 manifest file.|  
|[/win32res](../vs140/-win32res--csharp-compiler-options-.md)|Specifies the win32 resource file (.res).|  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [C# Compiler Options Listed by Category](../vs140/csharp-compiler-options-listed-by-category.md)   
 [How to: Set Environment Variables for the Visual Studio Command Line](../vs140/how-to--set-environment-variables-for-the-visual-studio-command-line.md)   
 [<compiler\> Element](assetId:///7a151659-b803-4c27-b5ce-1c4aa0d5a823)