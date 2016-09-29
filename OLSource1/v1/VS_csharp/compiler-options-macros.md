---
title: "Compiler Options Macros"
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
  - "compiler options, macros"
ms.assetid: a869adc6-b3de-4299-b040-9ae20b45f82c
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Options Macros
These macros control specific compiler features.  
  
|||  
|-|-|  
|[_ATL_ALL_WARNINGS](../VS_csharp/_atl_all_warnings.md)|A symbol which enables errors in projects converted from previous versions of ATL.|  
|[_ATL_APARTMENT_THREADED](../VS_csharp/_atl_apartment_threaded.md)|Define if one or more of your objects use apartment threading.|  
|[_ATL_CSTRING_EXPLICIT_CONSTRUCTORS](../VS_csharp/_atl_cstring_explicit_constructors.md)|Makes certain `CString` constructors explicit, preventing any unintentional conversions.|  
|[_ATL_ENABLE_PTM_WARNING](../VS_csharp/_atl_enable_ptm_warning.md)|Define this macro in order to use C++ standard compliant syntax, which generates the C4867 compiler error when a non standard syntax is used to initialize a pointer to a member function.|  
|[_ATL_FREE_THREADED](../VS_csharp/_atl_free_threaded.md)|Define if one or more of your objects use free or neutral threading.|  
|[_ATL_MULTI_THREADED](../VS_csharp/_atl_multi_threaded.md)|A symbol that indicates the project will have objects that are marked as Both, Free or Neutral. The macro [_ATL_FREE_THREADED](../VS_csharp/_atl_free_threaded.md) should be used instead.|  
|[_ATL_NO_AUTOMATIC_NAMESPACE](../VS_csharp/_atl_no_automatic_namespace.md)|A symbol which prevents the default use of namespace as ATL.|  
|[_ATL_NO_COM_SUPPORT](../VS_csharp/_atl_no_com_support.md)|A symbol which prevents COM-related code from being compiled with your project.|  
|[ATL_NO_VTABLE](../VS_csharp/atl_no_vtable.md)|A symbol that prevents the vtable pointer from being initialized in the class's constructor and destructor.|  
|[ATL_NOINLINE](../VS_csharp/atl_noinline.md)|A symbol that indicates a function should not be inlined.|  
|[_ATL_SINGLE_THREADED](../VS_csharp/_atl_single_threaded.md)|Define if all of your objects use the single threading model.|  
  
## See Also  
 [Macros](../VS_csharp/atl-macros.md)