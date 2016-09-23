---
title: "CComVariant::CopyTo"
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
  - ATL.CComVariant.CopyTo
  - CComVariant::CopyTo
  - CComVariant.CopyTo
  - ATL::CComVariant::CopyTo
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyTo method
ms.assetid: 94f26694-22c3-4d72-820f-7fe1ac8c77d5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComVariant::CopyTo
Copies the contents of the `CComVariant` object.  
  
## Syntax  
  
```  
  
      HRESULT CopyTo(  
   BSTR *pstrDest  
);  
```  
  
#### Parameters  
 *pstrDest*  
 Points to a `BSTR` that will receive a copy of the contents of the `CComVariant` object.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 The **CComVariant** object must be of type `VT_BSTR`.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)   
 [CComVariant::Copy](../vs140/ccomvariant--copy.md)