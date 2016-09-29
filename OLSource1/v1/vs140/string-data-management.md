---
title: "String Data Management"
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
  - "Unicode, string objects"
ms.assetid: 0b53a542-eeb1-4108-9ada-6700645b6f8f
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# String Data Management
Visual C++ provides several ways to manage string data:  
  
-   [String Manipulation](../vs140/string-manipulation--crt-.md) for working with C-style null-terminated strings  
  
-   Win32 API functions for managing strings  
  
-   MFC's class [CString](../vs140/cstringt-class.md), which provides flexible, resizable string objects  
  
-   Class [CStringT Class](../vs140/cstringt-class.md), which provides an MFC-independent string object with the same functionality as `CString`  
  
 Nearly all programs work with string data. MFC's `CString` class is often the best solution for flexible string handling. Starting with version 7.0, `CString` can be used in MFC or MFC-independent programs. Both the run-time library and `CString` support strings containing multibyte (wide) characters, as in Unicode or MBCS programming.  
  
 This article describes the general-purpose services that the class library provides related to string manipulation. Topics covered in this article include:  
  
-   [Unicode and MBCS Provide portability](#_core_unicode_and_mbcs_provide_portability)  
  
-   [CStrings and const char Pointers](#_core_cstrings_and_const_char_pointers)  
  
-   [CString Reference Counting](#_core_cstring_reference_counting)  
  
 The [CString](../vs140/cstringt-class.md) class provides support for manipulating strings. It is intended to replace and extend the functionality normally provided by the C run-time library string package. The `CString` class supplies member functions and operators for simplified string handling, similar to those found in Basic. The class also provides constructors and operators for constructing, assigning, and comparing **CStrings** and standard C++ string data types. Because `CString` is not derived from `CObject`, you can use `CString` objects independently of most of the Microsoft Foundation Class Library (MFC).  
  
 `CString` objects follow "value semantics." A `CString` object represents a unique value. Think of a `CString` as an actual string, not as a pointer to a string.  
  
 A `CString` object represents a sequence of a variable number of characters. `CString` objects can be thought of as arrays of characters.  
  
##  <a name="_core_unicode_and_mbcs_provide_portability"></a> Unicode and MBCS Provide Portability  
 With MFC version 3.0 and later, MFC, including `CString`, is enabled for both Unicode and multibyte character sets (MBCS). This support makes it easier for you to write portable applications that you can build for either Unicode or ANSI characters. To enable this portability, each character in a `CString` object is of type **TCHAR**, which is defined as `wchar_t` if you define the symbol **_UNICODE** when you build your application, or as `char` if not. A `wchar_t` character is 16 bits wide. MBCS is enabled if you build with the symbol **_MBCS** defined. MFC itself is built with either the **_MBCS** symbol (for the NAFX libraries) or the **_UNICODE** symbol (for the UAFX libraries) defined.  
  
> [!NOTE]
>  The `CString` examples in this and the accompanying articles on strings show literal strings properly formatted for Unicode portability, using the **_T** macro, which translates the literal string to the form:  
  
 `L"literal string"`  
  
> [!NOTE]
>  which the compiler treats as a Unicode string. For example, the following code:  
  
 [!code[NVC_ATLMFC_Utilities#187](../vs140/codesnippet/CPP/string-data-management_1.cpp)]  
  
> [!NOTE]
>  is translated as a Unicode string if **_UNICODE** is defined or as an ANSI string if not. For more information, see the article [Unicode and Multibyte Character Set (MBCS) Support](../vs140/unicode-and-multibyte-character-set--mbcs--support.md).  
  
 A `CString` object can store up to **INT_MAX** (2,147,483,647) characters. The **TCHAR** data type is used to get or set individual characters inside a `CString` object. Unlike character arrays, the `CString` class has a built-in memory allocation capability. This allows `CString` objects to automatically grow as needed (that is, you do not have to worry about growing a `CString` object to fit longer strings).  
  
##  <a name="_core_cstrings_and_const_char_pointers"></a> CStrings and const char Pointers  
 A `CString` object also can act like a literal C-style string (an `PCXSTR`, which is the same as **const char\*** if not under Unicode). The [CSimpleStringT::operator PCXSTR](../vs140/csimplestringt--operator-pcxstr.md) conversion operator allows `CString` objects to be freely substituted for character pointers in function calls. The **CString( LPCWSTR** `pszSrc` **)** constructor allows character pointers to be substituted for `CString` objects.  
  
 No attempt is made to fold `CString` objects. If you make two `CString` objects containing `Chicago`, for example, the characters in `Chicago` are stored in two places. (This may not be true of future versions of MFC, so you should not depend on it.)  
  
> [!NOTE]
>  Use the [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md) and [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md) member functions when you need to directly access a `CString` as a nonconstant pointer to a character.  
  
> [!NOTE]
>  Use the [CStringT::AllocSysString](../vs140/cstringt--allocsysstring.md) and [CStringT::SetSysString](../vs140/cstringt--setsysstring.md) member functions to allocate and set `BSTR` objects used in Automation (formerly known as OLE Automation).  
  
> [!NOTE]
>  Where possible, allocate `CString` objects on the frame rather than on the heap. This saves memory and simplifies parameter passing.  
  
 The `CString` class is not implemented as a Microsoft Foundation Class Library collection class, though `CString` objects can certainly be stored as elements in collections.  
  
##  <a name="_core_cstring_reference_counting"></a> CString Reference Counting  
 As of MFC version 4.0, when [CString](../vs140/cstringt-class.md) objects are copied, MFC increments a reference count rather than copying the data. This makes passing parameters by value and returning `CString` objects by value more efficient. These operations cause the copy constructor to be called, sometimes more than once. Incrementing a reference count reduces that overhead for these common operations and makes using `CString` a more attractive option.  
  
 As each copy is destroyed, the reference count in the original object is decremented. The original `CString` object is not destroyed until its reference count is reduced to zero.  
  
 You can use the `CString` member functions [CSimpleStringT::LockBuffer](../vs140/csimplestringt--lockbuffer.md) and [CSimpleStringT::UnlockBuffer](../vs140/csimplestringt--unlockbuffer.md) to disable or enable reference counting.  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)