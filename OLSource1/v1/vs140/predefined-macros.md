---
title: "Predefined Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "_ATL_VER"
  - "__ATOM__"
  - "__AVX__"
  - "__AVX2__"
  - "_CHAR_UNSIGNED"
  - "__CLR_VER"
  - "_CONTROL_FLOW_GUARD"
  - "__COUNTER__"
  - "__cplusplus"
  - "__cplusplus_cli"
  - "__cplusplus_winrt"
  - "_CPPRTTI"
  - "_CPPUNWIND"
  - "__DATE__"
  - "_DEBUG"
  - "_DLL"
  - "__FILE__"
  - "__FUNCDNAME__"
  - "__FUNCSIG__"
  - "__FUNCTION__"
  - "_INTEGRAL_MAX_BITS"
  - "_ISO_VOLATILE"
  - "_KERNEL_MODE"
  - "__LINE__"
  - "_M_AMD64"
  - "_M_ARM"
  - "_M_ARM_ARMV7VE"
  - "_M_ARM_FP"
  - "_M_ARM64"
  - "_M_CEE"
  - "_M_CEE_PURE"
  - "_M_CEE_SAFE"
  - "_M_FP_EXCEPT"
  - "_M_FP_FAST"
  - "_M_FP_PRECISE"
  - "_M_FP_STRICT"
  - "_M_IX86"
  - "_M_IX86_FP"
  - "_M_X64"
  - "_MANAGED"
  - "_MFC_VER"
  - "_MSC_BUILD"
  - "_MSC_EXTENSIONS"
  - "_MSC_FULL_VER"
  - "_MSC_VER"
  - "_MSVC_LANG"
  - "__MSVC_RUNTIME_CHECKS"
  - "_MT"
  - "_NATIVE_WCHAR_T_DEFINED"
  - "_NO_SIZED_DEALLOCATION"
  - "_OPENMP"
  - "_PREFAST_"
  - "_RESUMABLE_FUNCTIONS_SUPPORTED"
  - "_RTC_CONVERSION_CHECKS_ENABLED"
  - "__STDC__"
  - "__STDC_HOSTED__"
  - "__STDCPP_THREADS__"
  - "__TIME__"
  - "__TIMESTAMP__"
  - "__VA_ARGS__"
  - "_VC_NODEFAULTLIB"
  - "_WCHAR_T_DEFINED"
  - "_WIN32"
  - "_WIN64"
  - "_WINRT_DLL"
  - "__func__"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "timestamps, preprocessor macro"
  - "cl.exe compiler, version number"
  - "version numbers, C/C++ compiler (cl.exe)"
  - "macros, predefined C++"
  - "preprocessor, macros"
  - "predefined macros"
  - "_ATL_VER macro"
  - "__ATOM__ macro"
  - "__AVX__ macro"
  - "__AVX2__ macro"
  - "_CHAR_UNSIGNED macro"
  - "__CLR_VER macro"
  - "_CONTROL_FLOW_GUARD macro"
  - "__COUNTER__ macro"
  - "__cplusplus macro"
  - "__cplusplus_cli macro"
  - "__cplusplus_winrt macro"
  - "_CPPRTTI macro"
  - "_CPPUNWIND macro"
  - "__DATE__ macro"
  - "_DEBUG macro"
  - "_DLL macro"
  - "__FILE__ macro"
  - "__FUNCDNAME__ macro"
  - "__FUNCSIG__ macro"
  - "__FUNCTION__ macro"
  - "_INTEGRAL_MAX_BITS macro"
  - "_ISO_VOLATILE macro"
  - "_KERNEL_MODE macro"
  - "__LINE__ macro"
  - "_M_AMD64 macro"
  - "_M_ARM macro"
  - "_M_ARM_ARMV7VE macro"
  - "_M_ARM_FP macro"
  - "_M_ARM64 macro"
  - "_M_CEE macro"
  - "_M_CEE_PURE macro"
  - "_M_CEE_SAFE macro"
  - "_M_FP_EXCEPT macro"
  - "_M_FP_FAST macro"
  - "_M_FP_PRECISE macro"
  - "_M_FP_STRICT macro"
  - "_M_IX86 macro"
  - "_M_IX86_FP macro"
  - "_M_X64 macro"
  - "_MANAGED macro"
  - "_MFC_VER macro"
  - "_MSC_BUILD macro"
  - "_MSC_EXTENSIONS macro"
  - "_MSC_FULL_VER macro"
  - "_MSC_VER macro"
  - "_MSVC_LANG macro"
  - "__MSVC_RUNTIME_CHECKS macro"
  - "_MT macro"
  - "_NATIVE_WCHAR_T_DEFINED macro"
  - "_NO_SIZED_DEALLOCATION macro"
  - "_OPENMP macro"
  - "_PREFAST_ macro"
  - "_RESUMABLE_FUNCTIONS_SUPPORTED macro"
  - "_RTC_CONVERSION_CHECKS_ENABLED macro"
  - "__STDC__ macro"
  - "__STDC_HOSTED__ macro"
  - "__STDCPP_THREADS__ macro"
  - "__TIME__ macro"
  - "__TIMESTAMP__ macro"
  - "__VA_ARGS__ macro"
  - "_VC_NODEFAULTLIB macro"
  - "_WCHAR_T_DEFINED macro"
  - "_WIN32 macro"
  - "_WIN64 macro"
  - "_WINRT_DLL macro"
  - "__func__ identifier"
