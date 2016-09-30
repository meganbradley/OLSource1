---
title: "Using CString"
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
  - "CString objects, C++ string manipulation"
  - "CString objects, reference counting"
  - "CString class (Visual C++)"
ms.assetid: ed018aaf-8b10-46f9-828c-f9c092dc7609
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using CString
The topics in this section describe how to program with <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For reference documentation about the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class, see the documentation for [CStringT](../vs140/cstringt-class.md).  
  
 To use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, include the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> header.  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> classes are specializations of a class template called [CStringT](../vs140/cstringt-class.md) based on the type of character data they support.  
  
 A <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object contains the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> type and supports Unicode strings. A <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object contains the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> type, and supports single-byte and multi-byte (MBCS) strings. A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object supports either the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> type or the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> type, depending on whether the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> symbol or the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> symbol is defined at compile time.  
  
 A <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object keeps character data in a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> accepts <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>-terminated C-style strings, but does not retain the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> character in the stored character data. Instead, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> tracks string length. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> does provide a null terminator when it exports a C-style string. You can insert a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, but it may produce unexpected results.  
  
 The following set of string classes can be used without linking an MFC library, with or without CRT support: <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> is used in native projects. For managed-code (C++/CLI) projects, use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 To add more capabilities than <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> currently offer, you should create a subclass of <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> that contains the additional features.  
  
 The following code shows how to create a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and print it to standard output:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## In This Section  
 [Basic CString Operations](../vs140/basic-cstring-operations.md)  
 Describes basic <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> operations, including creating objects from C literal strings, accessing individual characters in a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, concatenating two objects, and comparing <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> objects.  
  
 [String Data Management](../vs140/string-data-management.md)  
 Discusses using Unicode and MBCS with <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
 [CString Semantics](../vs140/cstring-semantics.md)  
 Explains how <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> objects are used.  
  
 [CString Operations Relating to C-Style Strings](../vs140/cstring-operations-relating-to-c-style-strings.md)  
 Describes manipulating the contents of a <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> object like a C-style null-terminated string.  
  
 [Allocating and Releasing Memory for a BSTR](../vs140/allocating-and-releasing-memory-for-a-bstr.md)  
 Discusses using memory for a <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> and COM objects.  
  
 [CString Exception Cleanup](../vs140/cstring-exception-cleanup.md)  
 Explains that explicit cleanup in MFC 3.0 and later is no longer necessary.  
  
 [CString Argument Passing](../vs140/cstring-argument-passing.md)  
 Explains how to pass CString objects to functions and how to return <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> objects from functions.  
  
 [Unicode and Multibyte Character Set (MBCS) Support](../vs140/unicode-and-multibyte-character-set--mbcs--support.md)  
 Discusses how MFC is enabled for Unicode and MBCS support.  
  
## Reference  
 [CStringT](../vs140/cstringt-class.md)  
 Provides reference information about the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> class.  
  
 [CSimpleStringT Class](../vs140/csimplestringt-class.md)  
 Provides reference information about the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class.  
  
## Related Sections  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)  
 Contains links to topics that describe several ways to manage string data.  
  
 [Class Template Instantiation](../vs140/class-template-instantiation.md)  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> based on <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, an instance of a specialization of a class template.  
  
 [](../vs140/strings--atl-mfc-.md "Strings (ATL-MFC)")