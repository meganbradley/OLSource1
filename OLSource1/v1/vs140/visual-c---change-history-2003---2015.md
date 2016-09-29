---
title: "Visual C++ change history 2003 - 2015"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 106a3d74-423b-4ae7-93a9-351c848fddcc
caps.latest.revision: 22
---
# Visual C++ change history 2003 - 2015
This topic lists all the breaking changes starting with the changes in 2003 that were breaking for code compiled with Visual C++ 6. When upgrading code, you can use this page as a quick reference to search for specific keywords, error codes, API names and so on.  
  
## Visual C++ .NET 2003 Breaking Changes  
  
### Compiler  
  
-   Closing parentheses now required for the defined preprocessor directive (C2004).  
  
-   Explicit specializations no longer find template parameters from primary template ([C2146](../vs140/compiler-error-c2146.md)).  
  
-   A protected member (n) can only be accessed through a member function of a class (B) that inherits from the class (A) of which it (n) is a member ([C2247](../vs140/compiler-error-c2247.md)).  
  
-   Improved accessibility checks in compiler now detect inaccessible base classes ([C2248](../vs140/compiler-error-c2248.md)).  
  
-   An exception cannot be caught if the destructor and/or copy constructor is inaccessible (C2316).  
  
-   Default arguments on pointers to functions no longer allowed ([C2383](../vs140/compiler-error-c2383.md)).  
  
-   A static data member cannot be initialized via derived class ([C2477](../vs140/compiler-error-c2477.md)).  
  
-   The initialization of a typedef is not allowed by the standard and now generates a compiler error ([C2513](../vs140/compiler-error-c2513.md)).  
  
-   bool is now a proper type ([C2632](../vs140/compiler-error-c2632.md)).  
  
-   A UDC can now create ambiguity with overloaded operators ([C2666](8364d15-c6eb-439a-9088-e04a0176692b)).  
  
-   More expressions are now considered valid null pointer constants ([C2668](../vs140/compiler-error-c2668.md)).  
  
-   template<> is now required in places where the compiler would previously imply it ([C2768](../vs140/compiler-error-c2768.md)).  
  
-   The expilicit specialization of a member function ourside the class is not valid if the function has already been explicitly specialized via a template class specialization ([C2910](../vs140/compiler-error-c2910.md)).  
  
-   Floating point non-type template parameters are no longer allowed ([C2993](../vs140/compiler-error-c2993.md)).  
  
-   Class templates are not allowed as template type arguments (C3206).  
  
-   Friend function names are no longer introduced into containing namespace ([C3767](../vs140/compiler-error-c3767.md)).  
  
-   The compiler will no longer accept extra commas in a macro (C4002).  
  
-   An object of POD type constructed with an initializer of the form () will be default-initialized (C4345).  
  
-   typename is now required if a dependent name is to be treated as a type ([C4346](../vs140/compiler-warning--level-1--c4346.md)).  
  
-   Functions that were incorrectly considered template specializations are no longer considered so (C4347).  
  
-   Static data members cannot be initialized via derived class (C4356).  
  
-   A class template specialization needs to be defined before it was used in a return type ([C4686](../vs140/compiler-warning--level-3--c4686.md)).  
  
-   The compiler now reports unreachable code (C4702).  
  
## Visual C++ 2005 Breaking Changes  
  
### CRT  
  
-   Many functions have been deprecated. See Deprecated CRT Functions.  
  
-   Many functions now validate their parameters, halting execution if given invalid parameters. This may break code that passes invalid parameters and relies on the function ignoring them or just returning an error code. See Parameter Validation.  
  
-   The file descriptor value -2 is now used to indicate that stdout and stderr are not available for output, as for example in a Windows application that has no console window. The previous value used was -1. For more information, see [_fileno](../vs140/_fileno.md).  
  
-   The single-threaded CRT libraries, libc.lib and libcd.lib, have been removed. Use the multi-threaded CRT libraries. The /ML compiler flag is no longer supported. Non-locking versions of some functions have been added in cases where the performance difference between the multithreaded code and the single-threaded code is potentially significant.  
  
-   The overload of pow, double pow(int, int), was removed to better conform with the standard.  
  
-   The %n format specifier is no longer supported by default in any of the printf family of functions because it is inherently insecure. The default behavior if %n is encountered is to invoke the invalid parameter handler. To enable %n support, use _set_printf_count_output (also see_get_printf_count_output).  
  
-   sprintf now prints the negative sign of a signed zero.  
  
-   swprintf has been changed to conform with the Standard; it now requires a size parameter. The form of swprintf without a size parameter has been deprecated.  
  
-   _set_security_error_handler has been removed. Remove any calls to that function; the default handler is a much safer way of dealing with security errors.  
  
-   time_t is now a 64-bit value (unless _USE_32BIT_TIME_T is defined).  
  
-   The _spawn, _wspawn Functions now leave errno untouched on success, as specified by the C Standard.  
  
-   RTC now uses wide characters by default.  
  
-   Floating-point control word support functions have been deprecated for applications compiled with /CLR or /CLR:PURE. The affected functions are _clear87, _clearfp, _control87, _controlfp, _fpreset, _status87, _statusfp. You can disable the deprecation warning by defining _CRT_MANAGED_FP_NO_DEPRECATE, but the use of these functions in managed code is unpredictable and unsupported.  
  
-   Some functions now return const pointers. The old, non-const behavior can be reinstated by defining _CONST_RETURN. The affected functions are  
  
    1.  memchr, wmemchr  
  
    2.  strchr, wcschr, _mbschr, _mbschr_l  
  
    3.  strpbrk, wcspbrk, _mbspbrk, _mbspbrk_l  
  
    4.  strrchr, wcsrchr, _mbsrchr, _mbsrchr_l  
  
    5.  strstr, wcsstr, _mbsstr, _mbsstr_l  
  
-   When linking with Setargv.obj or Wsetargv.obj, it is no longer possible to suppress the expansion of a wildcard character on the command line by enclosing it in double quotes. For more information, see [Expanding Wildcard Arguments](../vs140/expanding-wildcard-arguments.md).  
  
### Standard Library (2005)  
 Insert subsection body here.  
  
-   The exception class (located in the \<exception> header) has been moved to the std namespace. In previous versions, this class was in the global namespace. To resolve any errors indicating that the exception class cannot be found, add the following using statement to your code:                                 using namespace std;  
  
-   When calling valarray::resize(), the contents of the valarray will be lost and will be replaced by default values. The resize() method is intended to reinitialize the valarray rather than grow it dynamically like a vector.  
  
-   Debug Iterators: Applications built with a debug version of the C-Runtime Library and which use iterators incorrectly might begin to see asserts at runtime. To disable these asserts, you must define _HAS_ITERATOR_DEBUGGING to 0. For more information, see [Debug Iterator Support](../vs140/debug-iterator-support.md)  
  
## Visual C++ 2008 Breaking Changes  
  
### Compiler  
  
-   The Windows 95, Windows 98, Windows ME, and Windows NT platforms are no longer supported. These operating systems have been removed from the list of targeted platforms.  
  
-   The compiler no longer supports multiple attributes that were directly associated with ATL Server. The following attributes are no longer supported:  
  
    -   perf_counter  
  
    -   perf_object  
  
    -   perfmon  
  
    -   request_handler  
  
    -   soap_handler  
  
    -   soap_header  
  
    -   soap_method  
  
    -   tag_name  
  
### Visual C++ Projects  
  
-   When upgrading projects from previous versions of Visual Studio, you might have to modify the WINVER and _WIN32_WINNT macros so that they are greater than or equal to 0x0500.  
  
-   Beginning with Visual Studio 2008, the new project wizard does not have an option to create a C++ SQL Server project. SQL Server projects created by using an earlier version of Visual Studio will still compile and work correctly.  
  
-   The Windows API header file Winable.h has been removed. Include Winuser.h instead.  
  
-   The Windows API library Rpcndr.lib has been removed. Link with rpcrt4.lib instead.  
  
### CRT  
  
-   Support for Windows 95, Windows 98, Windows Millennium Edition, and Windows NT 4.0 has been removed.  
  
-   The following global variables have been removed:  
  
    -   _osplatform  
  
    -   _osver  
  
    -   _winmajor  
  
    -   _winminor  
  
    -   _winver  
  
-   The following functions have been removed. Use the Windows API functions GetVersion or GetVersionEx instead:  
  
    -   _get_osplatform  
  
    -   _get_osver  
  
    -   _get_winmajor  
  
    -   _get_winminor  
  
    -   _get_winver  
  
-   The syntax for SAL Annotations has changed. For more information, see [SAL Annotations](../vs140/sal-annotations.md).  
  
-   The IEEE filter now supports the SSE 4.1 instruction set. For more information, see [_fpieee_flt](../vs140/_fpieee_flt.md)_fpieee_flt.  
  
-   The C Run-Time Libraries that ship with Visual Studio are no longer dependent on the system DLL msvcrt.dll.  
  
### Standard Library  
  
-   Support for Windows 95, Windows 98, Windows Millennium Edition, and Windows NT 4.0 has been removed.  
  
-   When compiling in debug mode with _HAS_ITERATOR_DEBUGGING defined, an application will now assert when an iterator attempts to increment or decrement past the bounds of the underlying container.  
  
-   The member variable c of the stack Class is now declared protected. Previously, this member variable was declared public.  
  
