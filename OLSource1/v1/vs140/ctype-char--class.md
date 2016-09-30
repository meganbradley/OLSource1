---
title: "ctype&lt;char&gt; Class"
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
  - "ctype<char>"
  - "locale/std::ctype<char>"
  - "std::ctype<char>"
  - "std.ctype<char>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ctype<char> class"
ms.assetid: ee30acb4-a743-405e-b3d4-13602092da84
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ctype&lt;char&gt; Class
The class is an explicit specialization of template class **ctype\<CharType**> to type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, describing an object that can serve as a locale facet to characterize various properties of a character of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The explicit specialization differs from the template class in several ways:  
  
-   An object of class ctype< <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>> stores a pointer to the first element of a ctype mask table, an array of UCHAR_MAX + 1 elements of type **ctype_base::mask**. It also stores a Boolean object that indicates whether the array should be deleted (using <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) when the ctype\< **Elem**> object is destroyed.  
  
-   Its sole public constructor lets you specify **tab**, the ctype mask table, and **del**, the Boolean object that is true if the array should be deleted when the ctype< <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>> object is destroyed, as well as the reference-count parameter refs.  
  
-   The protected member function **table** returns the stored ctype mask table.  
  
-   The static member object **table_size** specifies the minimum number of elements in a ctype mask table.  
  
-   The protected static member function **classic_table**( returns the ctype mask table appropriate to the "C" locale.  
  
-   There are no protected virtual member functions [do_is](../vs140/ctype-class.md#ctype__do_is), [do_scan_is](../vs140/ctype-class.md#ctype__do_scan_is), or [do_scan_not](../vs140/ctype-class.md#ctype__do_scan_not). The corresponding public member functions perform the equivalent operations themselves.  
  
 The member functions [do_narrow](../vs140/ctype-class.md#ctype__do_narrow) and [do_widen](../vs140/ctype-class.md#ctype__do_widen) copy elements unaltered.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [facet Class](7dd6d271-472d-4750-8fb5-ea8f55fbef62locale_class)   
 [ctype_base Class](../vs140/ctype_base-class.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)