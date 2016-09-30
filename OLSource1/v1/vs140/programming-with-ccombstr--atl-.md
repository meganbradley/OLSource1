---
title: "Programming with CComBSTR (ATL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComBSTR class, programming with"
  - "Unicode, using CComBSTR [ATL]"
ms.assetid: d3bd0851-d132-4be9-9c4c-6ccba17acb2b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Programming with CComBSTR (ATL)
The ATL class [CComBSTR](../vs140/ccombstr-class.md) provides a wrapper around the `BSTR` data type. While `CComBSTR` is a useful tool, there are several situations that require caution.  
  
-   [Conversion Issues](#programmingwithccombstr_conversionissues)  
  
-   [Scope Issues](#programmingwithccombstr_scopeissues)  
  
-   [Explicitly Freeing the CComBSTR Object](#programmingwithccombstr_explicitlyfreeing)  
  
-   [Using CComBSTR Objects in Loops](#programmingwithccombstr_usingloops)  
  
-   [Memory Leak Issues](#programmingwithccombstr_memoryleaks)  
  
##  \<a name="programmingwithccombstr_conversionissues"></a> Conversion Issues  
 Although several `CComBSTR` methods will automatically convert an ANSI string argument into Unicode, the methods will always return Unicode format strings. To convert the output string back to ANSI, use an ATL conversion class. For more information on the ATL conversion classes, see [ATL and MFC String Conversion Macros](../vs140/atl-and-mfc-string-conversion-macros.md).  
  
### Example  
 [!code[NVC_ATL_Utilities#114](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_1.cpp)]  
  
 If you are using a string literal to modify a `CComBSTR` object, use wide character strings. This will reduce unnecessary conversions.  
  
### Example  
 [!code[NVC_ATL_Utilities#115](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_2.cpp)]  
  
##  \<a name="programmingwithccombstr_scopeissues"></a> Scope Issues  
 As with any well-behaved class, `CComBSTR` will free its resources when it goes out of scope. If a function returns a pointer to the `CComBSTR` string, this can cause problems, as the pointer will reference memory that has already been freed. In these cases, use the **Copy** method, as shown below.  
  
### Example  
 [!code[NVC_ATL_Utilities#116](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_3.cpp)]  
  
##  \<a name="programmingwithccombstr_explicitlyfreeing"></a> Explicitly Freeing the CComBSTR Object  
 It is possible to explicitly free the string contained in the `CComBSTR` object before the object goes out scope. If the string is freed, the `CComBSTR` object is invalid.  
  
### Example  
 [!code[NVC_ATL_Utilities#117](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_4.cpp)]  
  
##  \<a name="programmingwithccombstr_usingloops"></a> Using CComBSTR Objects in Loops  
 As the `CComBSTR` class allocates a buffer to perform certain operations, such as the `+=` operator or **Append** method, it is not recommended that you perform string manipulation inside a tight loop. In these situations, `CStringT` provides better performance.  
  
### Example  
 [!code[NVC_ATL_Utilities#118](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_5.cpp)]  
  
##  \<a name="programmingwithccombstr_memoryleaks"></a> Memory Leak Issues  
 Passing the address of an initialized `CComBSTR` to a function as an **[out]** parameter causes a memory leak.  
  
 In the example below, the string allocated to hold the string `"Initialized"` is leaked when the function `MyGoodFunction` replaces the string.  
  
 [!code[NVC_ATL_Utilities#119](../vs140/codesnippet/CPP/programming-with-ccombstr--atl-_6.cpp)]  
  
 To avoid the leak, call the **Empty** method on existing `CComBSTR` objects before passing the address as an **[out]** parameter.  
  
 Note that the same code would not cause a leak if the function's parameter was **[in, out]**.  
  
## See Also  
 [Concepts](../vs140/active-template-library--atl--concepts.md)   
 [CStringT Class](../vs140/cstringt-class.md)   
 [wstring](../vs140/wstring.md)   
 [String Conversion Macros](../vs140/string-conversion-macros.md)