-   The behavior of money_get::do_get has changed. Previously, when parsing a monetary amount with more fraction digits than are called for by frac_digits, do_get used to consume them all. Now, do_get stops parsing after consuming at most frac_digits characters.  
  
### ATL  
  
-   ATL cannot be built without a dependency on CRT. In earlier versions of Visual Studio, you could use #define ATL_MIN_CRT to make an ATL project minimally dependent on CRT. In Visual C++ 2008, all ATL projects are minimally dependent on CRT regardless of whether ATL_MIN_CRT is defined.  
  
-   The ATL Server codebase has been released as a shared source project on CodePlex and is not installed as part of Visual Studio. Data encoding and decoding classes from atlenc.h and utility functions and classes from atlutil.h and atlpath.h have been kept and are now part of the ATL library. Several files associated with ATL Server are no longer part of Visual Studio.  
  
-   Some functions are no longer included in the DLL. They are still located in the import library. This will not affect code that uses the functions statically. It will affect only the code that uses these functions dynamically.  
  
-   The macros PROP_ENTRY and PROP_ENTRY_EX have been deprecated and replaced with the macros PROP_ENTRY_TYPE andPROP_ENTRY_TYPE_EX for security reasons.  
  
### ATL/MFC Shared Classes  
  
-   ATL cannot be built without a dependency on CRT. In earlier versions of Visual Studio, you could use #define ATL_MIN_CRT to make an ATL project minimally dependent on CRT. In Visual C++ 2008, all ATL projects are minimally dependent on CRT regardless of whether ATL_MIN_CRT is defined.  
  
-   The ATL Server codebase has been released as a shared source project on CodePlex and is not installed as part of Visual Studio. Data encoding and decoding classes from atlenc.h and utility functions and classes from atlutil.h and atlpath.h have been kept and are now part of the ATL library. Several files associated with ATL Server are no longer part of Visual Studio.  
  
-   Some functions are no longer included in the DLL. They are still located in the import library. This will not affect code that uses the functions statically. It will affect only the code that uses these functions dynamically.  
  
### MFC  
  
-   CTime Class The CTime class now accepts dates starting from 1/1/1900 C.E. instead of 1/1/1970 C.E.                                 Tab order of controls in MFC dialogs The correct tab order of multiple controls in an MFC dialog is disturbed if an MFC ActiveX control is inserted in the tab order. This change corrects that problem.  
  
     For example, create an MFC dialog application that has an ActiveX control and several edit controls. Position the ActiveX control in the middle of the tab order of the edit controls. Start the application, click an edit control whose tab order is after the ActiveX control, then tab. Prior to this change, the focus went to the edit control following the ActiveX control instead of the next edit control in the tab order.  
  
-   CFileDialog Class   Custom templates for the CFileDialog class cannot be automatically ported to Windows Vista. They are still usable, but will not have the additional functionality or looks of Windows Vista style dialogs.  
  
-   CWnd ClassandCFrameWnd Class    The CWnd::GetMenuBarInfo method was removed.                                 The CFrameWnd::GetMenuBarInfo method is now a non-virtual method. For more information, see GetMenuBarInfo Functionin the Windows SDK.                                 MFC ISAPI support  MFC no longer supports building applications with the Internet Server Application Programming Interface (ISAPI). If you want to build an ISAPI application, call the ISAPI extensions directly.  
  
-   Deprecated ANSI APIs    The ANSI versions of several MFC methods are deprecated. Use the Unicode versions of those methods in your future applications. For more information, see Build Requirements for Windows Vista Common Controls.  
  
## Visual C++ 2010 Breaking Changes  
  
### Compiler  
  
-   The auto keyword has a new default meaning. Because use of the old meaning is rare, most applications will not be affected by this change.  
  
-   The new static_assert keyword is introduced, which will cause a name conflict if there is already an identifier by that name in your code.  
  
-   Support for the new lambda notation excludes support for coding an unquoted GUID in an IDL uuid attribute.  
  
