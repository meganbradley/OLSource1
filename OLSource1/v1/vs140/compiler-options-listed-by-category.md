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
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Options Listed by Category
This article contains a categorical list of compiler options. For an alphabetical list, see [Compiler Options Listed Alphabetically](../vs140/compiler-options-listed-alphabetically.md).  
  
### Optimization  
  
|Option|Purpose|  
|------------|-------------|  
|[/O1](../vs140/-o1---o2--minimize-size--maximize-speed-.md)|Creates small code.|  
|[/O2](../vs140/-o1---o2--minimize-size--maximize-speed-.md)|Creates fast code.|  
|[/Ob](../vs140/-ob--inline-function-expansion-.md)|Controls inline expansion.|  
|[/Od](../vs140/-od--disable--debug--.md)|Disables optimization.|  
|[/Og](../vs140/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[/Oi](../vs140/-oi--generate-intrinsic-functions-.md)|Generates intrinsic functions.|  
|[/Os](../vs140/-os---ot--favor-small-code--favor-fast-code-.md)|Favors small code.|  
|[/Ot](../vs140/-os---ot--favor-small-code--favor-fast-code-.md)|Favors fast code.|  
|[/Ox](../vs140/-ox--full-optimization-.md)|Uses maximum optimization (/Ob2gity /Gs).|  
|[/Oy](../vs140/-oy--frame-pointer-omission-.md)|Omits frame pointer. (x86 only)|  
|[/favor](../vs140/-favor--optimize-for-architecture-specifics-.md)|Produces code that is optimized for a specified architecture, or for a range of architectures.|  
  
### Code Generation  
  
|Option|Purpose|  
|------------|-------------|  
|[/arch](../vs140/-arch--x86-.md)|Use SSE or SSE2 instructions in code generation. (x86 only)|  
|[/clr](../vs140/-clr--common-language-runtime-compilation-.md)|Produces an output file to run on the common language runtime.|  
|[/EH](../vs140/-eh--exception-handling-model-.md)|Specifies the model of exception handling.|  
|[/fp](../vs140/-fp--specify-floating-point-behavior-.md)|Specifies floating-point behavior.|  
|[/GA](../vs140/-ga--optimize-for-windows-application-.md)|Optimizes for Windows applications.|  
|[/Gd](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__cdecl` calling convention. (x86 only)|  
|[/Ge](../vs140/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes.|  
|[/GF](../vs140/-gf--eliminate-duplicate-strings-.md)|Enables string pooling.|  
|[/Gh](../vs140/-gh--enable-_penter-hook-function-.md)|Calls hook function `_penter`.|  
|[/GH](../vs140/-gh--enable-_pexit-hook-function-.md)|Calls hook function `_pexit`.|  
|[/GL](../vs140/-gl--whole-program-optimization-.md)|Enables whole program optimization.|  
|[/Gm](../vs140/-gm--enable-minimal-rebuild-.md)|Enables minimal rebuild.|  
|[/GR](../vs140/-gr--enable-run-time-type-information-.md)|Enables run-time type information (RTTI).|  
|[/Gr](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__fastcall` calling convention. (x86 only)|  
|[/GS](../vs140/-gs--buffer-security-check-.md)|Checks buffer security.|  
|[/Gs](../vs140/-gs--control-stack-checking-calls-.md)|Controls stack probes.|  
|[/GT](../vs140/-gt--support-fiber-safe-thread-local-storage-.md)|Supports fiber safety for data allocated by using static thread-local storage.|  
|[/guard:cf](../vs140/-guard--enable-control-flow-guard-.md)|Adds control flow guard security checks.|  
|[/Gv](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__vectorcall` calling convention. (x86 and x64 only)|  
|[/Gw](../vs140/-gw--optimize-global-data-.md)|Enables whole-program global data optimization.|  
|[/GX](../vs140/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../vs140/-eh--exception-handling-model-.md) instead.|  
|[/Gy](../vs140/-gy--enable-function-level-linking-.md)|Enables function-level linking.|  
|[/GZ](../vs140/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Enables fast checks. (Same as [/RTC1](../vs140/-rtc--run-time-error-checks-.md))|  
|[/Gz](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__stdcall` calling convention. (x86 only)|  
|[/homeparams](../vs140/-homeparams--copy-register-parameters-to-stack-.md)|Forces parameters passed in registers to be written to their locations on the stack upon function entry. This compiler option is only for the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] compilers (native and cross compile).|  
|[/hotpatch](../vs140/-hotpatch--create-hotpatchable-image-.md)|Creates a hotpatchable image.|  
|[/Qfast_transcendentals](../vs140/-qfast_transcendentals--force-fast-transcendentals-.md)|Generates fast transcendentals.|  
|[QIfist](../vs140/-qifist--suppress-_ftol-.md)|Deprecated. Suppresses the call of the helper function `_ftol` when a conversion from a floating-point type to an integral type is required. (x86 only)|  
|[/Qimprecise_fwaits](../vs140/-qimprecise_fwaits--remove-fwaits-inside-try-blocks-.md)|Removes `fwait` commands inside `try` blocks.|  
|[/Qpar](../vs140/-qpar--auto-parallelizer-.md)|Enables automatic parallelization of loops.|  
|[/Qpar-report](../vs140/-qpar-report--auto-parallelizer-reporting-level-.md)|Enables reporting levels for automatic parallelization.|  
|[/Qsafe_fp_loads](../vs140/-qsafe_fp_loads.md)|Uses integer move instructions for floating-point values and disables certain floating point load optimizations.|  
|[/Qvec-report (Auto-Vectorizer)](../vs140/-qvec-report--auto-vectorizer-reporting-level-.md)|Enables reporting levels for automatic vectorization.|  
|[/RTC](../vs140/-rtc--run-time-error-checks-.md)|Enables run-time error checking.|  
|[/volatile](../vs140/-volatile--volatile-keyword-interpretation-.md)|Selects how the volatile keyword is interpreted.|  
  
### Output Files  
  
|Option|Purpose|  
|------------|-------------|  
|[/doc](../vs140/-doc--process-documentation-comments---c-c---.md)|Processes documentation comments to an XML file.|  
|[/FA](../vs140/-fa---fa--listing-file-.md)|Configures an assembly listing file.|  
|[/Fa](../vs140/-fa---fa--listing-file-.md)|Creates an assembly listing file.|  
|[/Fd](../vs140/-fd--program-database-file-name-.md)|Renames program database file.|  
|[/Fe](../vs140/-fe--name-exe-file-.md)|Renames the executable file.|  
|[/Fi](../vs140/-fi--preprocess-output-file-name-.md)|Specifies the preprocessed output file name.|  
|[/Fm](../vs140/-fm--name-mapfile-.md)|Creates a mapfile.|  
|[/Fo](../vs140/-fo--object-file-name-.md)|Creates an object file.|  
|[/Fp](../vs140/-fp--name-.pch-file-.md)|Specifies a precompiled header file name.|  
|[/FR](../vs140/-fr---fr--create-.sbr-file-.md) [/Fr](../vs140/-fr---fr--create-.sbr-file-.md)|Generates browser files.|  
  
### Preprocessor  
  
|Option|Purpose|  
|------------|-------------|  
|[/AI](../vs140/-ai--specify-metadata-directories-.md)|Specifies a directory to search to resolve file references passed to the [#using](../vs140/sharpusing-directive--c---.md) directive.|  
|[/C](../vs140/-c--preserve-comments-during-preprocessing-.md)|Preserves comments during preprocessing.|  
|[/D](../vs140/-d--preprocessor-definitions-.md)|Defines constants and macros.|  
|[/E](../vs140/-e--preprocess-to-stdout-.md)|Copies preprocessor output to standard output.|  
|[/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md)|Copies preprocessor output to standard output.|  
|[/FI](../vs140/-fi--name-forced-include-file-.md)|Preprocesses the specified include file.|  
|[/FU](../vs140/-fu--name-forced-sharpusing-file-.md)|Forces the use of a file name, as if it had been passed to the [#using](../vs140/sharpusing-directive--c---.md) directive.|  
|[/Fx](../vs140/-fx--merge-injected-code-.md)|Merges injected code with the source file.|  
|[/I](../vs140/-i--additional-include-directories-.md)|Searches a directory for include files.|  
|[/P](../vs140/-p--preprocess-to-a-file-.md)|Writes preprocessor output to a file.|  
|[/U](../vs140/-u---u--undefine-symbols-.md)|Removes a predefined macro.|  
|[/u](../vs140/-u---u--undefine-symbols-.md)|Removes all predefined macros.|  
|[/X](../vs140/-x--ignore-standard-include-paths-.md)|Ignores the standard include directory.|  
  
### Language  
  
|Option|Purpose|  
|------------|-------------|  
|[/openmp](../vs140/-openmp--enable-openmp-2.0-support-.md)|Enables [#pragma omp](../vs140/omp.md) in source code.|  
|[/vd](../vs140/-vd--disable-construction-displacements-.md)|Suppresses or enables hidden `vtordisp` class members.|  
|[/vmb](../vs140/-vmb---vmg--representation-method-.md)|Uses best base for pointers to members.|  
|[/vmg](../vs140/-vmb---vmg--representation-method-.md)|Uses full generality for pointers to members.|  
|[/vmm](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares multiple inheritance.|  
|[/vms](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares single inheritance.|  
|[/vmv](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares virtual inheritance.|  
|[/Z7](../vs140/-z7---zi---zi--debug-information-format-.md)|Generates C 7.0–compatible debugging information.|  
|[/Za](../vs140/-za---ze--disable-language-extensions-.md)|Disables language extensions.|  
|[/Zc](../vs140/-zc--conformance-.md)|Specifies standard behavior under [/Ze](../vs140/-za---ze--disable-language-extensions-.md).|  
|[/Ze](../vs140/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/ZI](../vs140/-z7---zi---zi--debug-information-format-.md)|Includes debug information in a program database compatible with Edit and Continue. (x86 only)|  
|[/Zi](../vs140/-z7---zi---zi--debug-information-format-.md)|Generates complete debugging information.|  
|[/Zl](../vs140/-zl--omit-default-library-name-.md)|Removes the default library name from the .obj file.|  
|[/Zp](../vs140/-zp--struct-member-alignment-.md) *n*|Packs structure members.|  
|[/Zs](../vs140/-zs--syntax-check-only-.md)|Checks syntax only.|  
|[/ZW](../vs140/-zw--windows-runtime-compilation-.md)|Produces an output file to run on the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].|  
  
### Linking  
  
|Option|Purpose|  
|------------|-------------|  
|[/F](../vs140/-f--set-stack-size-.md)|Sets stack size.|  
|[/LD](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a dynamic-link library.|  
|[/LDd](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a debug dynamic-link library.|  
|[/link](../vs140/-link--pass-options-to-linker-.md)|Passes the specified option to LINK.|  
|[/LN](../vs140/-ln--create-msil-module-.md)|Creates an MSIL module.|  
|[/MD](../vs140/-md---mt---ld--use-run-time-library-.md)|Compiles to create a multithreaded DLL, by using MSVCRT.lib.|  
|[/MDd](../vs140/-md---mt---ld--use-run-time-library-.md)|Compiles to create a debug multithreaded DLL, by using MSVCRTD.lib.|  
|[/MT](../vs140/-md---mt---ld--use-run-time-library-.md)|Compiles to create a multithreaded executable file, by using LIBCMT.lib.|  
|[/MTd](../vs140/-md---mt---ld--use-run-time-library-.md)|Compiles to create a debug multithreaded executable file, by using LIBCMTD.lib.|  
  
### Precompiled Header  
  
|Option|Purpose|  
|------------|-------------|  
|[/Y-](../vs140/-y---ignore-precompiled-header-options-.md)|Ignores all other precompiled-header compiler options in the current build.|  
|[/Yc](../vs140/-yc--create-precompiled-header-file-.md)|Creates a precompiled header file.|  
|[/Yd](../vs140/-yd--place-debug-information-in-object-file-.md)|Places complete debugging information in all object files.|  
|[/Yu](../vs140/-yu--use-precompiled-header-file-.md)|Uses a precompiled header file during build.|  
  
### Miscellaneous  
  
|Option|Purpose|  
|------------|-------------|  
|[/?](../vs140/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[@](../vs140/@--specify-a-compiler-response-file-.md)|Specifies a response file.|  
|[/analyze](../vs140/-analyze--code-analysis-.md)|Enables code analysis.|  
|[/bigobj](../vs140/-bigobj--increase-number-of-sections-in-.obj-file-.md)|Increases the number of addressable sections in an .obj file.|  
|[/c](../vs140/-c--compile-without-linking-.md)|Compiles without linking.|  
|[/cgthreads](../vs140/-cgthreads--code-generation-threads-.md)|Specifies number of cl.exe threads to use for optimization and code generation.|  
|[/errorReport](../vs140/-errorreport--report-internal-compiler-errors-.md)|Enables you to provide internal compiler error (ICE) information directly to the Visual C++ team.|  
|[/FC](../vs140/-fc--full-path-of-source-code-file-in-diagnostics-.md)|Displays the full path of source code files passed to cl.exe in diagnostic text.|  
|[/FS](../vs140/-fs--force-synchronous-pdb-writes-.md)|Forces writes to the program database (PDB) file to be serialized through MSPDBSRV.EXE.|  
|[/H](../vs140/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/HELP](../vs140/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/J](../vs140/-j--default-char-type-is-unsigned-.md)|Changes the default `char` type.|  
|[/kernel](../vs140/-kernel--create-kernel-mode-binary-.md)|The compiler and linker will create a binary that can be executed in the Windows kernel.|  
|[/MP](../vs140/-mp--build-with-multiple-processes-.md)|Builds multiple source files concurrently.|  
|[/nologo](../vs140/-nologo--suppress-startup-banner---c-c---.md)|Suppresses display of sign-on banner.|  
|[/sdl](../vs140/-sdl--enable-additional-security-checks-.md)|Enables additional security features and warnings.|  
|[/showIncludes](../vs140/-showincludes--list-include-files-.md)|Displays a list of all include files during compilation.|  
|[/Tc](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md) [/TC](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C source file.|  
|[/Tp](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md) [/TP](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C++ source file.|  
|[/V](../vs140/-v--version-number-.md)|Deprecated. Sets the version string.|  
|[/w](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables all warnings.|  
|[/W0, /W1, /W2, /W3, /W4](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets output warning level.|  
|[/w1, /w2, /w3, /w4](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets warning level for the specified warning.|  
|[/Wall](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Enables all warnings, including warnings that are disabled by default.|  
|[/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables the specified warning.|  
|[/we](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats the specified warning as an error.|  
|[/WL](../vs140/-wl--enable-one-line-diagnostics-.md)|Enables one-line diagnostics for error and warning messages when compiling C++ source code from the command line.|  
|[/wo](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays the specified warning only once.|  
|[/Wp64](../vs140/-wp64--detect-64-bit-portability-issues-.md)|Obsolete. Detects 64-bit portability problems.|  
|[/Wv](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables warnings introduced by later versions of the compiler.|  
|[/WX](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats warnings as errors.|  
|[/Yd](../vs140/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Yl](../vs140/-yl--inject-pch-reference-for-debug-library-.md)|Injects a PCH reference when creating a debug library.|  
|[/Zm](../vs140/-zm--specify-precompiled-header-memory-allocation-limit-.md)|Specifies the precompiled header memory allocation limit.|  
  
### Deprecated and Removed Compiler Options  
  
|Option|Purpose|  
|------------|-------------|  
|[/clr:noAssembly](../vs140/-clr--common-language-runtime-compilation-.md)|Deprecated. Use [/LN (Create MSIL Module)](../vs140/-ln--create-msil-module-.md) instead.|  
|[/Fr](../vs140/-fr---fr--create-.sbr-file-.md)|Deprecated. Creates a browse information file without local variables.|  
|[/Ge](../vs140/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes. On by default.|  
|[/GX](../vs140/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../vs140/-eh--exception-handling-model-.md) instead.|  
|[/GZ](../vs140/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Enables fast checks. Use [/RTC1](../vs140/-rtc--run-time-error-checks-.md) instead.|  
|[/H](../vs140/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/Og](../vs140/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[QIfist](../vs140/-qifist--suppress-_ftol-.md)|Deprecated. Once used to specify how to convert from a floating-point type to an integral type.|  
|[/V](../vs140/-v--version-number-.md)|Deprecated. Sets the .obj file version string.|  
|[/Yd](../vs140/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Zc:forScope-](../vs140/-zc-forscope--force-conformance-in-for-loop-scope-.md)|Deprecated. Disables conformance in for loop scope.|  
|[/Ze](../vs140/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/Zg](../vs140/-zg--generate-function-prototypes-.md)|Removed in Visual C++ 2015. Generates function prototypes.|  
  
## See Also  
 [C/C++ Building Reference](../vs140/c-c---building-reference.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)