---
title: "-clr Restrictions"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "/clr Restrictions"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "/clr compiler option [C++], restrictions"
ms.assetid: 385f6462-2c68-46d6-810e-469553ead447
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# -clr Restrictions
Note the following restrictions on the use of **/clr**:  
  
-   In a structured exception handler, there are restrictions on using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when compiling with **/clr**. For more information, see [_alloca](../vs140/_alloca.md).  
  
-   The use of run-time error checks is not valid with **/clr**. For more information, see [Run-Time Error Checks](../vs140/how-to--use-native-run-time-checks.md).  
  
-   When **/clr** is used to compile a program that only uses standard C++ syntax, the following guidelines apply to the use of inline assembly:  
  
    -   Inline assembly code that assumes knowledge of the native stack layout, calling conventions outside of the current function, or other low-level information about the computer may fail if that knowledge is applied to the stack frame for a managed function. Functions containing inline assembly code are generated as unmanaged functions, as if they were placed in a separate module that was compiled without **/clr**.  
  
    -   Inline assembly code in functions that pass copy-constructed function parameters is not supported.  
  
-   The [vprintf Functions](../vs140/vprintf-functions.md) cannot be called from a program compiled with **/clr**.  
  
-   The [naked](../vs140/naked--c---.md) [__declspec](../vs140/__declspec.md) modifier is ignored under /clr.  
  
-   The translator function set by [_set_se_translator](../vs140/_set_se_translator.md) will affect only catches in unmanaged code. See [Exception Handling](../vs140/exception-handling---c---component-extensions-.md) for more information.  
  
-   The comparison of function pointers is not permitted under **/clr**.  
  
-   The use of functions that are not fully prototyped is not permitted under **/clr**.  
  
-   The following compiler options are not supported with **/clr**:  
  
    -   **/EHsc** and **/EHs** (**/clr** implies **/EHa** (see [/EH (Exception Handling Model)](../vs140/-eh--exception-handling-model-.md))  
  
    -   **/fp:strict** and **/fp:except** (see [/fp (Specify Floating-Point Behavior)](../vs140/-fp--specify-floating-point-behavior-.md))  
  
    -   [/Zd](../vs140/-z7---zi---zi--debug-information-format-.md)  
  
    -   [/Gm](../vs140/-gm--enable-minimal-rebuild-.md)  
  
    -   [/MT](../vs140/-md---mt---ld--use-run-time-library-.md)  
  
    -   [/RTC](../vs140/-rtc--run-time-error-checks-.md)  
  
    -   **/ZI**  
  
-   The combination of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> preprocessor definition (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) and the **/clr** or **/clr:pure** compiler option is not supported. This is so because the definition would cause your application to link with the static multithreaded Standard C++ Library, which is not supported. For more information, see the [/MD, /MT, /LD (Use Run-Time Library)](../vs140/-md---mt---ld--use-run-time-library-.md) topic.  
  
-   [/J](../vs140/-j--default-char-type-is-unsigned-.md) is not supported with **/clr:safe** or **/clr:pure**.  
  
-   The ATL and MFC libraries are not supported by pure mode compilation (**/clr:pure**). You can use **/clr:pure** with the Standard C++ Library and the CRT if you also compile with **/MD** or **/MDd**.  
  
-   When using **/Zi** with **/clr**, there are performance implications. For more information, see [/Zi](../vs140/-z7---zi---zi--debug-information-format-.md).  
  
-   Passing a wide character to a .NET Framework output routine without also specifying [/Zc:wchar_t](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) or without casting the character to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will cause the output to appear as an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   [/GS](../vs140/-gs--buffer-security-check-.md) is ignored when compiling with **/clr**, unless a function is under <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> [unmanaged](../vs140/managed--unmanaged.md) or if the function must be compiled to native, in which case the compiler will generate warning C4793, which is off by default.  
  
-   See [/ENTRY](../vs140/-entry--entry-point-symbol-.md) for function signature requirements of a managed application.  
  
-   Applications compiled with **/openmp** and **/clr** can only be run in a single appdomain process.  See [/openmp (Enable OpenMP 2.0 Support)](../vs140/-openmp--enable-openmp-2.0-support-.md) for more information.  
  
-   Functions that take a variable number of arguments (varargs) will be generated as native functions. Any managed data types in the variable argument position will be marshaled to native types. Note that \<xref:System.String*?displayProperty=fullName> types are actually wide-character strings, but they are marshaled to single-byte character strings. So if a printf specifier is %S (wchar_t*), it will marshal to a %s string instead.  
  
-   When using the va_arg macro, you may get unexpected results when compiling with **/clr:pure**.  For more information, see [va_arg, va_end, va_start](../vs140/va_arg--va_copy--va_end--va_start.md).  
  
-   If your application passes an argument of type [va_list](../vs140/va_arg--va_copy--va_end--va_start.md) to a function declared to take a [variable number of arguments](../vs140/variable-argument-lists.md), and your application is compiled with **/clr:pure**, the CLR throws \<xref:System.NotSupportedException*>. If **/clr**  is used instead, the affected functions are compiled to native code and execute properly. If **/clr:safe** is used, an error diagnostic is emitted.  
  
-   You should not call, from managed code, any functions that walk the stack to get parameter information (function arguments); the P/Invoke layer causes that information to be further down the stack.  For example, do not compile proxy/stub with **/clr**.  
  
-   Functions will be compiled to managed code whenever possible, but not all C++ constructs can be translated to managed code.  This determination is made on a function-by-function basis. If any part of a function cannot be converted to managed code, the entire function will be converted to native code instead. The following cases prevent the compiler from generating managed code.  
  
    -   Compiler-generated thunks or helper functions. Native thunks are generated for any function call through a function pointer, including virtual function calls.  
  
    -   Functions that call <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
    -   Functions that use certain intrinsic routines to directly manipulate machine resources. For example, the use of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, or multimedia intrinsics will all result in native code.  
  
    -   Functions that follow the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> directive. (Note that the inverse, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, is also supported.)  
  
    -   A function that contains references to aligned types, that is, types declared using <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
-   You cannot use the [Compiler COM Support](../vs140/compiler-com-support.md) classes with **/clr:pure** or **/clr:safe**.  
  
## See Also  
 [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md)