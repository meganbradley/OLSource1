---
title: "C# Compiler Options Listed by Category"
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
  - "Visual C# compiler, options listed by category"
  - "compiler options [C#], listed by category"
  - "Visual C#, compiler options listed by category"
ms.assetid: 96437ecc-6502-4cd3-b070-e9386a298e83
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# C# Compiler Options Listed by Category
The following compiler options are sorted by category. For an alphabetical list, see [C# Compiler Options Listed Alphabetically](../vs140/csharp-compiler-options-listed-alphabetically.md).  
  
### Optimization  
  
|Option|Purpose|  
|------------|-------------|  
|[/filealign](../vs140/-filealign--csharp-compiler-options-.md)|Specifies the size of sections in the output file.|  
|[/optimize](../vs140/-optimize--csharp-compiler-options-.md)|Enables/disables optimizations.|  
  
### Output Files  
  
|Option|Purpose|  
|------------|-------------|  
|[/doc](../vs140/-doc--csharp-compiler-options-.md)|Specifies an XML file where processed documentation comments are to be written.|  
|[/out](../vs140/-out--csharp-compiler-options-.md)|Specifies the output file.|  
|[/pdb](../vs140/-pdb--csharp-compiler-options-.md)|Specifies the file name and location of the .pdb file.|  
|[/platform](../vs140/-platform--csharp-compiler-options-.md)|Specify the output platform.|  
|[/preferreduilang](../vs140/-preferreduilang--csharp-compiler-options-.md)|Specify a language for compiler output.|  
|[/target](../vs140/-target--csharp-compiler-options-.md)|Specifies the format of the output file using one of five options: [/target:appcontainerexe](../vs140/-target-appcontainerexe--csharp-compiler-options-.md), [/target:exe](../vs140/-target-exe--csharp-compiler-options-.md), [/target:library](../vs140/-target-library--csharp-compiler-options-.md), [/target:module](../vs140/-target-module--csharp-compiler-options-.md), [/target:winexe](../vs140/-target-winexe--csharp-compiler-options-.md), or [/target:winmdobj](../vs140/-target-winmdobj--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|Specify the name of the source module|  
  
### .NET Framework Assemblies  
  
|Option|Purpose|  
|------------|-------------|  
|[/addmodule](../vs140/-addmodule--csharp-compiler-options-.md)|Specifies one or more modules to be part of this assembly.|  
|[/delaysign](../vs140/-delaysign--csharp-compiler-options-.md)|Instructs the compiler to add the public key but to leave the assembly unsigned.|  
|[/keycontainer](../vs140/-keycontainer--csharp-compiler-options-.md)|Specifies the name of the cryptographic key container.|  
|[/keyfile](../vs140/-keyfile--csharp-compiler-options-.md)|Specifies the filename containing the cryptographic key.|  
|[/lib](../vs140/-lib--csharp-compiler-options-.md)|Specifies the location of assemblies referenced by means of [/reference](../vs140/-reference--csharp-compiler-options-.md).|  
|[/nostdlib](../vs140/-nostdlib--csharp-compiler-options-.md)|Instructs the compiler not to import the standard library (mscorlib.dll).|  
|[/reference](../vs140/-reference--csharp-compiler-options-.md)|Imports metadata from a file that contains an assembly.|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Run the analyzers from this assembly (Short form: /a)|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Names additional files that don't directly affect code generation but may be used by analyzers for producing errors or warnings.|  
  
### Debugging/Error Checking  
  
|Option|Purpose|  
|------------|-------------|  
|[/bugreport](../vs140/-bugreport--csharp-compiler-options-.md)|Creates a file that contains information that makes it easy to report a bug.|  
|[/checked](../vs140/-checked--csharp-compiler-options-.md)|Specifies whether integer arithmetic that overflows the bounds of the data type will cause an exception at run time.|  
|[/debug](../vs140/-debug--csharp-compiler-options-.md)|Instruct the compiler to emit debugging information.|  
|[/errorreport](../vs140/-errorreport--csharp-compiler-options-.md)|Sets error reporting behavior.|  
|[/fullpaths](../vs140/-fullpaths--csharp-compiler-options-.md)|Specifies the absolute path to the file in compiler output.|  
|[/nowarn](../vs140/-nowarn--csharp-compiler-options-.md)|Suppresses the compiler's generation of specified warnings.|  
|[/warn](../vs140/-warn--csharp-compiler-options-.md)|Sets the warning level.|  
|[/warnaserror](../vs140/-warnaserror--csharp-compiler-options-.md)|Promotes warnings to errors.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Specify a ruleset file that disables specific diagnostics.|  
  
### Preprocessor  
  
|Option|Purpose|  
|------------|-------------|  
|[/define](../vs140/-define--csharp-compiler-options-.md)|Defines preprocessor symbols.|  
  
### Resources  
  
|Option|Purpose|  
|------------|-------------|  
|[/link](../vs140/-link--csharp-compiler-options-.md)|Makes COM type information in specified assemblies available to the project.|  
|[/linkresource](../vs140/-linkresource--csharp-compiler-options-.md)|Creates a link to a managed resource.|  
|[/resource](../vs140/-resource--csharp-compiler-options-.md)|Embeds a .NET Framework resource into the output file.|  
|[/win32icon](../vs140/-win32icon--csharp-compiler-options-.md)|Specifies an .ico file to insert into the output file.|  
|[/win32res](../vs140/-win32res--csharp-compiler-options-.md)|Specifies a Win32 resource to insert into the output file.|  
  
### Miscellaneous  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../vs140/@--csharp-compiler-options-.md)|Specifies a response file.|  
|[/?](../vs140/-help------csharp-compiler-options-.md)|Lists compiler options to stdout.|  
|[/baseaddress](../vs140/-baseaddress--csharp-compiler-options-.md)|Specifies the preferred base address at which to load a DLL.|  
|[/codepage](../vs140/-codepage--csharp-compiler-options-.md)|Specifies the code page to use for all source code files in the compilation.|  
|[/help](../vs140/-help------csharp-compiler-options-.md)|Lists compiler options to stdout.|  
|[/highentropyva](../vs140/-highentropyva--csharp-compiler-options-.md)|Specifies that the executable file supports address space layout randomization (ASLR).|  
|[/langversion](../vs140/-langversion--csharp-compiler-options-.md)|Specify language version mode: ISO-1, ISO-2, 3, 4, 5, 6, or Default|  
|[/main](../vs140/-main--csharp-compiler-options-.md)|Specifies the location of the **Main** method.|  
|[/noconfig](../vs140/-noconfig--csharp-compiler-options-.md)|Instructs the compiler not to compile with csc.rsp.|  
|[/nologo](../vs140/-nologo--csharp-compiler-options-.md)|Suppresses compiler banner information.|  
|[/recurse](../vs140/-recurse--csharp-compiler-options-.md)|Searches subdirectories for source files to compile.|  
|[/subsystemversion](../vs140/-subsystemversion--csharp-compiler-options-.md)|Specifies the minimum version of the subsystem that the executable file can use.|  
|[/unsafe](../vs140/-unsafe--csharp-compiler-options-.md)|Enables compilation of code that uses the [unsafe](../vs140/unsafe--csharp-reference-.md) keyword.|  
|[/utf8output](../vs140/-utf8output--csharp-compiler-options-.md)|Displays compiler output using UTF-8 encoding.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Specifies whether to use concurrent build (+).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Specify the algorithm for calculating the source file checksum stored in PDB.  Supported values are: SHA1 (default) or SHA256.|  
  
## Obsolete Options  
  
|||  
|-|-|  
|**/incremental**|Enables incremental compilation.|  
  
## See Also  
 [C# Compiler Options](../vs140/csharp-compiler-options.md)   
 [C# Compiler Options Listed Alphabetically](../vs140/csharp-compiler-options-listed-alphabetically.md)   
 [How to: Set Environment Variables for the Visual Studio Command Line](../vs140/how-to--set-environment-variables-for-the-visual-studio-command-line.md)