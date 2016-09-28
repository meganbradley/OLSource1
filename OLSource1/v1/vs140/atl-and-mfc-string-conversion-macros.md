---
title: "ATL and MFC String Conversion Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::T2COLE"
  - "W2OLE"
  - "ATL.LPWSTR"
  - "ATL::LPCOLESTR"
  - "ATL.OLE2CT"
  - "ATL.T2CW"
  - "A2CT"
  - "ATL.LPOLESTR"
  - "A2T"
  - "ATL.W2COLE"
  - "T2COLE"
  - "ATL::T2CA"
  - "ATL::A2W"
  - "ATL::T2W"
  - "W2BSTR"
  - "T2W"
  - "T2CA"
  - "ATL.LPCWSTR"
  - "ATL.A2CW"
  - "A2W"
  - "OLE2W"
  - "W2CA"
  - "ATL::OLE2W"
  - "ATL::LPWSTR"
  - "ATL.W2BSTR"
  - "T2A"
  - "ATL::W2BSTR"
  - "ATL::A2OLE"
  - "ATL::W2T"
  - "ATL.T2OLE"
  - "OLE2CA"
  - "ATL::OLE2CA"
  - "LPCWSTR"
  - "ATL.A2T"
  - "ATL::T2OLE"
  - "ATL.W2OLE"
  - "ATL.W2CA"
  - "W2T"
  - "OLE2CW"
  - "ATL::OLE2A"
  - "ATL.OLE2T"
  - "A2OLE"
  - "ATL.T2BSTR"
  - "ATL.OLE2CA"
  - "ATL.T2A"
  - "ATL::W2COLE"
  - "ATL.T2W"
  - "ATL::A2T"
  - "ATL::OLE2BSTR"
  - "ATL::LPOLESTR"
  - "ATL.OLE2CW"
  - "ATL::W2OLE"
  - "ATL.OLE2A"
  - "ATL::W2CT"
  - "ATL::A2BSTR"
  - "ATL::A2COLE"
  - "ATL.A2OLE"
  - "LPCOLESTR"
  - "OLE2T"
  - "T2CW"
  - "ATL::T2A"
  - "ATL.A2W"
  - "ATL.A2COLE"
  - "ATL::A2CW"
  - "A2COLE"
  - "OLE2A"
  - "ATL.A2CT"
  - "ATL.W2T"
  - "ATL.LPCOLESTR"
  - "ATL::W2CA"
  - "LPWSTR"
  - "OLE2CT"
  - "W2COLE"
  - "T2BSTR"
  - "A2CW"
  - "ATL.W2CT"
  - "OLE2BSTR"
  - "ATL::LPCWSTR"
  - "ATL::W2A"
  - "ATL.T2CA"
  - "A2BSTR"
  - "ATL.W2A"
  - "W2A"
  - "LPOLESTR"
  - "ATL.T2COLE"
  - "T2OLE"
  - "ATL::T2BSTR"
  - "W2CT"
  - "ATL.A2BSTR"
  - "ATL::OLE2CT"
  - "ATL::OLE2CW"
  - "ATL::T2CW"
  - "ATL.OLE2W"
  - "ATL::OLE2T"
  - "ATL::A2CT"
  - "ATL.OLE2BSTR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE2W macro"
  - "BSTRs, conversions"
  - "W2BSTR macro"
  - "LPWSTR"
  - "W2T macro"
  - "OLE2BSTR macro"
  - "W2OLE macro"
  - "string conversion, ATL"
  - "LPOLESTR conversions"
  - "OLE2CT macro"
  - "T2COLE macro"
  - "string conversion, string conversion macros"
  - "T2W macro"
  - "T2CA_EX macro"
  - "OLE2CA macro"
  - "LPCWSTR"
  - "ATL, string conversion macros"
  - "T2CA macro"
  - "A2W macro"
  - "text, conversion macros"
  - "A2T macro"
  - "A2OLE macro"
  - "A2BSTR macro"
  - "OLE2A macro"
  - "W2A macro"
  - "LPCTSTR"
  - "OLE2T macro"
  - "LPSTR"
  - "W2COLE macro"
  - "A2COLE macro"
  - "W2CA macro"
  - "T2BSTR macro"
  - "LPCOLESTR conversions"
  - "CT2CA macro"
  - "W2CT macro"
  - "LPTSTR"
  - "A2CW macro"
  - "T2OLE macro"
  - "T2CW macro"
  - "string conversion, macros"
  - "A2CT macro"
  - "T2A macro"
  - "string conversion macros [ATL]"
  - "OLE2CW macro"
  - "LPCSTR"
