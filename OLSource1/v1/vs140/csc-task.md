---
title: "Csc Task"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "http://schemas.microsoft.com/developer/msbuild/2003#Csc"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "Csc task [MSBuild]"
  - "MSBuild, Csc task"
ms.assetid: d8c19b36-f5ca-484b-afa6-8ff3b90e103a
caps.latest.revision: 30
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Csc Task
Wraps CSC.exe, and produces executables (.exe files), dynamic-link libraries (.dll files), or code modules (.netmodule files). For more information about CSC.exe, see [C# Compiler Options](../vs140/csharp-compiler-options.md).  
  
## Parameters  
 The following table describes the parameters of the `Csc` task.  
  
|Parameter|Description|  
|---------------|-----------------|  
|`AdditionalLibPaths`|Optional `String[]` parameter.<br /><br /> Specifies additional directories to search for references. For more information, see [/lib (Specify Assembly Reference Locations) (C# Compiler Options)](../vs140/-lib--csharp-compiler-options-.md).|  
|`AddModules`|Optional `String` parameter.<br /><br /> Specifies one or more modules to be part of the assembly. For more information, see [/addmodule (Import Metadata)](../vs140/-addmodule--csharp-compiler-options-.md).|  
|`AllowUnsafeBlocks`|Optional `Boolean` parameter.<br /><br /> If `true`, compiles code that uses the [unsafe](../vs140/unsafe--csharp-reference-.md) keyword. For more information, see [/unsafe (Enable Unsafe Mode)  (C# Compiler Options)](../vs140/-unsafe--csharp-compiler-options-.md).|  
|`ApplicationConfiguration`|Optional `String` parameter.<br /><br /> Specifies the application configuration file containing the assembly binding settings.|  
|`BaseAddress`|Optional `String` parameter.<br /><br /> Specifies the preferred base address at which to load a DLL. The default base address for a DLL is set by the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] common language runtime. For more information, see [/baseaddress (Specify Base Address of DLL) (C# Compiler Options)](../vs140/-baseaddress--csharp-compiler-options-.md).|  
|`CheckForOverflowUnderflow`|Optional `Boolean` parameter.<br /><br /> Specifies whether integer arithmetic that overflows the bounds of the data type causes an exception at run time. For more information, see [/checked (Check Integer Arithmetic)](../vs140/-checked--csharp-compiler-options-.md).|  
|`CodePage`|Optional `Int32` parameter.<br /><br /> Specifies the code page to use for all source code files in the compilation. For more information, see [/codepage (Specify Code Page for Source Code Files) (C# Compiler Options)](../vs140/-codepage--csharp-compiler-options-.md).|  
|`DebugType`|Optional `String` parameter.<br /><br /> Specifies the debug type. `DebugType` can be `full` or `pdbonly`. The default is `full`, which enables a debugger to be attached to a running program. Specifying `pdbonly` enables source code debugging when the program is started in the debugger, but only displays assembler when the running program is attached to the debugger.<br /><br /> This parameter overrides the `EmitDebugInformation` parameter.<br /><br /> For more information, see [/debug (Emit Debugging Information) (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md).|  
|`DefineConstants`|Optional `String` parameter.<br /><br /> Defines preprocessor symbols. For more information, see [/define (Preprocessor Definition) (C# Compiler Options)](../vs140/-define--csharp-compiler-options-.md).|  
|`DelaySign`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies that you want a fully signed assembly. If `false`, specifies that you only want to place the public key in the assembly.<br /><br /> This parameter has no effect unless used with either the `KeyFile` or `KeyContainer` parameter.<br /><br /> For more information, see [/delaysign (Delay Sign the Assembly) (C# Compiler Options)](../vs140/-delaysign--csharp-compiler-options-.md).|  
|`DisabledWarnings`|Optional `String` parameter.<br /><br /> Specifies the list of warnings to be disabled. For more information, see [/nowarn (Suppress Specified Warnings) (C# Compiler Options)](../vs140/-nowarn--csharp-compiler-options-.md).|  
|`DocumentationFile`|Optional `String` parameter.<br /><br /> Processes documentation comments to an XML file. For more information, see [/doc (Process Documentation Comments) (C# Compiler Options)](../vs140/-doc--csharp-compiler-options-.md).|  
|`EmitDebugInformation`|Optional `Boolean` parameter.<br /><br /> If `true`, the task generates debugging information and places it in a program database (.pdb) file. If `false`, the task emits no debug information. Default is `false`. For more information, see [/debug (Emit Debugging Information) (C# Compiler Options)](../vs140/-debug--csharp-compiler-options-.md).|  
|`ErrorReport`|Optional `String` parameter.<br /><br /> Provides a convenient way to report a C# internal error to Microsoft. This parameter can have a value of `prompt`, `send`, or `none`. If the parameter is set to `prompt`, you will receive a prompt when an internal compiler error occurs. The prompt lets you send a bug report electronically to Microsoft. If the parameter is set to `send`, a bug report is sent automatically. If the parameter is set to `none`, the error is reported only in the text output of the compiler. Default is `none`. For more information, see [/errorreport (Set Error Reporting Behavior)](../vs140/-errorreport--csharp-compiler-options-.md).|  
|`FileAlignment`|Optional `Int32` parameter.<br /><br /> Specifies the size of sections in the output file. For more information, see [/filealign (Specify Section Alignment)](../vs140/-filealign--csharp-compiler-options-.md).|  
|`GenerateFullPaths`|Optional `Boolean` parameter.<br /><br /> If `true`, specifies the absolute path to the file in the compiler output. If `false`, specifies the name of the file. Default is `false`. For more information, see [/fullpaths (Specify Fully Qualified Path in Compiler Output) (C# Compiler Options)](../vs140/-fullpaths--csharp-compiler-options-.md).|  
|`KeyContainer`|Optional `String` parameter.<br /><br /> Specifies the name of the cryptographic key container. For more information, see [/keycontainer (Specify Strong Name Key Container)](../vs140/-keycontainer--csharp-compiler-options-.md).|  
|`KeyFile`|Optional `String` parameter.<br /><br /> Specifies the file name containing the cryptographic key. For more information, see [/keyfile (Specify Strong Name Key File)](../vs140/-keyfile--csharp-compiler-options-.md).|  
|`LangVersion`|Optional `String` parameter.<br /><br /> Specifies the version of the language to use. For more information, see [/langversion (Specify Language Version)](../vs140/-langversion--csharp-compiler-options-.md).|  
|`LinkResources`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Creates a link to a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource in the output file; the resource file is not placed in the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/linkresource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/linkresource (Link to .NET Framework Resource) (C# Compiler Options)](../vs140/-linkresource--csharp-compiler-options-.md).|  
|`MainEntryPoint`|Optional `String` parameter.<br /><br /> Specifies the location of the `Main` method. For more information, see [/main (Specify Location of Main Method) (C# Compiler Options)](../vs140/-main--csharp-compiler-options-.md).|  
|`ModuleAssemblyName`|Optional `String` parameter.<br /><br /> Specifies the name of the assembly that this module will be a part of.|  
|`NoConfig`|Optional `Boolean` parameter.<br /><br /> If `true`, tells the compiler not to compile with the csc.rsp file. For more information, see [/noconfig (Ignore csc.rsp)](../vs140/-noconfig--csharp-compiler-options-.md).|  
|`NoLogo`|Optional `Boolean` parameter.<br /><br /> If `true`, suppresses display of compiler banner information. For more information, see [/nologo (Suppress Banner Information) (C# Compiler Options)](../vs140/-nologo--csharp-compiler-options-.md).|  
|`NoStandardLib`|Optional `Boolean` parameter.<br /><br /> If `true`, prevents the import of mscorlib.dll, which defines the entire System namespace. Use this parameter if you want to define or create your own System namespace and objects. For more information, see [/nostdlib (Do Not Import Standard Library)](../vs140/-nostdlib--csharp-compiler-options-.md).|  
|`NoWin32Manifest`|Optional `Boolean` parameter.<br /><br /> If `true`, do not include the default Win32 manifest.|  
|`Optimize`|Optional `Boolean` parameter.<br /><br /> If `true`, enables optimizations. If `false`, disables optimizations. For more information, see [/optimize (Enable/Disable Optimizations) (C# Compiler Options)](../vs140/-optimize--csharp-compiler-options-.md).|  
|`OutputAssembly`|Optional `String` output parameter.<br /><br /> Specifies the name of the output file. For more information, see [/out (Set Output File Name) (C# Compiler Options)](../vs140/-out--csharp-compiler-options-.md).|  
|`PdbFile`|Optional `String` parameter.<br /><br /> Specifies the debug information file name. The default name is the output file name with a .pdb extension.|  
|`Platform`|Optional `String` parameter.<br /><br /> Specifies the processor platform to be targeted by the output file. This parameter can have a value of `x86`, `x64`, or `anycpu`. Default is `anycpu`. For more information, see [/platform (Specify Output Platform)](../vs140/-platform--csharp-compiler-options-.md).|  
|`References`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Causes the task to import public type information from the specified items into the current project. For more information, see [/reference (Import Metadata) (C# Compiler Options)](../vs140/-reference--csharp-compiler-options-.md).<br /><br /> You can specify a [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] reference alias in an [!INCLUDE[vstecmsbuild](../vs140/includes/vstecmsbuild_md.md)] file by adding the metadata `Aliases` to the original "Reference" item. For example, to set the alias "LS1" in the following CSC command line:<br /><br /> `csc /r:LS1=MyCodeLibrary.dll /r:LS2=MyCodeLibrary2.dll *.cs`<br /><br /> you would use:<br /><br /> `<Reference Include="MyCodeLibrary"> <Aliases>LS1</Aliases> </Reference>`|  
|`Resources`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Embeds a [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] resource into the output file.<br /><br /> Items passed into this parameter can have optional metadata entries named `LogicalName` and `Access`. `LogicalName` corresponds to the `identifier` parameter of the `/resource` switch, and `Access` corresponds to `accessibility-modifier` parameter. For more information, see [/resource (Embed Resource File to Output) (C# Compiler Options)](../vs140/-resource--csharp-compiler-options-.md).|  
|`ResponseFiles`|Optional `String` parameter.<br /><br /> Specifies the response file that contains commands for this task. For more information, see [@ (Specify Response File) (C# Compiler Options)](../vs140/@--csharp-compiler-options-.md).|  
|`Sources`|Optional <xref:Microsoft.Build.Framework.ITaskItem*>`[]` parameter.<br /><br /> Specifies one or more [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] source files.|  
|`TargetType`|Optional `String` parameter.<br /><br /> Specifies the file format of the output file. This parameter can have a value of `library`, which creates a code library, `exe`, which creates a console application, `module`, which creates a module, or `winexe`, which creates a Windows program. The default value is `library`. For more information, see [/target (Specify Output File Format) (C# Compiler Options)](../vs140/-target--csharp-compiler-options-.md).|  
|`TreatWarningsAsErrors`|Optional `Boolean` parameter.<br /><br /> If `true`, treats all warnings as errors. For more information, see [/warnaserror (Treat Warnings as Errors) (C# Compiler Options)](../vs140/-warnaserror--csharp-compiler-options-.md).|  
|`UseHostCompilerIfAvailable`|Optional `Boolean` parameter.<br /><br /> Instructs the task to use the in-process compiler object, if available. Used only by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)].|  
|`Utf8Output`|Optional `Boolean` parameter.<br /><br /> Logs compiler output using UTF-8 encoding. For more information, see [/utf8output (Display Compiler Messages with UTF-8) (C# Compiler Options)](../vs140/-utf8output--csharp-compiler-options-.md).|  
|`WarningLevel`|Optional `Int32` parameter.<br /><br /> Specifies the warning level for the compiler to display. For more information, see [/warn (Specify Warning Level) (C# Compiler Options)](../vs140/-warn--csharp-compiler-options-.md).|  
|`WarningsAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings to treat as errors. For more information, see [/warnaserror (Treat Warnings as Errors) (C# Compiler Options)](../vs140/-warnaserror--csharp-compiler-options-.md).<br /><br /> This parameter overrides the `TreatWarningsAsErrors` parameter.|  
|`WarningsNotAsErrors`|Optional `String` parameter.<br /><br /> Specifies a list of warnings that are not treated as errors. For more information, see [/warnaserror (Treat Warnings as Errors) (C# Compiler Options)](../vs140/-warnaserror--csharp-compiler-options-.md).<br /><br /> This parameter is only useful if the `TreatWarningsAsErrors` parameter is set to `true`.|  
|`Win32Icon`|Optional `String` parameter.<br /><br /> Inserts an .ico file in the assembly, which gives the output file the desired appearance in File Explorer. For more information, see [/win32icon (Import an .ico File)](../vs140/-win32icon--csharp-compiler-options-.md).|  
|`Win32Manifest`|Optional `String` parameter.<br /><br /> Specifies the Win32 manifest to be included.|  
|`Win32Resource`|Optional `String` parameter.<br /><br /> Inserts a Win32 resource (.res) file in the output file. For more information, see [/win32res (Import a Win32 Resource File) (C# Compiler Options)](../vs140/-win32res--csharp-compiler-options-.md).|  
  
## Remarks  
 In addition to the parameters listed above, this task inherits parameters from the `Microsoft.Build.Tasks.ManagedCompiler` class, which inherits from the <xref:Microsoft.Build.Tasks.ToolTaskExtension*> class, which itself inherits from the <xref:Microsoft.Build.Utilities.ToolTask*> class. For a list of these additional parameters and their descriptions, see [ToolTaskExtension Base Class](../vs140/tooltaskextension-base-class.md).  
  
## Example  
 The following example uses the `Csc` task to compile an executable from the source files in the `Compile` item collection.  
  
```  
<CSC  
    Sources="@(Compile)"  
    OutputAssembly="$(AppName).exe"  
    EmitDebugInformation="true" />  
```  
  
## See Also  
 [MSBuild Task Reference](../vs140/msbuild-task-reference.md)   
 [MSBuild Tasks](../vs140/msbuild-tasks.md)