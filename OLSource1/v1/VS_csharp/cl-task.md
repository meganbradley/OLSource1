---
title: "CL Task"
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
  - "VC.Project.VCCLCompilerTool.UseUnicodeForAssemblerListing"
  - "vc.task.cl"
  - "VC.Project.VCCLCompilerTool.TreatSpecificWarningsAsErrors"
  - "VC.Project.VCCLCompilerTool.CreateHotpatchableImage"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "jsharp"
helpviewer_keywords: 
  - "MSBuild (Visual C++), CL task"
  - "CL task (MSBuild (Visual C++))"
ms.assetid: 651ba971-b755-4f03-a549-4816beb3cc0d
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CL Task
Wraps the Visual C++ compiler tool, cl.exe. The compiler produces executable (.exe) files, dynamic-link library (.dll) files, or code module (.netmodule) files. For more information, see [Compiler Options](../VS_csharp/compiler-options.md).  
  
## Parameters  
 The following table describes the parameters of the **CL** task. Most task parameters, and a few sets of parameters, correspond to a command-line option.  
  
-   **AdditionalIncludeDirectories**  
  
     Optional String[] parameter.  
  
     Adds a directory to the list of directories that are searched for include files.  
  
     For more information, see [/I (Additional Include Directories)](../VS_csharp/-i--additional-include-directories-.md).  
  
-   **AdditionalOptions**  
  
     Optional String parameter.  
  
     A list of command-line options. For example, "/*option1* /*option2* /*option#*". Use this parameter to specify command-line options that are not represented by any other task parameter.  
  
     For more information, see [Compiler Options](../VS_csharp/compiler-options.md).  
  
-   **AdditionalUsingDirectories**Optional String[] parameter.  
  
     Specifies a directory that the compiler will search to resolve file references passed to the **#using** directive.  
  
     For more information, see [/AI (Specify Metadata Directories)](../VS_csharp/-ai--specify-metadata-directories-.md).  
  
-   **AlwaysAppend**  
  
     Optional String parameter.  
  
     A string that always gets emitted on the command line. Its default value is "**/c**".  
  
-   **AssemblerListingLocation**  
  
     Creates a listing file that contains assembly code.  
  
     For more information, see the **/Fa** option in [/FA, /Fa (Listing File)](../VS_csharp/-fa---fa--listing-file-.md).  
  
-   **AssemblerOutput**  
  
     Optional String parameter.  
  
     Creates a listing file that contains assembly code.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NoListing** - *<none\>*  
  
    -   **AssemblyCode** - **/FA**  
  
    -   **AssemblyAndMachineCode** - **/FAc**  
  
    -   **AssemblyAndSourceCode** - **/FAs**  
  
    -   **All** - **/FAcs**  
  
     For more information, see the **/FA**, **/FAc**, **/FAs**, and **/FAcs** options in [/FA, /Fa (Listing File)](../VS_csharp/-fa---fa--listing-file-.md).  
  
-   **BasicRuntimeChecks**  
  
     Optional String parameter.  
  
     Enables and disables the run-time error checks feature, in conjunction with the [runtime_checks](../VS_csharp/runtime_checks.md) pragma.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** -                          *<none\>*  
  
    -   **StackFrameRuntimeCheck** - **/RTCs**  
  
    -   **UninitializedLocalUsageCheck** - **/RTCu**  
  
    -   **EnableFastChecks** -                          **/RTC1**  
  
     For more information, see [/RTC (Run-Time Error Checks)](../VS_csharp/-rtc--run-time-error-checks-.md).  
  
-   **BrowseInformation**  
  
     Optional Boolean parameter.  
  
     If `true`, creates a browse information file.  
  
     For more information, see the **/FR** option in [/FR, /Fr (Create .sbr File)](../VS_csharp/-fr---fr--create-.sbr-file-.md).  
  
-   **BrowseInformationFile**  
  
     Optional String parameter.  
  
     Specifies a file name for the browse information file.  
  
     For more information, see the **BrowseInformation** parameter in this table, and also see [/FR, /Fr (Create .sbr File)](../VS_csharp/-fr---fr--create-.sbr-file-.md).  
  
-   **BufferSecurityCheck**  
  
     Optional Boolean parameter.  
  
     If `true`, detects some buffer overruns that overwrite the return address, a common technique for exploiting code that does not enforce buffer size restrictions.  
  
     For more information, see [/GS (Buffer Security Check)](../VS_csharp/-gs--buffer-security-check-.md).  
  