ms.assetid: 1cc5f70a-a225-469c-aed0-fe766238e23f
caps.latest.revision: 79
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Predefined Macros
The Visual C++ compiler predefines certain preprocessor macros, depending on the language (C or C++), the compilation target, and the chosen compiler options.  
  
 Visual C++ supports the required predefined preprocessor macros specified by the ANSI/ISO C99 standard and the ISO C++14 standard. The implementation also supports several more Microsoft-specific preprocessor macros. Some macros are defined only for specific build environments or compiler options. Unless noted, the macros are defined throughout a translation unit as if they were specified as **/D** compiler option arguments. When defined, the macros are expanded to the specified values by the preprocessor before compilation. The predefined macros take no arguments and cannot be redefined.  
  
## Standard predefined identifier  
 The compiler supports this predefined identifier specified by ISO C99 and ISO C++11.  
  
-   **__func\_\_** The unqualified and unadorned name of the enclosing function as a function-local <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> array of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Standard predefined macros  
 The compiler supports these predefined macros specified by the ISO C99 and ISO C++14 standards.  
  
-   **__cplusplus** Defined as an integer literal value when the translation unit is compiled as C++. Otherwise, undefined.  
  
-   **__DATE\_\_** The compilation date of the current source file. The date is a constant length string literal of the form *Mmm dd yyyy*. The month name *Mmm* is the same as the abbreviated month name in dates generated by the C Runtime Library [asctime](../vs140/asctime--_wasctime.md) function. The first character of date *dd* is a space if the value is less than 10. This macro is always defined.  
  
-   **__FILE\_\_** The name of the current source file. **__FILE\_\_** expands to a character string literal. To ensure that the full path to the file is displayed, use [/FC (Full Path of Source Code File in Diagnostics)](../vs140/-fc--full-path-of-source-code-file-in-diagnostics-.md). This macro is always defined.  
  
-   **__LINE\_\_** Defined as the integer line number in the current source file. The value of the **__LINE\_\_** macro can be changed by using a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive. This macro is always defined.  
  
-   **__STDC\_\_** Defined as 1 only when compiled as C and if the [/Za](../vs140/-za---ze--disable-language-extensions-.md) compiler option is specified. Otherwise, undefined.  
  
-   **__STDC_HOSTED\_\_** Defined as 1 if the implementation is a *hosted implementation*, one that supports the entire required standard library. Otherwise, defined as 0.  
  
-   **__STDCPP_THREADS\_\_** Defined as 1 if and only if a program can have more than one thread of execution, and compiled as C++. Otherwise, undefined.  
  
-   **__TIME\_\_** The time of translation of the preprocessed translation unit. The time is a character string literal of the form *hh:mm:ss*, the same as the time returned by the C Runtime Library [asctime](../vs140/asctime--_wasctime.md) function. This macro is always defined.  
  
## Microsoft-specific predefined macros  
 Microsoft Visual C++ supports these additional predefined macros.  
  
-   **__ATOM\_\_** Defined as 1 when the [/favor:ATOM](../vs140/-favor--optimize-for-architecture-specifics-.md) compiler option is set and the compiler target is x86 or x64. Otherwise, undefined.  
  
-   **__AVX\_\_** Defined as 1 when the [/arch:AVX](../vs140/-arch--x86-.md) or [/arch:AVX2](../vs140/-arch--x86-.md) compiler options are set and the compiler target is x86 or x64. Otherwise, undefined.  
  
