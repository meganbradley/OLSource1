---
title: "CComVariant::SetByRef"
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
  - "ATL::CComVariant::SetByRef"
  - "ATL.CComVariant.SetByRef"
  - "CComVariant::SetByRef"
  - "SetByRef"
  - "CComVariant.SetByRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetByRef method"
ms.assetid: c246113b-9918-45be-b669-4f11764cae4d
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::SetByRef
Initializes the `CComVariant` object and sets the **vt** member to **VT_BYREF**.  
  
## Syntax  
  
```  
  
      template< typename   
      T  
       >  
void SetByRef(  
   T* pT   
) throw();  
```  
  
#### Parameters  
 `T`  
 The type of **VARIANT**, for example, `BSTR`, `int`, or `char`.  
  
 *pT*  
 The pointer used to initialize the `CComVariant` object.  
  
## Remarks  
 `SetByRef` is a function template that initializes the `CComVariant` object to the pointer *pT* and sets the **vt** member to **VT_BYREF**. For example:  
  
 [!code[NVC_ATL_Utilities#76](../vs140/codesnippet/CPP/ccomvariant--setbyref_1.cpp)]  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)