---
title: "Compiler Options (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "linkresource compiler option [F#]"
  - "crossoptimize compiler option [F#]"
  - "reference compiler option [F#]"
  - "win32res compiler option [F#]"
  - "doc compiler option [F#]"
  - "pdb compiler option [F#]"
  - "noframework compiler option [F#]"
  - "delaysign compiler option [F#]"
  - "tailcalls compiler option [F#]"
  - "codepage compiler option [F#]"
  - "nologo compiler option [F#]"
  - "warnaserror compiler option [F#]"
  - "standalone compiler option [F#]"
  - "utf8output compiler option [F#]"
  - "keyfile compiler option [F#]"
  - "times compiler option [F#]"
  - "nointerfacedata compiler option [F#]"
  - "fullpaths compiler option [F#]"
  - "optimize compiler option [F#]"
  - "mlcompatibility compiler option [F#]"
  - "help compiler option [F#]"
  - "nowarn compiler option [F#]"
  - "platform compiler option [F#]"
  - "sig compiler option [F#]"
  - "checked compiler option [F#]"
  - "resource compiler option [F#]"
  - "lib compiler option [F#]"
  - "define compiler option [F#]"
  - "staticlink compiler option [F#]"
  - "compiler options [F#]"
  - "target compiler option [F#]"
  - "debug compiler option [F#]"
  - "warn compiler option [F#]"
  - "baseaddress compiler option [F#]"
  - "out compiler option [F#]"
  - "keycontainer compiler option [F#]"
ms.assetid: 434394ae-0d4a-459c-a684-bffede519a04
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Options (F#)
This topic describes compiler command-line options for the F# compiler, fsc.exe. The compilation environment can also be controlled by setting the project properties.  
  
## Compiler Options Listed Alphabetically  
 The following table shows compiler options listed alphabetically. Some of the F# compiler options are similar to the C# compiler options. If that is the case, a link to the C# compiler options topic is provided.  
  
|Compiler Option|Description|  
|---------------------|-----------------|  
|`-a` `<output-filename>`|Generates a library and specifies its filename. This option is a short form of `--target:library``<filename>`.|  
|`--baseaddress:<string>`|Specifies the base address of the library to be built.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/baseaddress (C# Compiler Option)](../vs140/-baseaddress--csharp-compiler-options-.md).|  
|`--codepage:<int>`|Specifies the codepage used to read source files.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/codepage (C# Compiler Options)](../vs140/-codepage--csharp-compiler-options-.md).|  
|`--consolecolors`|Specifies that errors and warnings use color-coded text on the console.|  
|`--crossoptimize`[`+`&#124;`-`]|Enables or disables cross-module optimizations.|  
|`--delaysign`[`+`&#124;`-`]|Delay-signs the assembly using only the public portion of the strong name key.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/delaysign (C# Compiler Options)](../vs140/-delaysign--csharp-compiler-options-.md).|  
|`--checked`[`+`&#124;`-`]|Enables or disables the generation of overflow checks.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/checked (C# Compiler Options)](../vs140/-checked--csharp-compiler-options-.md).|  
|`--debug`[`+`&#124;`-`]<br /><br /> `-g`[`+`&#124;`-`]<br /><br /> `--debug`:[`full`&#124;`pdbonly`]<br /><br /> `-g:` [`full`&#124;`pdbonly`]|Enables or disables the generation of debug information, or specifies the type of debug information to generate. The default is full, which allows attaching to a running program. Choose `pdbonly` to get limited debugging information stored in a pdb (program database) file.<br /><br /> Equivalent to the C# compiler option of the same name. For more information, see<br /><br /> [/debug (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md).|  
|`--define:<string>`<br /><br /> `-d:<string>`|Defines a symbol for use in conditional compilation.|  
|`--doc:<xmldoc-filename>`|Instructs the compiler to generate XML documentation comments to the file specified. For more information, see [XML Documentation](../vs140/xml-documentation--fsharp-.md).<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/doc (C# Compiler Options)](../vs140/-doc--csharp-compiler-options-.md).|  
|`--fullpaths`|Instructs the compiler to generate fully qualified paths.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/fullpaths (C# Compiler Options)](../vs140/-fullpaths--csharp-compiler-options-.md).|  
|`--help`<br /><br /> `-?`|Displays usage information, including a brief description of all the compiler options.|  
|`--highentropyva`[`+`&#124;`-`]|Enable or disable high-entropy address space layout randomization (ASLR), an enhanced security feature. The OS randomizes the locations in memory where infrastructure for applications (such as the stack and heap) are loaded. If you enable this option, operating systems can use this randomization to use the full 64-bit address-space on a 64-bit machine.|  
|`--keycontainer:<string>`|Specifies a strong name key container.|  
|`--keyfile:<filename>`|Specifies the name of a public key file for signing the generated assembly.|  
|`--lib:<folder-name>`<br /><br /> `-I:<folder-name>`|Specifies a directory to be searched for assemblies that are referenced.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/lib (C# Compiler Options)](../vs140/-lib--csharp-compiler-options-.md).|  
|`--linkresource`:`<resource-info>`|Links a specified resource to the assembly. The format of resource-info is `filename`[,`name`[,`public`&#124;`private`]]<br /><br /> Linking a single resource with this option is an alternative to embedding an entire resource file with the `--resource` option.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/linkresource (C# Compiler Options)](../vs140/-linkresource--csharp-compiler-options-.md).|  
|`--mlcompatibility`|Ignores warnings that appear when you use features that are designed for compatibility with other versions of ML.|  
|`--noframework`|Disables the default reference to the .NET Framework assembly.|  
|`--nointerfacedata`|Instructs the compiler to omit the resource it normally adds to an assembly that includes F#-specific metadata.|  
|`--nologo`|Doesn't show the banner text when launching the compiler.|  
|`--nooptimizationdata`|Instructs the compiler to only include optimization essential for implementing inlined constructs. Inhibits cross-module inlining but improves binary compatibility.|  
|`--nowin32manifest`|Instructs the compiler to omit the default Win32 manifest.|  
|`--nowarn:<int-list>`|Disables specific warnings listed by number. Separate each warning number by a comma. You can discover the warning number for any warning from the compilation output.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/nowarn (C# Compiler Options)](../vs140/-nowarn--csharp-compiler-options-.md).|  
|`--optimize`[`+`&#124;`-`] `[<string-list>]`<br /><br /> `-O[+&#124;-] [<string-list>]`|Enables or disables optimizations. Some optimization options can be disabled or enabled selectively by listing them. These are: `nojitoptimize`, `nojittracking`, `nolocaloptimize`, `nocrossoptimize`, `notailcalls`.|  
|`--out:<output-filename>`<br /><br /> `-o:<output-filename>`|Specifies the name of the compiled assembly or module.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/out (C# Compiler Options)](../vs140/-out--csharp-compiler-options-.md).|  
|`--pdb:<pdb-filename>`|Names the output debug PDB (program database) file. This option only applies when `--debug` is also enabled.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/pdb (C# Compiler Options)](../vs140/-pdb--csharp-compiler-options-.md).|  
|`--platform:<platform-name>`|Specifies that the generated code will only run on the specified platform (`x86`, `Itanium`, or `x64`), or, if the platform-name `anycpu` is chosen, specifies that the generated code can run on any platform.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/platform (C# Compiler Options)](../vs140/-platform--csharp-compiler-options-.md).|  
|`--quotations-debug`|Specifies that extra debugging information should be emitted for expressions that are derived from F# quotation literals and reflected definitions. The debug information is added to the custom attributes of an F# expression tree node. See [Code Quotations](../vs140/code-quotations--fsharp-.md) and [Expr.CustomAttributes](../vs140/expr.customattributes-property--fsharp-.md).|  
|`--reference:<assembly-filename>`<br /><br /> `-r` <`assembly-filename>`|Makes code from an F# or .NET Framework assembly available to the code being compiled.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/reference (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md).|  
|`--resource:<resource-filename>`|Embeds a managed resource file into the generated assembly.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/resource (C# Compiler Options)](../vs140/-resource--csharp-compiler-options-.md).|  
|`--sig`:<`signature-filename>`|Generates a signature file based on the generated assembly. For more information about signature files, see [Signatures](../vs140/signatures--fsharp-.md).|  
|`--simpleresolution`|Specifies that assembly references should be resolved using directory-based Mono rules rather than MSBuild resolution. The default is to use MSBuild resolution except when running under Mono.|  
|`--standalone`|Specifies to produce an assembly that contains all of its dependencies so that it runs by itself without the need for additional assemblies, such as the F# library.|  
|`--staticlink:<assembly-name`>|Statically links the given assembly and all referenced DLLs that depend on this assembly. Use the assembly name, not the DLL name.|  
|`--subsystemversion`|Specifies the version of the OS subsystem to be used by the generated executable. Use 6.02 for [!INCLUDE[win8](../vs140/includes/win8_md.md)], 6.01 for Windows 7, 6.00 for Windows Vista. This option only applies to executables, not DLLs, and need only be used if your application depends on specific security features available only on certain versions of the OS. If this option is used, and a user attempts to execute your application on a lower version of the OS, it will fail with an error message.|  
|`--tailcalls`[`+`&#124;`-`]|Enables or disables the use of the tail IL instruction, which causes the stack frame to be reused for tail recursive functions. This option is enabled by default.|  
|`--target`:[`exe` &#124; `winexe` &#124; `library` &#124; `module` ] `<output-filename>`|Specifies the type and file name of the generated compiled code.<br /><br /> -   `exe` means a console application.<br />-   `winexe` means a Windows application, which differs from the console application in that it does not have standard input/output streams (stdin, stdout, and stderr) defined.<br />-   `library` is an assembly without an entry point.<br />-   `module` is a .NET Framework module (.netmodule), which can later be combined with other modules into an assembly.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/target (C# Compiler Options)](../vs140/-target--csharp-compiler-options-.md).|  
|`--times`|Displays timing information for compilation.|  
|`--utf8output`|Enables printing compiler output in the UTF-8 encoding.|  
|`--warn:<warning-level>`|Sets a warning level (0 to 5). The default level is 3. Each warning is given a level based on its severity. Level 5 gives more, but less severe, warnings than level 1.<br /><br /> Level 5 warnings are: 21 (recursive use checked at runtime), 22 (`let rec` evaluated out of order), 45 (full abstraction), and 52 (defensive copy). All other warnings are level 2.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/warn (C# Compiler Options)](../vs140/-warn--csharp-compiler-options-.md).|  
|`--warnon:<int-list>`|Enable specific warnings that might be off by default or disabled by another command line option. In F# 3.0, only the 1182 (unused variables) warning is off by default.|  
|`--warnaserror`[`+`&#124;`-`] [`<int-list>`]|Enables or disables the option to report warnings as errors. You can provide specific warning numbers to be disabled or enabled. Options later in the command line override options earlier in the command line. For example, to specify the warnings that you don't want reported as errors, specify `--warnaserror+ --warnaserror-:<int-list>`.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/warnaserror (C# Compiler Options)](../vs140/-warnaserror--csharp-compiler-options-.md).|  
|`--win32manifest:manifest-filename`|Adds a Win32 manifest file to the compilation. This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/win32manifest (C# Compiler Options)](../vs140/-win32manifest--csharp-compiler-options-.md).|  
|`--win32res:resource-filename`|Adds a Win32 resource file to the compilation.<br /><br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/win32res (C# Compiler Options)](../vs140/-win32res--csharp-compiler-options-.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Interpreter Options](../vs140/fsharp-interactive-options.md)|Describes command-line options supported by the F# interpreter, fsi.exe.|  
|[Projects, User Interface Elements](../vs140/project-properties-reference.md)|Describes the UI for projects, including project property pages that provide build options.|