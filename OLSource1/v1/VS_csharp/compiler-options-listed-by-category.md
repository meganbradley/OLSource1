---
title: "Compiler Options Listed by Category"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "compiler options, C++"
ms.assetid: c4750dcf-dba0-4229-99b6-45cdecc11729
caps.latest.revision: 68
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Options Listed by Category
This article contains a categorical list of compiler options. For an alphabetical list, see [Compiler Options Listed Alphabetically](../VS_csharp/compiler-options-listed-alphabetically.md).  
  
### Optimization  
  
|Option|Purpose|  
|------------|-------------|  
|[/O1](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md)|Creates small code.|  
|[/O2](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md)|Creates fast code.|  
|[/Ob](../VS_csharp/-ob--inline-function-expansion-.md)|Controls inline expansion.|  
|[/Od](../VS_csharp/-od--disable--debug--.md)|Disables optimization.|  
|[/Og](../VS_csharp/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[/Oi](../VS_csharp/-oi--generate-intrinsic-functions-.md)|Generates intrinsic functions.|  
|[/Os](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md)|Favors small code.|  
|[/Ot](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md)|Favors fast code.|  
|[/Ox](../VS_csharp/-ox--full-optimization-.md)|Uses maximum optimization (/Ob2gity /Gs).|  
|[/Oy](../VS_csharp/-oy--frame-pointer-omission-.md)|Omits frame pointer. (x86 only)|  
|[/favor](../VS_csharp/-favor--optimize-for-architecture-specifics-.md)|Produces code that is optimized for a specified architecture, or for a range of architectures.|  
  
### Code Generation  
  
|Option|Purpose|  
|------------|-------------|  
|[/arch](../VS_csharp/-arch--x86-.md)|Use SSE or SSE2 instructions in code generation. (x86 only)|  
|[/clr](../VS_csharp/-clr--common-language-runtime-compilation-.md)|Produces an output file to run on the common language runtime.|  
|[/EH](../VS_csharp/-eh--exception-handling-model-.md)|Specifies the model of exception handling.|  
|[/fp](../VS_csharp/-fp--specify-floating-point-behavior-.md)|Specifies floating-point behavior.|  
|[/GA](../VS_csharp/-ga--optimize-for-windows-application-.md)|Optimizes for Windows applications.|  
|[/Gd](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__cdecl` calling convention. (x86 only)|  
|[/Ge](../VS_csharp/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes.|  
|[/GF](../VS_csharp/-gf--eliminate-duplicate-strings-.md)|Enables string pooling.|  
|[/Gh](../VS_csharp/-gh--enable-_penter-hook-function-.md)|Calls hook function `_penter`.|  
|[/GH](../VS_csharp/-gh--enable-_pexit-hook-function-.md)|Calls hook function `_pexit`.|  
|[/GL](../VS_csharp/-gl--whole-program-optimization-.md)|Enables whole program optimization.|  
|[/Gm](../VS_csharp/-gm--enable-minimal-rebuild-.md)|Enables minimal rebuild.|  
|[/GR](../VS_csharp/-gr--enable-run-time-type-information-.md)|Enables run-time type information (RTTI).|  
|[/Gr](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__fastcall` calling convention. (x86 only)|  
|[/GS](../VS_csharp/-gs--buffer-security-check-.md)|Checks buffer security.|  
|[/Gs](../VS_csharp/-gs--control-stack-checking-calls-.md)|Controls stack probes.|  
|[/GT](../VS_csharp/-gt--support-fiber-safe-thread-local-storage-.md)|Supports fiber safety for data allocated by using static thread-local storage.|  
|[/guard:cf](../VS_csharp/-guard--enable-control-flow-guard-.md)|Adds control flow guard security checks.|  
|[/Gv](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__vectorcall` calling convention. (x86 and x64 only)|  
|[/Gw](../VS_csharp/-gw--optimize-global-data-.md)|Enables whole-program global data optimization.|  
|[/GX](../VS_csharp/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../VS_csharp/-eh--exception-handling-model-.md) instead.|  
|[/Gy](../VS_csharp/-gy--enable-function-level-linking-.md)|Enables function-level linking.|  
|[/GZ](../VS_csharp/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Enables fast checks. (Same as [/RTC1](../VS_csharp/-rtc--run-time-error-checks-.md))|  
|[/Gz](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__stdcall` calling convention. (x86 only)|  
|[/homeparams](../VS_csharp/-homeparams--copy-register-parameters-to-stack-.md)|Forces parameters passed in registers to be written to their locations on the stack upon function entry. This compiler option is only for the [!INCLUDE[vcprx64](../VS_csharp/includes/vcprx64_md.md)] compilers (native and cross compile).|  
|[/hotpatch](../VS_csharp/-hotpatch--create-hotpatchable-image-.md)|Creates a hotpatchable image.|  
|[/Qfast_transcendentals](../VS_csharp/-qfast_transcendentals--force-fast-transcendentals-.md)|Generates fast transcendentals.|  
|[QIfist](../VS_csharp/-qifist--suppress-_ftol-.md)|Deprecated. Suppresses the call of the helper function `_ftol` when a conversion from a floating-point type to an integral type is required. (x86 only)|  
|[/Qimprecise_fwaits](../VS_csharp/-qimprecise_fwaits--remove-fwaits-inside-try-blocks-.md)|Removes `fwait` commands inside `try` blocks.|  
|[/Qpar](../VS_csharp/-qpar--auto-parallelizer-.md)|Enables automatic parallelization of loops.|  
|[/Qpar-report](../VS_csharp/-qpar-report--auto-parallelizer-reporting-level-.md)|Enables reporting levels for automatic parallelization.|  
|[/Qsafe_fp_loads](../VS_csharp/-qsafe_fp_loads.md)|Uses integer move instructions for floating-point values and disables certain floating point load optimizations.|  
|[/Qvec-report (Auto-Vectorizer)](../VS_csharp/-qvec-report--auto-vectorizer-reporting-level-.md)|Enables reporting levels for automatic vectorization.|  
|[/RTC](../VS_csharp/-rtc--run-time-error-checks-.md)|Enables run-time error checking.|  
|[/volatile](../VS_csharp/-volatile--volatile-keyword-interpretation-.md)|Selects how the volatile keyword is interpreted.|  
  
### Output Files  
  
|Option|Purpose|  
|------------|-------------|  
|[/doc](../VS_csharp/-doc--process-documentation-comments---c-c---.md)|Processes documentation comments to an XML file.|  
|[/FA](../VS_csharp/-fa---fa--listing-file-.md)|Configures an assembly listing file.|  
|[/Fa](../VS_csharp/-fa---fa--listing-file-.md)|Creates an assembly listing file.|  
|[/Fd](../VS_csharp/-fd--program-database-file-name-.md)|Renames program database file.|  
|[/Fe](../VS_csharp/-fe--name-exe-file-.md)|Renames the executable file.|  
|[/Fi](../VS_csharp/-fi--preprocess-output-file-name-.md)|Specifies the preprocessed output file name.|  
|[/Fm](../VS_csharp/-fm--name-mapfile-.md)|Creates a mapfile.|  
|[/Fo](../VS_csharp/-fo--object-file-name-.md)|Creates an object file.|  
|[/Fp](../VS_csharp/-fp--name-.pch-file-.md)|Specifies a precompiled header file name.|  
|[/FR](../VS_csharp/-fr---fr--create-.sbr-file-.md) [/Fr](../VS_csharp/-fr---fr--create-.sbr-file-.md)|Generates browser files.|  
  
### Preprocessor  
  
|Option|Purpose|  
|------------|-------------|  
|[/AI](../VS_csharp/-ai--specify-metadata-directories-.md)|Specifies a directory to search to resolve file references passed to the [#using](../VS_csharp/sharpusing-directive--c---.md) directive.|  
|[/C](../VS_csharp/-c--preserve-comments-during-preprocessing-.md)|Preserves comments during preprocessing.|  
|[/D](../VS_csharp/-d--preprocessor-definitions-.md)|Defines constants and macros.|  
|[/E](../VS_csharp/-e--preprocess-to-stdout-.md)|Copies preprocessor output to standard output.|  
|[/EP](../VS_csharp/-ep--preprocess-to-stdout-without-sharpline-directives-.md)|Copies preprocessor output to standard output.|  
|[/FI](../VS_csharp/-fi--name-forced-include-file-.md)|Preprocesses the specified include file.|  
|[/FU](../VS_csharp/-fu--name-forced-sharpusing-file-.md)|Forces the use of a file name, as if it had been passed to the [#using](../VS_csharp/sharpusing-directive--c---.md) directive.|  
|[/Fx](../VS_csharp/-fx--merge-injected-code-.md)|Merges injected code with the source file.|  
|[/I](../VS_csharp/-i--additional-include-directories-.md)|Searches a directory for include files.|  
|[/P](../VS_csharp/-p--preprocess-to-a-file-.md)|Writes preprocessor output to a file.|  
|[/U](../VS_csharp/-u---u--undefine-symbols-.md)|Removes a predefined macro.|  
|[/u](../VS_csharp/-u---u--undefine-symbols-.md)|Removes all predefined macros.|  
|[/X](../VS_csharp/-x--ignore-standard-include-paths-.md)|Ignores the standard include directory.|  
  
### Language  
  
|Option|Purpose|  
|------------|-------------|  
|[/openmp](../VS_csharp/-openmp--enable-openmp-2.0-support-.md)|Enables [#pragma omp](../VS_csharp/omp.md) in source code.|  
|[/vd](../VS_csharp/-vd--disable-construction-displacements-.md)|Suppresses or enables hidden `vtordisp` class members.|  
|[/vmb](../VS_csharp/-vmb---vmg--representation-method-.md)|Uses best base for pointers to members.|  
|[/vmg](../VS_csharp/-vmb---vmg--representation-method-.md)|Uses full generality for pointers to members.|  
|[/vmm](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares multiple inheritance.|  
|[/vms](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares single inheritance.|  
|[/vmv](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares virtual inheritance.|  
|[/Z7](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Generates C 7.0–compatible debugging information.|  
|[/Za](../VS_csharp/-za---ze--disable-language-extensions-.md)|Disables language extensions.|  
|[/Zc](../VS_csharp/-zc--conformance-.md)|Specifies standard behavior under [/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md).|  
|[/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/ZI](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Includes debug information in a program database compatible with Edit and Continue. (x86 only)|  
|[/Zi](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Generates complete debugging information.|  
|[/Zl](../VS_csharp/-zl--omit-default-library-name-.md)|Removes the default library name from the .obj file.|  
|[/Zp](../VS_csharp/-zp--struct-member-alignment-.md) *n*|Packs structure members.|  
|[/Zs](../VS_csharp/-zs--syntax-check-only-.md)|Checks syntax only.|  
|[/ZW](../VS_csharp/-zw--windows-runtime-compilation-.md)|Produces an output file to run on the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].|  
  
### Linking  
  
|Option|Purpose|  
|------------|-------------|  
|[/F](../VS_csharp/-f--set-stack-size-.md)|Sets stack size.|  
|[/LD](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a dynamic-link library.|  
|[/LDd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a debug dynamic-link library.|  
|[/link](../VS_csharp/-link--pass-options-to-linker-.md)|Passes the specified option to LINK.|  
|[/LN](../VS_csharp/-ln--create-msil-module-.md)|Creates an MSIL module.|  
|[/MD](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Compiles to create a multithreaded DLL, by using MSVCRT.lib.|  
|[/MDd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Compiles to create a debug multithreaded DLL, by using MSVCRTD.lib.|  
|[/MT](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Compiles to create a multithreaded executable file, by using LIBCMT.lib.|  
|[/MTd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Compiles to create a debug multithreaded executable file, by using LIBCMTD.lib.|  
  
### Precompiled Header  
  
|Option|Purpose|  
|------------|-------------|  
|[/Y-](../VS_csharp/-y---ignore-precompiled-header-options-.md)|Ignores all other precompiled-header compiler options in the current build.|  
|[/Yc](../VS_csharp/-yc--create-precompiled-header-file-.md)|Creates a precompiled header file.|  
|[/Yd](../VS_csharp/-yd--place-debug-information-in-object-file-.md)|Places complete debugging information in all object files.|  
|[/Yu](../VS_csharp/-yu--use-precompiled-header-file-.md)|Uses a precompiled header file during build.|  
  
### Miscellaneous  
  
|Option|Purpose|  
|------------|-------------|  
|[/?](../VS_csharp/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[@](../VS_csharp/@--specify-a-compiler-response-file-.md)|Specifies a response file.|  
|[/analyze](../VS_csharp/-analyze--code-analysis-.md)|Enables code analysis.|  
|[/bigobj](../VS_csharp/-bigobj--increase-number-of-sections-in-.obj-file-.md)|Increases the number of addressable sections in an .obj file.|  
|[/c](../VS_csharp/-c--compile-without-linking-.md)|Compiles without linking.|  
|[/cgthreads](../VS_csharp/-cgthreads--code-generation-threads-.md)|Specifies number of cl.exe threads to use for optimization and code generation.|  
|[/errorReport](../VS_csharp/-errorreport--report-internal-compiler-errors-.md)|Enables you to provide internal compiler error (ICE) information directly to the Visual C++ team.|  
|[/FC](../VS_csharp/-fc--full-path-of-source-code-file-in-diagnostics-.md)|Displays the full path of source code files passed to cl.exe in diagnostic text.|  
|[/FS](../VS_csharp/-fs--force-synchronous-pdb-writes-.md)|Forces writes to the program database (PDB) file to be serialized through MSPDBSRV.EXE.|  
|[/H](../VS_csharp/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/HELP](../VS_csharp/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/J](../VS_csharp/-j--default-char-type-is-unsigned-.md)|Changes the default `char` type.|  
|[/kernel](../VS_csharp/-kernel--create-kernel-mode-binary-.md)|The compiler and linker will create a binary that can be executed in the Windows kernel.|  
|[/MP](../VS_csharp/-mp--build-with-multiple-processes-.md)|Builds multiple source files concurrently.|  
|[/nologo](../VS_csharp/-nologo--suppress-startup-banner---c-c---.md)|Suppresses display of sign-on banner.|  
|[/sdl](../VS_csharp/-sdl--enable-additional-security-checks-.md)|Enables additional security features and warnings.|  
|[/showIncludes](../VS_csharp/-showincludes--list-include-files-.md)|Displays a list of all include files during compilation.|  
|[/Tc](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md) [/TC](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C source file.|  
|[/Tp](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md) [/TP](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C++ source file.|  
|[/V](../VS_csharp/-v--version-number-.md)|Deprecated. Sets the version string.|  
|[/w](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables all warnings.|  
|[/W0, /W1, /W2, /W3, /W4](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets output warning level.|  
|[/w1, /w2, /w3, /w4](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets warning level for the specified warning.|  
|[/Wall](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Enables all warnings, including warnings that are disabled by default.|  
|[/wd](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables the specified warning.|  
|[/we](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats the specified warning as an error.|  
|[/WL](../VS_csharp/-wl--enable-one-line-diagnostics-.md)|Enables one-line diagnostics for error and warning messages when compiling C++ source code from the command line.|  
|[/wo](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays the specified warning only once.|  
|[/Wp64](../VS_csharp/-wp64--detect-64-bit-portability-issues-.md)|Obsolete. Detects 64-bit portability problems.|  
|[/Wv](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables warnings introduced by later versions of the compiler.|  
|[/WX](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats warnings as errors.|  
|[/Yd](../VS_csharp/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../VS_csharp/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Yl](../VS_csharp/-yl--inject-pch-reference-for-debug-library-.md)|Injects a PCH reference when creating a debug library.|  
|[/Zm](../VS_csharp/-zm--specify-precompiled-header-memory-allocation-limit-.md)|Specifies the precompiled header memory allocation limit.|  
  
### Deprecated and Removed Compiler Options  
  
|Option|Purpose|  
|------------|-------------|  
|[/clr:noAssembly](../VS_csharp/-clr--common-language-runtime-compilation-.md)|Deprecated. Use [/LN (Create MSIL Module)](../VS_csharp/-ln--create-msil-module-.md) instead.|  
|[/Fr](../VS_csharp/-fr---fr--create-.sbr-file-.md)|Deprecated. Creates a browse information file without local variables.|  
|[/Ge](../VS_csharp/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes. On by default.|  
|[/GX](../VS_csharp/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../VS_csharp/-eh--exception-handling-model-.md) instead.|  
|[/GZ](../VS_csharp/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Enables fast checks. Use [/RTC1](../VS_csharp/-rtc--run-time-error-checks-.md) instead.|  
|[/H](../VS_csharp/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/Og](../VS_csharp/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[QIfist](../VS_csharp/-qifist--suppress-_ftol-.md)|Deprecated. Once used to specify how to convert from a floating-point type to an integral type.|  
|[/V](../VS_csharp/-v--version-number-.md)|Deprecated. Sets the .obj file version string.|  
|[/Yd](../VS_csharp/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../VS_csharp/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Zc:forScope-](../VS_csharp/-zc-forscope--force-conformance-in-for-loop-scope-.md)|Deprecated. Disables conformance in for loop scope.|  
|[/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/Zg](../VS_csharp/-zg--generate-function-prototypes-.md)|Removed in Visual C++ 2015. Generates function prototypes.|  
  
## See Also  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)