---
title: "CComBSTR::operator =="
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
  - "CComBSTR::operator=="
  - "ATL.CComBSTR.operator=="
  - "ATL::CComBSTR::operator=="
  - "CComBSTR.operator=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, bstr"
  - "operator==, bstr"
  - "== operator"
ms.assetid: 8466f293-9326-463f-a61f-97930c0d658e
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComBSTR::operator ==
Compares a `CComBSTR` with a string. `CComBSTR`s are compared textually in the context of the user's default locale.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   const CComBSTR& bstrSrc   
) const throw( );  
bool operator ==(  
   LPCOLESTR pszSrc   
) const;  
bool operator ==(  
   LPCSTR pszSrc   
) const;  
bool operator ==(  
   int nNull   
) const throw( );  
```  
  
#### Parameters  
 `bstrSrc`  
 [in] A `CComBSTR` object.  
  
 `pszSrc`  
 [in] A zero-terminated string.  
  
 `nNull`  
 [in] Must be **NULL**.  
  
## Return Value  
 Returns **true** if the item being compared is equal to the `CComBSTR` object; otherwise, returns **false**.  
  
## Remarks  
 The final comparison operator just compares the contained string against **NULL**.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)