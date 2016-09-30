---
title: "Compiler Warning (level 3) C4996"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4996"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4996"
ms.assetid: 926c7cc2-921d-43ed-ae75-634f560dd317
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4996
The compiler encountered a deprecated declaration.  
  
 This warning or error has several possible meanings.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> occurs when the compiler encounters a function or variable that is marked as [deprecated](../vs140/deprecated--c---.md). Several functions, member functions, template functions, and global variables in the libraries in Visual Studio are marked as deprecated. These functions may have a different preferred name, may be insecure or have a more secure variant, or may be obsolete. The error message may include a suggested replacement for the deprecated function or global variable. You can turn this warning off with the [warning](../vs140/warning.md) pragma or the **/wd4996** command line option. You can also use preprocessor macros to turn off certain classes of deprecation warnings.  
  
 **The POSIX name for this item is deprecated. Instead, use the ISO C and C++ conformant name:** new_name**. See online help for details.**  
  
 Some POSIX functions in the CRT have been renamed to conform with C99 and C++03 rules for implementation-defined global function names. In most cases, a leading underscore was added to the POSIX function name to create a standard conformant name. The compiler issues a deprecation warning for the original function names, and suggests the preferred name. Only the original names are deprecated, not the functions themselves. To turn off deprecation warnings for these functions, define the preprocessor macro **_CRT_NONSTDC_NO_WARNINGS**. You can define this at the command line by including the option <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. To define this macro in Visual Studio, open the **Property Pages** dialog for your project. Expand **Configuration Properties**, **C/C++**, **Preprocessor**. In **Preprocessor Definitions**, add <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Choose **OK** to save, and then rebuild your project. To define this macro only in specific source files, add the line <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> before any line that includes a header file.  
  
 **This function or variable may be unsafe. Consider using**  safe_version **instead. To disable deprecation, use _CRT_SECURE_NO_WARNINGS.  See online help for details.**  
  
 Some CRT and Standard C++ Library functions and globals have been deprecated in favor of new, more secure functions. The compiler issues a deprecation warning for these functions, and suggests the preferred function. To turn off deprecation warnings for these functions in the CRT, define **_CRT_SECURE_NO_WARNINGS**. To turn off warnings about deprecated global variables, define **_CRT_SECURE_NO_WARNINGS_GLOBALS**. For more information about these deprecated functions and globals, see [Security Enhancements in the CRT](../vs140/security-features-in-the-crt.md) and [Safe Libraries: Standard C++ Library](../vs140/safe-libraries--c---standard-library.md).  
  
 **Function call with parameters that may be unsafe - this call relies on the caller to check that the passed values are correct. To disable this warning, use -D_SCL_SECURE_NO_WARNINGS. See documentation on how to use Visual C++ 'Checked Iterators'**  
  
 Certain C++ Standard Library template functions do not check parameters for correctness. This warning helps you identify the use of these functions. To turn off warnings for these functions, define **_SCL_SECURE_NO_WARNINGS**. For more information, see [Checked Iterators](../vs140/checked-iterators.md).  
  
 **This function or variable has been superceded by newer library or operating system functionality. Consider using** new_item **instead. See online help for details.**  
  
 Some library functions and global variables are deprecated as obsolete. These functions and variables may be removed in a future version of the library. The compiler issues a deprecation warning for these items, and suggests the preferred alternative. To turn off deprecation warnings for these items, define **_CRT_OBSOLETE_NO_WARNINGS**. For more information, see the documentation for the deprecated function or variable.  
  
 **Various messages in MFC or ATL code**  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> can also occur if you use MFC or ATL functions that were deprecated for security reasons. To suppress these warnings, see [_AFX_SECURE_NO_WARNINGS](../vs140/_afx_secure_no_warnings.md) and [_ATL_SECURE_NO_WARNINGS](../vs140/_atl_secure_no_warnings.md).  
  
 **Marshalling errors in CLR code**  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> can also occur when you use the marshaling library. In this case C4996 is an error, not a warning. This error will occur when you use [marshal_as](../vs140/marshal_as.md) to convert between two data types that require a [marshal_context Class](../vs140/marshal_context-class.md). You will also receive this error when the marshaling library does not support a conversion. For more information about the marshaling library, see [Overview of Marshaling in C++](../vs140/overview-of-marshaling-in-c--.md).  
  
 **Examples that generate C4996**  
  
 In the first example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is generated for the line on which the function is declared and for the line on which the function is used.  
  
## Example  
 The following sample generates C4996.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 C4996 can also occur if you do not use a checked iterator when compiling with <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> defined (set to 1 by default for debug mode builds).  See [Checked Iterators](../vs140/checked-iterators.md) for more information.  
  
 The following STL code example generates C4996.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following STL code example generates C4996 as a warning. Comments are inline.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C4996 because the marshaling library requires a context to convert from a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>