-   **BuildingInIDE**  
  
     Optional Boolean parameter.  
  
     If `true`, indicates that **MSBuild** is invoked by the IDE. Otherwise, **MSBuild** is invoked on the command line.  
  
-   **CallingConvention**  
  
     Optional String parameter.  
  
     Specifies the calling convention, which determines the order in which function arguments are pushed onto the stack, whether the caller function or called function removes the arguments from the stack at the end of the call, and the name-decorating convention that the compiler uses to identify individual functions.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Cdecl** - **/Gd**  
  
    -   **FastCall** -                          **/Gr**  
  
    -   **StdCall** -                          **/Gz**  
  
     For more information, see [/Gd, /Gr, /Gz (Calling Convention)](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md).  
  
-   **CompileAs**  
  
     Optional String parameter.  
  
     Specifies whether to compile the input file as a C or C++ source file.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - *<none\>*  
  
    -   **CompileAsC** - **/TC**  
  
    -   **CompileAsCpp** - **/TP**  
  
     For more information, see [/Tc, /Tp, /TC, /TP (Specify Source File Type)](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md).  
  
-   **CompileAsManaged**  
  
     Optional String parameter.  
  
     Enables applications and components to use features from the common language runtime (CLR).  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **false** - *<none\>*  
  
    -   **true** - **/clr**  
  
    -   **Pure** - **/clr:pure**  
  
    -   **Safe** - **/clr:safe**  
  
    -   **OldSyntax** - **/clr:oldSyntax**  
  
     For more information, see [/clr (Common Language Runtime Compilation)](../VS_csharp/-clr--common-language-runtime-compilation-.md).  
  
-   **CreateHotpatchableImage**  
  
     Optional Boolean parameter.  
  
     If `true`, tells the compiler to prepare an image for *hot patching*. This parameter ensures that the first instruction of each function is two bytes, which is required for hot patching.  
  
     For more information, see [/hotpatch (Create Hotpatchable Image)](../VS_csharp/-hotpatch--create-hotpatchable-image-.md).  
  
-   **DebugInformationFormat**  
  
     Optional String parameter.  
  
     Selects the type of debugging information created for your program and whether this information is kept in object (.obj) files or in a program database (PDB).  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **OldStyle** - **/Z7**  
  
    -   **ProgramDatabase** - **/Zi**  
  
    -   **EditAndContinue** - **/ZI**  
  
     For more information, see [/Z7, /Zi, /ZI (Debug Information Format)](../VS_csharp/-z7---zi---zi--debug-information-format-.md).  
  
-   **DisableLanguageExtensions**  
  
     Optional Boolean parameter.  
  
     If **true**, tells the compiler to emit an error for language constructs that are not compatible with either ANSI C or ANSI C++.  
  
     For more information, see the **/Za** option in [/Za, /Ze (Disable Language Extensions)](../VS_csharp/-za---ze--disable-language-extensions-.md).  
  
