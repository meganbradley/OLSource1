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
|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Generates a library and specifies its filename. This option is a short form of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Specifies the base address of the library to be built.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/baseaddress (C# Compiler Option)](../vs140/-baseaddress--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Specifies the codepage used to read source files.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/codepage (C# Compiler Options)](../vs140/-codepage--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Specifies that errors and warnings use color-coded text on the console.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>]|Enables or disables cross-module optimizations.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>]|Delay-signs the assembly using only the public portion of the strong name key.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/delaysign (C# Compiler Options)](../vs140/-delaysign--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>]|Enables or disables the generation of overflow checks.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/checked (C# Compiler Options)](../vs140/-checked--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>:[<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>]\<br />\<br /> <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> [<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>]|Enables or disables the generation of debug information, or specifies the type of debug information to generate. The default is full, which allows attaching to a running program. Choose <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to get limited debugging information stored in a pdb (program database) file.\<br />\<br /> Equivalent to the C# compiler option of the same name. For more information, see\<br />\<br /> [/debug (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Defines a symbol for use in conditional compilation.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Instructs the compiler to generate XML documentation comments to the file specified. For more information, see [XML Documentation](../vs140/xml-documentation--fsharp-.md).\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/doc (C# Compiler Options)](../vs140/-doc--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|Instructs the compiler to generate fully qualified paths.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/fullpaths (C# Compiler Options)](../vs140/-fullpaths--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Displays usage information, including a brief description of all the compiler options.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>]|Enable or disable high-entropy address space layout randomization (ASLR), an enhanced security feature. The OS randomizes the locations in memory where infrastructure for applications (such as the stack and heap) are loaded. If you enable this option, operating systems can use this randomization to use the full 64-bit address-space on a 64-bit machine.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Specifies a strong name key container.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Specifies the name of a public key file for signing the generated assembly.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|Specifies a directory to be searched for assemblies that are referenced.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/lib (C# Compiler Options)](../vs140/-lib--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>:<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Links a specified resource to the assembly. The format of resource-info is <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>[,<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>[,<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>]]\<br />\<br /> Linking a single resource with this option is an alternative to embedding an entire resource file with the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> option.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/linkresource (C# Compiler Options)](../vs140/-linkresource--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Ignores warnings that appear when you use features that are designed for compatibility with other versions of ML.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Disables the default reference to the .NET Framework assembly.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Instructs the compiler to omit the resource it normally adds to an assembly that includes F#-specific metadata.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Doesn't show the banner text when launching the compiler.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Instructs the compiler to only include optimization essential for implementing inlined constructs. Inhibits cross-module inlining but improves binary compatibility.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Instructs the compiler to omit the default Win32 manifest.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Disables specific warnings listed by number. Separate each warning number by a comma. You can discover the warning number for any warning from the compilation output.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/nowarn (C# Compiler Options)](../vs140/-nowarn--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>] <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Enables or disables optimizations. Some optimization options can be disabled or enabled selectively by listing them. These are: <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Specifies the name of the compiled assembly or module.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/out (C# Compiler Options)](../vs140/-out--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Names the output debug PDB (program database) file. This option only applies when <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is also enabled.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/pdb (C# Compiler Options)](../vs140/-pdb--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Specifies that the generated code will only run on the specified platform (<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>), or, if the platform-name <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> is chosen, specifies that the generated code can run on any platform.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/platform (C# Compiler Options)](../vs140/-platform--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Specifies that extra debugging information should be emitted for expressions that are derived from F# quotation literals and reflected definitions. The debug information is added to the custom attributes of an F# expression tree node. See [Code Quotations](../vs140/code-quotations--fsharp-.md) and [Expr.CustomAttributes](../vs140/expr.customattributes-property--fsharp-.md).|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>\<br />\<br /> <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> <<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Makes code from an F# or .NET Framework assembly available to the code being compiled.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/reference (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Embeds a managed resource file into the generated assembly.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/resource (C# Compiler Options)](../vs140/-resource--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>:<<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|Generates a signature file based on the generated assembly. For more information about signature files, see [Signatures](../vs140/signatures--fsharp-.md).|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Specifies that assembly references should be resolved using directory-based Mono rules rather than MSBuild resolution. The default is to use MSBuild resolution except when running under Mono.|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|Specifies to produce an assembly that contains all of its dependencies so that it runs by itself without the need for additional assemblies, such as the F# library.|  
|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>>|Statically links the given assembly and all referenced DLLs that depend on this assembly. Use the assembly name, not the DLL name.|  
|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|Specifies the version of the OS subsystem to be used by the generated executable. Use 6.02 for [!INCLUDE[win8](../vs140/includes/win8_md.md)], 6.01 for Windows 7, 6.00 for Windows Vista. This option only applies to executables, not DLLs, and need only be used if your application depends on specific security features available only on certain versions of the OS. If this option is used, and a user attempts to execute your application on a lower version of the OS, it will fail with an error message.|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>]|Enables or disables the use of the tail IL instruction, which causes the stack frame to be reused for tail recursive functions. This option is enabled by default.|  
|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>:[<CodeContentPlaceHolder>89\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> ] <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|Specifies the type and file name of the generated compiled code.\<br />\<br /> -   <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> means a console application.\<br />-   <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> means a Windows application, which differs from the console application in that it does not have standard input/output streams (stdin, stdout, and stderr) defined.\<br />-   <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> is an assembly without an entry point.\<br />-   <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> is a .NET Framework module (.netmodule), which can later be combined with other modules into an assembly.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/target (C# Compiler Options)](../vs140/-target--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|Displays timing information for compilation.|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Enables printing compiler output in the UTF-8 encoding.|  
|<CodeContentPlaceHolder>100\</CodeContentPlaceHolder>|Sets a warning level (0 to 5). The default level is 3. Each warning is given a level based on its severity. Level 5 gives more, but less severe, warnings than level 1.\<br />\<br /> Level 5 warnings are: 21 (recursive use checked at runtime), 22 (<CodeContentPlaceHolder>101\</CodeContentPlaceHolder> evaluated out of order), 45 (full abstraction), and 52 (defensive copy). All other warnings are level 2.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/warn (C# Compiler Options)](../vs140/-warn--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|Enable specific warnings that might be off by default or disabled by another command line option. In F# 3.0, only the 1182 (unused variables) warning is off by default.|  
|<CodeContentPlaceHolder>103\</CodeContentPlaceHolder>[<CodeContentPlaceHolder>104\</CodeContentPlaceHolder>&#124;<CodeContentPlaceHolder>105\</CodeContentPlaceHolder>] [<CodeContentPlaceHolder>106\</CodeContentPlaceHolder>]|Enables or disables the option to report warnings as errors. You can provide specific warning numbers to be disabled or enabled. Options later in the command line override options earlier in the command line. For example, to specify the warnings that you don't want reported as errors, specify <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/warnaserror (C# Compiler Options)](../vs140/-warnaserror--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>108\</CodeContentPlaceHolder>|Adds a Win32 manifest file to the compilation. This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/win32manifest (C# Compiler Options)](../vs140/-win32manifest--csharp-compiler-options-.md).|  
|<CodeContentPlaceHolder>109\</CodeContentPlaceHolder>|Adds a Win32 resource file to the compilation.\<br />\<br /> This compiler option is equivalent to the C# compiler option of the same name. For more information, see [/win32res (C# Compiler Options)](../vs140/-win32res--csharp-compiler-options-.md).|  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Interpreter Options](../vs140/fsharp-interactive-options.md)|Describes command-line options supported by the F# interpreter, fsi.exe.|  
|[Projects, User Interface Elements](../vs140/project-properties-reference.md)|Describes the UI for projects, including project property pages that provide build options.|