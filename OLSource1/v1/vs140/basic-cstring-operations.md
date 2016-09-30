---
title: "Basic CString Operations"
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
  - "CString objects, basic operations"
  - "string literals, CString operations"
  - "literal strings, CString operations"
  - "CString objects"
  - "string comparison, CString operations"
  - "characters, accessing in CStrings"
ms.assetid: 41db66b2-9427-4bb3-845a-9b6869159a6c
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Basic CString Operations
This topic explains the following basic [CString](../vs140/cstringt-class.md) operations:  
  
-   [Creating CString objects from standard C literal strings](#_core_creating_cstring_objects_from_standard_c_literal_strings)  
  
-   [Accessing individual characters in a CString](#_core_accessing_individual_characters_in_a_cstring)  
  
-   [Concatenating two CString objects](#_core_concatenating_two_cstring_objects)  
  
-   [Comparing CString objects](#_core_comparing_cstring_objects)  
  
-   [Converting CString objects](#_core_converting_cstring_objects)  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is based on class template [CStringT](../vs140/cstringt-class.md). <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. More exactly, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> of an *explicit specialization* of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which is a common way to use a class template to define a class. Similarly defined classes are <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. For more information on explicit specialization, see [Class Template Instantiation](../vs140/class-template-instantiation.md).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> are defined in atlstr.h. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is defined in cstringt.h.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> each get a set of the methods and operators defined by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> for use with the string data they support. Some of the methods duplicate and, in some cases, surpass the string services of the C run-time libraries.  
  
 Note: <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a native class. For a string class that is for use in a C++/CLI managed project, use <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
##  \<a name="_core_creating_cstring_objects_from_standard_c_literal_strings">\</a> Creating CString Objects from Standard C Literal Strings  
 You can assign C-style literal strings to a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> just as you can assign one <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object to another.  
  
-   Assign the value of a C literal string to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
     [!code[NVC_ATLMFC_Utilities#183](../vs140/codesnippet/CPP/basic-cstring-operations_1.cpp)]  
  
-   Assign the value of one <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> to another <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
     [!code[NVC_ATLMFC_Utilities#184](../vs140/codesnippet/CPP/basic-cstring-operations_2.cpp)]  
  
     The contents of a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object are copied when one <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object is assigned to another. Therefore, the two strings do not share a reference to the actual characters that make up the string. For more information about how to use <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> objects as values, see [CString Semantics](../vs140/cstring-semantics.md).  
  
    > [!NOTE]
    >  To write your application so that it can be compiled for Unicode or for ANSI, code literal strings by using the _T macro. For more information, see [Unicode and Multibyte Character Set (MBCS) Support](../vs140/unicode-and-multibyte-character-set--mbcs--support.md).  
  
##  \<a name="_core_accessing_individual_characters_in_a_cstring">\</a> Accessing Individual Characters in a CString  
 You can access individual characters in a <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object by using the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> methods. You can also use the array element, or subscript, operator ( [ ] ) instead of <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to get individual characters. (This resembles accessing array elements by index, as in standard C-style strings.) Index values for <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> characters are zero-based.  
  
##  \<a name="_core_concatenating_two_cstring_objects">\</a> Concatenating Two CString Objects  
 To concatenate two <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> objects, use the concatenation operators (+ or +=), as follows.  
  
 [!code[NVC_ATLMFC_Utilities#185](../vs140/codesnippet/CPP/basic-cstring-operations_3.cpp)]  
  
 At least one argument to the concatenation operators (+ or +=) must be a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object, but you can use a constant character string (for example, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) or a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> (for example, 'x') for the other argument.  
  
##  \<a name="_core_comparing_cstring_objects">\</a> Comparing CString Objects  
 The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method and the == operator for <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> are equivalent. <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> are MBCS and Unicode aware; <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is also case-insensitive. The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is locale-sensitive and is often slower than <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> only where you must abide by the sorting rules as specified by the current locale.  
  
 The following table shows the available [CString](../vs140/cstringt-class.md) comparison functions and their equivalent Unicode/MBCS-portable functions in the C run-time library.  
  
|CString function|MBCS function|Unicode function|  
|----------------------|-------------------|----------------------|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|  
  
 The <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> class template defines the relational operators (<, \<=, >=, >, ==, and !=), which are available for use by <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. You can compare two <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> by using these operators, as shown in the following example.  
  
 [!code[NVC_ATLMFC_Utilities#186](../vs140/codesnippet/CPP/basic-cstring-operations_4.cpp)]  
  
##  \<a name="_core_converting_cstring_objects">\</a> Converting CString Objects  
 For information about converting CString objects to other string types, see [How to: Convert Between Various String Types](../vs140/how-to--convert-between-various-string-types.md).  
  
## Using CString with wcout  
 To use a CString with <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> you must explicitly cast the object to a <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> as shown in the following example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 Without the cast, <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> is treated as a <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> prints the address of the object. This behavior is caused by subtle interactions between template argument deduction and overload resolution which are in themselves correct and conformant with the C++ standard.  
  
## See Also  
 [Strings (ATL/MFC)](../vs140/strings--atl-mfc-.md)   
 [CStringT](../vs140/cstringt-class.md)   
 [Class Template Instantiation](../vs140/class-template-instantiation.md)   
 [Explicit Specialization of Class Templates](../vs140/explicit-specialization-of-class-templates.md)   
 [Partial Specialization of Class Templates](../vs140/template-specialization--c---.md)   
 [How to: Convert Between Various String Types](../vs140/how-to--convert-between-various-string-types.md)