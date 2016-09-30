---
title: "Unicode and Multibyte Character Set (MBCS) Support"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], character set support"
  - "MBCS [C++], strings and MFC support"
  - "strings [C++], MBCS support in MFC"
  - "character sets [C++], multibyte"
  - "Unicode [C++], MFC strings"
  - "Unicode [C++], string objects"
  - "strings [C++], Unicode"
  - "strings [C++], character set support"
ms.assetid: 44b3193b-c92d-40c5-9fa8-5774da303cce
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Unicode and Multibyte Character Set (MBCS) Support
Some languages, for example, Japanese and Chinese, have large character sets. To support programming for these markets, the Microsoft Foundation Class Library (MFC) is enabled for two different approaches to handling large character sets:  
  
-   [Unicode](#_core_mfc_support_for_unicode_strings)  
  
-   [Multibyte Character Sets (MBCS)](#_core_mfc_support_for_mbcs_strings)  
  
 You should use Unicode for all new development.  
  
##  \<a name="_core_mfc_support_for_unicode_strings">\</a> MFC Support for Unicode Strings  
 The entire class library is conditionally enabled for Unicode characters and strings. In particular, class [CString](../vs140/cstringt-class.md) is Unicode-enabled.  
  
|||||  
|-|-|-|-|  
|UAFXCW.LIB|UAFXCW.PDB|UAFXCWD.LIB|UAFXCWD.PDB|  
|MFC*xx*U.LIB|MFC*xx*U.PDB|MFC*xx*U.DLL|MFC*xx*UD.LIB|  
|MFC*xx*UD.PDB|MFC*xx*UD.DLL|MFCS*xx*U.LIB|MFCS*xx*U.PDB|  
|MFCS*xx*UD.LIB|MFCS*xx*UD.PDB|MFCM*xx*U.LIB|MFCM*xx*U.PDB|  
|MFCM*xx*U.DLL|MFCM*xx*UD.LIB|MFCM*xx*UD.PDB|MFCM*xx*UD.DLL|  
  
 (*xx* represents the version number of the file; for example, '80' means version 8.0.)  
  
 <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> is based on the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data type. If the symbol <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is defined for a build of your program, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is defined as type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, a 16-bit character encoding type. Otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the normal 8-bit character encoding. Therefore, under Unicode, a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is composed of 16-bit characters. Without Unicode, it is composed of characters of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 To complete Unicode programming of your application, you must also:  
  
-   Use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macro to conditionally code literal strings to be portable to Unicode.  
  
-   When you pass strings, pay attention to whether function arguments require a length in characters or a length in bytes. The difference is important if you are using Unicode strings.  
  
-   Use portable versions of the C run-time string-handling functions.  
  
-   Use the following data types for characters and character pointers:  
  
    -   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> Where you would use <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
    -   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> Where you would use <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
    -   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> Where you would use <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> provides the operator <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to convert between <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> also supplies Unicode-aware constructors, assignment operators, and comparison operators.  
  
 For related information on Unicode programming, see [Unicode Topics](../vs140/unicode-in-mfc.md). The [Run-Time Library Reference](../vs140/c-run-time-library-reference.md) defines portable versions of all its string-handling functions. See the category [Internationalization](../vs140/internationalization.md).  
  
##  \<a name="_core_mfc_support_for_mbcs_strings">\</a> MFC Support for MBCS Strings  
  
> [!WARNING]
>  MBCS strings are legacy technology and should not be used in new projects. The following information is provided for scenarios in which you need to maintain existing code that uses MBCS and it is not feasible to upgrade the code to use Unicode.  
  
 The class library is also enabled for multibyte character sets, but only for double-byte character sets (DBCS).  
  
> [!IMPORTANT]
>  In [!INCLUDE[vs_dev12](../vs140/includes/vs_dev12_md.md)] and later, the MBCS versions of the MFC DLLs are available as a free add-in to Visual Studio from the MSDN download site. For more information, see [MFC MBCS DLL Add-in](../vs140/mfc-mbcs-dll-add-on.md).  
  
 In a multibyte character set, a character can be one or two bytes wide. If it is two bytes wide, its first byte is a special "lead byte" that is chosen from a particular range, depending on which code page is in use. Taken together, the lead and "trail bytes" specify a unique character encoding.  
  
 If the symbol <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is defined for a build of your program, type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, on which <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is based, maps to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. It is up to you to determine which bytes in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> are lead bytes and which are trail bytes. The C run-time library supplies functions to help you determine this.  
  
 Under DBCS, a given string can contain all single-byte ANSI characters, all double-byte characters, or a combination of the two. These possibilities require special care in parsing strings. This includes <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects.  
  
> [!NOTE]
>  Unicode string serialization in MFC can read both Unicode and MBCS strings regardless of which version of the application that you are running. Your data files are portable between Unicode and MBCS versions of your program.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> member functions use special "generic text" versions of the C run-time functions they call, or they use Unicode-aware functions. Therefore, for example, if a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> function would typically call <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, it calls the corresponding generic-text function <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instead. Depending on how the symbols <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are defined, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> maps as follows:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder> defined|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder> defined|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|  
|Neither symbol defined|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
> [!NOTE]
>  The symbols <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> are mutually exclusive.  
  
 Generic-text function mappings for all of the run-time string-handling routines are discussed in [Run-Time Library Reference](../vs140/c-run-time-library-reference.md). In particular, see [Internationalization](../vs140/internationalization.md).  
  
 Similarly, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> methods are implemented by using "generic" data type mappings. To enable both MBCS and Unicode, MFC uses <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. These ensure the correct mappings for either MBCS or Unicode.  
  
## See Also  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)   
 [String Manipulation (CRT)](../vs140/string-manipulation--crt-.md)