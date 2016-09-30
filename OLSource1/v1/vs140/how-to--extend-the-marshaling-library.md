---
title: "How to: Extend the Marshaling Library"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Marshaling Library, extending"
ms.assetid: 4c4a56d7-1d44-4118-b85f-f9686515e6e9
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Extend the Marshaling Library
This topic explains how to extend the marshaling library to provide more conversions between data types. Users can extend the marshaling library for any data conversions not currently supported by the library.  
  
 You can extend the marshaling library in one of two ways - with or without a [marshal_context Class](../vs140/marshal_context-class.md). Review the [Overview of Marshaling in C++](../vs140/overview-of-marshaling-in-c--.md) topic to determine whether a new conversion requires a context.  
  
 In both cases, you first create a file for new marshaling conversions. You do so to preserve the integrity of the standard marshaling library files. If you want to port a project to another computer or to another programmer, you must copy the new marshaling file together with the rest of the project. In this manner, the user receiving the project will be guaranteed to receive the new conversions and will not have to modify any library files.  
  
### To Extend the Marshaling Library with a Conversion that does not Require a Context  
  
1.  Create a file to store the new marshaling functions, for example, MyMarshal.h.  
  
2.  Include one or more of the marshal library files:  
  
    -   marshal.h for base types.  
  
    -   marshal_windows.h for windows data types.  
  
    -   marshal_cppstd.h for STL data types.  
  
    -   marshal_atl.h for ATL data types.  
  
3.  Use the code at the end of these steps to write the conversion function. In this code, TO is the type to convert to, FROM is the type to convert from, and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is the parameter to be converted.  
  
4.  Replace the comment about conversion logic with code to convert the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter into an object of TO type and return the converted object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To Extend the Marshaling Library with a Conversion that Requires a Context  
  
1.  Create a file to store the new marshaling functions, for example, MyMarshal.h  
  
2.  Include one or more of the marshal library files:  
  
    -   marshal.h for base types.  
  
    -   marshal_windows.h for windows data types.  
  
    -   marshal_cppstd.h for STL data types.  
  
    -   marshal_atl.h for ATL data types.  
  
3.  Use the code at the end of these steps to write the conversion function. In this code, TO is the type to convert to, FROM is the type to convert from, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is a pointer in which to store the result, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is the parameter to be converted.  
  
4.  Replace the comment about initializing with code to initialize the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to the appropriate empty value. For example, if it is a pointer, set it to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
5.  Replace the comment about conversion logic with code to convert the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter into an object of *TO* type. This converted object will be stored in <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
6.  Replace the comment about setting <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with code to set <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> to your converted object.  
  
7.  Replace the comment about cleaning up native resources with code to free any memory allocated by <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> allocated memory by using <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, use <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to free the memory.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example extends the marshaling library with a conversion that does not require a context. In this example, the code converts the employee information from a native data type to a managed data type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the previous example, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> function returns a handle to the converted data. This was done in order to prevent creating an additional copy of the data. Returning the variable directly would have an unnecessary performance cost associated with it.  
  
 **Managed name: Jeff Smith**  
**Managed address: 123 Main Street**  
**Managed zip code: 98111**   
## Example  
 The following example converts the employee information from a managed data type to a native data type. This conversion requires a marshaling context.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Native name: Jeff Smith**  
**Native address: 123 Main Street**  
**Native zip code: 98111**   
## See Also  
 [Overview of Marshaling in C++](../vs140/overview-of-marshaling-in-c--.md)