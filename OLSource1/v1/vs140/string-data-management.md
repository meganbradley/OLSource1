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
  
-   Class [CStringT Class](../vs140/cstringt-class.md), which provides an MFC-independent string object with the same functionality as <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
  
 Nearly all programs work with string data. MFC's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class is often the best solution for flexible string handling. Starting with version 7.0, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> can be used in MFC or MFC-independent programs. Both the run-time library and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> support strings containing multibyte (wide) characters, as in Unicode or MBCS programming.  
  
 This article describes the general-purpose services that the class library provides related to string manipulation. Topics covered in this article include:  
  
-   [Unicode and MBCS Provide portability](#_core_unicode_and_mbcs_provide_portability)  
  
-   [CStrings and const char Pointers](#_core_cstrings_and_const_char_pointers)  
  
-   [CString Reference Counting](#_core_cstring_reference_counting)  
  
 The [CString](../vs140/cstringt-class.md) class provides support for manipulating strings. It is intended to replace and extend the functionality normally provided by the C run-time library string package. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class supplies member functions and operators for simplified string handling, similar to those found in Basic. The class also provides constructors and operators for constructing, assigning, and comparing **CStrings** and standard C++ string data types. Because <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is not derived from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, you can use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> objects independently of most of the Microsoft Foundation Class Library (MFC).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects follow "value semantics." A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object represents a unique value. Think of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> as an actual string, not as a pointer to a string.  
  
 A <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object represents a sequence of a variable number of characters. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> objects can be thought of as arrays of characters.  
  
##  \<a name="_core_unicode_and_mbcs_provide_portability">\</a> Unicode and MBCS Provide Portability  
 With MFC version 3.0 and later, MFC, including <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, is enabled for both Unicode and multibyte character sets (MBCS). This support makes it easier for you to write portable applications that you can build for either Unicode or ANSI characters. To enable this portability, each character in a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object is of type **TCHAR**, which is defined as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if you define the symbol **_UNICODE** when you build your application, or as <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> if not. A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> character is 16 bits wide. MBCS is enabled if you build with the symbol **_MBCS** defined. MFC itself is built with either the **_MBCS** symbol (for the NAFX libraries) or the **_UNICODE** symbol (for the UAFX libraries) defined.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> examples in this and the accompanying articles on strings show literal strings properly formatted for Unicode portability, using the **_T** macro, which translates the literal string to the form:  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
> [!NOTE]
>  which the compiler treats as a Unicode string. For example, the following code:  
  
 [!code[NVC_ATLMFC_Utilities#187](../vs140/codesnippet/CPP/string-data-management_1.cpp)]  
  
> [!NOTE]
>  is translated as a Unicode string if **_UNICODE** is defined or as an ANSI string if not. For more information, see the article [Unicode and Multibyte Character Set (MBCS) Support](../vs140/unicode-and-multibyte-character-set--mbcs--support.md).  
  
 A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object can store up to **INT_MAX** (2,147,483,647) characters. The **TCHAR** data type is used to get or set individual characters inside a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object. Unlike character arrays, the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> class has a built-in memory allocation capability. This allows <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> objects to automatically grow as needed (that is, you do not have to worry about growing a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object to fit longer strings).  
  
##  \<a name="_core_cstrings_and_const_char_pointers">\</a> CStrings and const char Pointers  
 A <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object also can act like a literal C-style string (an <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, which is the same as **const char\*** if not under Unicode). The [CSimpleStringT::operator PCXSTR](../vs140/csimplestringt--operator-pcxstr.md) conversion operator allows <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects to be freely substituted for character pointers in function calls. The **CString( LPCWSTR** <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> **)** constructor allows character pointers to be substituted for <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> objects.  
  
 No attempt is made to fold <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> objects. If you make two <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> objects containing <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, for example, the characters in <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> are stored in two places. (This may not be true of future versions of MFC, so you should not depend on it.)  
  
> [!NOTE]
>  Use the [CSimpleStringT::GetBuffer](../vs140/csimplestringt--getbuffer.md) and [CSimpleStringT::ReleaseBuffer](../vs140/csimplestringt--releasebuffer.md) member functions when you need to directly access a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> as a nonconstant pointer to a character.  
  
> [!NOTE]
>  Use the [CStringT::AllocSysString](../vs140/cstringt--allocsysstring.md) and [CStringT::SetSysString](../vs140/cstringt--setsysstring.md) member functions to allocate and set <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> objects used in Automation (formerly known as OLE Automation).  
  
> [!NOTE]
>  Where possible, allocate <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> objects on the frame rather than on the heap. This saves memory and simplifies parameter passing.  
  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> class is not implemented as a Microsoft Foundation Class Library collection class, though <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects can certainly be stored as elements in collections.  
  
##  \<a name="_core_cstring_reference_counting">\</a> CString Reference Counting  
 As of MFC version 4.0, when [CString](../vs140/cstringt-class.md) objects are copied, MFC increments a reference count rather than copying the data. This makes passing parameters by value and returning <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> objects by value more efficient. These operations cause the copy constructor to be called, sometimes more than once. Incrementing a reference count reduces that overhead for these common operations and makes using <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> a more attractive option.  
  
 As each copy is destroyed, the reference count in the original object is decremented. The original <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object is not destroyed until its reference count is reduced to zero.  
  
 You can use the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> member functions [CSimpleStringT::LockBuffer](../vs140/csimplestringt--lockbuffer.md) and [CSimpleStringT::UnlockBuffer](../vs140/csimplestringt--unlockbuffer.md) to disable or enable reference counting.  
  
## See Also  
 [General MFC Topics](../vs140/general-mfc-topics.md)