ms.assetid: 8f53659e-0464-4424-97db-6b8453c49863
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL and MFC String Conversion Macros
The string conversion macros discussed here are valid for both ATL and MFC. For more information on MFC string conversion, see [TN059: Using MFC MBCS/Unicode Conversion Macros](../vs140/tn059--using-mfc-mbcs-unicode-conversion-macros.md) and [MFC Macros and Globals](../vs140/mfc-macros-and-globals.md).  
  
-   [ATL 7.0 String Conversion Classes and Macros](#atl70stringconversionclassesmacros)  
  
-   [ATL 3.0 String Conversion Macros](#atl30stringconversionmacros)  
  
##  <a name="atl70stringconversionclassesmacros"></a> ATL 7.0 String Conversion Classes and Macros  
 ATL 7.0 introduces several new conversion classes and macros, providing significant improvements over the existing macros.  
  
 The names of the new string conversion classes and macros take the form:  
  
 `C` *SourceType* `2`[`C`]*DestinationType*[`EX`]  
  
 where:  
  
-   *SourceType* and *DestinationType* are described in the table below.  
  
-   [`C`] is present when the destination type must be constant.  
  
-   [`EX`] is present when the initial size of the buffer must be specified as a template argument.  
  
    |SourceType/DestinationType|Description|  
    |---------------------------------|-----------------|  
    |A|ANSI character string.|  
    |W|Unicode character string.|  
    |T|Generic character string (equivalent to `W` when `_UNICODE` is defined, equivalent to `A` otherwise).|  
    |OLE|OLE character string (equivalent to `W`).|  
  
 For example, to convert from a Unicode string to a generic string without changing the converted string, use `CW2CT`.  
  
> [!WARNING]
>  Some of the permutations of the pattern listed above are not supported. `CA2CW` and `CW2CA` (and `CA2CWEX` and `CW2CAEX`) are not supported. For OLE character string conversions, only `COLE2T` and `CT2OLE` (and `COLE2CT`, `COLE2TEX`, `COLE2CTEX`, `CT2COLE`, `CT2OLEEX`, and `CT2COLEEX`) are supported. For details, see atlconv.h.  
  
 If it is known that the converted string is unlikely to be more than 64 characters, the `EX` version, such as `CW2CTEX<64>`, can be used to save space on the stack.  
  
> [!NOTE]
>  The recommended way of converting to and from BSTR strings is to use the [CComBSTR](../vs140/ccombstr-class.md) class. To convert to a BSTR, pass the existing string to the constructor of `CComBSTR`. To convert from a BSTR, use `COLE2`[`C`]`DestinationType`[`EX`], such as `COLE2T`.  
  
 The new conversion classes which require a buffer (`CA2AEX`, `CA2WEX`, `CW2AEX`, and `CW2WEX`) use a fixed-size static buffer to store the result of the conversion. If the result is too large to fit into the static buffer, the class allocates memory using `malloc`, freeing the memory when the object goes out of scope. This ensures that, unlike the older text conversion macros, these classes are safe to use in loops and won't overflow the stack.  
  
 The conversion macros introduced in ATL 7.0 are optimized to be aware of input `NULL` strings.  These macros will return `NULL` if the input parameter is `NULL` without allocating any memory.  
  
 By default, the ATL conversion classes and macros will use the current thread's ANSI code page for the conversion. If you want to override that behavior for a specific conversion using macros based on the classes `CA2WEX` or `CW2AEX`, specify the code page as the second parameter to the constructor for the class.  
  
> [!IMPORTANT]
>  Check the length of the strings before passing them to these macros to avoid potential buffer overrun problems. Stack overflows are exceptions that could also be caught with try/except.  
  
 There are several important differences between the older string conversion macros and the new string conversion classes:  
  
|Old ATL 3.0 Conversion Macros|New ATL 7.0 Conversion Classes|  
|-----------------------------------|------------------------------------|  
|Allocates memory on the stack.|Uses stack memory for small strings. Uses the heap if the stack is not large enough.|  
|The string is freed when the function is exited.|The string is freed when the variable goes out of scope.|  
|Cannot be used in exception handlers.|Can be used in exception handlers.|  
|Not suitable for use in loops. Memory use grows until the function is exited.|Supports use in loops. Loop scope ensures that memory is freed on each iteration.|  
|Not good for large strings. Stack space is limited.|No problems with large strings. Strings will be allocated on the heap.|  
|Usually require USES_CONVERSION to be defined.|Never require USES_CONVERSION to be defined.|  
|Meaning of OLE depends on definition of OLE2ANSI.|OLE is always equivalent to W.|  
  
## Example  
  
### Code  
 [!code[NVC_ATL_Utilities#98](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_1.cpp)]  
  
### A Warning Regarding Temporary Class Instances  
 It should be stressed that the following is not good code:  
  
 [!code[NVC_ATL_Utilities#99](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_2.cpp)]  
  
 Using ATL 3.0 macros, it was acceptable to use:  
  
 [!code[NVC_ATL_Utilities#100](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_3.cpp)]  
  
 as the memory allocated by the conversion functions would not be freed until the current function was exited. The same code does not work with the new classes.  
  
 This code:  
  
 [!code[NVC_ATL_Utilities#101](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_4.cpp)]  
  
 is equivalent to this:  
  
 [!code[NVC_ATL_Utilities#102](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_5.cpp)]  
  
 As the memory allocated by the temporary object and returned from the cast operator is destroyed when the temporary object is destroyed, using the value in `szr` will have undesirable results.  
  
 Instead, use this code:  
  
 [!code[NVC_ATL_Utilities#103](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_6.cpp)]  
  
 The cast operator makes the CA2T object look like a `LPCTSTR`.  
  
### Advanced Usage  
 The default static buffer size is 128 characters. If the buffer size must be changed for a specific conversion, use the EX version of a macro, and specify the buffer size as a template argument.  
  
 [!code[NVC_ATL_Utilities#104](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_7.cpp)]  
  
 Here is an example of specifying the code page as the second parameter to the constructor for the class.  
  
 [!code[NVC_ATL_Utilities#105](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_8.cpp)]  
  
##  <a name="atl30stringconversionmacros"></a> ATL 3.0 String Conversion Macros  
 The original text conversion macros are still available and are listed in the table below:  
  
### ATL 3.0 String Conversion Macros  
  
|||||  
|-|-|-|-|  
|A2BSTR|`OLE2A`|`T2A`|`W2A`|  
|`A2COLE`|`OLE2BSTR`|`T2BSTR`|`W2BSTR`|  
|`A2CT`|`OLE2CA`|`T2CA` (Deprecated. Use `T2CA_EX` or `CT2CA` instead.)|`W2CA`|  
|`A2CW`|`OLE2CT`|`T2COLE`|`W2COLE`|  
|`A2OLE`|`OLE2CW`|`T2CW`|`W2CT`|  
|`A2T`|`OLE2T`|`T2OLE`|`W2OLE`|  
|`A2W`|`OLE2W`|`T2W`|`W2T`|  
  
 The syntax for using these macros is as follows:  
  
 `MACRONAME( string_address )`  
  
 For example:  
  
 [!code[NVC_ATL_Utilities#106](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_9.cpp)]  
  
 In the macro names, the source string type is on the left (for example, `A`) and the destination string type is on the right (for example,  `W`). `A` stands for `LPSTR`, `OLE` stands for `LPOLESTR`, `T` stands for `LPTSTR`, and `W` stands for `LPWSTR`.  
  
 If there is a `C` in the macro name, the macro converts to a `const` string. For example, `W2CA` converts an `LPWSTR` to an `LPCSTR`.  
  
 Thus, `A2W` converts an `LPSTR` to an `LPWSTR`, `OLE2T` converts an `LPOLESTR` to an `LPTSTR`, and so on.  
  
> [!WARNING]
>  Legacy ATL and MFC 3.0 conversions are limited to supporting system code pages and thus should not be used for MBCS (multi-byte) encodings such as UTF-8. The ATL and MFC 7.0 conversions should be used instead.  
  
 The behavior of the ATL string conversion macros depends on the compiler directive in effect, if any. If the source and destination types are the same, no conversion takes place. Compiler directives change `T` and `OLE` as follows:  
  
|Compiler directive in effect|T becomes|OLE becomes|  
|----------------------------------|---------------|-----------------|  
|None|`A`|`W`|  
|`_UNICODE`|`W`|`W`|  
|`OLE2ANSI`|`A`|`A`|  
|`_UNICODE` and `OLE2ANSI`|`W`|`A`|  
  
 The destination string is created using `_alloca`, except when the destination type is `BSTR`. Using `_alloca` allocates memory off the stack, so that when your function returns, it is automatically cleaned up. By default this macro will only convert up to 500KB at one time.  
  
 When using an ATL string conversion macro, specify the `USES_CONVERSION` macro at the beginning of your function in order to avoid compiler errors. For example:  
  
 [!code[NVC_ATL_Utilities#107](../vs140/codesnippet/CPP/atl-and-mfc-string-conversion-macros_10.cpp)]  
  
### Requirements  
 Header file: AtlBase.h, AtlConv.h (declared in AtlConv.h)  
  
## See Also  
 [Macros](../vs140/atl-macros.md)   
 [DEVMODE and TEXTMETRIC String Conversion Macros](../vs140/devmode-and-textmetric-string-conversion-macros.md)