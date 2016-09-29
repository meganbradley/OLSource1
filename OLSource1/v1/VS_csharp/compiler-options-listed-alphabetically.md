---
title: "Compiler Options Listed Alphabetically"
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
ms.assetid: 98375dad-c9c6-4796-aaa6-fd573269d4ae
caps.latest.revision: 70
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Options Listed Alphabetically
The following is a comprehensive alphabetical list of compiler options. For a categorical list, see the [Compiler Options Listed by Category](../VS_csharp/compiler-options-listed-by-category.md).  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../VS_csharp/@--specify-a-compiler-response-file-.md)|Specifies a response file.|  
|[/?](../VS_csharp/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/AI](../VS_csharp/-ai--specify-metadata-directories-.md)|Specifies a directory to search to resolve file references passed to the [#using](../VS_csharp/sharpusing-directive--c---.md) directive.|  
|[/analyze](../VS_csharp/-analyze--code-analysis-.md)|Enable code analysis.|  
|[/arch](../VS_csharp/-arch--minimum-cpu-architecture-.md)|Specifies the architecture for code generation.|  
|[/bigobj](../VS_csharp/-bigobj--increase-number-of-sections-in-.obj-file-.md)|Increases the number of addressable sections in an .obj file.|  
|[/C](../VS_csharp/-c--preserve-comments-during-preprocessing-.md)|Preserves comments during preprocessing.|  
|[/c](../VS_csharp/-c--compile-without-linking-.md)|Compiles without linking.|  
|[/cgthreads](../VS_csharp/-cgthreads--code-generation-threads-.md)|Specifies number of cl.exe threads to use for optimization and code generation.|  
|[/clr](../VS_csharp/-clr--common-language-runtime-compilation-.md)|Produces an output file to run on the common language runtime.|  
|[/D](../VS_csharp/-d--preprocessor-definitions-.md)|Defines constants and macros.|  
|[/doc](../VS_csharp/-doc--process-documentation-comments---c-c---.md)|Process documentation comments to an XML file.|  
|[/E](../VS_csharp/-e--preprocess-to-stdout-.md)|Copies preprocessor output to standard output.|  
|[/EH](../VS_csharp/-eh--exception-handling-model-.md)|Specifies the model of exception handling.|  
|[/EP](../VS_csharp/-ep--preprocess-to-stdout-without-sharpline-directives-.md)|Copies preprocessor output to standard output.|  
|[/errorReport](../VS_csharp/-errorreport--report-internal-compiler-errors-.md)|Allows you to provide internal compiler error (ICE) information directly to the Visual C++ team.|  
|[/F](../VS_csharp/-f--set-stack-size-.md)|Sets stack size.|  
|[/favor](../VS_csharp/-favor--optimize-for-architecture-specifics-.md)|Produces code that is optimized for a specific [!INCLUDE[vcprx64](../VS_csharp/includes/vcprx64_md.md)] architecture or for the specifics of micro-architectures in both the AMD64 and Extended Memory 64 Technology (EM64T) architectures.|  
|[/FA](../VS_csharp/-fa---fa--listing-file-.md)|Creates a listing file.|  
|[/Fa](../VS_csharp/-fa---fa--listing-file-.md)|Sets the listing file name.|  
|[/FC](../VS_csharp/-fc--full-path-of-source-code-file-in-diagnostics-.md)|Display full path of source code files passed to cl.exe in diagnostic text.|  
|[/Fd](../VS_csharp/-fd--program-database-file-name-.md)|Renames program database file.|  
|[/Fe](../VS_csharp/-fe--name-exe-file-.md)|Renames the executable file.|  
|[/FI](../VS_csharp/-fi--name-forced-include-file-.md)|Preprocesses the specified include file.|  
|[/Fi](../VS_csharp/-fi--preprocess-output-file-name-.md)|Sets the preprocessed output file name.|  
|[/Fm](../VS_csharp/-fm--name-mapfile-.md)|Creates a mapfile.|  
|[/Fo](../VS_csharp/-fo--object-file-name-.md)|Creates an object file.|  
|[/fp](../VS_csharp/-fp--specify-floating-point-behavior-.md)|Specify floating-point behavior.|  
|[/Fp](../VS_csharp/-fp--name-.pch-file-.md)|Specifies a precompiled header file name.|  
|[/FR](../VS_csharp/-fr---fr--create-.sbr-file-.md)<br /><br /> [/Fr](../VS_csharp/-fr---fr--create-.sbr-file-.md)|Generates browser files. **/Fr** is deprecated.|  
|[/FS](../VS_csharp/-fs--force-synchronous-pdb-writes-.md)|Forces writes to the program database (PDB) file to be serialized through MSPDBSRV.EXE.|  
|[/FU](../VS_csharp/-fu--name-forced-sharpusing-file-.md)|Forces the use of a file name as if it had been passed to the [#using](../VS_csharp/sharpusing-directive--c---.md) directive.|  
|[/Fx](../VS_csharp/-fx--merge-injected-code-.md)|Merges injected code with source file.|  
|[/GA](../VS_csharp/-ga--optimize-for-windows-application-.md)|Optimizes code for Windows application.|  
|[/Gd](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__cdecl` calling convention (x86 only).|  
|[/Ge](../VS_csharp/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes.|  
|[/GF](../VS_csharp/-gf--eliminate-duplicate-strings-.md)|Enables string pooling.|  
|[/GH](../VS_csharp/-gh--enable-_pexit-hook-function-.md)|Calls hook function `_pexit`.|  
|[/Gh](../VS_csharp/-gh--enable-_penter-hook-function-.md)|Calls hook function `_penter`.|  
|[/GL](../VS_csharp/-gl--whole-program-optimization-.md)|Enables whole program optimization.|  
|[/Gm](../VS_csharp/-gm--enable-minimal-rebuild-.md)|Enables minimal rebuild.|  
|[/GR](../VS_csharp/-gr--enable-run-time-type-information-.md)|Enables run-time type information (RTTI).|  
|[/Gr](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__fastcall` calling convention (x86 only).|  
|[/GS](../VS_csharp/-gs--buffer-security-check-.md)|Buffers security check.|  
|[/Gs](../VS_csharp/-gs--control-stack-checking-calls-.md)|Controls stack probes.|  
|[/GT](../VS_csharp/-gt--support-fiber-safe-thread-local-storage-.md)|Supports fiber safety for data allocated using static thread-local storage.|  
|[/guard:cf](../VS_csharp/-guard--enable-control-flow-guard-.md)|Adds control flow guard security checks.|  
|[/Gv](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__vectorcall` calling convention. (x86 and x64 only)|  
|[/Gw](../VS_csharp/-gw--optimize-global-data-.md)|Enables whole-program global data optimization.|  
|[/GX](../VS_csharp/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../VS_csharp/-eh--exception-handling-model-.md) instead.|  
|[/Gy](../VS_csharp/-gy--enable-function-level-linking-.md)|Enables function-level linking.|  
|[/GZ](../VS_csharp/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Same as [/RTC1](../VS_csharp/-rtc--run-time-error-checks-.md).|  
|[/Gz](../VS_csharp/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__stdcall` calling convention (x86 only).|  
|[/H](../VS_csharp/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/HELP](../VS_csharp/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/homeparams](../VS_csharp/-homeparams--copy-register-parameters-to-stack-.md)|Forces parameters passed in registers to be written to their locations on the stack upon function entry. This compiler option is only for the [!INCLUDE[vcprx64](../VS_csharp/includes/vcprx64_md.md)] compilers (native and cross compile).|  
|[/hotpatch](../VS_csharp/-hotpatch--create-hotpatchable-image-.md)|Creates a hotpatchable image.|  
|[/I](../VS_csharp/-i--additional-include-directories-.md)|Searches a directory for include files.|  
|[/J](../VS_csharp/-j--default-char-type-is-unsigned-.md)|Changes the default `char` type.|  
|[/kernel](../VS_csharp/-kernel--create-kernel-mode-binary-.md)|The compiler and linker will create a binary that can be executed in the Windows kernel.|  
|[/LD](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a dynamic-link library.|  
|[/LDd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a debug dynamic-link library.|  
|[/link](../VS_csharp/-link--pass-options-to-linker-.md)|Passes the specified option to LINK.|  
|[/LN](../VS_csharp/-ln--create-msil-module-.md)|Creates an MSIL module.|  
|[/MD](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a multithreaded DLL using MSVCRT.lib.|  
|[/MDd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a debug multithreaded DLL using MSVCRTD.lib.|  
|[/MP](../VS_csharp/-mp--build-with-multiple-processes-.md)|Compiles multiple source files by using multiple processes.|  
|[/MT](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a multithreaded executable file using LIBCMT.lib.|  
|[/MTd](../VS_csharp/-md---mt---ld--use-run-time-library-.md)|Creates a debug multithreaded executable file using LIBCMTD.lib.|  
|[/nologo](../VS_csharp/-nologo--suppress-startup-banner---c-c---.md)|Suppresses display of sign-on banner.|  
|[/O1](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md)|Creates small code.|  
|[/O2](../VS_csharp/-o1---o2--minimize-size--maximize-speed-.md)|Creates fast code.|  
|[/Ob](../VS_csharp/-ob--inline-function-expansion-.md)|Controls inline expansion.|  
|[/Od](../VS_csharp/-od--disable--debug--.md)|Disables optimization.|  
|[/Og](../VS_csharp/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[/Oi](../VS_csharp/-oi--generate-intrinsic-functions-.md)|Generates intrinsic functions.|  
|[/openmp](../VS_csharp/-openmp--enable-openmp-2.0-support-.md)|Enables [#pragma omp](../VS_csharp/omp.md) in source code.|  
|[/Os](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md)|Favors small code.|  
|[/Ot](../VS_csharp/-os---ot--favor-small-code--favor-fast-code-.md)|Favors fast code.|  
|[/Ox](../VS_csharp/-ox--full-optimization-.md)|Uses maximum optimization (/Ob2gity /Gs).|  
|[/Oy](../VS_csharp/-oy--frame-pointer-omission-.md)|Omits frame pointer (x86 only).|  
|[/P](../VS_csharp/-p--preprocess-to-a-file-.md)|Writes preprocessor output to a file.|  
|[/Qfast_transcendentals](../VS_csharp/-qfast_transcendentals--force-fast-transcendentals-.md)|Generates fast transcendentals.|  
|[/QIfist](../VS_csharp/-qifist--suppress-_ftol-.md)|Deprecated. Suppresses `_ftol` when a conversion from a floating-point type to an integral type is required (x86 only).|  
|[/Qimprecise_fwaits](../VS_csharp/-qimprecise_fwaits--remove-fwaits-inside-try-blocks-.md)|Removes `fwait` commands inside `try` blocks.|  
|[/Qpar (Auto-Parallelizer)](../VS_csharp/-qpar--auto-parallelizer-.md)|Enables automatic parallelization of loops that are marked with the [#pragma loop()](../VS_csharp/loop.md) directive.|  
|[/Qsafe_fp_loads](../VS_csharp/-qsafe_fp_loads.md)|Uses integer move instructions for floating-point values and disables certain floating point load optimizations.|  
|[/Qvec-report (Auto-Vectorizer)](../VS_csharp/-qvec-report--auto-vectorizer-reporting-level-.md)|Enables reporting levels for automatic vectorization.|  
|[/RTC](../VS_csharp/-rtc--run-time-error-checks-.md)|Enables run-time error checking.|  
|[/sdl](../VS_csharp/-sdl--enable-additional-security-checks-.md)|Enables additional security features and warnings.|  
|[/showIncludes](../VS_csharp/-showincludes--list-include-files-.md)|Displays a list of include files during compilation.|  
|[/Tc](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)<br /><br /> [/TC](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C source file.|  
|[/Tp](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)<br /><br /> [/TP](../VS_csharp/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C++ source file.|  
|[/U](../VS_csharp/-u---u--undefine-symbols-.md)|Removes a predefined macro.|  
|[/u](../VS_csharp/-u---u--undefine-symbols-.md)|Removes all predefined macros.|  
|[/V](../VS_csharp/-v--version-number-.md)|Deprecated. Sets the .obj file version string.|  
|[/vd](../VS_csharp/-vd--disable-construction-displacements-.md)|Suppresses or enables hidden vtordisp class members.|  
|[/vmb](../VS_csharp/-vmb---vmg--representation-method-.md)|Uses best base for pointers to members.|  
|[/vmg](../VS_csharp/-vmb---vmg--representation-method-.md)|Uses full generality for pointers to members.|  
|[/vmm](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares multiple inheritance.|  
|[/vms](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares single inheritance.|  
|[/vmv](../VS_csharp/-vmm---vms---vmv--general-purpose-representation-.md)|Declares virtual inheritance.|  
|[/volatile](../VS_csharp/-volatile--volatile-keyword-interpretation-.md)|Selects how the volatile keyword is interpreted.|  
|[/w](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables all warnings.|  
|[/W0, /W1, /W2, /W3, /W4](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets which warning level to output.|  
|[/w1, /w2, /w3, /w4](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets the warning level for the specified warning.|  
|[/Wall](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Enables all warnings, including warnings that are disabled by default.|  
|[/wd](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables the specified warning.|  
|[/we](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats the specified warning as an error.|  
|[/WL](../VS_csharp/-wl--enable-one-line-diagnostics-.md)|Enables one-line diagnostics for error and warning messages when compiling C++ source code from the command line.|  
|[/wo](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays the specified warning only once.|  
|[/Wp64](../VS_csharp/-wp64--detect-64-bit-portability-issues-.md)|Obsolete. Detects 64-bit portability problems.|  
|[/Wv](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays no warnings introduced after the specified version of the compiler.|  
|[/WX](../VS_csharp/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats all warnings as errors.|  
|[/X](../VS_csharp/-x--ignore-standard-include-paths-.md)|Ignores the standard include directory.|  
|[/Y-](../VS_csharp/-y---ignore-precompiled-header-options-.md)|Ignores all other precompiled-header compiler options in the current build.|  
|[/Yc](../VS_csharp/-yc--create-precompiled-header-file-.md)|Creates a precompiled header file.|  
|[/Yd](../VS_csharp/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../VS_csharp/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Yl](../VS_csharp/-yl--inject-pch-reference-for-debug-library-.md)|Injects a PCH reference when creating a debug library|  
|[/Yu](../VS_csharp/-yu--use-precompiled-header-file-.md)|Uses a precompiled header file during build.|  
|[/Z7](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Generates C 7.0–compatible debugging information.|  
|[/Za](../VS_csharp/-za---ze--disable-language-extensions-.md)|Disables language extensions.|  
|[/Zc](../VS_csharp/-zc--conformance-.md)|Specifies standard behavior under [/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md).[/Za, /Ze (Disable Language Extensions)](../VS_csharp/-za---ze--disable-language-extensions-.md)|  
|[/Ze](../VS_csharp/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/Zg](../VS_csharp/-zg--generate-function-prototypes-.md)|Removed in Visual C++ 2015. Generates function prototypes.|  
|[/ZI](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Includes debug information in a program database compatible with Edit and Continue.|  
|[/Zi](../VS_csharp/-z7---zi---zi--debug-information-format-.md)|Generates complete debugging information.|  
|[/Zl](../VS_csharp/-zl--omit-default-library-name-.md)|Removes default library name from .obj file (x86 only).|  
|[/Zm](../VS_csharp/-zm--specify-precompiled-header-memory-allocation-limit-.md)|Specifies the precompiled header memory allocation limit.|  
|[/Zp](../VS_csharp/-zp--struct-member-alignment-.md)|Packs structure members.|  
|[/Zs](../VS_csharp/-zs--syntax-check-only-.md)|Checks syntax only.|  
|[/ZW](../VS_csharp/-zw--windows-runtime-compilation-.md)|Produces an output file to run on the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].|  
  
## See Also  
 [C/C++ Building Reference](../VS_csharp/c-c---building-reference.md)   
 [Compiler Options](../VS_csharp/compiler-options.md)   
 [Setting Compiler Options](../VS_csharp/setting-compiler-options.md)