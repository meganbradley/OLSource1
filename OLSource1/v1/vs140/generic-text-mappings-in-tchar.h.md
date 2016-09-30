---
title: "Generic-Text Mappings in Tchar.h"
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
  - ""tchar.h""
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "mapping generic-text"
  - "generic-text mappings [C++]"
  - "character sets [C++], generic-text mappings"
  - "Unicode [C++], generic-text mappings"
  - "MBCS [C++], generic-text mappings"
  - "TCHAR.H data types, mapping"
  - "mappings [C++], TCHAR.H"
ms.assetid: 01e1bb74-5a01-4093-8720-68b6c1fdda80
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Generic-Text Mappings in Tchar.h
To simplify the transporting of code for international use, the [!INCLUDE[TLA#tla_ms](../vs140/includes/tlasharptla_ms_md.md)] run-time library provides [!INCLUDE[TLA#tla_ms](../vs140/includes/tlasharptla_ms_md.md)]-specific generic-text mappings for many data types, routines, and other objects. You can use these mappings, which are defined in Tchar.h, to write generic code that can be compiled for single-byte, multibyte, or [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] character sets, depending on a manifest constant that you define by using a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> statement. Generic-text mappings are [!INCLUDE[TLA#tla_ms](../vs140/includes/tlasharptla_ms_md.md)] extensions that are not [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] compatible.  
  
 By using the Tchar.h, you can build single-byte, Multibyte Character Set (MBCS), and [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] applications from the same sources. Tchar.h defines macros (which have the prefix <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) that, with the correct preprocessor definitions, map to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions, as appropriate. To build MBCS, define the symbol <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. To build [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)], define the symbol <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. To build a single-byte application, define neither (the default). By default, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is defined for MFC applications.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> data type is defined conditionally in Tchar.h. If the symbol <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is defined for your build, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is defined as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>; otherwise, for single-byte and MBCS builds, it is defined as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the basic Unicode wide-character data type, is the 16-bit counterpart to an 8-bit signed <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.) For international applications, use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> family of functions, which operate in <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> units, not bytes. For example, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> copies <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, not <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> bytes.  
  
 Because some Single Byte Character Set (SBCS) string-handling functions take (signed) <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameters, a type mismatch compiler warning results when <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is defined. There are three ways to avoid this warning:  
  
1.  Use the type-safe inline function thunks in Tchar.h. This is the default behavior.  
  
2.  Use the direct macros in Tchar.h by defining <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> on the command line. If you do this, you must manually match types. This is the fastest method, but is not type-safe.  
  
3.  Use the type-safe statically linked library function thunks in Tchar.h. To do so, define the constant <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> on the command line. This is the slowest method, but the most type-safe.  
  
### Preprocessor Directives for Generic-Text Mappings  
  
|# define|Compiled version|Example|  
|---------------|----------------------|-------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|[!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] (wide-character)|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Multibyte-character|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|  
|None (the default has neither <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> defined)|SBCS ([!INCLUDE[TLA#tla_ascii](../vs140/includes/tlasharptla_ascii_md.md)])|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|  
  
 For example, the generic-text function <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, which is defined in Tchar.h, maps to <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if you defined <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> in your program, or to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> if you defined <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. Otherwise, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> maps to <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Other data type mappings are provided in Tchar.h for programming convenience, but <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is the most useful.  
  
### Generic-Text Data Type Mappings  
  
|Generic-Text\<br />\<br /> Data Type Name|_UNICODE &\<br />\<br /> _MBCS Not Defined|_MBCS\<br />\<br /> Defined|_UNICODE\<br />\<br /> Defined|  
|--------------------------------------|----------------------------------------|------------------------|---------------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|No effect (removed by preprocessor)|No effect (removed by preprocessor)|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder> (converts the following character or string to its [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)] counterpart)|  
  
 For a list of generic-text mappings of routines, variables, and other objects, see [Generic-Text Mappings](../vs140/generic-text-mappings.md) in the Run-Time Library Reference.  
  
> [!NOTE]
>  Do not use the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> family of functions with Unicode strings, which are likely to contain embedded null bytes. Similarly, do not use the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> family of functions with MBCS (or SBCS) strings.  
  
 The following code fragments illustrate the use of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> for mapping to the MBCS, [!INCLUDE[TLA#tla_unicode](../vs140/includes/tlasharptla_unicode_md.md)], and SBCS models.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> has been defined, the preprocessor maps this fragment to this code:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> has been defined, the preprocessor maps this fragment to this code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If neither <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> nor <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> have been defined, the preprocessor maps the fragment to single-byte [!INCLUDE[TLA#tla_ascii](../vs140/includes/tlasharptla_ascii_md.md)] code, as follows:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Therefore, you can write, maintain, and compile a single-source code file to run with routines that are specific to any of the three kinds of character sets.  
  
## See Also  
 [Text and Strings](../vs140/text-and-strings-in-visual-c--.md)   
 [Using TCHAR.H Data Types with _MBCS Code](../vs140/using-tchar.h-data-types-with-_mbcs-code.md)