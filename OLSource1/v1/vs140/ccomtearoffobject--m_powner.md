---
title: "CComTearOffObject::m_pOwner"
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
  - "CComTearOffObject::m_pOwner"
  - "m_pOwner"
  - "CComTearOffObject.m_pOwner"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_pOwner"
ms.assetid: ef2e3985-d279-4394-8d73-7927f8a244d8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComTearOffObject::m_pOwner
A pointer to a [CComObject](../vs140/ccomobject-class.md) object derived from *Owner*.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *Owner*  
 [in] The class for which a tear-off is being implemented.  
  
## Remarks  
 The pointer is initialized to **NULL** during construction.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComTearOffObject Class](../vs140/ccomtearoffobject-class.md)   
 [CComTearOffObject::CComTearOffObjectBase](../vs140/ccomtearoffobject--ccomtearoffobjectbase.md)