-   **__AVX2\_\_** Defined as 1 when the [/arch:AVX2](../vs140/-arch--x86-.md) compiler option is set and the compiler target is x86 or x64. Otherwise, undefined.  
  
-   **_CHAR_UNSIGNED** Defined as 1 if the default <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type is unsigned. This is set when the [/J (Default char Type Is unsigned)](../vs140/-j--default-char-type-is-unsigned-.md) compiler option is set. Otherwise, undefined.  
  
-   **__CLR_VER** Defined as an integer literal that represents the version of the common language runtime used when the application was compiled. The value is encoded in the form <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is the major version of the runtime, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is the minor version of the runtime, and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is the build number. **__CLR_VER** is defined if the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   **_CONTROL_FLOW_GUARD** Defined as 1 when the [/guard:cf (Enable Control Flow Guard)](../vs140/-guard--enable-control-flow-guard-.md) compiler option is set. Otherwise, undefined.  
  
-   **__COUNTER\_\_** Expands to an integer literal that starts at 0 and is incremented by 1 every time it is used in a source file or included headers of the source file. **__COUNTER\_\_** remembers its state when you use precompiled headers. This macro is always defined.  
  
     This example uses <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to assign unique identifiers to three different objects of the same type. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> constructor takes an integer as a parameter. In <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, the application declares three objects of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, using <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> as the unique identifier parameter:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
