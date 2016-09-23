---
title: "Compiler Options Listed Alphabetically"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - compiler options, C++
ms.assetid: 98375dad-c9c6-4796-aaa6-fd573269d4ae
caps.latest.revision: 70
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Options Listed Alphabetically
The following is a comprehensive alphabetical list of compiler options. For a categorical list, see the [Compiler Options Listed by Category](../vs140/compiler-options-listed-by-category.md).  
  
|Option|Purpose|  
|------------|-------------|  
|[@](../vs140/@--specify-a-compiler-response-file-.md)|Specifies a response file.|  
|[/?](../vs140/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/AI](../vs140/-ai--specify-metadata-directories-.md)|Specifies a directory to search to resolve file references passed to the [#using](../vs140/sharpusing-directive--c---.md) directive.|  
|[/analyze](../vs140/-analyze--code-analysis-.md)|Enable code analysis.|  
|[/arch](../vs140/-arch--minimum-cpu-architecture-.md)|Specifies the architecture for code generation.|  
|[/bigobj](../vs140/-bigobj--increase-number-of-sections-in-.obj-file-.md)|Increases the number of addressable sections in an .obj file.|  
|[/C](../vs140/-c--preserve-comments-during-preprocessing-.md)|Preserves comments during preprocessing.|  
|[/c](../vs140/-c--compile-without-linking-.md)|Compiles without linking.|  
|[/cgthreads](../vs140/-cgthreads--code-generation-threads-.md)|Specifies number of cl.exe threads to use for optimization and code generation.|  
|[/clr](../vs140/-clr--common-language-runtime-compilation-.md)|Produces an output file to run on the common language runtime.|  
|[/D](../vs140/-d--preprocessor-definitions-.md)|Defines constants and macros.|  
|[/doc](../vs140/-doc--process-documentation-comments---c-c---.md)|Process documentation comments to an XML file.|  
|[/E](../vs140/-e--preprocess-to-stdout-.md)|Copies preprocessor output to standard output.|  
|[/EH](../vs140/-eh--exception-handling-model-.md)|Specifies the model of exception handling.|  
|[/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md)|Copies preprocessor output to standard output.|  
|[/errorReport](../vs140/-errorreport--report-internal-compiler-errors-.md)|Allows you to provide internal compiler error (ICE) information directly to the Visual C++ team.|  
|[/F](../vs140/-f--set-stack-size-.md)|Sets stack size.|  
|[/favor](../vs140/-favor--optimize-for-architecture-specifics-.md)|Produces code that is optimized for a specific [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] architecture or for the specifics of micro-architectures in both the AMD64 and Extended Memory 64 Technology (EM64T) architectures.|  
|[/FA](../vs140/-fa---fa--listing-file-.md)|Creates a listing file.|  
|[/Fa](../vs140/-fa---fa--listing-file-.md)|Sets the listing file name.|  
|[/FC](../vs140/-fc--full-path-of-source-code-file-in-diagnostics-.md)|Display full path of source code files passed to cl.exe in diagnostic text.|  
|[/Fd](../vs140/-fd--program-database-file-name-.md)|Renames program database file.|  
|[/Fe](../vs140/-fe--name-exe-file-.md)|Renames the executable file.|  
|[/FI](../vs140/-fi--name-forced-include-file-.md)|Preprocesses the specified include file.|  
|[/Fi](../vs140/-fi--preprocess-output-file-name-.md)|Sets the preprocessed output file name.|  
|[/Fm](../vs140/-fm--name-mapfile-.md)|Creates a mapfile.|  
|[/Fo](../vs140/-fo--object-file-name-.md)|Creates an object file.|  
|[/fp](../vs140/-fp--specify-floating-point-behavior-.md)|Specify floating-point behavior.|  
|[/Fp](../vs140/-fp--name-.pch-file-.md)|Specifies a precompiled header file name.|  
|[/FR](../vs140/-fr---fr--create-.sbr-file-.md)<br /><br /> [/Fr](../vs140/-fr---fr--create-.sbr-file-.md)|Generates browser files. **/Fr** is deprecated.|  
|[/FS](../vs140/-fs--force-synchronous-pdb-writes-.md)|Forces writes to the program database (PDB) file to be serialized through MSPDBSRV.EXE.|  
|[/FU](../vs140/-fu--name-forced-sharpusing-file-.md)|Forces the use of a file name as if it had been passed to the [#using](../vs140/sharpusing-directive--c---.md) directive.|  
|[/Fx](../vs140/-fx--merge-injected-code-.md)|Merges injected code with source file.|  
|[/GA](../vs140/-ga--optimize-for-windows-application-.md)|Optimizes code for Windows application.|  
|[/Gd](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__cdecl` calling convention (x86 only).|  
|[/Ge](../vs140/-ge--enable-stack-probes-.md)|Deprecated. Activates stack probes.|  
|[/GF](../vs140/-gf--eliminate-duplicate-strings-.md)|Enables string pooling.|  
|[/GH](../vs140/-gh--enable-_pexit-hook-function-.md)|Calls hook function `_pexit`.|  
|[/Gh](../vs140/-gh--enable-_penter-hook-function-.md)|Calls hook function `_penter`.|  
|[/GL](../vs140/-gl--whole-program-optimization-.md)|Enables whole program optimization.|  
|[/Gm](../vs140/-gm--enable-minimal-rebuild-.md)|Enables minimal rebuild.|  
|[/GR](../vs140/-gr--enable-run-time-type-information-.md)|Enables run-time type information (RTTI).|  
|[/Gr](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__fastcall` calling convention (x86 only).|  
|[/GS](../vs140/-gs--buffer-security-check-.md)|Buffers security check.|  
|[/Gs](../vs140/-gs--control-stack-checking-calls-.md)|Controls stack probes.|  
|[/GT](../vs140/-gt--support-fiber-safe-thread-local-storage-.md)|Supports fiber safety for data allocated using static thread-local storage.|  
|[/guard:cf](../vs140/-guard--enable-control-flow-guard-.md)|Adds control flow guard security checks.|  
|[/Gv](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__vectorcall` calling convention. (x86 and x64 only)|  
|[/Gw](../vs140/-gw--optimize-global-data-.md)|Enables whole-program global data optimization.|  
|[/GX](../vs140/-gx--enable-exception-handling-.md)|Deprecated. Enables synchronous exception handling. Use [/EH](../vs140/-eh--exception-handling-model-.md) instead.|  
|[/Gy](../vs140/-gy--enable-function-level-linking-.md)|Enables function-level linking.|  
|[/GZ](../vs140/-gz--enable-stack-frame-run-time-error-checking-.md)|Deprecated. Same as [/RTC1](../vs140/-rtc--run-time-error-checks-.md).|  
|[/Gz](../vs140/-gd---gr---gv---gz--calling-convention-.md)|Uses the `__stdcall` calling convention (x86 only).|  
|[/H](../vs140/-h--restrict-length-of-external-names-.md)|Deprecated. Restricts the length of external (public) names.|  
|[/HELP](../vs140/-help--compiler-command-line-help-.md)|Lists the compiler options.|  
|[/homeparams](../vs140/-homeparams--copy-register-parameters-to-stack-.md)|Forces parameters passed in registers to be written to their locations on the stack upon function entry. This compiler option is only for the [!INCLUDE[vcprx64](../vs140/includes/vcprx64_md.md)] compilers (native and cross compile).|  
|[/hotpatch](../vs140/-hotpatch--create-hotpatchable-image-.md)|Creates a hotpatchable image.|  
|[/I](../vs140/-i--additional-include-directories-.md)|Searches a directory for include files.|  
|[/J](../vs140/-j--default-char-type-is-unsigned-.md)|Changes the default `char` type.|  
|[/kernel](../vs140/-kernel--create-kernel-mode-binary-.md)|The compiler and linker will create a binary that can be executed in the Windows kernel.|  
|[/LD](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a dynamic-link library.|  
|[/LDd](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a debug dynamic-link library.|  
|[/link](../vs140/-link--pass-options-to-linker-.md)|Passes the specified option to LINK.|  
|[/LN](../vs140/-ln--create-msil-module-.md)|Creates an MSIL module.|  
|[/MD](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a multithreaded DLL using MSVCRT.lib.|  
|[/MDd](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a debug multithreaded DLL using MSVCRTD.lib.|  
|[/MP](../vs140/-mp--build-with-multiple-processes-.md)|Compiles multiple source files by using multiple processes.|  
|[/MT](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a multithreaded executable file using LIBCMT.lib.|  
|[/MTd](../vs140/-md---mt---ld--use-run-time-library-.md)|Creates a debug multithreaded executable file using LIBCMTD.lib.|  
|[/nologo](../vs140/-nologo--suppress-startup-banner---c-c---.md)|Suppresses display of sign-on banner.|  
|[/O1](../vs140/-o1---o2--minimize-size--maximize-speed-.md)|Creates small code.|  
|[/O2](../vs140/-o1---o2--minimize-size--maximize-speed-.md)|Creates fast code.|  
|[/Ob](../vs140/-ob--inline-function-expansion-.md)|Controls inline expansion.|  
|[/Od](../vs140/-od--disable--debug--.md)|Disables optimization.|  
|[/Og](../vs140/-og--global-optimizations-.md)|Deprecated. Uses global optimizations.|  
|[/Oi](../vs140/-oi--generate-intrinsic-functions-.md)|Generates intrinsic functions.|  
|[/openmp](../vs140/-openmp--enable-openmp-2.0-support-.md)|Enables [#pragma omp](../vs140/omp.md) in source code.|  
|[/Os](../vs140/-os---ot--favor-small-code--favor-fast-code-.md)|Favors small code.|  
|[/Ot](../vs140/-os---ot--favor-small-code--favor-fast-code-.md)|Favors fast code.|  
|[/Ox](../vs140/-ox--full-optimization-.md)|Uses maximum optimization (/Ob2gity /Gs).|  
|[/Oy](../vs140/-oy--frame-pointer-omission-.md)|Omits frame pointer (x86 only).|  
|[/P](../vs140/-p--preprocess-to-a-file-.md)|Writes preprocessor output to a file.|  
|[/Qfast_transcendentals](../vs140/-qfast_transcendentals--force-fast-transcendentals-.md)|Generates fast transcendentals.|  
|[/QIfist](../vs140/-qifist--suppress-_ftol-.md)|Deprecated. Suppresses `_ftol` when a conversion from a floating-point type to an integral type is required (x86 only).|  
|[/Qimprecise_fwaits](../vs140/-qimprecise_fwaits--remove-fwaits-inside-try-blocks-.md)|Removes `fwait` commands inside `try` blocks.|  
|[/Qpar (Auto-Parallelizer)](../vs140/-qpar--auto-parallelizer-.md)|Enables automatic parallelization of loops that are marked with the [#pragma loop()](../vs140/loop.md) directive.|  
|[/Qsafe_fp_loads](../vs140/-qsafe_fp_loads.md)|Uses integer move instructions for floating-point values and disables certain floating point load optimizations.|  
|[/Qvec-report (Auto-Vectorizer)](../vs140/-qvec-report--auto-vectorizer-reporting-level-.md)|Enables reporting levels for automatic vectorization.|  
|[/RTC](../vs140/-rtc--run-time-error-checks-.md)|Enables run-time error checking.|  
|[/sdl](../vs140/-sdl--enable-additional-security-checks-.md)|Enables additional security features and warnings.|  
|[/showIncludes](../vs140/-showincludes--list-include-files-.md)|Displays a list of include files during compilation.|  
|[/Tc](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)<br /><br /> [/TC](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C source file.|  
|[/Tp](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)<br /><br /> [/TP](../vs140/-tc---tp---tc---tp--specify-source-file-type-.md)|Specifies a C++ source file.|  
|[/U](../vs140/-u---u--undefine-symbols-.md)|Removes a predefined macro.|  
|[/u](../vs140/-u---u--undefine-symbols-.md)|Removes all predefined macros.|  
|[/V](../vs140/-v--version-number-.md)|Deprecated. Sets the .obj file version string.|  
|[/vd](../vs140/-vd--disable-construction-displacements-.md)|Suppresses or enables hidden vtordisp class members.|  
|[/vmb](../vs140/-vmb---vmg--representation-method-.md)|Uses best base for pointers to members.|  
|[/vmg](../vs140/-vmb---vmg--representation-method-.md)|Uses full generality for pointers to members.|  
|[/vmm](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares multiple inheritance.|  
|[/vms](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares single inheritance.|  
|[/vmv](../vs140/-vmm---vms---vmv--general-purpose-representation-.md)|Declares virtual inheritance.|  
|[/volatile](../vs140/-volatile--volatile-keyword-interpretation-.md)|Selects how the volatile keyword is interpreted.|  
|[/w](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables all warnings.|  
|[/W0, /W1, /W2, /W3, /W4](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets which warning level to output.|  
|[/w1, /w2, /w3, /w4](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Sets the warning level for the specified warning.|  
|[/Wall](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Enables all warnings, including warnings that are disabled by default.|  
|[/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Disables the specified warning.|  
|[/we](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats the specified warning as an error.|  
|[/WL](../vs140/-wl--enable-one-line-diagnostics-.md)|Enables one-line diagnostics for error and warning messages when compiling C++ source code from the command line.|  
|[/wo](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays the specified warning only once.|  
|[/Wp64](../vs140/-wp64--detect-64-bit-portability-issues-.md)|Obsolete. Detects 64-bit portability problems.|  
|[/Wv](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Displays no warnings introduced after the specified version of the compiler.|  
|[/WX](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md)|Treats all warnings as errors.|  
|[/X](../vs140/-x--ignore-standard-include-paths-.md)|Ignores the standard include directory.|  
|[/Y-](../vs140/-y---ignore-precompiled-header-options-.md)|Ignores all other precompiled-header compiler options in the current build.|  
|[/Yc](../vs140/-yc--create-precompiled-header-file-.md)|Creates a precompiled header file.|  
|[/Yd](../vs140/-yd--place-debug-information-in-object-file-.md)|Deprecated. Places complete debugging information in all object files. Use [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md) instead.|  
|[/Yl](../vs140/-yl--inject-pch-reference-for-debug-library-.md)|Injects a PCH reference when creating a debug library|  
|[/Yu](../vs140/-yu--use-precompiled-header-file-.md)|Uses a precompiled header file during build.|  
|[/Z7](../vs140/-z7---zi---zi--debug-information-format-.md)|Generates C 7.0–compatible debugging information.|  
|[/Za](../vs140/-za---ze--disable-language-extensions-.md)|Disables language extensions.|  
|[/Zc](../vs140/-zc--conformance-.md)|Specifies standard behavior under [/Ze](../vs140/-za---ze--disable-language-extensions-.md).[/Za, /Ze (Disable Language Extensions)](../vs140/-za---ze--disable-language-extensions-.md)|  
|[/Ze](../vs140/-za---ze--disable-language-extensions-.md)|Deprecated. Enables language extensions.|  
|[/Zg](../vs140/-zg--generate-function-prototypes-.md)|Removed in Visual C++ 2015. Generates function prototypes.|  
|[/ZI](../vs140/-z7---zi---zi--debug-information-format-.md)|Includes debug information in a program database compatible with Edit and Continue.|  
|[/Zi](../vs140/-z7---zi---zi--debug-information-format-.md)|Generates complete debugging information.|  
|[/Zl](../vs140/-zl--omit-default-library-name-.md)|Removes default library name from .obj file (x86 only).|  
|[/Zm](../vs140/-zm--specify-precompiled-header-memory-allocation-limit-.md)|Specifies the precompiled header memory allocation limit.|  
|[/Zp](../vs140/-zp--struct-member-alignment-.md)|Packs structure members.|  
|[/Zs](../vs140/-zs--syntax-check-only-.md)|Checks syntax only.|  
|[/ZW](../vs140/-zw--windows-runtime-compilation-.md)|Produces an output file to run on the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].|  
  
## See Also  
 [C/C++ Building Reference](../vs140/c-c---building-reference.md)   
 [Compiler Options](../vs140/compiler-options.md)   
 [Setting Compiler Options](../vs140/setting-compiler-options.md)