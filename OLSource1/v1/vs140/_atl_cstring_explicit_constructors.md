---
title: "_ATL_CSTRING_EXPLICIT_CONSTRUCTORS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL._ATL_CSTRING_EXPLICIT_CONSTRUCTORS"
  - "ATL::_ATL_CSTRING_EXPLICIT_CONSTRUCTORS"
  - "_ATL_CSTRING_EXPLICIT_CONSTRUCTORS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_CSTRING_EXPLICIT_CONSTRUCTORS macro"
  - "_ATL_CSTRING_EXPLICIT_CONSTRUCTORS macro"
ms.assetid: 18c344b4-81ea-4977-8e25-e35467286dee
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_CSTRING_EXPLICIT_CONSTRUCTORS
Makes certain <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> constructors explicit, preventing any unintentional conversions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 When this is defined, all CString constructors that take a single parameter are compiled with the explicit keyword, which prevents implicit conversions of input arguments. This means for example, that when _UNICODE is defined, if you attempt use a char* string as a CString constructor argument, a compiler error will result. Use this macro in situations where you need to prevent implicit conversions between narrow and wide string types.  
  
 By using the _T macro on all constructor string arguments, you can define _ATL_CSTRING_EXPLICIT_CONSTRUCTORS and avoid compile errors regardless of whether _UNICODE is defined.  
  
## See Also  
 [Compiler Options Macros](../vs140/compiler-options-macros.md)   
 [CStringT Class](../vs140/cstringt-class.md)