-   **__cplusplus_cli** Defined as the integer literal value 200406 when compiled as C++ and the [/clr](../vs140/-clr--common-language-runtime-compilation-.md), [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md), or [/clr:safe](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined. When defined, **__cplusplus_cli** is in effect throughout the translation unit.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
-   **__cplusplus_winrt** Defined as the integer literal value 201009 when compiled as C++ and the [/ZW](../vs140/-zw--windows-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_CPPRTTI** Defined as 1 if the [/GR (Enable Run-Time Type Information)](../vs140/-gr--enable-run-time-type-information-.md) compiler option is set. Otherwise, undefined.  
  
-   **_CPPUNWIND** Defined as 1 if one or more of the [/GX](../vs140/-gx--enable-exception-handling-.md), [/clr](../vs140/-clr--common-language-runtime-compilation-.md), or [/EH (Exception Handling Model)](../vs140/-eh--exception-handling-model-.md) compiler options are set. Otherwise, undefined.  
  
-   **_DEBUG** Defined as 1 when the [/LDd](../vs140/-md---mt---ld--use-run-time-library-.md), [/MDd](../vs140/-md---mt---ld--use-run-time-library-.md), or [/MTd](../vs140/-md---mt---ld--use-run-time-library-.md) compiler option is set. Otherwise, undefined.  
  
-   **_DLL** Defined as 1 when the [/MD](../vs140/-md---mt---ld--use-run-time-library-.md) or [/MDd](../vs140/-md---mt---ld--use-run-time-library-.md) (Multithreaded DLL) compiler option is set. Otherwise, undefined.  
  
-   **__FUNCDNAME\_\_** Defined as a string literal that contains the [decorated name](../vs140/decorated-names.md) of the enclosing function. The macro is defined only within a function. The **__FUNCDNAME\_\_** macro is not expanded if you use the [/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md) or [/P](../vs140/-p--preprocess-to-a-file-.md) compiler option.  
  
     This example uses the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> macros to display function information.  
  
     [!code[NVC_Predefined_Macros_Examples#1](../vs140/codesnippet/CPP/predefined-macros_1.cpp)]  
  
-   **__FUNCSIG\_\_** Defined as a string literal that contains the signature of the enclosing function. The macro is defined only within a function. The **__FUNCSIG\_\_** macro is not expanded if you use the [/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md) or [/P](../vs140/-p--preprocess-to-a-file-.md) compiler option. When compiled for a 64-bit target, the calling convention is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> by default. For an example of usage, see the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> macro.  
  
-   **__FUNCTION\_\_** Defined as a string literal that contains the undecorated name of the enclosing function. The macro is defined only within a function. The **__FUNCTION\_\_** macro is not expanded if you use the [/EP](../vs140/-ep--preprocess-to-stdout-without-sharpline-directives-.md) or [/P](../vs140/-p--preprocess-to-a-file-.md) compiler option. For an example of usage, see the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> macro.  
  
-   **_INTEGRAL_MAX_BITS** Defined as the integer literal value 64, the maximum size (in bits) for a non-vector integral type. This macro is always defined.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
-   **__INTELLISENSE\_\_** Defined as 1 during an IntelliSense compiler pass in the Visual Studio IDE. Otherwise, undefined. You can use this macro to guard code the IntelliSense compiler does not understand, or use it to toggle between the build and IntelliSense compiler. For more information, see [Troubleshooting Tips for IntelliSense Slowness](https://blogs.msdn.microsoft.com/vcblog/2011/03/29/troubleshooting-tips-for-intellisense-slowness/).  
  
-   **_ISO_VOLATILE** Defined as 1 if the [/volatile:iso](../vs140/-volatile--volatile-keyword-interpretation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_KERNEL_MODE** Defined as 1 if the [/kernel](../vs140/-kernel--create-kernel-mode-binary-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_AMD64** Defined as the integer literal value 100 for compilations that target x64 processors. Otherwise, undefined.  
  
-   **_M_ARM** Defined as the integer literal value 7 for compilations that target ARM processors. Otherwise, undefined.  
  
-   **_M_ARM_ARMV7VE** Defined as 1 when the [/arch:ARMv7VE](../vs140/-arch--arm-.md) compiler option is set for compilations that target ARM processors. Otherwise, undefined.  
  
-   **_M_ARM_FP** Defined as an integer literal value that indicates which [/arch](../vs140/-arch--arm-.md) compiler option was set, if the compilation target is an ARM processor. Otherwise, undefined.  
  
    -   In the range 30-39 if no **/arch** ARM option was specified, indicating the default architecture for ARM was set (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>).  
  
    -   In the range 40-49 if **/arch:VFPv4** was set.  
  
    -   See [/arch (ARM)](../vs140/-arch--arm-.md) for more information.  
  
-   **_M_ARM64** Defined as 1 for compilations that target 64-bit ARM processors. Otherwise, undefined.  
  
-   **_M_CEE** Defined as 001 if any [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_CEE_PURE** Defined as 001 if the [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_CEE_SAFE** Defined as 001 if the [/clr:safe](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_FP_EXCEPT** Defined as 1 if the [/fp:except](../vs140/-fp--specify-floating-point-behavior-.md) or [/fp:strict](../vs140/-fp--specify-floating-point-behavior-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_FP_FAST** Defined as 1 if the [/fp:fast](../vs140/-fp--specify-floating-point-behavior-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_FP_PRECISE** Defined as 1 if the [/fp:precise](../vs140/-fp--specify-floating-point-behavior-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_FP_STRICT** Defined as 1 if the [/fp:strict](../vs140/-fp--specify-floating-point-behavior-.md) compiler option is set. Otherwise, undefined.  
  
-   **_M_IX86** Defined as the integer literal value 600 for compilations that target x86 processors. This macro is not defined for x64 or ARM compilation targets.  
  
-   **_M_IX86_FP** Defined as an integer literal value that indicates the [/arch](../vs140/-arch--arm-.md) compiler option that was set, or the default. This macro is always defined when the compilation target is an x86 processor. Otherwise, undefined. When defined, the value is:  
  
    -   0 if the **/arch:IA32** compiler option was set.  
  
    -   1 if the **/arch:SSE** compiler option was set.  
  
    -   2 if the **/arch:SSE2**, **/arch:AVX** or **/arch:AVX2** compiler option was set. This value is the default if an **/arch** compiler option was not specified. When **/arch:AVX** is specified, the macro **__AVX\_\_** is also defined. When **/arch:AVX2** is specified, both **__AVX\_\_** and **__AVX2\_\_** are also defined.  
  
    -   See [/arch (x86)](../vs140/-arch--x86-.md) for more information.  
  
-   **_M_X64** Defined as the integer literal value 100 for compilations that target x64 processors. Otherwise, undefined.  
  
-   **_MANAGED** Defined as 1 when the [/clr](../vs140/-clr--common-language-runtime-compilation-.md) compiler option is set. Otherwise, undefined.  
  
-   **_MSC_BUILD** Defined as an integer literal that contains the revision number element of the compiler's version number. The revision number is the fourth element of the period-delimited version number. For example, if the version number of the Visual C++ compiler is 15.00.20706.01, the **_MSC_BUILD** macro evaluates to 1. This macro is always defined.  
  
-   **_MSC_EXTENSIONS** Defined as 1 if the [/Ze (Enable Language Extensions)](../vs140/-za---ze--disable-language-extensions-.md) compiler option is set, which is the default. Otherwise, undefined.  
  
-   **_MSC_FULL_VER** Defined as an integer literal that encodes the major, minor, and build number elements of the compiler's version number. The major number is the first element of the period-delimited version number, the minor number is the second element, and the build number is the third element. For example, if the version number of the Visual C++ compiler is 15.00.20706.01, the **_MSC_FULL_VER** macro evaluates to 150020706. Enter **cl /?** at the command line to view the compiler's version number. This macro is always defined.  
  
-   **_MSC_VER** Defined as an integer literal that encodes the major and minor number elements of the compiler's version number. The major number is the first element of the period-delimited version number and the minor number is the second element. For example, if the version number of the Visual C++ compiler is 17.00.51106.1, the **_MSC_VER** macro evaluates to 1700. Enter **cl /?** at the command line to view the compiler's version number. This macro is always defined.  
  
-   **_MSVC_LANG** Defined as an integer literal that specifies the C++ language standard targeted by the compiler. When compiled as C++, the macro is the integer literal value 201402 if the [/std:c++14](../vs140/-std--specify-language-standard-version-.md) compiler option is set, or by default, and it is set to a higher, unspecified value when the [/std:c++latest](../vs140/-std--specify-language-standard-version-.md) compiler option is set. Otherwise, the macro is undefined. The **_MSVC_LANG** macro and [/std](../vs140/-std--specify-language-standard-version-.md) compiler options are available beginning in Visual Studio 2015 Update 3.  
  
-   **__MSVC_RUNTIME_CHECKS** Defined as 1 when one of the [/RTC](../vs140/-rtc--run-time-error-checks-.md) compiler options is set. Otherwise, undefined.  
  
-   **_MT** Defined as 1 when [/MD or /MDd](../vs140/-md---mt---ld--use-run-time-library-.md) (Multithreaded DLL) or [/MT or /MTd](../vs140/-md---mt---ld--use-run-time-library-.md) (Multithreaded) is specified. Otherwise, undefined.  
  
-   **_NATIVE_WCHAR_T_DEFINED** Defined as 1 when the [/Zc:wchar_t](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) compiler option is set. Otherwise, undefined.  
  
-   **_OPENMP** Defined as integer literal 200203, representing the date of the OpenMP specification implemented by Visual C++, if the [/openmp](../vs140/-openmp--enable-openmp-2.0-support-.md) compiler option is set. Otherwise, undefined.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
-   **_PREFAST\_** Defined as 1 when the [/analyze](../vs140/-analyze--code-analysis-.md) compiler option is set. Otherwise, undefined.  
  
-   **__TIMESTAMP\_\_** Defined as a string literal that contains the date and time of the last modification of the current source file, in the abbreviated, constant length form returned by the C Runtime Library [asctime](../vs140/asctime--_wasctime.md) function, for example, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. This macro is always defined.  
  
-   **_VC_NODEFAULTLIB** Defined as 1 when the [/Zl (Omit Default Library Name)](../vs140/-zl--omit-default-library-name-.md) compiler option is set. Otherwise, undefined.  
  
-   **_WCHAR_T_DEFINED** Defined as 1 when the default [/Zc:wchar_t](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) compiler option is set. The **_WCHAR_T_DEFINED** macro is defined but has no value if the **/Zc:wchar_t-** compiler option is set, and <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> is defined in a system header file included in your project. Otherwise, undefined.  
  
-   **_WIN32** Defined as 1 when the compilation target is 32-bit ARM, 64-bit ARM, x86, or x64. Otherwise, undefined.  
  
-   **_WIN64** Defined as 1 when the compilation target is 64-bit ARM or x64. Otherwise, undefined.  
  
-   **_WINRT_DLL** Defined as 1 when compiled as C++ and both [/ZW](../vs140/-zw--windows-runtime-compilation-.md) and [/LD or /LDd](../vs140/-md---mt---ld--use-run-time-library-.md) compiler options are set. Otherwise, undefined.  
  
 Preprocessor macros used to determine the ATL or MFC library version are not predefined by the compiler. These macros are defined in the headers for the library, so they are undefined in preprocessor directives before the required header is included.  
  
-   **_ATL_VER** Defined in \<atldef.h> as an integer literal that encodes the ATL version number.  
  
-   **_MFC_VER** Defined in \<afxver_.h> as an integer literal that encodes the MFC version number.  
  
## See Also  
 [Macros (C/C++)](../vs140/macros--c-c---.md)   
 [Preprocessor Operators](../vs140/preprocessor-operators.md)   
 [Preprocessor Directives](../vs140/preprocessor-directives.md)