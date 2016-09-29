---
title: "Breaking Changes in Visual C++ 2015"
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
  - "breaking changes [C++]"
ms.assetid: b38385a9-a483-4de9-99a6-797488bc5110
caps.latest.revision: 125
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Breaking Changes in Visual C++ 2015
When you upgrade to a new version of the Visual C++ compiler, you might encounter compilation and/or runtime errors in code that previously compiled and ran correctly. Changes in the new version that cause such problems are known as *breaking changes*, and typically they're required by modifications in the C++ language standard, function signatures, or the layout of objects in memory.  
  
 To avoid run-time errors that are difficult to detect and diagnose, we recommend that you never statically link to binaries that were compiled by using different versions of the compiler. Also, when you upgrade an EXE or DLL project, make sure to upgrade the libraries that it links to. If you're using CRT (C Runtime) or STL (Standard Template Library) types, don't pass them between binaries (including DLLs) that were compiled by using different versions of the compiler. For more information, see [Potential Errors Passing CRT Objects Across DLL Boundaries](../vs140/potential-errors-passing-crt-objects-across-dll-boundaries.md).  
  
 We further recommend that you never write code that depends on a particular layout for an object that is not a COM interface or a POD object. If you do write such code, then you must ensure that it works after you upgrade. For more information, see [Portability at ABI Boundaries (Modern C++)](../vs140/portability-at-abi-boundaries--modern-c---.md).  
  
 Additionally, ongoing improvements to compiler conformance can sometimes change how the compiler understands your existing source code. When this happens, you might encounter new or different errors during your build, or even behavioral differences in code that previously built and seemed to run correctly. Although these are not breaking changes like the ones discussed in this document, source code changes might be needed to resolve these issues. For more information, see [Compiler Conformance Improvements in Visual C++ 2015](../vs140/compiler-conformance-improvements-in-visual-c---2015.md).  
  
 The rest of this article describes specific breaking changes in [!INCLUDE[cpp_dev14_long](../vs140/includes/cpp_dev14_long_md.md)], and in this article the terms "new behavior" or "now" refer to that version. The terms "old behavior" and "before" refer to Visual Studio 2013 and earlier releases.  
  
