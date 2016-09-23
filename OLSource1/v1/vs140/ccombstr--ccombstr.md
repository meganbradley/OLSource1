---
title: "CComBSTR::CComBSTR"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CComBSTR::CComBSTR
  - CComBSTR.CComBSTR
  - ATL.CComBSTR.CComBSTR
  - ATL::CComBSTR::CComBSTR
dev_langs: 
  - C++
helpviewer_keywords: 
  - CComBSTR class, constructor
  - CComBSTR constructor
ms.assetid: 738ade40-31f1-47fc-bae1-303437db310e
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComBSTR::CComBSTR
The constructor. The default constructor sets the [m_str](../vs140/ccombstr--m_str.md) member to **NULL**.  
  
## Syntax  
  
```  
  
      CComBSTR( ) throw( );   
CComBSTR(  
   const CComBSTR& src   
);  
CComBSTR(  
   REFGUID guid   
);  
CComBSTR(  
   int nSize   
);  
CComBSTR(  
   int nSize,  
   LPCOLESTR sz   
);  
CComBSTR(  
   int nSize,  
   LPCSTR sz   
);  
CComBSTR(  
   LPCOLESTR pSrc   
);  
CComBSTR(  
   LPCSTR pSrc   
);  
CComBSTR(  
   CComBSTR&& src   
);  
  
```  
  
#### Parameters  
 `nSize`  
 [in] The number of characters to copy from `sz` or the initial size in characters for the `CComBSTR`.  
  
 `sz`  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an `LPCSTR`.  
  
 `pSrc`  
 [in] A string to copy. The Unicode version specifies an **LPCOLESTR**; the ANSI version specifies an `LPCSTR`.  
  
 *src*  
 [in] A `CComBSTR` object.  
  
 `guid`  
 [in] A reference to a **GUID** structure.  
  
## Remarks  
 The copy constructor sets `m_str` to a copy of the `BSTR` member of *src*. The **REFGUID** constructor converts the **GUID** to a string using **StringFromGUID2** and stores the result.  
  
 The other constructors set `m_str` to a copy of the specified string. If you pass a value for `nSize`, then only `nSize` characters will be copied, followed by a terminating null character.  
  
 `CComBSTR` supports move semantics. You can use the move constructor (the constructor that takes an rvalue reference (`&&`) to create a new object that uses the same underlying data as the old object you pass in as an argument, without the overhead of copying the object.  
  
 The destructor frees the string pointed to by `m_str`.  
  
## Example  
 [!code[NVC_ATL_Utilities#37](../vs140/codesnippet/CPP/ccombstr--ccombstr_1.cpp)]
  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [ATL and MFC String Conversion Macros](assetId:///6ffb16b0-df9e-4011-a105-f756c3caf3ba)