-   **DisableSpecificWarnings**  
  
     Optional String[] parameter.  
  
     Disables the warning numbers that are specified in a semicolon-delimited list.  
  
     For more information, see the `/wd` option in [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
-   **EnableEnhancedInstructionSet**  
  
     Optional String parameter.  
  
     Specifies the architecture for code generation that uses the Streaming SIMD Extensions (SSE) and Streaming SIMD Extensions 2 (SSE2) instructions.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **StreamingSIMDExtensions** - **/arch:SSE**  
  
    -   **StreamingSIMDExtensions2** - **/arch:SSE2**  
  
     For more information, see [/arch (Minimum CPU Architecture)](../VS_csharp/-arch--x86-.md).  
  
-   **EnableFiberSafeOptimizations**  
  
     Optional Boolean parameter.  
  
     If `true`, support fiber safety for data allocated by using static thread-local storage, that is, data allocated by using `__declspec(thread)`.  
  
     For more information, see [/GT (Support Fiber-Safe Thread-Local Storage)](../VS_csharp/-gt--support-fiber-safe-thread-local-storage-.md).  
  
-   **EnablePREfast**  
  
     Optional Boolean parameter.  
  
     If `true`, enable code analysis.  
  
     For more information, see [/analyze (Enterprise Code Analysis)](../VS_csharp/-analyze--code-analysis-.md).  
  
-   **ErrorReporting**  
  
     Optional String parameter.  
  
     Lets you provide internal compiler error (ICE) information directly to Microsoft. By default, the setting in IDE builds is **Prompt** and the setting in command-line builds is **Queue**.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **None** - **/errorReport:none**  
  
    -   **Prompt** - **/errorReport:prompt**  
  
    -   **Queue** - **/errorReport:queue**  
  
    -   **Send** - **/errorReport:send**  
  
     For more information, see [/errorReport (Report Internal Compiler Errors)](../VS_csharp/-errorreport--report-internal-compiler-errors-.md).  
  
-   **ExceptionHandling**  
  
     Optional String parameter.  
  
     Specifies the model of exception handling to be used by the compiler.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **false** - *<none\>*  
  
    -   **Async** - **/EHa**  
  
    -   **Sync** - **/EHsc**  
  
    -   **SyncCThrow** - **/EHs**  
  
     For more information, see [/EH (Exception Handling Model)](../VS_csharp/-eh--exception-handling-model-.md).  
  
-   **ExpandAttributedSource**  
  
     Optional Boolean parameter.  
  
     If `true`, creates a listing file that has expanded attributes injected into the source file.  
  
     For more information, see [/Fx (Merge Injected Code)](../VS_csharp/-fx--merge-injected-code-.md).  
  
-   **FavorSizeOrSpeed**  
  
     Optional String parameter.  
  
     Specifies whether to favor code size or code speed.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Neither** - *<none\>*  
  
    -   **Size** - **/Os**  
  
    -   **Speed** - **/Ot**  
  
     For more information, see [/Os, /Ot (Favor Small Code, Favor Fast Code)](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md).  
  
-   **FloatingPointExceptions**  
  
     Optional Boolean parameter.  
  
     If `true`, enables the reliable floating-point exception model. Exceptions will be raised immediately after they are triggered.  
  
     For more information, see the /**fp:except** option in [/fp (Specify Floating-Point Behavior)](../VS_csharp/-fp--specify-floating-point-behavior-.md).  
  
-   **FloatingPointModel**  
  
     Optional String parameter.  
  
     Sets the floating point model.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Precise** - **/fp:precise**  
  
    -   **Strict** - **/fp:strict**  
  
    -   **Fast** - **/fp:fast**  
  
     For more information, see [/fp (Specify Floating-Point Behavior)](../VS_csharp/-fp--specify-floating-point-behavior-.md).  
  
-   **ForceConformanceInForLoopScope**  
  
     Optional Boolean parameter.  
  
     If `true`, implements standard C++ behavior in [for](../VS_csharp/for-statement--c---.md) loops that use Microsoft extensions ([/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md)).  
  
     For more information, see [/Zc:forScope (Force Conformance in for Loop Scope)](../VS_csharp/-zc-forscope--force-conformance-in-for-loop-scope-.md).  
  
-   **ForcedIncludeFiles**  
  
     Optional `String[]` parameter.  
  
     Causes the preprocessor to process one or more specified header files.  
  
     For more information, see [/FI (Name Forced Include File)](../VS_csharp/-fi--name-forced-include-file-.md).  
  
-   **ForcedUsingFiles**  
  
     Optional **String[]** parameter.  
  
     Causes the preprocessor to process one or more specified **#using** files.  
  
     For more information, see [/FU (Name Forced #using File)](../VS_csharp/-fu--name-forced-sharpusing-file-.md).  
  
-   **FunctionLevelLinking**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables the compiler to package individual functions in the form of packaged functions (COMDATs).  
  
     For more information, see [/Gy (Enable Function-Level Linking)](../VS_csharp/-gy--enable-function-level-linking-.md).  
  
-   **GenerateXMLDocumentationFiles**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to process documentation comments in source code files and to create an .xdc file for each source code file that has documentation comments.  
  
     For more information, see [/doc (Process Documentation Comments) (C/C++)](../VS_csharp/-doc--process-documentation-comments---c-c---.md). Also see the **XMLDocumentationFileName** parameter in this table.  
  
-   **IgnoreStandardIncludePath**  
  
     Optional `Boolean` parameter.  
  
     If `true`, prevents the compiler from searching for include files in directories specified in the PATH and INCLUDE environment variables.  
  
     For more information, see [/X (Ignore Standard Include Paths)](../VS_csharp/-x--ignore-standard-include-paths-.md).  
  
-   **InlineFunctionExpansion**  
  
     Optional **String** parameter.  
  
     Specifies the level of inline function expansion for the build.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - *<none\>*  
  
    -   **Disabled** - **/Ob0**  
  
    -   **OnlyExplicitInline** - **/Ob1**  
  
    -   **AnySuitable** - **/Ob2**  
  
     For more information, see [/Ob (Inline Function Expansion)](../VS_csharp/-ob--inline-function-expansion-.md).  
  
-   **IntrinsicFunctions**  
  
     Optional `Boolean` parameter.  
  
     If `true`, replaces some function calls with intrinsic or otherwise special forms of the function that help your application run faster.  
  
     For more information, see [/Oi (Generate Intrinsic Functions)](../VS_csharp/-oi--generate-intrinsic-functions-.md).  
  
-   **MinimalRebuild**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables minimal rebuild, which determines whether C++ source files that include changed C++ class definitions (stored in header (.h) files) must be recompiled.  
  
     For more information, see [/Gm (Enable Minimal Rebuild)](../VS_csharp/-gm--enable-minimal-rebuild-.md).  
  
-   **MultiProcessorCompilation**  
  
     Optional `Boolean` parameter.  
  
     If `true`, use multiple processors to compile. This parameter creates a process for each effective processor on your computer.  
  
     For more information, see [/MP (Build with Multiple Processes)](../VS_csharp/-mp--build-with-multiple-processes-.md). Also, see the **ProcessorNumber** parameter in this table.  
  
-   **ObjectFileName**  
  
     Optional **String** parameter.  
  
     Specifies an object (.obj) file name or directory to be used instead of the default.  
  
     For more information, see [/Fo (Object File Name)](../VS_csharp/-fo--object-file-name-.md).  
  
-   **ObjectFiles**  
  
     Optional **String[]** parameter.  
  
     A list of object files.  
  
-   **OmitDefaultLibName**  
  
     Optional `Boolean` parameter.  
  
     If `true`, omits the default C run-time library name from the object (.obj) file. By default, the compiler puts the name of the library into the .obj file to direct the linker to the correct library.  
  
     For more information, see [/Zl (Omit Default Library Name)](../VS_csharp/-zl--omit-default-library-name-.md).  
  
-   **OmitFramePointers**  
  
     Optional `Boolean` parameter.  
  
     If `true`, suppresses creation of frame pointers on the call stack.  
  
     For more information, see [/Oy (Frame-Pointer Omission)](../VS_csharp/-oy--frame-pointer-omission-.md).  
  
-   **OpenMPSupport**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to process OpenMP clauses and directives.  
  
     For more information, see [/openmp (Enable OpenMP 2.0 Support)](../VS_csharp/-openmp--enable-openmp-2.0-support-.md).  
  
-   **Optimization**  
  
     Optional **String** parameter.  
  
     Specifies various code optimizations for speed and size.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Disabled** - **/Od**  
  
    -   **MinSpace** - **/O1**  
  
    -   **MaxSpeed** - **/O2**  
  
    -   **Full** - **/Ox**  
  
     For more information, see [/O Options (Optimize Code)](../VS_csharp/-o-options--optimize-code-.md).  
  
-   **PrecompiledHeader**  
  
     Optional **String** parameter.  
  
     Create or use a precompiled header (.pch) file during the build.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **NotUsing** - *<none\>*  
  
    -   **Create** - **/Yc**  
  
    -   **Use** - **/Yu**  
  
     For more information, see [/Yc (Create Precompiled Header File)](../VS_csharp/-yc--create-precompiled-header-file-.md) and [/Yu (Use Precompiled Header File)](../VS_csharp/-yu--use-precompiled-header-file-.md). Also, see the **PrecompiledHeaderFile** and **PrecompiledHeaderOutputFile** parameters in this table.  
  
-   **PrecompiledHeaderFile**  
  
     Optional **String** parameter.  
  
     Specifies a precompiled header file name to create or use.  
  
     For more information, see [/Yc (Create Precompiled Header File)](../VS_csharp/-yc--create-precompiled-header-file-.md) and [/Yu (Use Precompiled Header File)](../VS_csharp/-yu--use-precompiled-header-file-.md).  
  
-   **PrecompiledHeaderOutputFile**  
  
     Optional **String** parameter.  
  
     Specifies a path name for a precompiled header instead of using the default path name.  
  
     For more information, see [/Fp (Name .pch File)](../VS_csharp/-fp--name-.pch-file-.md).  
  
-   **PreprocessKeepComments**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preserves comments during preprocessing.  
  
     For more information, see [/C (Preserve Comments During Preprocessing)](../VS_csharp/-c--preserve-comments-during-preprocessing-.md).  
  
-   **PreprocessorDefinitions**  
  
     Optional `String[]` parameter.  
  
     Defines a preprocessing symbol for your source file.  
  
     For more information, see [/D (Preprocessor Definitions)](../VS_csharp/-d--preprocessor-definitions-.md).  
  
-   **PreprocessOutput**  
  
     Optional `ITaskItem[]` parameter.  
  
     Defines an array of preprocessor output items that can be consumed and emitted by tasks.  
  
-   **PreprocessOutputPath**  
  
     Optional `String` parameter.  
  
     Specifies the name of the output file to which the **PreprocessToFile** parameter writes preprocessed output.  
  
     For more information, see [/Fi (Preprocess Output File Name)](../VS_csharp/-fi--preprocess-output-file-name-.md).  
  
-   **PreprocessSuppressLineNumbers**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preprocesses C and C++ source files and copies the preprocessed files to the standard output device.  
  
     For more information, see [/EP (Preprocess to stdout Without #line Directives)](../VS_csharp/-ep--preprocess-to-stdout-without-sharpline-directives-.md).  
  
-   **PreprocessToFile**  
  
     Optional `Boolean` parameter.  
  
     If `true`, preprocesses C and C++ source files and writes the preprocessed output to a file.  
  
     For more information, see [/P (Preprocess to a File)](../VS_csharp/-p--preprocess-to-a-file-.md).  
  
-   **ProcessorNumber**  
  
     Optional `Integer` parameter.  
  
     Specifies the maximum number of processors to use in a multiprocessor compilation. Use this parameter in combination with the **MultiProcessorCompilation** parameter.  
  
-   **ProgramDataBaseFileName**  
  
     Optional `String` parameter.  
  
     Specifies a file name for the program database (PDB) file.  
  
     For more information, see [/Fd (Program Database File Name)](../VS_csharp/-fd--program-database-file-name-.md).  
  
-   **RuntimeLibrary**  
  
     Optional `String` parameter.  
  
     Indicates whether a multithreaded module is a DLL, and selects retail or debug versions of the run-time library.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **MultiThreaded** - **/MT**  
  
    -   **MultiThreadedDebug** - **/MTd**  
  
    -   **MultiThreadedDLL** - **/MD**  
  
    -   **MultiThreadedDebugDLL** - **/MDd**  
  
     For more information, see [/MD, /MT, /LD (Use Run-Time Library)](../VS_csharp/-md---mt---ld--use-run-time-library-.md).  
  
-   **RuntimeTypeInfo**  
  
     Optional `Boolean` parameter.  
  
     If `true`, adds code to check C++ object types at run time (run-time type information).  
  
     For more information, see [/GR (Enable Run-Time Type Information)](../VS_csharp/-gr--enable-run-time-type-information-.md).  
  
-   **ShowIncludes**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the compiler to output a list of the include files.  
  
     For more information, see [/showIncludes (List Include Files)](../VS_csharp/-showincludes--list-include-files-.md).  
  
-   **SmallerTypeCheck**  
  
     Optional `Boolean` parameter.  
  
     If `true`, reports a run-time error if a value is assigned to a smaller data type and causes a data loss.  
  
     For more information, see the **/RTCc** option in [/RTC (Run-Time Error Checks)](../VS_csharp/-rtc--run-time-error-checks-.md).  
  
-   **Sources**  
  
     Required `ITaskItem[]` parameter.  
  
     Specifies a list of source files separated by spaces.  
  
-   **StringPooling**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables the compiler to create one copy of identical strings in the program image.  
  
     For more information, see [/GF (Eliminate Duplicate Strings)](../VS_csharp/-gf--eliminate-duplicate-strings-.md).  
  
-   **StructMemberAlignment**  
  
     Optional `String` parameter.  
  
     Specifies the byte alignment for all members in a structure.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **Default** - **/Zp1**  
  
    -   **1Byte** - **/Zp1**  
  
    -   **2Bytes** - **/Zp2**  
  
    -   **4Bytes** - **/Zp4**  
  
    -   **8Bytes** - **/Zp8**  
  
    -   **16Bytes** - **/Zp16**  
  
     For more information, see [/Zp (Struct Member Alignment)](../VS_csharp/-zp--struct-member-alignment-.md).  
  
-   **SuppressStartupBanner**  
  
     Optional `Boolean` parameter.  
  
     If `true`, prevents the display of the copyright and version number message when the task starts.  
  
     For more information, see [/nologo (Suppress Startup Banner) (C/C++)](../VS_csharp/-nologo--suppress-startup-banner---c-c---.md).  
  
-   **TrackerLogDirectory**  
  
     Optional `String` parameter.  
  
     Specifies the intermediate directory where tracking logs for this task are stored.  
  
     For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
-   **TreatSpecificWarningsAsErrors**  
  
     Optional **String[]** parameter.  
  
     Treats the specified list of compiler warnings as errors.  
  
     For more information, see the **/we**`n` option in [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
-   **TreatWarningAsError**  
  
     Optional `Boolean` parameter.  
  
     If `true`, treat all compiler warnings as errors.  
  
     For more information, see **/WX** option in [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
-   **TreatWChar_tAsBuiltInType**  
  
     Optional `Boolean` parameter.  
  
     If `true`, treat the `wchar_t` type as a native type.  
  
     For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](../VS_csharp/-zc-wchar_t--wchar_t-is-native-type-.md).  
  
-   **UndefineAllPreprocessorDefinitions**  
  
     Optional `Boolean` parameter.  
  
     If `true`, undefines the Microsoft-specific symbols that the compiler defines.  
  
     For more information, see the **/u** option in [/U, /u (Undefine Symbols)](../VS_csharp/-u---u--undefine-symbols-.md).  
  
-   **UndefinePreprocessorDefinitions**  
  
     Optional `String[]` parameter.  
  
     Specifies a list of one or more preprocessor symbols to undefine.  
  
     For more information, see **/U** option in [/U, /u (Undefine Symbols)](../VS_csharp/-u---u--undefine-symbols-.md).  
  
-   **UseFullPaths**  
  
     Optional `Boolean` parameter.  
  
     If `true`, displays the full path of source code files passed to the compiler in diagnostics.  
  
     For more information, see [/FC (Full Path of Source Code File in Diagnostics)](../VS_csharp/-fc--full-path-of-source-code-file-in-diagnostics-.md).  
  
-   **UseUnicodeForAssemblerListing**  
  
     Optional `Boolean` parameter.  
  
     If `true`, causes the output file to be created in UTF-8 format.  
  
     For more information, see the **/FAu** option in [/FA, /Fa (Listing File)](../VS_csharp/-fa---fa--listing-file-.md).  
  
-   **WarningLevel**  
  
     Optional `String` parameter.  
  
     Specifies the highest level of warning that is to be generated by the compiler.  
  
     Specify one of the following values, each of which corresponds to a command-line option.  
  
    -   **TurnOffAllWarnings** - **/W0**  
  
    -   **Level1** - **/W1**  
  
    -   **Level2** - **/W2**  
  
    -   **Level3** - **/W3**  
  
    -   **Level4** - **/W4**  
  
    -   **EnableAllWarnings** - **/Wall**  
  
     For more information, see the **/W***n* option in [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md).  
  
-   **WholeProgramOptimization**  
  
     Optional `Boolean` parameter.  
  
     If `true`, enables whole program optimization.  
  
     For more information, see [/GL (Whole Program Optimization)](../VS_csharp/-gl--whole-program-optimization-.md).  
  
-   **XMLDocumentationFileName**  
  
     Optional `String` parameter.  
  
     Specifies the name of the generated XML documentation files. This parameter can be a file or directory name.  
  
     For more information, see the `name` argument in [/doc (Process Documentation Comments) (C/C++)](../VS_csharp/-doc--process-documentation-comments---c-c---.md). Also see the **GenerateXMLDocumentationFiles** parameter in this table.  
  
-   **MinimalRebuildFromTracking**  
  
     Optional `Boolean` parameter.  
  
     If `true`, a tracked incremental build is performed; if `false`, a rebuild is performed.  
  
-   **TLogReadFiles**  
  
     Optional `ITaskItem[]` parameter.  
  
     Specifies an array of items that represent the *read file tracking logs*.  
  
     A read-file tracking log (.tlog) contains the names of the input files that are read by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
-   **TLogWriteFiles**  
  
     Optional `ITaskItem[]` parameter.  
  
     Specifies an array of items that represent the *write file tracking logs*.  
  
     A write-file tracking log (.tlog) contains the names of the output files that are written by a task, and is used by the project build system to support incremental builds. For more information, see the **TrackerLogDirectory** and **TrackFileAccess** parameters in this table.  
  
-   **TrackFileAccess**  
  
     Optional `Boolean` parameter.  
  
     If `true`, tracks file access patterns.  
  
     For more information, see the **TLogReadFiles** and **TLogWriteFiles** parameters in this table.  
  
## Remarks  
  
## See Also  
 [MSBuild Task Reference](../VS_csharp/msbuild-task-reference.md)