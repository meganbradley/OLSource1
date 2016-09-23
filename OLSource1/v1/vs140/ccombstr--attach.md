---
title: "CComBSTR::Attach"
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
  - ATL::CComBSTR::Attach
  - CComBSTR::Attach
  - ATL.CComBSTR.Attach
  - CComBSTR.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 1ecb7183-5a01-428d-b8a1-c13af795ecf8
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComBSTR::Attach
Attaches a `BSTR` to the `CComBSTR` object by setting the [m_str](../vs140/ccombstr--m_str.md) member to *src*.  
  
## Syntax  
  
```  
  
      void Attach(  
   BSTR src   
) throw( );  
```  
  
#### Parameters  
 *src*  
 [in] The `BSTR` to attach to the object.  
  
## Remarks  
 Do not pass an ordinary wide-character string to this method. The compiler cannot catch the error and run time errors will occur.  
  
> [!NOTE]
>  This method will assert if `m_str` is non-**NULL**.  
  
## Example  
 [!code[NVC_ATL_Utilities#35](../vs140/codesnippet/CPP/ccombstr--attach_1.cpp)]
  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComBSTR Class](../vs140/ccombstr-class.md)   
 [CComBSTR::Detach](../vs140/ccombstr--detach.md)   
 [CComBSTR::operator =](../vs140/ccombstr--operator-=.md)