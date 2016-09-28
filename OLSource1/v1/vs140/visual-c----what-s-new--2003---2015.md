---
title: "Visual C++ &quot;What&#39;s New&quot; 2003 - 2015"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7c374d83-e622-44a7-964d-3dbe4283de18
caps.latest.revision: 18
author: ""
ms.author: ""
---
# Visual C++ &quot;What&#39;s New&quot; 2003 - 2015
This page gathers all the "What's New" pages for all versions of Visual C++ going back to 2003. It is provided as a convenience in case it might be useful when upgrading from earlier versions of Visual C++.  
  
-   [](#cpp2003)  
  
-   [](#cpp2005)  
  
-   [What's New for Visual C++ in Visual Studio 2008](https://msdn.microsoft.com/library/bb384632\(v=vs.90\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2010](https://msdn.microsoft.com/library/dd465215\(v=vs.100\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2012](https://msdn.microsoft.com/library/hh409293\(v=vs.110\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2013](https://msdn.microsoft.com/library/hh409293\(v=vs.120\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2015](https://msdn.microsoft.com/library/hh409293\(v=vs.140\).aspx)  
  
##  <a name="cpp2003"></a> Visual Studio 2003  
  
### Compiler  
  
-   Information on how to run a Managed Extensions for C++ application built with the current version's compiler on a previous version of the runtime; see Running a Managed Extensions for C++ Application on a Previous Version's Runtime.  
  
-   Managed Extensions for C++ Frequently Asked Questions.  
  
-   A walkthrough has been added showing how to port an existing, native application to use Managed Extensions for C++: Walkthrough: Porting an Existing Native C++ Application to Interoperate with .NET Framework Components  
  
-   You can now create a delegate on a method of a value type.  
  
-   The compiler's conformance with the C++ standard has been significantly enhanced for Visual C++ .NET 2003. See Standard Compliance Issues in Visual C++ for more information. See Breaking Changes in the Visual C++ Compiler for information on where your upgraded Visual C++ applications may no longer compile because of enhanced conformance.  
  
-   /arch compiler option is added.  
  
-   /Gf is deprecated and will be removed in the next version of Visual C++.  
  
-   /G7 compiler option is added.  
  
-   The /GS compiler option has been enhanced to help protect local variables from direct buffer overruns.  
  
-   The /noBool compiler option has been removed. The compiler now allows bool to appear only as a keyword (and not an identifier) in a C++ source code file.  
  
-   The long long type is now available as a typedef of __int64. See Fundamental Types for more information. Note that there is not yet support for long long in the CRT.  
  
-   The /Zm compiler option now specifies the precompiled header memory allocation limit.  
  
-   _InterlockedCompareExchange intrinsic now documented.  
  
-   _InterlockedDecrement intrinsic now documented.  
  
-   _InterlockedExchange intrinsic now documented.  
  
-   _InterlockedExchangeAdd intrinsic now documented.  
  
-   _InterlockedIncrement intrinsic now documented.  
  
-   _ReadWriteBarrier intrinsic added.  
  
### Attributes  
 implements attribute is now documented.  
  
### Linker features  
 The following linker switches have been added:  
  
-   /ASSEMBLYDEBUG  
  
-   /ASSEMBLYLINKRESOURCE  
  
-   DELAYSIGN  
  
-   /KEYFILE  
  
-   /KEYCONTAINER  
  
-   /SAFESEH  
  
### MASM  
 The .SAFESEH directive and /safeseh ml.exe option were added.  
  
##  <a name="cpp2005"></a> Visual Studio 2005  
 The following features were new in Visual C++ 2005 Service                 Pack 1:  
  
### Intrinsics for x86 and x64  
  
-   [__halt](https://msdn.microsoft.com/en-us/library/aa983390\(v=vs.80\).aspx)  
  
-   [__lidt](https://msdn.microsoft.com/en-us/library/aa983382\(v=vs.80\).aspx)  
  
-   [__nop](https://msdn.microsoft.com/en-us/library/aa983381\(v=vs.80\).aspx)  
  
-   [__readcr8](https://msdn.microsoft.com/en-us/library/a1xx74s6\(v=vs.80\).aspx)  
  
-   [__sidt](https://msdn.microsoft.com/en-us/library/aa983358\(v=vs.80\).aspx)  
  
-   [__svm_clgi](https://msdn.microsoft.com/en-us/library/aa983376\(v=vs.80\).aspx)  
  
-   [__svm_invlpga](https://msdn.microsoft.com/en-us/library/aa983393\(v=vs.80\).aspx)  
  
-   [__svm_skinit](https://msdn.microsoft.com/en-us/library/aa983378\(v=vs.80\).aspx)  
  
-   [__svm_stgi](https://msdn.microsoft.com/en-us/library/aa983389\(v=vs.80\).aspx)  
  
-   [__svm_vmload](https://msdn.microsoft.com/en-us/library/aa983397\(v=vs.80\).aspx)  
  
-   [__svm_vmrun](https://msdn.microsoft.com/en-us/library/aa983395\(v=vs.80\).aspx)  
  
-   [__svm_vmsave](https://msdn.microsoft.com/en-us/library/aa983371\(v=vs.80\).aspx)  
  
-   [__ud2](https://msdn.microsoft.com/en-us/library/aa983360\(v=vs.80\).aspx)  
  
-   [__vmx_off](https://msdn.microsoft.com/en-us/library/aa983379\(v=vs.80\).aspx)  
  
-   [__vmx_vmptrst](https://msdn.microsoft.com/en-us/library/aa983387\(v=vs.80\).aspx)  
  
-   [__writecr8](https://msdn.microsoft.com/en-us/library/bx8z22fy\(v=vs.80\).aspx)  
  
### Intrinsics for x64 Only  
  
-   [__vmx_on](https://msdn.microsoft.com/en-us/library/aa983363\(v=vs.80\).aspx)  
  
-   [__vmx_vmclear](https://msdn.microsoft.com/en-us/library/aa983405\(v=vs.80\).aspx)  
  
-   [__vmx_vmlaunch](https://msdn.microsoft.com/en-us/library/aa983377\(v=vs.80\).aspx)  
  
-   [__vmx_vmptrld](https://msdn.microsoft.com/en-us/library/aa983388\(v=vs.80\).aspx)  
  
-   [__vmx_vmread](https://msdn.microsoft.com/en-us/library/aa983361\(v=vs.80\).aspx)  
  
-   [__vmx_vmresume](https://msdn.microsoft.com/en-us/library/aa983365\(v=vs.80\).aspx)  
  
-   [__vmx_vmwrite](https://msdn.microsoft.com/en-us/library/aa983386\(v=vs.80\).aspx)  
  
### New Language Keywords  
 Insert section body here.  
  
-   [__sptr,  
                                            \__uptr](https://msdn.microsoft.com/en-us/library/aa983399\(v=vs.80\).aspx)  
  
### New Compiler Features  
  
-   The compiler                                 has breaking changes in this release. See [Breaking  
                                            Changes in the Visual C++ 2005 Compiler](https://msdn.microsoft.com/en-us/library/ms177253\(v=vs.80\).aspx) for more information.  
  
-   64-bit native                                 and cross-compilers. For more information, see [Compiler  
                                            Options](https://msdn.microsoft.com/en-us/library/9s7c9wdw\(v=vs.80\).aspx) and [x64  
                                            Software Conventions](https://msdn.microsoft.com/en-us/library/7kcdt6fy\(v=vs.80\).aspx).  
  
-   [/analyze (Enterprise Code Analysis)](https://msdn.microsoft.com/en-us/library/ms173498\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/bigobj](https://msdn.microsoft.com/en-us/library/ms173499\(v=vs.80\).aspx) compiler option has been added.  
  
-   /clr:pure,                                 /clr:safe, and /clr:oldSyntax have been added. For more                                 information, see [/clr  
                                            (Common Language Runtime Compilation)](https://msdn.microsoft.com/en-us/library/k8d11d4s\(v=vs.80\).aspx).  
  
-   Deprecated                                 compiler options: many compiler options have been deprecated in this release;                                 see [Deprecated  
                                            Compiler Options](https://msdn.microsoft.com/en-us/library/z8dh4h17\(v=vs.80\).aspx) for more information.  
  
-   Double thunking                                 in /clr code is reduced; see [Double  
                                            Thunking (C++)](https://msdn.microsoft.com/en-us/library/ms235292\(v=vs.80\).aspx) for more information.  
  
-   [/EH  
                                            (Exception Handling Model)](https://msdn.microsoft.com/en-us/library/1deeycx5\(v=vs.80\).aspx) or /EHs can no longer be used to catch an                                 exception that is raised with something other than a throw; use /EHa.  
  
-   [/errorReport  
                                            (Report Internal Compiler Errors)](https://msdn.microsoft.com/en-us/library/ms173502\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/favor  
                                            (Optimize for 64)](https://msdn.microsoft.com/en-us/library/ms173505\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/FA, /Fa  
                                            (Listing File)](https://msdn.microsoft.com/en-us/library/367y26c6\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/FC  
                                            (Full Path of Source Code File in Diagnostics)](https://msdn.microsoft.com/en-us/library/027c4t2s\(v=vs.80\).aspx) compiler option has been                                 added.  
  
-   [/fp (Specify  
                                            Floating-Point Behavior)](https://msdn.microsoft.com/en-us/library/e7s85ffb\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/G  
                                            (Optimize for Processor) Options](https://msdn.microsoft.com/en-us/library/h66s5s0e\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/G  
                                            (Optimize for Processor) Options](https://msdn.microsoft.com/en-us/library/h66s5s0e\(v=vs.80\).aspx) compiler option has been added.  
  
-   /G3, /G4,                                 /G5, /G6, /G7, and /GB compiler options have been                                 removed. The compiler now uses a "blended model" that attempts to                                 create the best output file for all architectures.  
  
-   /Gf has                                 been removed. Use [/GF  
                                            (Eliminate Duplicate Strings)](https://msdn.microsoft.com/en-us/library/s0s0asdt\(v=vs.80\).aspx) instead.  
  
-   [/GL  
                                            (Whole Program Optimization)](https://msdn.microsoft.com/en-us/library/0zza0de8\(v=vs.80\).aspx) is now compatible with [/CLRHEADER](https://msdn.microsoft.com/en-us/library/ds03hhk8\(v=vs.80\).aspx).                                 For more information, see [/LTCG  
                                            (Link-time Code Generation)](https://msdn.microsoft.com/en-us/library/xbf3tbeh\(v=vs.80\).aspx).  
  
-   /GR is                                 now on by default. See [/GR  
                                            (Enable Run-Time Type Information)](https://msdn.microsoft.com/en-us/library/we6hfdy0\(v=vs.80\).aspx) for more information.  
  
-   [/GS  
                                            (Buffer Security Check)](https://msdn.microsoft.com/en-us/library/8dbf701c\(v=vs.80\).aspx) now provides security protection for vulnerable                                 pointer parameters. /GS is now on by default. /GS now also works                                 on functions compiled to MSIL with [/clr  
                                            (Common Language Runtime Compilation)](https://msdn.microsoft.com/en-us/library/k8d11d4s\(v=vs.80\).aspx).  
  
-   [/homeparams  
                                            (Copy Register Parameters to Stack)](https://msdn.microsoft.com/en-us/library/6exwh0y6\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/hotpatch  
                                            (Create Hotpatchable Image)](https://msdn.microsoft.com/en-us/library/ms173507\(v=vs.80\).aspx) compiler option has been added.  
  
-   Inline function                                 heuristics have been updated; see [inline,  
                                            __inline, \__forceinline](https://msdn.microsoft.com/en-us/library/z8y1yy88\(v=vs.80\).aspx) and [inline_depth](https://msdn.microsoft.com/en-us/library/cx053bca\(v=vs.80\).aspx) for more information  
  
-   Many new                                 intrinsic functions have been added, and many previously undocumented intrinsics                                 are now documented. For more information, see [Alphabetical  
                                            Listing of Intrinsic Functions](https://msdn.microsoft.com/en-us/library/w5405h95\(v=vs.80\).aspx).  
  
-   By default, any                                 call to new that fails will throw an exception. For more information,                                 see [The  
                                            new and delete Operators](https://msdn.microsoft.com/en-us/library/kftdy56f\(v=vs.80\).aspx).  
  
-   /ML and /MLd                                 compiler options have been removed. Visual C++ no longer supports                                 single-threaded, statically linked CRT library support. See [C  
                                            Run-Time Libraries](https://msdn.microsoft.com/en-us/library/abx4dbyh\(v=vs.80\).aspx) for more information.  
  
-   The compiler                                 implemented the Named Return Value Optimization, which is enabled when you                                 compile with [/O1, /O2  
                                            (Minimize Size, Maximize Speed)](https://msdn.microsoft.com/en-us/library/8f8h5cxt\(v=vs.80\).aspx), [/Og  
                                            (Global Optimizations)](https://msdn.microsoft.com/en-us/library/1yk3ydd7\(v=vs.80\).aspx), and [/Ox  
                                            (Full Optimization)](https://msdn.microsoft.com/en-us/library/59a3b321\(v=vs.80\).aspx).  
  
-   /Oa                                 compiler option has been removed but will be silently ignored; use the [noalias](https://msdn.microsoft.com/en-us/library/k649tyc7\(v=vs.80\).aspx) or [restrict](https://msdn.microsoft.com/en-us/library/8bcxafdh\(v=vs.80\).aspx)__declspec modifiers to specify how the compiler does aliasing.  
  
-   /Op                                 compiler option had been removed. Use [/fp  
                                            (Specify Floating-Point Behavior)](https://msdn.microsoft.com/en-us/library/e7s85ffb\(v=vs.80\).aspx) instead.  
  
-   OpenMP is now                                 supported by Visual C++. For more information, see [OpenMP  
                                            in Visual C++](https://msdn.microsoft.com/en-us/library/tt15eb9t\(v=vs.80\).aspx).  
  
-   [/openmp  
                                            (Enable OpenMP 2.0 Support)](https://msdn.microsoft.com/en-us/library/fw509c3b\(v=vs.80\).aspx) compiler option has been added.  
  
-   /Ow                                 compiler option has been removed but will be silently ignored. Use the [noalias](https://msdn.microsoft.com/en-us/library/k649tyc7\(v=vs.80\).aspx) or [restrict](https://msdn.microsoft.com/en-us/library/8bcxafdh\(v=vs.80\).aspx)__declspec modifiers to specify how the compiler does aliasing.  
  
### Profile-Guided Optimizations  
  
-   /QI0f                                 has been removed.  
  
-   /QIfdiv                                 has been removed.  
  
-   [/QIPF_B  
                                            (Errata for B CPU Stepping)](https://msdn.microsoft.com/en-us/library/bt1z85wy\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/QIPF_C  
                                            (Errata for C CPU Stepping)](https://msdn.microsoft.com/en-us/library/t9zkze9f\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/QIPF_fr32  
                                            (Do Not Use Upper 96 Floating Point Registers)](https://msdn.microsoft.com/en-us/library/5y29d6s1\(v=vs.80\).aspx) compiler option has been                                 added.  
  
-   [/QIPF_noPIC  
                                            (Generate Position Dependent Code)](https://msdn.microsoft.com/en-us/library/ms173509\(v=vs.80\).aspx) compiler option has been added.  
  
-   [/QIPF_restrict_plabels  
                                            (Assume No Functions Created at Run Time)](https://msdn.microsoft.com/en-us/library/s15cta9c\(v=vs.80\).aspx) compiler option has been added.  
  
-   [Unicode  
                                            Support in the Compiler and Linker](https://msdn.microsoft.com/en-us/library/xwy0e8f2\(v=vs.80\).aspx)  
  
-   [/vd  
                                            (Disable Construction Displacements)](https://msdn.microsoft.com/en-us/library/7sf3txa8\(v=vs.80\).aspx) now allows you to use [dynamic_cast  
                                            Operator](https://msdn.microsoft.com/en-us/library/cby9kycs\(v=vs.80\).aspx) on an object being constructed (/vd2)  
  
-   /YX                                 compiler option has been removed. Use [/Yc  
                                            (Create Precompiled Header File)](https://msdn.microsoft.com/en-us/library/7zc28563\(v=vs.80\).aspx) or [/Yu (Use  
                                            Precompiled Header File)](https://msdn.microsoft.com/en-us/library/z0atkd6c\(v=vs.80\).aspx) instead. If you remove /YX from your build                                 configurations and replace it with nothing, it can result in faster builds.  
  
-   /Zc:forScope                                 is now on by default. See [/Zc:forScope  
                                            (Force Conformance in for Loop Scope)](https://msdn.microsoft.com/en-us/library/84wcsx8x\(v=vs.80\).aspx) for more information.  
  
-   /Zc:wchar_t                                 is now on by default. See [/Zc:wchar_t  
                                            (wchar_t Is Native Type)](https://msdn.microsoft.com/en-us/library/dh8che7s\(v=vs.80\).aspx) for more information.  
  
-   /Zd                                 compiler option has been removed. Line-number only debugging information is no                                 longer supported. Use /Zi instead (see [/Z7,  
                                            /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/en-us/library/958x11bc\(v=vs.80\).aspx) for more information).  
  
-   /Zg is                                 now only valid on C source code files, and not on C++ source code files. See [/Zg  
                                            (Generate Function Prototypes)](https://msdn.microsoft.com/en-us/library/y4s1adf3\(v=vs.80\).aspx) for more information.  
  
-   [/Zx  
                                            (Debug Optimized Itanium Code)](https://msdn.microsoft.com/en-us/library/acf58x4d\(v=vs.80\).aspx) compiler option has been added.  
  
### New Language Features  
  
-   The [attribute](https://msdn.microsoft.com/en-us/library/axs3bz64\(v=vs.80\).aspx)attribute                                 is now deprecated. See [User-Defined  
                                            Attributes](https://msdn.microsoft.com/en-us/library/yd21828z\(v=vs.80\).aspx) for information on how to create attributes.  
  
-   [appdomain](https://msdn.microsoft.com/en-us/library/d6ykz7kt\(v=vs.80\).aspx)__declspec modifier has been added.  
  
-   [__clrcall](https://msdn.microsoft.com/en-us/library/ec7sfckb\(v=vs.80\).aspx) calling convention has been added.  
  
-   [deprecated  
                                            (C++)](https://msdn.microsoft.com/en-us/library/044swk7y\(v=vs.80\).aspx)declspec modifier now allows you to specify a string that will                                 be displayed at compile time, when a user tries to access a deprecated class or                                 function.  
  
-   [dynamic_cast  
                                            Operator](https://msdn.microsoft.com/en-us/library/cby9kycs\(v=vs.80\).aspx) has breaking changes.  
  
-   Native enums                                 now allow you to specify the underlying type. For more information, see [C++  
                                            Enumeration Declarations](https://msdn.microsoft.com/en-us/library/2dzy4k6e\(v=vs.80\).aspx).  
  
-   [jitintrinsic](https://msdn.microsoft.com/en-us/library/ms235541\(v=vs.80\).aspx)declspec modifier has been added.  
  
-   [noalias](https://msdn.microsoft.com/en-us/library/k649tyc7\(v=vs.80\).aspx)declspec                                 modifier has been added.  
  
-   [process](https://msdn.microsoft.com/en-us/library/xs15886w\(v=vs.80\).aspx)__declspec                                 modifier has been added.  
  
-   abstract,                                 override, and sealed are valid for native compilations. For more                                 information, see [How to:  
                                            Declare Override Specifiers in Native Compilations](https://msdn.microsoft.com/en-us/library/z8ew2153\(v=vs.80\).aspx).  
  
-   [__restrict](https://msdn.microsoft.com/en-us/library/5ft82fed\(v=vs.80\).aspx) keyword has been added.  
  
-   [restrict](https://msdn.microsoft.com/en-us/library/8bcxafdh\(v=vs.80\).aspx)declspec modifier has been added.  
  
-   [__thiscall](https://msdn.microsoft.com/en-us/library/ek8tkfbw\(v=vs.80\).aspx) is now a keyword.  
  
-   [__unaligned](https://msdn.microsoft.com/en-us/library/ms177389\(v=vs.80\).aspx) keyword is now documented.  
  
-   [volatile  
                                            (C++)](https://msdn.microsoft.com/en-us/library/12a04hfd\(v=vs.80\).aspx) has updated behavior with respect to optimizations.  
  
### New Preprocessor Features  
  
-   __CLR_VER                                 predefined macro added. For more information, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   The [comment  
                                            (C/C++)](https://msdn.microsoft.com/en-us/library/7f0aews7\(v=vs.80\).aspx) pragma now accepts /MANIFESTDEPENDENCY as a linker comment.                                 The exestr option to comment is now deprecated.  
  
-   embedded_idl                                 attribute ([The  
                                            #import Directive](https://msdn.microsoft.com/en-us/library/8etzzkb6\(v=vs.80\).aspx)) now takes an optional parameter.  
  
-   [fenv_access](https://msdn.microsoft.com/en-us/library/bfwa91s0\(v=vs.80\).aspx) pragma  
  
-   [float_control](https://msdn.microsoft.com/en-us/library/45ec64h6\(v=vs.80\).aspx) pragma  
  
-   [fp_contract](https://msdn.microsoft.com/en-us/library/4f994tzs\(v=vs.80\).aspx) pragma  
  
-   Global                                 variables will not be initialized in the order they are declared if you have                                 global variables in pragma [managed,  
                                            unmanaged](https://msdn.microsoft.com/en-us/library/0adb9zxe\(v=vs.80\).aspx) and unmanaged sections. This is a potential breaking change if,                                 for example, an unmanaged global variable is initialized with a managed global                                 variables, and a fully constructed managed object is required.  
  
-   Sections                                 specified with [init_seg](https://msdn.microsoft.com/en-us/library/7977wcck\(v=vs.80\).aspx) are now read only, and not read/write as in previous versions.  
  
-   [inline_depth](https://msdn.microsoft.com/en-us/library/cx053bca\(v=vs.80\).aspx) default is now 16. A default of 16 was also in effect in Visual C++ .NET 2003.  
  
-   _INTEGRAL_MAX_BITS                                 predefined macro added, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   _M_CEE, _M_CEE_PURE,                                 and _M_CEE_SAFE predefined macros added, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   _M_IX86_FP                                 predefined macro added. For more information, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   _M_X64                                 predefined macro added. For more information, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   [make_public](https://msdn.microsoft.com/en-us/library/ms235607\(v=vs.80\).aspx) pragma  
  
-   [managed,  
                                            unmanaged](https://msdn.microsoft.com/en-us/library/0adb9zxe\(v=vs.80\).aspx) pragma syntax updated (now has push and pop)  
  
-   mscorlib.dll is                                 now implicitly referenced by [The  
                                            #using Directive](https://msdn.microsoft.com/en-us/library/yab9swk4\(v=vs.80\).aspx) in all /clr compilations.  
  
-   _OPENMP                                 predefined macro added. For more information, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   [optimize](https://msdn.microsoft.com/en-us/library/chh3fb0k\(v=vs.80\).aspx) pragma has been updated, a and w are no longer valid parameters.  
  
-   [no_registry](https://msdn.microsoft.com/en-us/library/81eb3zcy\(v=vs.80\).aspx)#import attribute has been added.  
  
-   [region,  
                                            endregion](https://msdn.microsoft.com/en-us/library/b6xkz944\(v=vs.80\).aspx) pragmas added  
  
-   _VC_NODEFAULTLIB                                 predefined macro added. For more information, see [Predefined  
                                            Macros](https://msdn.microsoft.com/en-us/library/b0084kay\(v=vs.80\).aspx).  
  
-   [Variadic  
                                            Macros](https://msdn.microsoft.com/en-us/library/ms177415\(v=vs.80\).aspx) are now implemented.  
  
-   [vtordisp](https://msdn.microsoft.com/en-us/library/453x4xdd\(v=vs.80\).aspx) is deprecated and will be removed in a future release of Visual C++.  
  
-   The [warning](https://msdn.microsoft.com/en-us/library/2c8f766e\(v=vs.80\).aspx) pragma now has the suppress specifier.  
  
### New Linker Features  
  
-   Modules                                 (non-assembly MSIL output files) are now allowed as input to the linker. For                                 more information, see [.netmodule  
                                            Files as Linker Input](https://msdn.microsoft.com/en-us/library/k669k83h\(v=vs.80\).aspx).  
  
-   [/ALLOWISOLATION  
                                            (Manifest Lookup)](https://msdn.microsoft.com/en-us/library/daa1w5yk\(v=vs.80\).aspx) linker option has been added.  
  
-   [/ASSEMBLYRESOURCE  
                                            (Embed a Managed Resource)](https://msdn.microsoft.com/en-us/library/yzdy7b10\(v=vs.80\).aspx) has been updated to now allow you to specify the                                 name of the resource in the assembly, and to specify that the resource is                                 private in the assembly.  
  
-   [/CLRIMAGETYPE  
                                            (Specify Type of CLR Image)](https://msdn.microsoft.com/en-us/library/31zwwc39\(v=vs.80\).aspx) linker option has been added.  
  
-   [/CLRSUPPORTLASTERROR  
                                            (Preserve Last Error Code for PInvoke Calls)](https://msdn.microsoft.com/en-us/library/yy0hww86\(v=vs.80\).aspx) linker option has been added.  
  
-   [/CLRTHREADATTRIBUTE  
                                            (Set CLR Thread Attribute)](https://msdn.microsoft.com/en-us/library/s6bz81ya\(v=vs.80\).aspx) linker option has been added.  
  
-   [/CLRUNMANAGEDCODECHECK  
                                            (Add SupressUnmanagedCodeSecurityAttribute)](https://msdn.microsoft.com/en-us/library/ms173523\(v=vs.80\).aspx) linker option has been added.  
  
-   [/ERRORREPORT  
                                            (Report Internal Linker Errors)](https://msdn.microsoft.com/en-us/library/ms235602\(v=vs.80\).aspx) linker option has been added.  
  
-   /EXETYPE                                 linker option has been removed. The linker no longer supports creating Windows                                 95 and Windows 98 device drivers. Use an appropriate DDK to create these device                                 drivers. The EXETYPE keyword is no longer valid for module definition                                 files.  
  
-   [/FUNCTIONPADMIN  
                                            (Create Hotpatchable Image)](https://msdn.microsoft.com/en-us/library/ms173524\(v=vs.80\).aspx) linker option has been added.  
  
-   /LTCG                                 linker option is now supported on modules compiled with /clr. /LTCG has                                 also been updated to support profile-guided optimizations. See [/LTCG  
                                            (Link-time Code Generation)](https://msdn.microsoft.com/en-us/library/xbf3tbeh\(v=vs.80\).aspx), [Profile-Guided  
                                            Optimizations](https://msdn.microsoft.com/en-us/library/e7k32f4k\(v=vs.80\).aspx), and [/clr  
                                            (Common Language Runtime Compilation)](https://msdn.microsoft.com/en-us/library/k8d11d4s\(v=vs.80\).aspx) for more information.  
  
-   [/MANIFEST  
                                            (Create Side-by-Side Assembly Manifest)](https://msdn.microsoft.com/en-us/library/f2c0w594\(v=vs.80\).aspx) linker option has been added.  
  
-   [/MANIFESTDEPENDENCY  
                                            (Specify Manifest Dependencies)](https://msdn.microsoft.com/en-us/library/ew0y5khy\(v=vs.80\).aspx) linker option has been added.  
  
-   [/MANIFESTFILE  
                                            (Name Manifest File)](https://msdn.microsoft.com/en-us/library/fft52235\(v=vs.80\).aspx) linker option has been added.  
  
-   /MAPINFO:LINES                                 linker option has been removed.  
  
-   [/NXCOMPAT  
                                            (Compatible with Data Execution Prevention)](https://msdn.microsoft.com/en-us/library/ms235442\(v=vs.80\).aspx) linker option has been added.  
  
-   [/PGD  
                                            (Specify Database for Profile-Guided Optimizations)](https://msdn.microsoft.com/en-us/library/438sd1tf\(v=vs.80\).aspx) linker option has been                                 added.  
  
-   [/PROFILE  
                                            (Performance Tools Profiler)](https://msdn.microsoft.com/en-us/library/ays5x7b0\(v=vs.80\).aspx) linker option has been added.  
  
-   [/SECTION  
                                            (Specify Section Attributes)](https://msdn.microsoft.com/en-us/library/sf9b18xk\(v=vs.80\).aspx) linker option now supports attribute negation                                 and no longer supports the L or D (VxD-related) attributes.  
  
-   [Unicode  
                                            Support in the Compiler and Linker](https://msdn.microsoft.com/en-us/library/xwy0e8f2\(v=vs.80\).aspx)  
  
-   [/VERBOSE  
                                            (Print Progress Messages)](https://msdn.microsoft.com/en-us/library/wdsk6as6\(v=vs.80\).aspx) linker option now also accepts ICF and REF.  
  
-   /VXD                                 linker option has been removed. The linker no longer supports creating Windows                                 95 and Windows 98 device drivers. Use an appropriate DDK to create these device                                 drivers. The VXD keyword is no longer valid for module definition files.  
  
-   /WS                                 linker option has been removed. /WS was used to modify images targeted                                 for Windows NT 4.0. IMAGECFG.exe -R  *filename*  can be used instead of                                 /WS. IMAGECFG.exe can be found on the Windows NT 4.0 CD-ROM in                                 SUPPORT\DEBUG\I386\IMAGECFG.EXE.  
  
-   [/WX  
                                            (Treat Linker Warnings as Errors)](https://msdn.microsoft.com/en-us/library/ms235592\(v=vs.80\).aspx) linker option is now documented.  
  
### New Linker Utility Features  
  
-   [/ALLOWISOLATION](https://msdn.microsoft.com/en-us/library/69xzf91x\(v=vs.80\).aspx) editbin option had been added  
  
-   DESCRIPTION                                 module definition file statement is removed. The linker no longer supports                                 building virtual device drivers.  
  
-   /ERRORREPORT                                 option has been added to bscmake.exe, dumpbin.exe, editbin.exe, and lib.exe.  
  
-   /LTCG                                 lib option has been added.  
  
-   [/NXCOMPAT](https://msdn.microsoft.com/en-us/library/ms235338\(v=vs.80\).aspx) editbin option has been added.  
  
-   [/RANGE](https://msdn.microsoft.com/en-us/library/06c11xc0\(v=vs.80\).aspx) dumpbin option has been added.  
  
-   [/TLS](https://msdn.microsoft.com/en-us/library/2y3fexze\(v=vs.80\).aspx) dumpbin option has been added.  
  
-   /WS                                 editbin option has been removed. /WS was used to modify images targeted                                 for Windows NT 4.0. IMAGECFG.exe -R  *filename*  can be used instead of /WS.                                 IMAGECFG.exe can be found on the Windows NT 4.0 CD-ROM in                                 SUPPORT\DEBUG\I386\IMAGECFG.EXE.  
  
-   /WX[:NO]                                 lib option has been added. See [Running  
                                            LIB](https://msdn.microsoft.com/en-us/library/h34w59b3\(v=vs.80\).aspx) for more information.  
  
### New NMAKE Features  
  
-   /ERRORREPORT                                 has been added. For more information, see [NMAKE  
                                            Options](https://msdn.microsoft.com/en-us/library/afyyse50\(v=vs.80\).aspx).  
  
-   /G has                                 been added. For more information, see [NMAKE  
                                            Options](https://msdn.microsoft.com/en-us/library/afyyse50\(v=vs.80\).aspx).  
  
-   The predefined                                 rules have been updated. For more information, see [Predefined  
                                            Rules](https://msdn.microsoft.com/en-us/library/cx06ysxh\(v=vs.80\).aspx).  
  
-   The $(MAKE)                                 macro, which is documented in [Recursion  
                                            Macros](https://msdn.microsoft.com/en-us/library/7cafx990\(v=vs.80\).aspx), now gives the full path to nmake.exe.  
  
### New MASM Features  
  
-   MASM                                 expressions are now 64-bit values. In previous versions MASM expressions were                                 32-bit values.  
  
-   The instruction                                 __asm int 3 now causes a function to be compiled to native. For more                                 information, see [__asm](https://msdn.microsoft.com/en-us/library/45yd4tzz\(v=vs.80\).aspx).  
  
-   [ALIAS  
                                            (MASM)](https://msdn.microsoft.com/en-us/library/b07c5b4f\(v=vs.80\).aspx) is now documented.  
  
-   /ERRORREPORT                                 ml.exe and ml64.exe option is added.  
  
-   [.FPO](https://msdn.microsoft.com/en-us/library/9c9k076y\(v=vs.80\).aspx) is now documented.  
  
-   H2INC.exe will                                 not ship in Visual C++ 2005. If you need to continue to use H2INC, use                                 H2INC.exe from a previous version of Visual C++.  
  
-   [operator  
                                            IMAGEREL](https://msdn.microsoft.com/en-us/library/ms177476\(v=vs.80\).aspx) has been added.  
  
-   [operator  
                                            HIGH32](https://msdn.microsoft.com/en-us/library/ms235621\(v=vs.80\).aspx) has been added.  
  
-   [operator  
                                            LOW32](https://msdn.microsoft.com/en-us/library/ms235622\(v=vs.80\).aspx) has been added.  
  
-   ml64.exe is a                                 version of MASM for the x64 architecture. It assembles x64 .asm files into x64                                 object files. Inline assembly language is not supported in the x64 compiler.                                 For more information, see [MASM for  
                                            x64 (ml64.exe)](https://msdn.microsoft.com/en-us/library/hb5z4sxd\(v=vs.80\).aspx). The following MASM directives have been added for ml64.exe (x64):  
  
-   [.ALLOCSTACK](https://msdn.microsoft.com/en-us/library/5btab6c7\(v=vs.80\).aspx)  
  
-   [.ENDPROLOG](https://msdn.microsoft.com/en-us/library/94fzht6a\(v=vs.80\).aspx)  
  
-   [.PUSHFRAME](https://msdn.microsoft.com/en-us/library/b3fffac7\(v=vs.80\).aspx)  
  
-   [.PUSHREG](https://msdn.microsoft.com/en-us/library/5kbwa7zs\(v=vs.80\).aspx)  
  
-   [.SAVEREG](https://msdn.microsoft.com/en-us/library/3cwzs27h\(v=vs.80\).aspx)  
  
-   [.SAVEXMM128](https://msdn.microsoft.com/en-us/library/47yak4w3\(v=vs.80\).aspx)  
  
-   [.SETFRAME](https://msdn.microsoft.com/en-us/library/2435h06y\(v=vs.80\).aspx) In addition, the [PROC](https://msdn.microsoft.com/en-us/library/01d2az3t\(v=vs.80\).aspx) directive was updated with x64-only syntax.  
  
-   [MMWORD](https://msdn.microsoft.com/en-us/library/3bt808ab\(v=vs.80\).aspx) directive has been added  
  
-   /omf                                 (ML.exe command line option) now implies /c. ML.exe does not support                                 linking OMF format objects.  
  
-   The [SEGMENT](https://msdn.microsoft.com/en-us/library/d06y3478\(v=vs.80\).aspx) directive now supports additional attributes.  
  
-   [operator  
                                            SECTIONREL](https://msdn.microsoft.com/en-us/library/ms177477\(v=vs.80\).aspx) has been added.  
  
-   [XMMWORD](https://msdn.microsoft.com/en-us/library/cw0399sf\(v=vs.80\).aspx) directive has been added  
  
### New CRT Features  
  
-   [Secure  
                                            versions](https://msdn.microsoft.com/en-us/library/wd3wzwts\(v=vs.80\).aspx) of several functions have been added. These functions handle                                 errors in a better way and enforce stricter controls on buffers to help avoid                                 common security flaws. The new secure versions are identified by the _s                                 suffix.  
  
-   Existing less secure versions of many functions have been                                 deprecated. To disable the deprecation warnings, define _CRT_SECURE_NO_WARNINGS.                                 For more information, see [Security-Enhanced  
                                            Versions of CRT Functions](https://msdn.microsoft.com/en-us/library/wd3wzwts\(v=vs.80\).aspx).  
  
-   Many existing functions now validate their parameters and invoke                                 the invalid parameter handler when an invalid parameter is passed. For more                                 information, see the individual function references and the [Parameter  
                                            Validation](https://msdn.microsoft.com/en-us/library/ksazx244\(v=vs.80\).aspx) topic.  
  
-   Many existing functions now set errno where they did not                                 before. See individual function references for specific errno                                 information.  
  
-   The typedef errno_t with type integer was added. errno_t                                 is used whenever a function return type or parameter deals with error codes                                 from errno. errno_t replaces errcode.  
  
-   Locale-dependent functions now have versions which take the                                 locale as a parameter rather than using the current locale. These new functions                                 have the _l suffix. Several new functions were added to work with locale                                 objects. New functions include [_get_current_locale](https://msdn.microsoft.com/en-us/library/3szh5e2z\(v=vs.80\).aspx),                                 [_create_locale](https://msdn.microsoft.com/en-us/library/4zx9aht2\(v=vs.80\).aspx) and [_free_locale](https://msdn.microsoft.com/en-us/library/beadd31b\(v=vs.80\).aspx).                                 See individual function references for more information.  
  
-   New functions were added to support locking and unlocking file                                 handles. For more information, see [_lock_file](https://msdn.microsoft.com/en-us/library/8w5bsb4f\(v=vs.80\).aspx) and [_unlock_file](https://msdn.microsoft.com/en-us/library/s2z49acd\(v=vs.80\).aspx).  
  
-   The _spawn family of functions does not reset errno                                 to zero on success, as it did in previous versions. For more information, see [_spawn,  
                                            _wspawn Functions](https://msdn.microsoft.com/en-us/library/20y988d2\(v=vs.80\).aspx).  
  
-   Versions of the printf family of functions that allow you                                 to specify the order in which the arguments are used are available. See [printf_p  
                                            Positional Parameters](https://msdn.microsoft.com/en-us/library/bt7tawza\(v=vs.80\).aspx), [_cprintf_p,  
                                            _cwprintf_p](https://msdn.microsoft.com/en-us/library/hy4t91t7\(v=vs.80\).aspx), [_printf_p,  
                                            _wprintf_p](https://msdn.microsoft.com/en-us/library/s3a5ky4x\(v=vs.80\).aspx), [_sprintf_p,  
                                            _swprintf_p](https://msdn.microsoft.com/en-us/library/02y7cdtk\(v=vs.80\).aspx), [_fprintf_p,  
                                            _fwprintf_p](https://msdn.microsoft.com/en-us/library/35tfd78h\(v=vs.80\).aspx), [_vprintf_p,  
                                            _vwprintf_p](https://msdn.microsoft.com/en-us/library/h72hc3e0\(v=vs.80\).aspx), [_vsprintf_p,  
                                            _vswprintf_p](https://msdn.microsoft.com/en-us/library/c8c2ax31\(v=vs.80\).aspx), and [_vfprintf_p,  
                                            _vfwprintf_p](https://msdn.microsoft.com/en-us/library/38hz5f36\(v=vs.80\).aspx).  
  
-   Unicode is now a supported text format. The function _open                                 supports _O_TEXTW, _O_UTF8 and _O_UTF16 attributes. The                                 fopen function supports the "ccs=ENCODING" method of specifying a                                 Unicode format. For more information, see [_open,  
                                            _wopen](https://msdn.microsoft.com/en-us/library/z0kc8e3z\(v=vs.80\).aspx) and [fopen,  
                                            _wfopen](https://msdn.microsoft.com/en-us/library/yeby3zcb\(v=vs.80\).aspx) and [fopen_s,  
                                            _wfopen_s](https://msdn.microsoft.com/en-us/library/z5hh6ee9\(v=vs.80\).aspx).  
  
-   A new version of the CRT libraries built in managed code (MSIL)                                 is now available and is used when compiling with the [/clr  
                                            (Common Language Runtime Compilation)](https://msdn.microsoft.com/en-us/library/k8d11d4s\(v=vs.80\).aspx) option. See [C  
                                            Run-Time Libraries](https://msdn.microsoft.com/en-us/library/abx4dbyh\(v=vs.80\).aspx) for more information.  
  
-   [_fileinfo](https://msdn.microsoft.com/en-us/library/ecthkkx5\(v=vs.80\).aspx) has been removed.  
  
-   The default size for time_t is now 64 bits, which expands                                 the range of time_t and several of the time functions out to the year                                 3000. See [Time  
                                            Management](https://msdn.microsoft.com/en-us/library/w4ddyt9h\(v=vs.80\).aspx), and the individual time functions.  
  
-   The CRT now supports setting the locale on a per thread basis.                                 The function [_configthreadlocale](https://msdn.microsoft.com/en-us/library/26c0tb7x\(v=vs.80\).aspx) was added to support this feature.  
  
-   The [_statusfp2](https://msdn.microsoft.com/en-us/library/9st43tcf\(v=vs.80\).aspx) and [__control87_2](https://msdn.microsoft.com/en-us/library/e9b52ceh\(v=vs.80\).aspx) functions were added to allow access to and control of the floating point                                 control word on both the x87 and SSE2 floating point processor.  
  
-   The[_mkgmtime  
                                            and _mkgmtime64](https://msdn.microsoft.com/en-us/library/2093ets1\(v=vs.80\).aspx) functions were added to provide support for converting                                 times (struct tm) to Greenwich Mean Time (GMT).  
  
-   Changes were made to swprintf and [vswprintf](https://msdn.microsoft.com/en-us/library/28d5ce15\(v=vs.80\).aspx) to better conform with the standard. For more information, see [sprintf,  
                                            _sprintf_l, swprintf, _swprintf_l, \__swprintf_l](https://msdn.microsoft.com/en-us/library/ybk95axf\(v=vs.80\).aspx).  
  
-   A new header file, INTRIN.H, provides prototypes for some                                 intrinsic functions.  
  
-   The [fopen](https://msdn.microsoft.com/en-us/library/yeby3zcb\(v=vs.80\).aspx) function now has an N attribute.  
  
-   The [_open](https://msdn.microsoft.com/en-us/library/z0kc8e3z\(v=vs.80\).aspx) function now has an _O_NOINHERIT attribute.  
  
-   The [atoi](https://msdn.microsoft.com/en-us/library/hc25t012\(v=vs.80\).aspx) function now returns INT_MAX and sets errno to ERANGE on                                 overflow. In previous versions, the overflow behavior was undefined.  
  
-   The [printf](https://msdn.microsoft.com/en-us/library/wc7014hz\(v=vs.80\).aspx) family of functions supports hexadecimal floating point output implemented                                 according to the ANSI C99 standard using the format type specifiers %a                                 and %A. For more information, see [printf  
                                            Type Field Characters](https://msdn.microsoft.com/en-us/library/hf4y5e3w\(v=vs.80\).aspx).  
  
-   The printf family now supports the "ll" (long                                 long) size prefix. For more information, see [Size and  
                                            Distance Specification](https://msdn.microsoft.com/en-us/library/tcxf1dw6\(v=vs.80\).aspx).  
  
-   The [_controlfp](https://msdn.microsoft.com/en-us/library/e9b52ceh\(v=vs.80\).aspx) function has been optimized for better performance.  
  
-   Debug versions of some functions have been added. For more                                 information, see [_strdup_dbg,  
                                            _wcsdup_dbg](https://msdn.microsoft.com/en-us/library/3yf2858b\(v=vs.80\).aspx), [_tempnam_dbg,  
                                            _wtempnam_dbg](https://msdn.microsoft.com/en-us/library/6yfsyebs\(v=vs.80\).aspx), [_getcwd_dbg,  
                                            _wgetcwd_dbg](https://msdn.microsoft.com/en-us/library/6w0115c9\(v=vs.80\).aspx), [_getdcwd_dbg,  
                                            _wgetdcwd_dbg](https://msdn.microsoft.com/en-us/library/0d889d5x\(v=vs.80\).aspx),[_fullpath_dbg,  
                                            _wfullpath_dbg](https://msdn.microsoft.com/en-us/library/ce8baf8z\(v=vs.80\).aspx).  
  
-   Added _chgsignl and _cpysignl (long double                                 versions).  
  
-   Added _locale_t type to type table.  
  
-   New macro [_countof  
                                            Macro](https://msdn.microsoft.com/en-us/library/ms175773\(v=vs.80\).aspx) added for computing number of elements in an array.  
  
-   In each function topic, a section on .NET Framework equivalents                                 has been added.  
  
-   Several string functions now have the option of truncating                                 strings rather than failing when output buffers are too small; see [_TRUNCATE](https://msdn.microsoft.com/en-us/library/ms175769\(v=vs.80\).aspx).  
  
-   [_set_se_translator](https://msdn.microsoft.com/en-us/library/5z4bw5h5\(v=vs.80\).aspx) now requires the use of the [/EHa](https://msdn.microsoft.com/en-us/library/1deeycx5\(v=vs.80\).aspx) compiler option.  
  
-   fpos_t is now __int64 under /Za (for C code) and                                 when \__STDC\_\_ is set manually (for C++ code). It used to be a struct.  
  
-   [_CRT_DISABLE_PERFCRIT_LOCKS](https://msdn.microsoft.com/en-us/library/ms235356\(v=vs.80\).aspx) can improve the I/O performance of single-threaded programs.  
  
-   POSIX names have been deprecated in favor of ISO C++ conformant                                 names (for example, use [_getch](https://msdn.microsoft.com/en-us/library/078sfkak\(v=vs.80\).aspx) rather than [getch](https://msdn.microsoft.com/en-us/library/ms235446\(v=vs.80\).aspx)).  
  
-   New link options .obj files are available for pure mode. See [Link  
                                            Options](https://msdn.microsoft.com/en-us/library/ms235330\(v=vs.80\).aspx) for more details.  
  
-   [_recalloc](https://msdn.microsoft.com/en-us/library/ms235322\(v=vs.80\).aspx) combines features of [realloc](https://msdn.microsoft.com/en-us/library/xbebcx7d\(v=vs.80\).aspx) and [calloc](https://msdn.microsoft.com/en-us/library/3f8w183e\(v=vs.80\).aspx).  
  
## Visual C++ 2008 - 2015  
  
-   [What's New for Visual C++ in Visual Studio 2008](https://msdn.microsoft.com/library/bb384632\(v=vs.90\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2010](https://msdn.microsoft.com/library/dd465215\(v=vs.100\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2012](https://msdn.microsoft.com/library/hh409293\(v=vs.110\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2013](https://msdn.microsoft.com/library/hh409293\(v=vs.120\).aspx)  
  
-   [What's New for Visual C++ in Visual Studio 2015](https://msdn.microsoft.com/library/hh409293\(v=vs.140\).aspx)  
  
## See Also  
 [Visual C++ Porting and Upgrading Guide](../vs140/visual-c---porting-and-upgrading-guide.md)