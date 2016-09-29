---
title: "Compiler COM Support Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_raise_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "cl.exe compiler, COM support"
  - "COM, compiler support"
ms.assetid: 6d800d9b-b902-4033-9639-740a30b06f88
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler COM Support Classes
**Microsoft Specific**  
  
 Standard classes are used to support some of the COM types. The classes are defined in comdef.h and the header files generated from the type library.  
  
|Class|Purpose|  
|-----------|-------------|  
|[_bstr_t](../vs140/_bstr_t-class.md)|Wraps the `BSTR` type to provide useful operators and methods.|  
|[_com_error](../vs140/_com_error-class.md)|Defines the error object thrown by [_com_raise_error](../vs140/_com_raise_error.md) in most failures.|  
|[_com_ptr_t](../vs140/_com_ptr_t-class.md)|Encapsulates COM interface pointers, and automates the required calls to `AddRef`, **Release**, and `QueryInterface`.|  
|[_variant_t](../vs140/_variant_t-class.md)|Wraps the **VARIANT** type to provide useful operators and methods.|  
  
## END Microsoft Specific  
  
## See Also  
 [Compiler COM Support](../vs140/compiler-com-support.md)   
 [Compiler COM Global Functions](../vs140/compiler-com-global-functions.md)   
 [C++ Language Reference](../vs140/c---language-reference.md)