1.  [C Runtime (CRT) Library Breaking Changes](#BK_CRT)  
  
2.  [Standard C++ and Standard Template Library (STL) Breaking Changes](#BK_STL)  
  
3.  [MFC and ATL Breaking Changes](#BK_MFC)  
  
4.  [Concurrency Runtime Breaking Changes](#BK_ConcRT)  
  
##  <a name="BK_CRT"></a> C Runtime Library (CRT)  
  
### General Changes  
  
-   **Refactored binaries**  
  
     The CRT Library  has been refactored into a two different binaries, a Universal CRT (ucrtbase), which contains most of the standard functionality, and a VC Runtime Library (vcruntime140), which contains the compiler-related functionality, such as exception handling, and intrinsics. If you are using the default project settings, then this change does not impact you since the linker will use the new default libraries automatically. If you have set the project's **Linker** property **Ignore All Default Libraries** to **Yes** or you are using the /NODEFAULTLIB linker option on the command line, or if you are using a custom entry point (/ENTRY linker option), then you must update your list of libraries (in the **Additional Dependencies** linker property) to include the new, refactored libraries. Replace the old CRT library (libcmt.lib, libcmtd.lib, msvcrt.lib, msvcrtd.lib) with the equivalent refactored libraries. For each of the two refactored libraries, there are static (.lib) and dynamic (.dll) versions, and release (with no suffix) and debug versions (with the "d" suffix). The dynamic versions have an import library that you link with. The two refactored libraries are Universal CRT, specifically ucrtbase.dll or .lib, ucrtbased.dll or .lib, and the VC runtime library, libvcruntime.lib, libvcruntime.dll, libvcruntimed.lib, and libvcruntimed.dll. See [CRT Library Features](../vs140/crt-library-features.md).  
  
### <locale.h>  
  
-   **localeconv**  
  
     The [localeconv](../vs140/localeconv.md) function declared in locale.h now works correctly when [per-thread locale](../vs140/multithreading-and-locales.md) is enabled. In previous versions of the library, this function would return the lconv data for the global locale, not the thread's locale.  
  
     If you use per thread locale, you should check your use of localeconv to see if your code assumes that the lconv data returned is for the global locale and modify it appropriately.  
  
### <math.h>  
  
-   **C++ overloads of math library functions**  
  
     In previous versions, <math.h> defined some, but not all, of the C++ overloads for the math library functions. \<cmath> defined the remaining overloads, so to get all of the overloads, one needed to include the \<cmath> header. This led to problems with function overload resolution in code that only included <math.h>. Now, all C++ overloads have been removed from <math.h> and are now present only in \<cmath>.  
  
     To resolve errors, include \<cmath> to get the declarations of the functions that were removed from <math.h>. The following table lists the functions that were moved.  
  
     Functions that were moved:  
  
    1.  double abs(double) and float abs(float)  
  
    2.  double pow(double, int), float pow(float, float), float pow(float, int), long double pow(long double, long double), long double pow(long double, int)  
  
    3.  float and long double versions of floating point functions acos, acosh, asin, asinh, atan, atanh, atan2, cbrt, ceil, copysign, cos, cosh, erf, erfc, exp, exp2, expm1, fabs, fdim, floor, fma, fmax, fmin, fmod, frexp, hypot, ilogb, ldexp, lgamma, llrint, llround, log, log10, log1p, log2, lrint, lround, modf, nearbyint, nextafter, nexttoward, remainder, remquo, rint, round, scalbln, scalbn, sin, sinh, sqrt, tan, tanh, tgamma, trunc  
  
     If you have code that uses abs with a floating point type that only includes the math.h header, the floating point versions will no longer be available, so the call, even with a floating point argument, now resolves to abs(int). This produces the error:  
  
 **warning C4244: 'argument' : conversion from 'float' to 'int', possible loss of data**     The fix for this warning is to replace the call to abs with a floating point version of abs, such as fabs for a double argument or fabsf for a float argument, or include the cmath header and continue to use abs.  
  
-   **Floating point conformance**  
  
     Many changes to the math library have been made to improve conformance to the IEEE-754 and C11 Annex F specifications with respect to special case inputs such as NaNs and infinities. For example, quiet NaN inputs, which were often treated as errors in previous versions of the library, are no longer treated as errors. See [IEEE 754 Standard](http://grouper.ieee.org/groups/754) and Annex F of the [C11 Standard](http://www.iso-9899.info/wiki/The_Standard).  
  
     These changes won't cause compile-time errors, but might cause programs to behave differently and more correctly according to the standard.  
  
-   **FLT_ROUNDS**  
  
     In Visual Studio 2013, the FLT_ROUNDS macro expanded to a constant expression, which was incorrect because the rounding mode is configurable at runtime, for example, by calling fesetround. The FLT_ROUNDS macro is now dynamic and correctly reflects the current rounding mode.  
  
### \<new> and <new.h>  
  
-   **new and delete**  
  
     In previous versions of the library, the implementation-defined operator new and delete functions were exported from the runtime library DLL (for example, msvcr120.dll). These operator functions are now always statically linked into your binaries, even when using the runtime library DLLs.  
  
     This is not a breaking change for native or mixed code (/clr), however for code compiled as [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md), this might cause your code to fail to compile. If you compile code as /clr:pure, you may need to add #include <new> or #include <new.h> to work around build errors due to this change. Note that /clr:pure is deprecated in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] and might be removed in future releases.  
  
### <process.h>  
  
-   **_beginthread and _beginthreadex**  
  
     The [_beginthread](../vs140/_beginthread--_beginthreadex.md) and [_beginthreadex](../vs140/_beginthread--_beginthreadex.md) functions now hold a reference to the module in which the thread procedure is defined for the duration of the thread. This helps to ensure that modules are not unloaded until a thread has run to completion.  
  
### <stdarg.h>  
  
-   **va_start and reference types**  
  
     When compiling C++ code, [va_start](../vs140/va_arg--va_copy--va_end--va_start.md) now validates at compile-time that the argument passed to it is not of reference type. Reference-type arguments are prohibited by the C++ Standard.  
  
### <stdio.h> and <conio.h>  
  
-   **The printf and scanf family of functions are now defined inline.**  
  
     The definitions of all of the printf and scanf functions have been moved inline into <stdio.h>, <conio.h>, and other CRT headers. This is a breaking change that leads to a linker error (LNK2019, unresolved external symbol) for any programs that declared these functions locally without including the appropriate CRT headers. If possible, you should update the code to include the CRT headers (that is, add #include <stdio.h>) and the inline functions, but if you do not want to modify your code to include these header files, an alternative solution is to add an additional library to your linker input, legacy_stdio_definitions.lib.  
  
     To add this library to your linker input in the IDE, open the context menu for the project node, choose **Properties**, then in the **Project Properties** dialog box, choose **Linker**, and edit the **Linker Input** to add legacy_stdio_definitions.lib to the semi-colon-separated list.  
  
     If your project links with static libraries that were compiled with a release of Visual C++ earlier than 2015, the linker might report an unresolved external symbol. These errors might reference internal stdio definitions for _iob, _iob_func, or related imports for certain stdio functions in the form of _imp_*. Microsoft recommends that you recompile all static libraries with the latest version of the Visual C++ compiler and libraries when you upgrade a project. If the library is a third-party library for which source is not available, you should either request an updated binary from the third party or encapsulate your usage of that library into a separate DLL that you compile with the older version of the Visual C++ compiler and libraries.  
  
    > [!WARNING]
    >  If you are linking with Windows SDK 8.1 or earlier, you might encounter these unresolved external symbol errors. In that case, you should resolve the error by adding legacy_stdio_definitions.lib to the linker input as described previously.  
  
     To troubleshoot unresolved symbol errors, you can try using [dumpbin.exe](../vs140/dumpbin-reference.md) to examine the symbols defined in a binary. Try the following command line to view symbols defined in a library.  
  
    ```  
    dumpbin.exe /LINKERMEMBER somelibrary.lib  
    ```  
  
-   **gets and _getws**  
  
     The [gets](../vs140/gets--_getws.md) and [_getws](../vs140/gets--_getws.md) functions have been removed. The gets function was removed from the C Standard Library in C11 because it cannot be used securely. The _getws function was a Microsoft extension that was equivalent to gets but for wide strings. As alternatives to these functions, consider use of [fgets](../vs140/fgets--fgetws.md), [fgetws](../vs140/fgets--fgetws.md), [gets_s](../vs140/gets_s--_getws_s.md), and [_getws_s](../vs140/gets_s--_getws_s.md).  
  
-   **_cgets and _cgetws**  
  
     The [_cgets](../vs140/_cgets--_cgetws.md) and [_cgetws](../vs140/_cgets--_cgetws.md) functions have been removed. As alternatives to these functions, consider use of [_cgets_s](../vs140/_cgets_s--_cgetws_s.md) and [_cgetws_s](../vs140/_cgets_s--_cgetws_s.md).  
  
-   **Infinity and NaN Formatting**  
  
     In previous versions, infinities and NaNs would be formatted using a set of Visual C++-specific sentinel strings.  
  
    -   Infinity: 1.#INF  
  
    -   Quiet NaN: 1.#QNAN  
  
    -   Signaling NaN: 1.#SNAN  
  
    -   Indefinite NaN: 1.#IND  
  
     Any of these may have been prefixed by a sign and may have been formatted slightly differently depending on field width and precision (sometimes with unusual effects, e.g. printf("%.2f\n", INFINITY) would print 1.#J because the #INF would be "rounded" to a precision of 2 digits). C99 introduced new requirements on how infinities and NaNs are to be formatted. The Visual C++ implementation now conforms to these requirements. The new strings are as follows:  
  
    -   Infinity: inf  
  
    -   Quiet NaN: nan  
  
    -   Signaling NaN: nan(snan)  
  
    -   Indefinite NaN:nan(ind)  
  
     Any of these may be prefixed by a sign. If a capital format specifier is used (%F instead of %f) then the strings are printed in capital letters (INF instead of inf), as is required.  
  
     The [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) functions have been modified to parse these new strings, so these strings will round-trip through printf and scanf.  
  
-   **Floating point formatting and parsing**  
  
     New floating point formatting and parsing algorithms have been introduced to improve correctness. This change affects the [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) and [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) families of functions, as well as functions like [strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md).  
  
     The old formatting algorithms would generate only a limited number of digits, then would fill the remaining decimal places with zero. This is usually good enough to generate strings that will round-trip back to the original floating point value, but it's not great if you want the exact value (or the closest decimal representation thereof). The new formatting algorithms generate as many digits as are required to represent the value (or to fill the specified precision). As an example of the improvement; consider the results when printing a large power of two:  
  
    ```  
    printf("%.0f\n", pow(2.0, 80))  
  
    ```  
  
  **Old:  1208925819614629200000000    New:  1208925819614629174706176**     The old parsing algorithms would consider only up to 17 significant digits from the input string and would discard the rest of the digits. This is sufficient to generate a very close approximation of the value represented by the string, and the result is usually very close to the correctly rounded result. The new implementation considers all present digits and produces the correctly rounded result for all inputs (up to 768 digits in length). In addition, these functions now respect the rounding mode (controllable via fesetround).  This is a potentially breaking behavior change because these functions might output different results. The new results are always more correct than the old results.  
  
-   **Hexadecimal and infinity/NaN floating point parsing**  
  
     The floating point parsing algorithms will now parse hexadecimal floating point strings (such as those generated by the %a and %A printf format specifiers) and all infinity and NaN strings that are generated by the printf functions, as described above.  
  
-   **%A and %a zero padding**  
  
     The %a and %A format specifiers format a floating point number as a hexadecimal mantissa and binary exponent. In previous versions, the printf functions would incorrectly zero-pad strings. For example, printf("%07.0a\n", 1.0) would print 00x1p+0, where it should print 0x01p+0. This has been fixed.  
  
-   **%A and %a precision**  
  
     The default precision of the %A and %a format specifiers was 6 in previous versions of the library. The default precision is now 13 for conformance with the C Standard.  
  
     This is a runtime behavior change in the output of any function that uses a format string with %A or %a. In the old behavior, the output using the %A specifier might be "1.1A2B3Cp+111". Now the output for the same value is "1.1A2B3C4D5E6F7p+111". To get the old behavior, you can specify the precision, for example, %.6A. See [Precision Specification](../vs140/precision-specification.md).  
  
-   **%F specifier**  
  
     The %F format/conversion specifier is now supported. It is functionally equivalent to the %f format specifier, except that infinities and NaNs are formatted using capital letters.  
  
     In previous versions, the implementation used to parse F and N as length modifiers. This behavior dated back to the age of segmented address spaces: these length modifiers were used to indicate far and near pointers, respectively, as in %Fp or %Ns. This behavior has been removed. If %F is encountered, it is now treated as the %F format specifier; if %N is encountered, it is now treated as an invalid parameter.  
  
-   **Exponent formatting**  
  
     The %e and %E format specifiers format a floating point number as a decimal mantissa and exponent. The %g and %G format specifiers also format numbers in this form in some cases. In previous versions, the CRT would always generate strings with three-digit exponents. For example, printf("%e\n", 1.0) would print 1.000000e+000. This was incorrect: C requires that if the exponent is representable using only one or two digits, then only two digits are to be printed.  
  
     In Visual Studio 2005 a global conformance switch was added: [_set_output_format](../vs140/_set_output_format.md). A program could call this function with the argument _TWO_DIGIT_EXPONENT, to enable conforming exponent printing. The default behavior has been changed to the standards-conforming exponent printing mode.  
  
-   **Format string validation**  
  
     In previous versions, the printf and scanf functions would silently accept many invalid format strings, sometimes with unusual effects. For example, %hlhlhld would be treated as %d. All invalid format strings are now treated as invalid parameters.  
  
-   **fopen mode string validation**  
  
     In previous versions, the fopen family of functions silently accepted some invalid mode strings (e.g. r+b+). Invalid mode strings are now detected and treated as invalid parameters.  
  
-   **_O_U8TEXT mode**  
  
     The [_setmode](../vs140/_setmode.md) function now correctly reports the mode for streams opened in_O_U8TEXT mode. In previous versions of the library, it would report such streams as being opened in _O_WTEXT.  
  
     This is a breaking change if your code interprets the _O_WTEXT mode for streams where the encoding is UTF-8. If your application doesn't support UTF_8, consider adding support for this increasingly common encoding.  
  
-   **snprintf and vsnprintf**  
  
     The [snprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md) and [vsnprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) functions are now implemented. Older code often provided definitions macro versions of these functions because they were not implemented by the CRT library, but these are no longer needed in newer versions. If [snprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md) or [vsnprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) is defined as a macro before including <stdio.h>, compilation now fails with an error that indicates where the macro was defined.  
  
     Normally, the fix to this problem is to delete any declarations of snprintf or vsnprintf in user code.  
  
-   **tmpnam Generates Usable File Names**  
  
     In previous versions, the tmpnam and tmpnam_s functions generated file names in the root of the drive (such as \sd3c.). These functions now generate usable file name paths in a temporary directory.  
  
-   **FILE Encapsulation**  
  
     In previous versions, the FILE type was completely defined in <stdio.h>, so it was possible for user code to reach into a FILE and modify its internals. The stdio library has been changed to hide implementation details. As part of this, FILE as defined in <stdio.h> is now an opaque type and its members are inaccessible from outside of the CRT itself.  
  
-   **_outp and _inp**  
  
     The functions [_outp](../vs140/_outp--_outpw--_outpd.md), [_outpw](../vs140/_outp--_outpw--_outpd.md), [_outpd](../vs140/_outp--_outpw--_outpd.md), [_inp](../vs140/_inp--_inpw--_inpd.md), [_inpw](../vs140/_inp--_inpw--_inpd.md), and [_inpd](../vs140/_inp--_inpw--_inpd.md) have been removed.  
  
-   **The fflush function no longer discards the buffer for a stream opened in read mode**  
  
     In previous versions of the CRT, the [fflush](../vs140/fflush.md) function discarded the buffer for all streams, regardless of the mode they were opened in. In the Universal CRT, the stream buffer is no longer discarded if the stream is opened in read mode. The behavior of the fflush function is only defined to flush the buffer for streams opened in write mode, and streams opened in update mode where the last operation was a write. The new behavior gives somewhat better consistency for non-seekable read mode streams.  
  
### <stdlib.h>, <malloc.h>, and <sys/stat.h>  
  
-   **strtof and wcstof**  
  
     The strtof and wcstof functions failed to set errno to ERANGE when the value was not representable as a float. This has been fixed. (Note that this error was specific to these two functions; the strtod, wcstod, strtold, and wcstold functions were unaffected.) This is a runtime breaking change.  
  
-   **Aligned allocation functions**  
  
     In previous versions, the aligned allocation functions (_aligned_malloc, _aligned_offset_malloc, etc.) would silently accept requests for a block with an alignment of 0. The requested alignment must be a power of two, which zero is not. This has been fixed, and a requested alignment of 0 is now treated as an invalid parameter. This is a runtime breaking change.  
  
-   **Heap functions**  
  
     The _heapadd, _heapset, and _heapused functions have been removed. These functions have been nonfunctional since the CRT was updated to use the Windows heap.  
  
-   **smallheap**  
  
     The smalheap link option has been removed. See [Link Options](../vs140/link-options.md).  
  
### <string.h>  
  
-   **wcstok**  
  
     The signature of the wcstok function has been changed to match what is required by the C Standard. In previous versions of the library, the signature of this function was:  
  
    ```  
    wchar_t* wcstok(wchar_t*, wchar_t const*)  
    ```  
  
     It used an internal, per-thread context to track state across calls, as is done for strtok. The function now has the signature wchar_t* wcstok(wchar_t\*, wchar_t const\*, wchar_t\*\*), and requires the caller to pass the context as a third argument to the function.  
  
     A new _wcstok function has been added with the old signature to ease porting. When compiling C++ code, there is also an inline overload of wcstok that has the old signature. This overload is declared as deprecated. In C code, you may define_CRT_NON_CONFORMING_WCSTOK to cause _wcstok to be used in place of wcstok.  
  
### <time.h>  
  
-   **clock**  
  
     In previous versions, the [clock](../vs140/clock.md) function was implemented using the Windows API [GetSystemTimeAsFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724397.aspx). With this implementation, the clock function was sensitive to the system time, and was thus not necessarily monotonic. The clock function has been reimplemented in terms of [QueryPerformanceCounter](https://msdn.microsoft.com/library/windows/desktop/ms644904.aspx) and is now monotonic.  
  
-   **fstat and _utime**  
  
     In previous versions, the [_stat](../vs140/_stat--_stat32--_stat64--_stati64--_stat32i64--_stat64i32--_wstat--_wstat32--_wstat64--_wstati64--_wstat32i64--_wstat64i32.md), [fstat](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md), and [_utime](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md) functions handle daylight savings time incorrectly. Prior to Visual Studio 2013, all of these functions incorrectly adjusted standard time times as if they were in daylight time.  
  
     In Visual Studio 2013, the problem was fixed in the _stat family of functions, but the similar problems in the fstat and _utime families of functions were not fixed. This led to problems due to the inconsistency between the functions. The fstat and _utime families of functions have now been fixed, so all of these functions now handle daylight savings time correctly and consistently.  
  
-   **asctime**  
  
     In previous versions, the [asctime](../vs140/asctime--_wasctime.md) function would pad single-digit days with a leading zero, for example: Fri Jun 06 08:00:00 2014. The specification requires that such days be padded with a leading space, e.g. Fri Jun  6 08:00:00 2014. This has been fixed.  
  
-   **strftime and wcsftime**  
  
     The strftime and wcsftime functions now support the %C, %D, %e, %F, %g, %G, %h, %n, %r, %R, %t, %T, %u, and %V format specifiers. Additionally, the E and O modifiers are parsed but ignored.  
  
     The %c format specifier is specified as producing an "appropriate date and time representation" for the current locale. In the C locale, this representation is required to be the same as %a %b %e %T %Y. This is the same form as is produced by asctime. In previous versions, the %c format specifier incorrectly formatted times using a MM/DD/YY HH:MM:SS representation. This has been fixed.  
  
-   **timespec and TIME_UTC**  
  
     The <time.h> header now defines the timespec type and the timespec_get function from the C11 Standard. In addition, the TIME_UTC macro, for use with the timespec_get function, is now defined. This is a breaking change for code that has a conflicting definition for any of these.  
  
-   **CLOCKS_PER_SEC**  
  
     The CLOCKS_PER_SEC macro now expands to an integer of type clock_t, as required by the C language.  
  
###  <a name="BK_STL"></a> Standard Template Library  
 To enable new optimizations and debugging checks, the Visual Studio implementation of the C++ Standard Library intentionally breaks binary compatibility from one version to the next. Therefore, when the C++ Standard Library is used, object files and static libraries that are compiled by using different versions can't be mixed in one binary (EXE or DLL), and C++ Standard Library objects can't be passed between binaries that are compiled by using different versions. Such mixing emits linker errors about _MSC_VER mismatches. (_MSC_VER is the macro that contains the compiler's major version—for example, 1800 for Visual Studio 2013.) This check cannot detect DLL mixing, and cannot detect mixing that involves Visual C++ 2008 or earlier.  
  
-   **STL include files**  
  
     Some changes have been made to the include structure in the STL headers. STL headers are allowed to include each other in unspecified ways. In general, you should write your code so that it carefully includes all of the headers that it needs according to the C++ standard and doesn't rely on which STL headers include which other STL headers. This makes code portable across versions and platforms. At least two header changes in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] affect user code. First, \<string> no longer includes \<iterator>. Second, \<tuple> now declares std::array without including all of \<array>, which can break code through the following combination of code constructs: your code has a variable named "array", and you have a using-directive "using namespace std;", and you include an STL header (such as \<functional>) that includes \<tuple>, which now declares std::array.  
  
-   **steady_clock**  
  
     The \<chrono> implementation of [steady_clock](../vs140/steady_clock-struct.md) has changed to meet the C++ Standard requirements for steadiness and monotonicity. steady_clock is now based on [QueryPerformanceCounter](https://msdn.microsoft.com/library/windows/desktop/ms644904.aspx) and high_resolution_clock is now a typedef for steady_clock. As a result, in Visual C++ steady_clock::time_point is now a typedef for chrono::time_point<steady_clock>; however, this is not necessarily the case for other implementations.  
  
-   **allocators and const**  
  
     We now require allocator equality/inequality comparisons to accept const arguments on both sides.  If your allocators define these operators as follows:  
  
    ```  
    bool operator==(const MyAlloc& other)  
    ```  
  
     You should update these to declare them as const members.  
  
    ```  
    bool operator==(const MyAlloc& other) const  
    ```  
  
-   **const elements**  
  
     The C++ standard has always forbidden containers of const elements (such as vector\<const T> or set\<const T>). Visual C++ 2013 and earlier accepted such containers. In the current version, such containers fail to compile.  
  
-   **std::allocator::deallocate**  
  
     In Visual C++ 2013 and earlier, std::allocator::deallocate(p, n) ignored the argument passed in for n.  The C++ standard has always required that n be equal to the value passed as the first argument to the invocation of allocate which returned p. However, in the current version, the value of n is inspected. Code that passes arguments for n that differ from what the standard requires might crash at runtime.  
  
-   **hash_map and hash_set**  
  
     The non-standard header files hash_map and hash_set are deprecated in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] and will be removed in a future release. Use unordered_map and unordered_set instead.  
  
-   **comparators and operator()**  
  
     Associative containers (the \<map> family) now require their comparators to have const-callable function call operators. The following code in a comparator class declaration now fails to compile:  
  
    ```  
    bool operator()(const X& a, const X& b)  
    ```  
  
     To resolve this error, change the function declaration to:  
  
    ```  
    bool operator()(const X& a, const X& b) const  
    ```  
  
-   **type traits**  
  
     The old names for type traits from an earlier version of the C++ draft standard have been removed. These were changed in C++11 and have been updated to the C++11 values in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)]. The following table shows the old and new names.  
  
    |Old name|New name|  
    |--------------|--------------|  
    |add_reference|add_lvalue_reference|  
    |has_default_constructor|is_default_constructible|  
    |has_copy_constructor|is_copy_constructible|  
    |has_move_constructor|is_move_constructible|  
    |has_nothrow_constructor|is_nothrow_default_constructible|  
    |has_nothrow_default_constructor|is_nothrow_default_constructible|  
    |has_nothrow_copy|is_nothrow_copy_constructible|  
    |has_nothrow_copy_constructor|is_nothrow_copy_constructible|  
    |has_nothrow_move_constructor|is_nothrow_move_constructible|  
    |has_nothrow_assign|is_nothrow_copy_assignable|  
    |has_nothrow_copy_assign|is_nothrow_copy_assignable|  
    |has_nothrow_move_assign|is_nothrow_move_assignable|  
    |has_trivial_constructor|is_trivially_default_constructible|  
    |has_trivial_default_constructor|is_trivially_default_constructible|  
    |has_trivial_copy|is_trivially_copy_constructible|  
    |has_trivial_move_constructor|is_trivially_move_constructible|  
    |has_trivial_assign|is_trivially_copy_assignable|  
    |has_trivial_move_assign|is_trivially_move_assignable|  
    |has_trivial_destructor|is_trivially_destructible|  
  
-   **launch::any and launch::sync policies**  
  
     The nonstandard launch::any and launch::sync policies were removed. Instead, for launch::any, use launch:async &#124; launch:deferred. For launch::sync, use launch::deferred. See [launch Enumeration](../vs140/launch-enumeration.md).  
  
###  <a name="BK_MFC"></a> MFC and ATL  
  
-   **Microsoft Foundation Classes (MFC)** is no longer included in a "Typical" install of Visual Studio because of its large size. To install MFC, choose the Custom install option in Visual Studio 2015 setup. If you already have Visual Studio 2015 installed, you can install MFC by re-running Visual Studio setup, choosing the Custom install option, and choosing Microsoft Foundation Classes. You can re-run Visual Studio setup from the Control Panel, Programs and Features, or from the installation media.  
  
     The Visual C++ Redistributable Package still includes this library.  
  
###  <a name="BK_ConcRT"></a> Concurrency Runtime  
  
-   **Yield macro from Windows.h conflicting with concurrency::Context::Yield**  
  
     The Concurrency Runtime previously used #undef to undefine the Yield macro to avoid conflicts between the Yield macro defined in Windows.h h and the concurrency::Context::Yield function. This #undef has been removed and a new non-conflicting equivalent API call [concurrency::Context::YieldExecution](../vs140/context--yieldexecution-method.md) has been added. To work around conflicts with Yield, you can either update your code to call the YieldExecution function instead, or surround the Yield function name with parentheses at call sites, as in the following example:  
  
    ```  
    (concurrency::Context::Yield)();  
    ```  
  
## See Also  
 [Getting Started with Visual C++](../vs140/getting-started-with-visual-c---in-visual-studio-2015.md)   
 [Breaking Changes in Visual C++ 2013](https://msdn.microsoft.com/library/hh409293.aspx)