-   The .NET Framework 4 introduces the concept of corrupted state exceptions, which are exceptions that leave a process in an unrecoverable                                 corrupted state. By default, you cannot catch a corrupted state exception, even with the /EHa compiler option that catches all other exceptions.                                 To explicitly catch a corrupted state exception, use __try-\__except statements. Or, apply the [HandledProcessCorruptedStateExceptions]attribute                                 to enable a function to catch corrupted state exceptions.  This change affects primarily system programmers who might have to catch a corrupted                                 state exception. The eight exceptions are STATUS_ACCESS_VIOLATION, STATUS_STACK_OVERFLOW, EXCEPTION_ILLEGAL_INSTRUCTION,                                 EXCEPTION_IN_PAGE_ERROR, EXCEPTION_INVALID_DISPOSITION, EXCEPTION_NONCONTINUABLE_EXCEPTION, EXCEPTION_PRIV_INSTRUCTION, STATUS_UNWIND_CONSOLIDATE.                                 For more information about these exceptions, see the [GetExceptionCode](https://msdn.microsoft.com/en-us/library/windows/desktop/ms679356.aspx) macro.  
  
-   The revised /GS compiler option guards against buffer overruns more comprehensively than in earlier versions. This version might insert additional security checks in the stack that might decrease performance. Use the new __declspec(safebuffers) keyword to instruct the compiler to not insert security checks for a particular function.  
  
-   If you compile with both the /GL (Whole Program Optimization) and /clr (Common Language Runtime Compilation) compiler options, the /GLoption is ignored. This change was made because the combination of compiler options provided little benefit. As a result of this change, the performance of the build is improved.  
  
-   By default, support for trigraphs is disabled in Visual C++ 2010 . Use the /Zc:trigraphs compiler option to enable trigraphs support. A trigraph consists of two consecutive question marks ("??") followed by a unique third character. The compiler replaces a trigraph with a corresponding punctuation character. For example, the compiler replaces the "??=" trigraph with the '#' character. Use trigraphs in C source files that use a character set that does not contain convenient graphic representations for some punctuation characters.  
  
-   The linker no longer supports optimizing for Windows 98. The /OPT (Optimizations) option produces a compile time error if you specify/OPT:WIN98 or /OPT:NOWIN98.  
  
-   The default compiler options that are specified by the RuntimeLibrary and DebugInformationFormat build system properties have been changed. By default, these build properties are specified in projects that are created by Visual C++ releases 7.0 through 10.0. If you migrate a project that was created by Visual C++ 6.0, consider whether to specify a value for these properties.  
  
-   In Visual C++ 2010, RuntimeLibrary = MultiThreaded (/MD) and DebugInformationFormat = ProgramDatabase (/Zi). In Visual C++ 9.0,RuntimeLibrary = MultiThreaded (/MT) and DebugInformationFormat = Disabled.  
  
### CLR  
  
-   The Microsoft C# and Visual Basic compilers can now produce a no primary interop assembly (no-PIA). A no-PIA assembly can use COM types without the deployment of the relevant primary interop assembly (PIA). When consuming no-PIA assemblies produced by Visual C# or Visual Basic, you must reference the PIA assembly on the compile command before you reference any no-PIA assembly that uses the library.  
  
### Visual C++ Projects and MSBuild  
  
-   Visual C++ projects are now based on the MSBuild tool. Consequently, project files use a new XML file format and a .vcxproj file suffix. Visual C++ 2010 automatically converts project files from earlier versions of Visual Studio to the new file format. An existing project is affected if it depends on the previous build tool, VCBUILD.exe, or project file suffix, .vcproj.  
  
-   In earlier releases, Visual C++ supported the late evaluation of property sheets. For example, a parent property sheet could import a child property sheet, and the parent could use a variable defined in the child to define other variables. Late evaluation enabled the parent to use the child variable even before the child property sheet was imported. In Visual C++ 2010, a project sheet variable cannot be used before it is defined because MSBuild supports only early evaluation.  
  
### IDE  
  
-   The application termination dialog box no longer ends an application. In previous releases, when the abort() or terminate() function closed the                                 retail build of an application, the C Run-Time Library displayed an application termination message in a console window or dialog box. The message said in part, "This                                 application has requested the Runtime to terminate it in an unusual way. Please contact the application's support team for more information."                                 The application termination message was redundant because Windows subsequently displayed the current termination handler, which was usually the Windows Error Reporting                                 (Dr. Watson) dialog box or the Visual Studio debugger. Starting in Visual Studio 2010, the C Run-Time Library does not display the message. Furthermore, the runtime                                 prevents the application from ending before a debugger starts. This is a breaking change only if you depend on the previous behavior of the application termination                                 message.  
  
-   Specifically for Visual Studio 2010, IntelliSense does not work for C++/CLI code or attributes, Find All References does not work for local                                 variables, and Code Model does not retrieve type names from imported assemblies or resolve types to their fully qualified names.  
  
### Libraries  
  
-   The SafeInt class is included in Visual C++ and is no longer in a separate download. This is a breaking change only if you have developed a class that is also named "SafeInt".  
  
-   The libraries deployment model no longer uses manifests to find a particular version of a dynamic link library. Instead, the name of each dynamic link library contains its version number, and you use that name to locate the library.  
  
-   In previous versions of Visual Studio, you could rebuild the run time libraries. Visual C++ 2010 no longer supports building your own copies of the C run time library files.  
  
### Standard Library  
  
-   The \<iterator>                                 header is no longer included automatically by many other header files. Instead, include that header explicitly if you require support                                 for the standalone iterators defined in the An existing project is affected if it depends on the previous build tool, VCBUILD.exe, or project file suffix,                                  .vcproj.interator> header.  
  
-   In the \<algorithm>                                 header, the checked_* and unchecked_\* functions are removed. And in the \<iterator>> header, the                                  checked_iteratorclass is removed, and the unchecked_array_iterator class has been added.  
  
-   The CComPtr::CComPtr(int) constructor is removed. That constructor allowed a CComPtr object to be constructed from the NULL macro, but was unnecessary and allowed nonsensical constructions from non-zero integers.  
  
     A CComPtr can still be constructed from NULL, which is defined as 0, but will fail if constructed from an integer other than literal 0. use nullptr instead.  
  
-   The following ctype member functions were removed: ctype::_Do_narrow_s, ctype::_Do_widen_s, ctype::_narrow_s, ctype::_widen_s. If an application uses one of these member functions, you must replace it with the corresponding non-secure version: ctype::do_narrow,ctype::do_widen, ctype::narrow, ctype::widen.  
  
### CRT, MFC, and ATL Libraries  
  
-   Support has been removed for users to build the CRT, MFC, and ATL libraries. For example, an appropriate nmake file is not provided.                                 However, users still have access to the source code for these libraries. And a document that describes the MSBuild options that Microsoft uses to build these                                 libraries will probably be posted in a Visual C++ Team Blog.  
  
-   MFC support for IA64 has been removed. However, support for the CRT and ATL on IA64 is still provided.  
  
-   Ordinals are no longer reused in MFC module-definition (.def) files. This change means ordinals will not be different between minor versions, and binary compatibility for service packs and quick fix engineering releases will be improved.  
  
-   A new virtual function was added to the CDocTemplate class. This new virtual function is [CDocTemplate::OpenDocumentFile](../vs140/cdoctemplate-class.md). The previous version of OpenDocumentFile had two parameters. The new version has three parameters. To support the restart manager, any class derived from CDocTemplate must implement the version that has three parameters. The new parameter is bAddToMRU.  
  
### Macros and Environment Variables  
  
-   The environment variable __MSVCRT_HEAP_SELECT is no longer supported. This environment variable is removed and there is no replacement.  
  
### Microsoft Macro Assembler Reference  
  
-   Several directives were removed from the Microsoft Macro Assembler Reference compiler. The removed directives are .186, .286, .286P, .287,.8086, .8087, and .NO87.  
  
## Visual C++ 2012 Breaking Changes  
  
### Compiler  
  
-   The /Yl compiler option has changed. By default, the compiler uses this option, which can lead to LNK2011 errors under certain conditions. For more information, see [/Yl (Inject PCH Reference for Debug Library)](../vs140/-yl--inject-pch-reference-for-debug-library-.md).  
  
-   In code that's compiled by using /clr, the enum class keyword defines a C++11 enum, not a common language runtime (CLR) enum. To define a CLR enum, you must be explicit about its accessibility.  
  
-   Use the template keyword to explicitly disambiguate a dependent name (C++ Language Standard compliance). In the following example, the highlighted template keyword is mandatory to resolve the ambiguity. For more information, see [Name Resolution for Dependent Types](../vs140/name-resolution-for-dependent-types.md).  
  
    ```  
  
    template <typename X="", typename="" AY="">  
    struct Container {     typedef typename AY::template Rebind<X>::Other AX; };  
  
    ```  
  
-   Constant expression of type float is no longer allowed as a template argument, as shown in the following example.  
  
    ```  
  
    template<float n="">  
    struct B {};  // error C2762: 'float': illegal type for non-type template parameter 'n'  template<int n="">  
    struct A {};  A<1.1>  
    a1; // error C2762: 'A': invalid expression as a template argument for 'n' A<(int)1.1< a2; // ok  
  
    ```  
  
-   Code that's compiled by using the /GS command-line option and that has an off-by-one vulnerability may lead to process termination at                                 runtime, as shown in the following pseudocode example.  
  
    ```  
    char buf[MAX]; int cch; ManipulateString(buf, &cch); // ... buf[cch] = '\0'; // if cch >= MAX, process will terminate  
    ```  
  
-   The default architecture for x86 builds is changed to SSE2; therefore, the compiler may emit SSE instructions, and will use the XMM                                 registers to perform floating-point calculations. If you want to revert to previous behavior, then use the /arch:IA32 compiler flag to specify the                                 architecture as IA32.  
  
-   The compiler may issue warnings [C4703](../vs140/compiler-warning--level-4--c4703.md) and C4701 where previously it did not. The compiler applies stronger checks for use of                                 uninitialized local variables of pointer type.  
  
-   When the new linker flag /HIGHENTROPYVA is specified, Windows 8 typically causes memory allocations to return a 64-bit address.                                 (Prior to Windows 8, such allocations more often returned addresses that were less than 2 GB.)  This may expose pointer truncation bugs in existing code. By default, this switch is on.  To disable this behavior, specify /HIGHENTROPYVA:NO.  
  
-   The managed compiler (Visual Basic/C#) also supports /HIGHENTROPYVA for managed builds.  However, in this case,                                 the /HIGHENTROPYVAswitch is off by default.  
  
### IDE  
  
-   The following project templates no longer exist:  
  
    -   Windows Forms Application  
  
    -   Windows Forms Control Library  
  
-   Although we recommend that you do not create Windows Forms applications in C++/CLI, maintenance of existing C++/CLI UI applications is supported. If you have to create a Windows Forms application, or any other .NET UI application, use C# or Visual Basic. Use C++/CLI for interoperability purposes only.  
  
### Parallel Patterns Library and Concurrency Runtime Library  
 The SchedulerType enumeration of UmsThreadDefault is deprecated. Specification of UmsThreadDefault produces a deprecated warning, and internally maps back to the ThreadScheduler.  
  
### Standard Library  
  
-   Following a breaking change between the C++98/03 and C++11 standards, using explicit template arguments to call make_pair()—as inmake_pair<int, int>(x, y)—typically does not compile in Visual C++ in Visual Studio 2012. The solution is to always call make_pair()without explicit template arguments—as in make_pair(x, y). Providing explicit template arguments defeats the purpose of the function. If you require precise control over the resulting type, use pair instead of make_pair—as in pair<short, short>(int1, int2).  
  
-   Another breaking change between the C++98/03 and C++11 standards: When A is implicitly convertible to B and B is implicitly convertible to C, but A is not implicitly convertible to C, C++98/03 and Visual C++ 2010 permitted pair<A, X> to be converted (implicitly or explicitly) to pair<C, X>. (The other type, X, is not of interest here, and this is not specific to the first type in the pair.) Because C++11 and Visual C++ in Visual Studio 2012 detect that A is not implicitly convertible to C, they remove the pair conversion from overload resolution. This is a positive change for many scenarios. For example, overloading func(const pair<int, int>&) and func(const pair<string, string>&), and calling func() with pair<const char *, const char \*> will compile with this change. However, this change breaks code that relied on aggressive pair conversions. Such code can typically be fixed by performing one part of the conversion explicitly—for example, by passing make_pair(static_cast\<B>(a), x) to a function that expects pair<C, X>.  
  
-   Visual C++ 2010 simulated variadic templates—for example, make_shared\<T>(arg1, arg2, argN)—up to a limit of 10 arguments, by stamping out overloads and specializations with preprocessor machinery. In Visual C++ in Visual Studio 2012, this limit is reduced to 5 arguments to improve compile times and compiler memory consumption for the majority of users. However, you can set the previous limit by explicitly defining _VARIADIC_MAX as 10, project-wide.  
  
-   C++11 17.6.4.3.1 [macro.names]/2 forbids macro-izing keywords when C++ Standard Library headers are included. The headers now emit compiler errors if they detect macro-ized keywords. (Defining _ALLOW_KEYWORD_MACROS allows such code to compile, but we strongly discourage that usage.) As an exception, macro-ized new is permitted by default, because the headers comprehensively defend themselves by using #pragma push_macro("new")/#undef new/#pragma pop_macro("new"). Defining _ENFORCE_BAN_OF_MACRO_NEW does exactly what its name implies.  
  
-   To implement various optimizations and debugging checks, the C++ Standard Library implementation intentionally breaks binary compatibility among versions of Visual Studio (2005, 2008, 2010, 2012). When the C++ Standard Library is used, this forbids the mixing of object files and static libraries that are compiled by using different versions into one binary (EXE or DLL), and forbids the passing of C++ Standard Library objects between binaries that are compiled by using different versions. The mixing of object files and static libraries (using the C++ Standard Library) that were compiled by using Visual C++ 2010 with those that were compiled by using Visual C++ in Visual Studio 2012 emits linker errors about _MSC_VER mismatch, where _MSC_VER is the macro that contains the compiler's major version (1700 for Visual C++ in Visual Studio 2012). This check cannot detect DLL mixing, and cannot detect mixing that involves Visual C++ 2008 or earlier.  
  
-   In addition to detecting _ITERATOR_DEBUG_LEVEL mismatches, which was implemented in Visual C++ 2010, Visual C++ in Visual Studio 2012 detects Runtime Library mismatches. These occur when the compiler options /MT (static release), /MTd (static debug), /MD (dynamic release), and /MDd (dynamic debug) are mixed.  
  
-   operator<(), operator>(), operator<=(), and operator>=() were previously available for the std::unordered_map andstdext::hash_map families of containers, although their implementations were not actually useful. These non-standard operators have been removed in Visual C++ in Visual Studio 2012. Additionally, the implementation of operator==() and operator!=() for thestd::unordered_map family has been extended to cover the stdext::hash_map family. (We recommend that you avoid the use of thestdext::hash_map family in new code.)  
  
-   C++11 22.4.1.4 [locale.codecvt] specifies that codecvt::length() and codecvt::do_length() should take modifiable stateT&parameters, but Visual C++ 2010 took const stateT&. Visual C++ in Visual Studio 2012 takes stateT& as mandated by the standard. This difference is significant for anyone who is attempting to override the virtual function do_length().  
  
### CRT  
  
-   The C Runtime (CRT) heap, which is used for new and malloc(), is no longer private. The CRT now uses the process heap. This means that the heap is not destroyed when a DLL is unloaded, so DLLs that link statically to the CRT must ensure memory that's allocated by the DLL code is cleaned up before it’s unloaded.  
  
-   The iscsymf() function asserts with negative values.  
  
-   The threadlocaleinfostruct struct has changed to accommodate the changes to locale functions.  
  
-   CRT functions that have corresponding intrinsics such as memxxx(), strxxx() are removed from intrin.h. If you included intrin.h only for these functions, you must now include the corresponding CRT headers.  
  
### MFC and ATL  
  
-   Removed Fusion support (afxcomctl32.h); therefore, all methods that are defined in afxcomctl32.h have been removed. Header files afxcomctl32.h and afxcomctl32.inl have been deleted.  
  
-   Changed the name of CDockablePane::RemoveFromDefaultPaneDividier to CDockablePane::RemoveFromDefaultPaneDivider.  
  
-   Changed the signature of CFileDialog::SetDefExt to use LPCTSTR; therefore, Unicode builds are affected.  
  
-   Removed obsolete ATL tracing categories.  
  
-   Changed the signature of CBasePane::MoveWindow to take a const CRect.  
  
-   Changed the signature of CMFCEditBrowseCtrl::EnableBrowseButton.  
  
-   Removed m_fntTabs and m_fntTabsBold from CMFCBaseTabCtrl.  
  
-   Added a parameter to the CMFCRibbonStatusBarPane constructors. (It is a default parameter, and so it is not source-breaking.)  
  
-   Added a parameter to the CMFCRibbonCommandsListBox constructor. (It is a default parameter, and so it is not source-breaking.)  
  
-   Removed the AFXTrackMouse API (and related timer proc). Use the Win32 TrackMouseEvent API instead.  
  
-   Added a parameter to the CFolderPickerDialog constructor. (It is a default parameter, and so it is not source-breaking.)  
  
-   CFileStatus structure size changed: The m_attribute member changed from BYTE to DWORD (to match the value that's returned fromGetFileAttributes).  
  
-   CRichEditCtrl and CRichEditView use MSFTEDIT_CLASS (RichEdit 4.1 control) instead of RICHEDIT_CLASS (RichEdit 3.0 control) in Unicode builds.  
  
-   Removed AFX_GLOBAL_DATA::IsWindowsThemingDrawParentBackground because it is always TRUE on Windows Vista, Windows 7, and Windows 8.  
  
-   Removed AFX_GLOBAL_DATA::IsWindowsLayerSupportAvailable because it is always TRUE on Windows Vista, Windows 7, and Windows 8.  
  
-   Removed AFX_GLOBAL_DATA::DwmExtendFrameIntoClientArea. Call Windows API directly on Windows Vista, Windows 7, and Windows 8.  
  
-   Removed AFX_GLOBAL_DATA::DwmDefWindowProc. Call Windows API directly on Windows Vista, Windows 7, and Windows 8.  
  
-   Renamed AFX_GLOBAL_DATA::DwmIsCompositionEnabled to IsDwmCompositionEnabled to eliminate name collision.  
  
-   Changed identifiers for a number of MFC internal timers and moved the definitions to afxres.h (AFX_TIMER_ID_*).  
  
-   Changed the signature of OnExitSizeMove method to agree with the ON_WM_EXITSIZEMOVE macro:  
  
    -   CFrameWndEx  
  
    -   CMDIFrameWndEx  
  
    -   CPaneFrameWnd  
  
-   Changed the name and signature of OnDWMCompositionChanged to agree with the ON_WM_DWMCOMPOSITIONCHANGED macro:  
  
    -   CFrameWndEx  
  
    -   CMDIFrameWndEx  
  
    -   CPaneFrameWnd  
  
-   Changed the signature of OnMouseLeave method to agree with the ON_WM_MOUSELEAVE macro:  
  
    -   CMFCCaptionBar  
  
    -   CMFCColorBar  
  
    -   CMFCHeaderCtrl  
  
    -   CMFCProperySheetListBox  
  
    -   CMFCRibbonBar  
  
    -   CMFCRibbonPanelMenuBar  
  
    -   CMFCRibbonRichEditCtrl  
  
    -   CMFCSpinButtonCtrl  
  
    -   CMFCToolBar ReplaceThisText  
  
    -   CMFCToolBarComboBoxEdit  
  
    -   CMFCToolBarEditCtrl  
  
    -   CMFCAutoHideBar  
  
-   Changed the signature of OnPowerBroadcast to agree with the ON_WM_POWERBROADCAST macro:  
  
    -   CFrameWndEx  
  
    -   CMDIFrameWndEx  
  
-   Changed the signature of OnStyleChanged to agree with the ON_WM_STYLECHANGED macro:  
  
    -   CMFCListCtrl  
  
    -   CMFCStatusBar  
  
-   Renamed the internal method FontFamalyProcFonts to FontFamilyProcFonts.  
  
-   Removed numerous global static CString objects to eliminate memory leaks in some situations (replaced with #defines), and the following class member variables:  
  
    -   CKeyBoardManager::m_strDelimiter  
  
    -   CMFCPropertyGridProperty::m_strFormatChar  
  
    -   CMFCPropertyGridProperty::m_strFormatShort  
  
    -   CMFCPropertyGridProperty::m_strFormatLong  
  
    -   CMFCPropertyGridProperty::m_strFormatUShort  
  
    -   CMFCPropertyGridProperty::m_strFormatULong  
  
    -   CMFCPropertyGridProperty::m_strFormatFloat  
  
    -   CMFCPropertyGridProperty::m_strFormatDouble  
  
    -   CMFCToolBarImages::m_strPngResType  
  
    -   CMFCPropertyGridProperty::m_strFormat  
  
-   Changed the signature of CKeyboardManager::ShowAllAccelerators and removed the accelerator delimiter parameter.  
  
-   Added CPropertyPage::GetParentSheet, and in the CPropertyPage class, call it instead of GetParent to get the correct parent sheet window, which may be the parent or a grandparent window to CPropertyPage. You might have to change your code to call GetParentSheet instead ofGetParent.  
  
-   Fixed unbalanced #pragma warning(push) in ATLBASE.H, which caused warnings to be disabled incorrectly. Those warnings are now enabled correctly after ATLBASE.H has been parsed.  
  
-   Moved D2D-related methods from AFX_GLOBAL_DATA to _AFX_D2D_STATE:  
  
    -   GetDirectD2dFactory  
  
    -   GetWriteFactory  
  
    -   GetWICFactory  
  
    -   InitD2D  
  
    -   ReleaseD2DRefs  
  
    -   IsD2DInitialized  
  
    -   D2D1MakeRotateMatrix  
  
    -   Instead of calling, for example, afxGlobalData.IsD2DInitialized, call AfxGetD2DState->IsD2DInitialized.  
  
-   Removed obsolete ATL*.CPP files from the \atlmfc\include\ folder.  
  
-   Moved afxGlobalData initialization to on-demand instead of at CRT initialization time, to satisfy DLLMain requirements.  
  
-   Added the RemoveButtonByIndex method to the CMFCOutlookBarPane class.  
  
-   Corrected CMFCCmdUsageCount::IsFreqeuntlyUsedCmd to IsFrequentlyUsedCmd.  
  
-   Corrected several instances of RestoreOriginalstate to RestoreOriginalState (CMFCToolBar, CMFCMenuBar, CMFCOutlookBarPane).  
  
-   Removed unused methods from CDockablePane: SetCaptionStyle, IsDrawCaption, IsHideDisabledButtons, GetRecentSiblingPaneInfo, andCanAdjustLayout.  
  
-   Removed CDockablePane static member variables m_bCaptionText and m_bHideDisabledButtons.  
  
-   Added an override DeleteString method to CMFCFontComboBox.  
  
-   Removed unused methods from CPane: GetMinLength and IsLastPaneOnLastRow.  
  
-   Renamed CPane::GetDockSiteRow(CDockingPanesRow *) to CPane::SetDockSiteRow.  
  
## Visual C++ 2013 Breaking Changes  
  
### Compiler  
  
-   The final keyword now generates an unresolved symbol error where it would have compiled previously:  
  
    ```cpp  
  
    struct S1 {  
    virtual void f() = 0;  
    };  
  
    struct S2 final : public S1 {  
    virtual void f();  
    };  
  
    int main(S2 *p)  
    {  
    p->f();  
    }  
  
    ```  
  
     In earlier versions, an error wasn't issued because the call was a virtual call; nevertheless, the program would crash at runtime. Now, a linker error is issued because the class is known to be final. In this example, to fix the error, you would link against the obj that contains the definition of S2::f.  
  
-   When you use friend functions in namespaces, you must re-declare the friend function before you refer to it or you will get an error because the compiler now conforms to the ISO C++ Standard. For example, this no longer compiles:  
  
    ```cpp  
  
    namespace NS {  
    class C {  
    void func(int);  
    friend void func(C* const) {}  
    };  
  
    void C::func(int) {  
    NS::func(this);  // error  
    }  
    }  
  
    ```  
  
     To correct this code, declare the friend function:  
  
    ```cpp  
  
    namespace NS {  
    class C {  
    void func(int);  
    friend void func(C* const) {}  
    };  
  
    void func(C* const);  // conforming fix  
  
    void C::func(int) {  
    NS::func(this);  
    }  
    }  
  
    ```  
  
-   The C++ Standard does not allow explicit specialization in a class. Although Visual C++ allows it in some cases, in cases such as the following example, an error is now generated because the compiler doesn't consider the second function to be a specialization of the first one.  
  
    ```cpp  
  
    template <int N>  
    class S {  
    public:  
    template  void f(T& val);  
    template <> void f(char val);  
    };  
  
    template class S<1>;  
  
    ```  
  
     To correct this code, modify the second function:  
  
    ```cpp  
  
    template <> void f(char& val);  
  
    ```  
  
-   Visual C++ no longer tries to disambiguate the two functions in the following example, and now emits an error:  
  
    ```cpp  
  
    template<typename T> void Func(T* t = nullptr);  
    template<typename T> void Func(...);  
  
    int main() {  
    Func<int>(); // error  
    }  
  
    ```  
  
     To correct this code, clarify the call:  
  
    ```cpp  
  
    template<typename T> void Func(T* t = nullptr);  
    template<typename T> void Func(...);  
  
    int main() {  
    Func<int>(nullptr); // ok  
    }  
  
    ```  
  
-   Before the compiler was made compliant with ISO C++11, the following code would have compiled and caused x to resolve to type int:  
  
    ```cpp  
  
    auto x = {0};  
    int y = x;  
  
    ```  
  
     This code now resolves x to a type of std::initializer_list\<int> and causes an error on the next line that tries to assign x to type int. (There is no conversion by default.) To correct this code, use int to replace auto:  
  
    ```cpp  
  
    int x = {0};  
    int y = x;  
  
    ```  
  
-   Aggregate initialization is no longer allowed when the type of the right-hand value does not match the type of the left-hand value that's being initialized, and an error is issued because the ISO C++11 Standard requires uniform initialization to work without narrowing conversions. Previously, if a narrowing conversion was available, a [C4242](../vs140/compiler-warning--level-4--c4242.md) warning would have been issued instead of an error.  
  
    ```cpp  
  
    C++  
  
    int i = 0;  
    char c = {i}; // error  
  
    ```  
  
     To correct this code, add an explicit narrowing conversion:  
  
    ```cpp  
  
    int i = 0;  
    char c = {static_cast<char>(i)};  
  
    ```  
  
-   The following initialization is no longer allowed:  
  
    ```cpp  
  
    void *p = {{0}};  
  
    ```  
  
     To correct this code, use either of these forms:  
  
    ```cpp  
  
    void *p = 0;  
    // or  
    void *p = {0};  
  
    ```  
  
-   Name lookup has changed. The following code is resolved differently in Visual C++ in Visual Studio 2012 and Visual C++ in Visual Studio 2013:  
  
    ```cpp  
  
    enum class E1 {a};  
    enum class E2 {b};  
  
    int main()  
    {  
    typedef E2 E1;  
    E1::b;  
    }  
  
    ```  
  
     In Visual C++ in Visual Studio 2012, the E1 in expression E1::b resolved to ::E1 in the global scope. In Visual C++ in Visual Studio 2013, E1 in expression E1::b resolves to the typedef E2 definition in main() and has type ::E2.  
  
-   Object layout has changed. On x64, the object layout of a class may change from previous releases. If it has a virtual function but it doesn’t have a base class that has a virtual function, the object model of the compiler inserts a pointer to a virtual function table after the data member layout. This means the layout may not be optimal in all cases. In previous releases, an optimization for x64 would try to improve the layout for you, but because it failed to work correctly in complex code situations, it was removed in Visual C++ in Visual Studio 2013. For example, consider this code:  
  
    ```cpp  
  
    __declspec(align(16)) struct S1 {  
    };  
  
    struct S2 {  
    virtual ~S2();  
    void *p;  
    S1 s;  
    };  
  
    ```  
  
-   In Visual C++ in Visual Studio 2013, the result of sizeof(S2) on x64 is 48, but in previous releases, it evaluates to 32. To make this evaluate to 32 in Visual C++ in Visual Studio 2013 for x64, add a dummy base class that has a virtual function:  
  
    ```cpp  
  
    __declspec(align(16)) struct S1 {  
    };  
  
    struct dummy {  
    virtual ~dummy() {}  
    };  
    struct S2 : public dummy {  
    virtual ~S2();  
    void *p;  
    S1 s;  
    };  
  
    ```  
  
     To find places in your code that an earlier release would have tried to optimize, use a compiler from that release together with the /W3 compiler option and turn on Warning 4370. For example:  
  
    ```cpp  
  
    #pragma warning(default:4370)  
  
    __declspec(align(16)) struct S1 {  
    };  
  
    struct S2 {  
    virtual ~S2();  
    void *p;  
    S1 s;  
    };  
  
    ```  
  
     On Visual C++ compilers before Visual C++ in Visual Studio 2013, this code outputs this message: warning C4370: 'S2' : layout of class has changed from a previous version of the compiler due to better packing  
  
     The x86 compiler has the same sub-optimal layout issue in all versions of Visual C++. For example, if this code is compiled for x86:  
  
    ```cpp  
  
    struct S {  
    virtual ~S();  
    int i;  
    double d;  
    };  
  
    ```  
  
     The result of sizeof(S) is 24. However, this can be reduced to 16 if you use the workaround just mentioned for x64:  
  
    ```cpp  
  
    struct dummy {  
    virtual ~dummy() {}  
    };  
  
    struct S : public dummy {  
    virtual ~S();  
    int i;  
    double d;  
    };  
  
    ```  
  
### Standard Library  
 Visual C++ in Visual Studio 2013 detects mismatches in _ITERATOR_DEBUG_LEVEL, which was implemented in Visual C++ 2010, and RuntimeLibrary mismatches. These occur when compiler options /MT (static release), /MTd (static debug), /MD (dynamic release), and /MDd (dynamic debug) are mixed.  
  
-   If your code acknowledges the previous release's simulated alias templates, you have to change it. For example, instead of allocator_traits\<A>::rebind_alloc\<U>::other, now you have to say allocator_traits\<A>::rebind_alloc\<U>. Although ratio_add<R1, R2>::type is no longer necessary and we now recommend that you say ratio_add<R1, R2>, the former will still compile because ratio<N, D> is required to have a "type" typedef for a reduced ratio, which will be the same type if it's already reduced.  
  
-   You must use #include \<algorithm> when you call std::min() or std::max().  
  
-   If your existing code uses the previous release’s simulated scoped enums—traditional unscoped enums wrapped in namespaces—you have to change it. For example, if you referred to the type std::future_status::future_status, now you have to say std::future_status. However, most code is unaffected—for example, std::future_status::ready still compiles.  
  
-   explicit operator bool() is stricter than operator unspecified-bool-type(). explicit operator bool() permits explicit conversions to bool—for example, given shared_ptr\<X> sp, both static_cast\<bool>(sp) and bool b(sp) are valid—and Boolean-testable "contextual conversions" to bool—for example, if (sp), !sp, sp && whatever. However, explicit operator bool() forbids implicit conversions to bool, so you can't say bool b = sp; and given a bool return type, you can't say return sp.  
  
-   Now that real variadic templates are implemented, _VARIADIC_MAX and related macros have no effect. If you're still defining _VARIADIC_MAX, it is just ignored. If you acknowledged our macro machinery intended to support simulated variadic templates in any other way, you have to change your code.  
  
-   In addition to ordinary keywords, STL headers now forbid the macro-izing of the context-sensitive keywords "override" and "final".  
  
-   reference_wrapper/ref()/cref() now forbid binding to temporary objects.  
  
-   \<random> now strictly enforces its compile-time preconditions.  
  
-   Various STL type traits have the precondition "T shall be a complete type". Although the compiler now enforces this more strictly, it may not enforce it in all situations. (Because STL precondition violations trigger undefined behavior, the Standard doesn't guarantee enforcement.)  
  
-   The STL does not support /clr:oldSyntax.  
  
-   The C++11 specification for common_type<> had unexpected and undesired consequences; in particular, it makes common_type<int, int>::type return int&&. Therefore, Visual C++ implements the Proposed Resolution for Library Working Group issue 2141, which makes common_type<int, int="">::type return int.  
  
     As a side-effect of this change, the identity case no longer works (common_type<T> does not always result in type T). This complies with the Proposed Resolution, but it breaks any code that relied on the previous behavior.  
  
     If you require an identity type trait, don't use the non-standard std::identity that's defined in <type_traits>                                             because it won't work for <void>                                                 . Instead, implement your own identity type trait to suit your needs. Here's an example:  
  
    ```cpp  
  
    template <typename T> struct Identity {  
    typedef T type;  
    };  
  
    ```  
  
### MFC and ATL  
  
-   MFC MBCS Library is no longer included in Visual Studio because Unicode is so popular and use of MBCS is significantly reduced. This change also keeps MFC more closely aligned with the Windows SDK itself, because many of the new controls and messages are Unicode-only. However, if you must continue to use the MFC MBCS library, you can download it from the MSDN Download Center. The Visual C++ Redistributable Package still includes this library.  
  
-   Accessibility for the MFC ribbon is changed.  Instead of a one-level architecture, there is now a hierarchical architecture. You can still use the old behavior by calling CRibbonBar::EnableSingleLevelAccessibilityMode().  
  
-   CDatabase::GetConnect method is removed. To improve security, the connection string is now stored encrypted and is decrypted only as needed; it cannot be returned as plain text.  The string can be obtained by using the CDatabase::Dump method.  
  
-   Signature of CWnd::OnPowerBroadcast is changed. The signature of this message handler is changed to take an LPARAM as the second parameter.  
  
-   Signatures are changed to accommodate message handlers. The parameter lists of the following functions have been changed to use newly added ON_WM_* message handlers:  
  
    -   CWnd::OnDisplayChange changed to (UINT, int, int) instead of (WPARAM, LPARAM) so that the new ON_WM_DISPLAYCHANGE macro can be used in the message map.  
  
    -   CFrameWnd::OnDDEInitiate changed to (CWnd*, UINT, UNIT) instead of (WPARAM, LPARAM) so that the new ON_WM_DDE_INITIATE macro can be used in the message map.  
  
    -   CFrameWnd::OnDDEExecute changed to (CWnd*, HANDLE) instead of (WPARAM, LPARAM) so that the new ON_WM_DDE_EXECUTE macro can be used in the message map.  
  
    -   CFrameWnd::OnDDETerminate changed to (CWnd*) as the parameter instead of (WPARAM, LPARAM) so that the new ON_WM_DDE_TERMINATE macro can be used in the message map.  
  
    -   CMFCMaskedEdit::OnCut changed to no parameters instead of (WPARAM, LPARAM) so that the new ON_WM_CUT macro can be used in the message map.  
  
    -   CMFCMaskedEdit::OnClear changed to no parameters instead of (WPARAM, LPARAM) so that the new ON_WM_CLEAR macro can be used in the message map.  
  
    -   CMFCMaskedEdit::OnPaste changed to no parameters instead of (WPARAM, LPARAM) so that the new ON_WM_PASTE macro can be used in the message map.  
  
-   \#ifdefs in the MFC header files are removed. Numerous #ifdefs in the MFC header files related to unsupported versions of Windows (WINVER &lt; 0x0501) are removed.  
  
-   ATL DLL (atl120.dll) is removed. ATL is now provided as headers and a static library (atls.lib).  
  
-   Atlsd.lib, atlsn.lib, and atlsnd.lib are removed. Atls.lib no longer has character-set dependencies or code that's specific for debug/release. Because it works the same for Unicode/ANSI and debug/release, only one version of the library is required.  
  
-   ATL/MFC Trace tool is removed together with the ATL DLL, and the tracing mechanism is simplified. The CTraceCategory constructor now takes one parameter (the category name), and the TRACE macros call the CRT debug reporting functions.  
  
## Visual C++ 2015 Breaking Changes  
  
###  <a name="BK_CRT"></a> C Runtime Library (CRT)  
  
#### General Changes  
  
-   **Refactored binaries** The CRT Library  has been refactored into a two different binaries, a Universal CRT (ucrtbase), which contains most of the standard functionality, and a VC Runtime Library (vcruntime140), which contains the compiler-related functionality, such as exception handling, and intrinsics. If you are using the default project settings, then this change does not impact you since the linker will use the new default libraries automatically. If you have set the project's **Linker** property **Ignore All Default Libraries** to **Yes** or you are using the /NODEFAULTLIB linker option on the command line, then you must update your list of libraries (in the **Additional Dependencies** property) to include the new, refactored libraries. Replace the old CRT library (libcmt.lib, libcmtd.lib, msvcrt.lib, msvcrtd.lib) with the equivalent refactored libraries. For each of the two refactored libraries, there are static (.lib) and dynamic (.dll) versions, and release (with no suffix) and debug versions (with the "d" suffix). The dynamic versions have an import library that you link with. The two refactored libraries are Universal CRT, specifically ucrtbase.dll or .lib, ucrtbased.dll or .lib, and the VC runtime library, libvcruntime.lib, libvcruntime.dll, libvcruntimed.lib, and libvcruntimed.dll. See [CRT Library Features](../vs140/crt-library-features.md).  
  
#### <locale.h>  
  
-   **localeconv** The [localeconv](../vs140/localeconv.md) function declared in locale.h now works correctly when [per-thread locale](../vs140/multithreading-and-locales.md) is enabled. In previous versions of the library, this function would return the lconv data for the global locale, not the thread's locale.  
  
     If you use per thread locale, you should check your use of localeconv to see if your code assumes that the lconv data returned is for the global locale and modify it appropriately.  
  
#### <math.h>  
  
-   **C++ overloads of math library functions** In previous versions, <math.h> defined some, but not all, of the C++ overloads for the math library functions. \<cmath> defined the remaining overloads, so to get all of the overloads, one needed to include the \<cmath> header. This led to problems with function overload resolution in code that only included <math.h>. Now, all C++ overloads have been removed from <math.h> and are now present only in \<cmath>.  
  
     To resolve errors, include \<cmath> to get the declarations of the functions that were removed from <math.h>. The following table lists the functions that were moved.  
  
     Functions that were moved:  
  
    1.  double abs(double) and float abs(float)  
  
    2.  double pow(double, int), float pow(float, float), float pow(float, int), long double pow(long double, long double), long double pow(long double, int)  
  
    3.  float and long double versions of floating point functions acos, acosh, asin, asinh, atan, atanh, atan2, cbrt, ceil, copysign, cos, cosh, erf, erfc, exp, exp2, expm1, fabs, fdim, floor, fma, fmax, fmin, fmod, frexp, hypot, ilogb, ldexp, lgamma, llrint, llround, log, log10, log1p, log2, lrint, lround, modf, nearbyint, nextafter, nexttoward, remainder, remquo, rint, round, scalbln, scalbn, sin, sinh, sqrt, tan, tanh, tgamma, trunc  
  
     If you have code that uses abs with a floating point type that only includes the math.h header, the floating point versions will no longer be available, so the call, even with a floating point argument, now resolves to abs(int). This produces the error:  
  
 **warning C4244: 'argument' : conversion from 'float' to 'int', possible loss of data**     The fix for this warning is to replace the call to abs with a floating point version of abs, such as fabs for a double argument or fabsf for a float argument, or include the cmath header and continue to use abs.  
  
-   **Floating point conformance** Many changes to the math library have been made to improve conformance to the IEEE-754 and C11 Annex F specifications with respect to special case inputs such as NaNs and infinities. For example, quiet NaN inputs, which were often treated as errors in previous versions of the library, are no longer treated as errors. See [IEEE 754 Standard](http://grouper.ieee.org/groups/754) and Annex F of the [C11 Standard](http://www.iso-9899.info/wiki/The_Standard).  
  
     These changes won't cause compile-time errors, but might cause programs to behave differently and more correctly according to the standard.  
  
-   **FLT_ROUNDS** In Visual Studio 2013, the FLT_ROUNDS macro expanded to a constant expression, which was incorrect because the rounding mode is configurable at runtime, for example, by calling fesetround. The FLT_ROUNDS macro is now dynamic and correctly reflects the current rounding mode.  
  
#### \<new> and <new.h>  
  
-   **new and delete** In previous versions of the library, the implementation-defined operator new and delete functions were exported from the runtime library DLL (for example, msvcr120.dll). These operator functions are now always statically linked into your binaries, even when using the runtime library DLLs.  
  
     This is not a breaking change for native or mixed code (/clr), however for code compiled as [/clr:pure](../vs140/-clr--common-language-runtime-compilation-.md), this might cause your code to fail to compile. If you compile code as /clr:pure, you may need to add #include <new> or #include <new.h> to work around build errors due to this change. Note that /clr:pure is deprecated in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] and might be removed in future releases.  
  
#### <process.h>  
  
-   **_beginthread and _beginthreadex** The [_beginthread](../vs140/_beginthread--_beginthreadex.md) and [_beginthreadex](../vs140/_beginthread--_beginthreadex.md) functions now hold a reference to the module in which the thread procedure is defined for the duration of the thread. This helps to ensure that modules are not unloaded until a thread has run to completion.  
  
#### <stdarg.h>  
  
-   **va_start and reference types** When compiling C++ code, [va_start](../vs140/va_arg--va_copy--va_end--va_start.md) now validates at compile-time that the argument passed to it is not of reference type. Reference-type arguments are prohibited by the C++ Standard.  
  
#### <stdio.h> and <conio.h>  
  
-   **The printf and scanf family of functions are now defined inline.** The definitions of all of the printf and scanf functions have been moved inline into <stdio.h>, <conio.h>, and other CRT headers. This is a breaking change that leads to a linker error (LNK2019, unresolved external symbol) for any programs that declared these functions locally without including the appropriate CRT headers. If possible, you should update the code to include the CRT headers (that is, add #include <stdio.h>) and the inline functions, but if you do not want to modify your code to include these header files, an alternative solution is to add an additional library to your linker input, legacy_stdio_definitions.lib.  
  
     To add this library to your linker input in the IDE, open the context menu for the project node, choose **Properties**, then in the **Project Properties** dialog box, choose **Linker**, and edit the **Linker Input** to add legacy_stdio_definitions.lib to the semi-colon-separated list.  
  
     If your project links with static libraries that were compiled with a release of Visual C++ earlier than 2015, the linker might report an unresolved external symbol. These errors might reference internal stdio definitions for _iob, _iob_func, or related imports for certain stdio functions in the form of _imp_*. Microsoft recommends that you recompile all static libraries with the latest version of the Visual C++ compiler and libraries when you upgrade a project. If the library is a third-party library for which source is not available, you should either request an updated binary from the third party or encapsulate your usage of that library into a separate DLL that you compile with the older version of the Visual C++ compiler and libraries.  
  
    > [!WARNING]
    >  If you are linking with Windows SDK 8.1 or earlier, you might encounter these unresolved external symbol errors. In that case, you should resolve the error by adding legacy_stdio_definitions.lib to the linker input as described previously.  
  
     To troubleshoot unresolved symbol errors, you can try using [dumpbin.exe](../vs140/dumpbin-reference.md) to examine the symbols defined in a binary. Try the following command line to view symbols defined in a library.  
  
    ```  
    dumpbin.exe /LINKERMEMBER somelibrary.lib  
    ```  
  
-   **gets and _getws** The [gets](../vs140/gets--_getws.md) and [_getws](../vs140/gets--_getws.md) functions have been removed. The gets function was removed from the C Standard Library in C11 because it cannot be used securely. The _getws function was a Microsoft extension that was equivalent to gets but for wide strings. As alternatives to these functions, consider use of [fgets](../vs140/fgets--fgetws.md), [fgetws](../vs140/fgets--fgetws.md), [gets_s](../vs140/gets_s--_getws_s.md), and [_getws_s](../vs140/gets_s--_getws_s.md).  
  
-   **_cgets and _cgetws** The [_cgets](../vs140/_cgets--_cgetws.md) and [_cgetws](../vs140/_cgets--_cgetws.md) functions have been removed. As alternatives to these functions, consider use of [_cgets_s](../vs140/_cgets_s--_cgetws_s.md) and [_cgetws_s](../vs140/_cgets_s--_cgetws_s.md).  
  
-   **Infinity and NaN Formatting** In previous versions, infinities and NaNs would be formatted using a set of Visual C++-specific sentinel strings.  
  
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
  
-   **Floating point formatting and parsing** New floating point formatting and parsing algorithms have been introduced to improve correctness. This change affects the [printf](../vs140/printf--_printf_l--wprintf--_wprintf_l.md) and [scanf](../vs140/scanf--_scanf_l--wscanf--_wscanf_l.md) families of functions, as well as functions like [strtod](../vs140/strtod--_strtod_l--wcstod--_wcstod_l.md).  
  
     The old formatting algorithms would generate only a limited number of digits, then would fill the remaining decimal places with zero. This is usually good enough to generate strings that will round-trip back to the original floating point value, but it's not great if you want the exact value (or the closest decimal representation thereof). The new formatting algorithms generate as many digits as are required to represent the value (or to fill the specified precision). As an example of the improvement; consider the results when printing a large power of two:  
  
    ```  
  
    printf("%.0f\n", pow(2.0, 80))  
  
    ```  
  
  **Old:  1208925819614629200000000    New:  1208925819614629174706176**     The old parsing algorithms would consider only up to 17 significant digits from the input string and would discard the rest of the digits. This is sufficient to generate a very close approximation of the value represented by the string, and the result is usually very close to the correctly rounded result. The new implementation considers all present digits and produces the correctly rounded result for all inputs (up to 768 digits in length). In addition, these functions now respect the rounding mode (controllable via fesetround).  This is a potentially breaking behavior change because these functions might output different results. The new results are always more correct than the old results.  
  
-   **Hexadecimal and infinity/NaN floating point parsing** The floating point parsing algorithms will now parse hexadecimal floating point strings (such as those generated by the %a and %A printf format specifiers) and all infinity and NaN strings that are generated by the printf functions, as described above.  
  
-   **%A and %a zero padding** The %a and %A format specifiers format a floating point number as a hexadecimal mantissa and binary exponent. In previous versions, the printf functions would incorrectly zero-pad strings. For example, printf("%07.0a\n", 1.0) would print 00x1p+0, where it should print 0x01p+0. This has been fixed.  
  
-   **%A and %a precision** The default precision of the %A and %a format specifiers was 6 in previous versions of the library. The default precision is now 13 for conformance with the C Standard.  
  
     This is a runtime behavior change in the output of any function that uses a format string with %A or %a. In the old behavior, the output using the %A specifier might be "1.1A2B3Cp+111". Now the output for the same value is "1.1A2B3C4D5E6F7p+111". To get the old behavior, you can specify the precision, for example, %.6A. See [Precision Specification](../vs140/precision-specification.md).  
  
-   **%F specifier** The %F format/conversion specifier is now supported. It is functionally equivalent to the %f format specifier, except that infinities and NaNs are formatted using capital letters.  
  
     In previous versions, the implementation used to parse F and N as length modifiers. This behavior dated back to the age of segmented address spaces: these length modifiers were used to indicate far and near pointers, respectively, as in %Fp or %Ns. This behavior has been removed. If %F is encountered, it is now treated as the %F format specifier; if %N is encountered, it is now treated as an invalid parameter.  
  
-   **Exponent formatting** The %e and %E format specifiers format a floating point number as a decimal mantissa and exponent. The %g and %G format specifiers also format numbers in this form in some cases. In previous versions, the CRT would always generate strings with three-digit exponents. For example, printf("%e\n", 1.0) would print 1.000000e+000. This was incorrect: C requires that if the exponent is representable using only one or two digits, then only two digits are to be printed.  
  
     In Visual Studio 2005 a global conformance switch was added: [_set_output_format](../vs140/_set_output_format.md). A program could call this function with the argument _TWO_DIGIT_EXPONENT, to enable conforming exponent printing. The default behavior has been changed to the standards-conforming exponent printing mode.  
  
-   **Format string validation** In previous versions, the printf and scanf functions would silently accept many invalid format strings, sometimes with unusual effects. For example, %hlhlhld would be treated as %d. All invalid format strings are now treated as invalid parameters.  
  
-   **fopen mode string validation**  
  
     In previous versions, the fopen family of functions silently accepted some invalid mode strings (e.g. r+b+). Invalid mode strings are now detected and treated as invalid parameters.  
  
-   **_O_U8TEXT mode**  
  
     The [_setmode](../vs140/_setmode.md) function now correctly reports the mode for streams opened in_O_U8TEXT mode. In previous versions of the library, it would report such streams as being opened in _O_WTEXT.  
  
     This is a breaking change if your code interprets the _O_WTEXT mode for streams where the encoding is UTF-8. If your application doesn't support UTF_8, consider adding support for this increasingly common encoding.  
  
-   **snprintf and vsnprintf** The [snprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md) and [vsnprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) functions are now implemented. Older code often provided definitions macro versions of these functions because they were not implemented by the CRT library, but these are no longer needed in newer versions. If [snprintf](../vs140/snprintf--_snprintf--_snprintf_l--_snwprintf--_snwprintf_l.md) or [vsnprintf](../vs140/vsnprintf--_vsnprintf--_vsnprintf_l--_vsnwprintf--_vsnwprintf_l.md) is defined as a macro before including <stdio.h>, compilation now fails with an error that indicates where the macro was defined.  
  
     Normally, the fix to this problem is to delete any declarations of snprintf or vsnprintf in user code.  
  
-   **tmpnam Generates Usable File Names** In previous versions, the tmpnam and tmpnam_s functions generated file names in the root of the drive (such as \sd3c.). These functions now generate usable file name paths in a temporary directory.  
  
-   **FILE Encapsulation** In previous versions, the FILE type was completely defined in <stdio.h>, so it was possible for user code to reach into a FILE and modify its internals. The stdio library has been changed to hide implementation details. As part of this, FILE as defined in <stdio.h> is now an opaque type and its members are inaccessible from outside of the CRT itself.  
  
-   **_outp and _inp** The functions [_outp](../vs140/_outp--_outpw--_outpd.md), [_outpw](../vs140/_outp--_outpw--_outpd.md), [_outpd](../vs140/_outp--_outpw--_outpd.md), [_inp](../vs140/_inp--_inpw--_inpd.md), [_inpw](../vs140/_inp--_inpw--_inpd.md), and [_inpd](../vs140/_inp--_inpw--_inpd.md) have been removed.  
  
#### <stdlib.h>, <malloc.h>, and <sys/stat.h>  
  
-   **strtof and wcstof** The strtof and wcstof functions failed to set errno to ERANGE when the value was not representable as a float. This has been fixed. (Note that this error was specific to these two functions; the strtod, wcstod, strtold, and wcstold functions were unaffected.) This is a runtime breaking change.  
  
-   **Aligned allocation functions** In previous versions, the aligned allocation functions (_aligned_malloc, _aligned_offset_malloc, etc.) would silently accept requests for a block with an alignment of 0. The requested alignment must be a power of two, which zero is not. This has been fixed, and a requested alignment of 0 is now treated as an invalid parameter. This is a runtime breaking change.  
  
-   **Heap functions** The _heapadd, _heapset, and _heapused functions have been removed. These functions have been nonfunctional since the CRT was updated to use the Windows heap.  
  
-   **smallheap** The smalheap link option has been removed. See [Link Options](../vs140/link-options.md).  
  
#### <string.h>  
  
-   **wcstok** The signature of the wcstok function has been changed to match what is required by the C Standard. In previous versions of the library, the signature of this function was:  
  
    ```  
    wchar_t* wcstok(wchar_t*, wchar_t const*)  
    ```  
  
     It used an internal, per-thread context to track state across calls, as is done for strtok. The function now has the signature wchar_t* wcstok(wchar_t\*, wchar_t const\*, wchar_t\*\*), and requires the caller to pass the context as a third argument to the function.  
  
     A new _wcstok function has been added with the old signature to ease porting. When compiling C++ code, there is also an inline overload of wcstok that has the old signature. This overload is declared as deprecated. In C code, you may define_CRT_NON_CONFORMING_WCSTOK to cause _wcstok to be used in place of wcstok.  
  
#### <time.h>  
  
-   **clock** In previous versions, the [clock](../vs140/clock.md) function was implemented using the Windows API [GetSystemTimeAsFileTime](http://msdn.microsoft.com/library/windows/desktop/ms724397.aspx). With this implementation, the clock function was sensitive to the system time, and was thus not necessarily monotonic. The clock function has been reimplemented in terms of [QueryPerformanceCounter](https://msdn.microsoft.com/library/windows/desktop/ms644904.aspx) and is now monotonic.  
  
-   **fstat and _utime** In previous versions, the [_stat](../vs140/_stat--_stat32--_stat64--_stati64--_stat32i64--_stat64i32--_wstat--_wstat32--_wstat64--_wstati64--_wstat32i64--_wstat64i32.md), [fstat](../vs140/_fstat--_fstat32--_fstat64--_fstati64--_fstat32i64--_fstat64i32.md), and [_utime](../vs140/_utime--_utime32--_utime64--_wutime--_wutime32--_wutime64.md) functions handle daylight savings time incorrectly. Prior to Visual Studio 2013, all of these functions incorrectly adjusted standard time times as if they were in daylight time.  
  
     In Visual Studio 2013, the problem was fixed in the _stat family of functions, but the similar problems in the fstat and _utime families of functions were not fixed. This led to problems due to the inconsistency between the functions. The fstat and _utime families of functions have now been fixed, so all of these functions now handle daylight savings time correctly and consistently.  
  
-   **asctime** In previous versions, the [asctime](../vs140/asctime--_wasctime.md) function would pad single-digit days with a leading zero, for example: Fri Jun 06 08:00:00 2014. The specification requires that such days be padded with a leading space, e.g. Fri Jun  6 08:00:00 2014. This has been fixed.  
  
-   **strftime and wcsftime** The strftime and wcsftime functions now support the %C, %D, %e, %F, %g, %G, %h, %n, %r, %R, %t, %T, %u, and %V format specifiers. Additionally, the E and O modifiers are parsed but ignored.  
  
     The %c format specifier is specified as producing an "appropriate date and time representation" for the current locale. In the C locale, this representation is required to be the same as %a %b %e %T %Y. This is the same form as is produced by asctime. In previous versions, the %c format specifier incorrectly formatted times using a MM/DD/YY HH:MM:SS representation. This has been fixed.  
  
-   **timespec and TIME_UTC** The <time.h> header now defines the timespec type and the timespec_get function from the C11 Standard. In addition, the TIME_UTC macro, for use with the timespec_get function, is now defined. This is a breaking change for code that has a conflicting definition for any of these.  
  
-   **CLOCKS_PER_SEC** The CLOCKS_PER_SEC macro now expands to an integer of type clock_t, as required by the C language.  
  
####  <a name="BK_STL"></a> Standard Template Library  
 To enable new optimizations and debugging checks, the Visual Studio implementation of the C++ Standard Library intentionally breaks binary compatibility from one version to the next. Therefore, when the C++ Standard Library is used, object files and static libraries that are compiled by using different versions can't be mixed in one binary (EXE or DLL), and C++ Standard Library objects can't be passed between binaries that are compiled by using different versions. Such mixing emits linker errors about _MSC_VER mismatches. (_MSC_VER is the macro that contains the compiler's major version—for example, 1800 for Visual Studio 2013.) This check cannot detect DLL mixing, and cannot detect mixing that involves Visual C++ 2008 or earlier.  
  
-   **STL include files** Some changes have been made to the include structure in the STL headers. STL headers are allowed to include each other in unspecified ways. In general, you should write your code so that it carefully includes all of the headers that it needs according to the C++ standard and doesn't rely on which STL headers include which other STL headers. This makes code portable across versions and platforms. At least two header changes in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] affect user code. First, \<string> no longer includes \<iterator>. Second, \<tuple> now declares std::array without including all of \<array>, which can break code through the following combination of code constructs: your code has a variable named "array", and you have a using-directive "using namespace std;", and you include an STL header (such as \<functional>) that includes \<tuple>, which now declares std::array.  
  
-   **steady_clock** The \<chrono> implementation of [steady_clock](../vs140/steady_clock-struct.md) has changed to meet the C++ Standard requirements for steadiness and monotonicity. steady_clock is now based on [QueryPerformanceCounter](https://msdn.microsoft.com/library/windows/desktop/ms644904.aspx) and high_resolution_clock is now a typedef for steady_clock. As a result, in Visual C++ steady_clock::time_point is now a typedef for chrono::time_point<steady_clock>; however, this is not necessarily the case for other implementations.  
  
-   **allocators and const** We now require allocator equality/inequality comparisons to accept const arguments on both sides.  If your allocators define these operators as follows:  
  
    ```  
    bool operator==(const MyAlloc& other)  
    ```  
  
     You should update these to declare them as const members.  
  
    ```  
    bool operator==(const MyAlloc& other) const  
    ```  
  
-   **const elements** The C++ standard has always forbidden containers of const elements (such as vector\<const T> or set\<const T>). Visual C++ 2013 and earlier accepted such containers. In the current version, such containers fail to compile.  
  
-   **std::allocator::deallocate** In Visual C++ 2013 and earlier, std::allocator::deallocate(p, n) ignored the argument passed in for n.  The C++ standard has always required that n be equal to the value passed as the first argument to the invocation of allocate which returned p. However, in the current version, the value of n is inspected. Code that passes arguments for n that differ from what the standard requires might crash at runtime.  
  
-   **hash_map and hash_set** The non-standard header files hash_map and hash_set are deprecated in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)] and will be removed in a future release. Use unordered_map and unordered_set instead.  
  
-   **comparators and operator()** Associative containers (the \<map> family) now require their comparators to have const-callable function call operators. The following code in a comparator class declaration now fails to compile:  
  
    ```  
    bool operator()(const X& a, const X& b)  
    ```  
  
     To resolve this error, change the function declaration to:  
  
    ```  
    bool operator()(const X& a, const X& b) const  
    ```  
  
-   **type traits** The old names for type traits from an earlier version of the C++ draft standard have been removed. These were changed in C++11 and have been updated to the C++11 values in [!INCLUDE[vs_dev14](../vs140/includes/vs_dev14_md.md)]. The following table shows the old and new names.  
  
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
  
-   **launch::any and launch::sync policies** The nonstandard launch::any and launch::sync policies were removed. Instead, for launch::any, use launch:async &#124; launch:deferred. For launch::sync, use launch::deferred. See [launch Enumeration](../vs140/launch-enumeration.md).  
  
####  <a name="BK_MFC"></a> MFC and ATL  
  
-   **Microsoft Foundation Classes (MFC)** is no longer included in a "Typical" install of Visual Studio because of its large size. To install MFC, choose the Custom install option in Visual Studio 2015 setup. If you already have Visual Studio 2015 installed, you can install MFC by re-running Visual Studio setup, choosing the Custom install option, and choosing Microsoft Foundation Classes. You can re-run Visual Studio setup from the Control Panel, Programs and Features, or from the installation media.  
  
     The Visual C++ Redistributable Package still includes this library.  
  
####  <a name="BK_ConcRT"></a> Concurrency Runtime  
  
-   **Yield macro from Windows.h conflicting with concurrency::Context::Yield** The Concurrency Runtime previously used #undef to undefine the Yield macro to avoid conflicts between the Yield macro defined in Windows.h h and the concurrency::Context::Yield function. This #undef has been removed and a new non-conflicting equivalent API call [concurrency::Context::YieldExecution](../vs140/context--yieldexecution-method.md) has been added. To work around conflicts with Yield, you can either update your code to call the YieldExecution function instead, or surround the Yield function name with parentheses at call sites, as in the following example:  
  
    ```  
    (concurrency::Context::Yield)();  
    ```  
  
## Compiler Conformance Improvements in Visual C++ 2015  
 When upgrading code from previous versions, you might also encounter compiler errors that are due to conformance improvements made in Visual C++ 2015. These improvements do not break binary compatibility from earlier versions of Visual C++, but they can produce compiler errors where none were emitted before. For more information, see [Compiler Conformance Improvements in Visual C++ 2015](../vs140/compiler-conformance-improvements-in-visual-c---2015.md).