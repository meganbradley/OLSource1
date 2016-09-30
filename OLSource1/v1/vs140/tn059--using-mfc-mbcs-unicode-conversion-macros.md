---
title: "TN059: Using MFC MBCS-Unicode Conversion Macros"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "TN059: Using MFC MBCS/Unicode Conversion Macros"
f1_keywords: 
  - "vc.mfc.mbcs"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFCANS32.DLL"
  - "Unicode [C++], conversion macros"
  - "Unicode [C++], OLE interfaces"
  - "conversion macros [C++]"
  - "converting Unicode"
  - "MBCS [C++], conversion macros"
  - "macros [C++], MBCS conversion macros"
  - "TN059"
ms.assetid: a2aab748-94d0-4e2f-8447-3bd07112a705
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN059: Using MFC MBCS-Unicode Conversion Macros
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 This note describes how to use the macros for MBCS/Unicode conversion, which are defined in AFXPRIV.H. These macros are most useful if your application deals directly with the OLE API or for some reason, often needs to convert between Unicode and MBCS.  
  
## Overview  
 In MFC 3.x, a special DLL was used (MFCANS32.DLL) to automatically convert between Unicode and MBCS when OLE interfaces were called. This DLL was an almost transparent layer that allowed OLE applications to be written as if the OLE APIs and interfaces were MBCS, even though they are always Unicode (except on the Macintosh). While this layer was convenient and allowed applications to be quickly ported from Win16 to Win32 (MFC, Microsoft Word, Microsoft Excel, and VBA, are just some of the Microsoft applications that used this technology), it had a sometimes significant performance hit. For this reason, MFC 4.x does not use this DLL and instead talks directly to the Unicode OLE interfaces. To do this, MFC needs to convert to Unicode to MBCS when making a call to an OLE interface, and often needs to convert to MBCS from Unicode when implementing an OLE interface. In order to handle this efficiently and easily, a number of macros were created to make this conversion easier.  
  
 One of the biggest hurdles of creating such a set of macros is memory allocation. Because the strings cannot be converted in place, new memory to hold the converted results must be allocated. This could have been done with code similar to the following:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This approach as a number of problems. The main problem is that it is a lot of code to write, test, and debug. Something that was a simple function call, is now much more complex. In addition, there is a significant runtime overhead in doing so. Memory has to be allocated on the heap and freed each time a conversion is done. Finally, the code above would need to have appropriate <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> added for Unicode and Macintosh builds (which don't require this conversion to take place).  
  
 The solution we came up with is to create some macros which 1) mask the difference between the various platforms, and 2) use an efficient memory allocation scheme, and 3) are easy to insert into the existing source code. Here is an example of one of the definitions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Using this macro instead of the code above and things are much simpler:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 There are extra calls where conversion is necessary, but using the macros is simple and effective.  
  
 The implementation of each macro uses the _alloca() function to allocate memory from the stack instead of the heap. Allocating memory from the stack is much faster than allocating memory on the heap, and the memory is automatically freed when the function is exited. In addition, the macros avoid calling **MultiByteToWideChar** (or **WideCharToMultiByte**) more than one time. This is done by allocating a little bit more memory than is necessary. We know that an MBC will convert into at most one **WCHAR** and that for each **WCHAR** we will have a maximum of two MBC bytes. By allocating a little more than necessary, but always enough to handle the conversion the second call second call to the conversion function is avoided. The call to the helper function **AfxA2Whelper** reduces the number of argument pushes that must be done in order to perform the conversion (this results in smaller code, than if it called **MultiByteToWideChar** directly).  
  
 In order to for the macros to have space to store the a temporary length, it is necessary to declare a local variable called _convert that does this in each function that uses the conversion macros. This is done by invoking the **USES_CONVERSION** macro as seen above in the example.  
  
 There are both generic conversion macros and OLE specific macros. These two different macro sets are discussed below. All of the macros reside in AFXPRIV.H.  
  
## Generic Conversion Macros  
 The generic conversion macros form the underlying mechanism. The macro example and implementation shown in the previous section, A2W, is one such "generic" macro. It is not related to OLE specifically. The set of generic macros is listed below:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Besides doing text conversions, there are also macros and helper functions for converting <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and OLE allocated strings. These macros are beyond the scope of this discussion – refer to AFXPRIV.H for more information on those macros.  
  
## OLE Conversion Macros  
 The OLE conversion macros are designed specifically for handling functions that expect **OLESTR** characters. If you examine the OLE headers, you will see many references to **LPCOLESTR** and **OLECHAR**. These types are used to refer to the type of characters used in OLE interfaces in a way that is not specific to the platform. **OLECHAR** maps to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> in Win16 and Macintosh platforms and **WCHAR** in Win32.  
  
 In order to keep the number of **#ifdef** directives in the MFC code to a minimum we have a similar macro for each conversion that where OLE strings are involved. The following macros are the most commonly used:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Again, there are similar macros for doing <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, and OLE allocated strings. Refer to AFXPRIV.H for more information.  
  
## Other Considerations  
 Do not use the macros in a tight loop. For example, you do not want to write the following kind of code:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The code above could result in allocating megabytes of memory on the stack depending on what the contents of the string <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is! It also takes time to convert the string for each iteration of the loop. Instead, move such constant conversions out of the loop:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If the string is not constant, then encapsulate the method call into a function. This will allow the conversion buffer to be freed each time. For example:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Never return the result of one of the macros, unless the return value implies making a copy of the data before the return. For example, this code is bad:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The code above could be fixed by changing the return value to something that copies the value:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The macros are easy to use and easy to insert into your code, but as you can tell from the caveats above, you need to be careful when using them.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)