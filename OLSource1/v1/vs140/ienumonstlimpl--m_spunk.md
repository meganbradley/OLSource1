---
title: "IEnumOnSTLImpl::m_spUnk"
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
  - "ATL.IEnumOnSTLImpl.m_spUnk"
  - "IEnumOnSTLImpl.m_spUnk"
  - "IEnumOnSTLImpl::m_spUnk"
  - "m_spUnk"
  - "ATL::IEnumOnSTLImpl::m_spUnk"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_spUnk"
ms.assetid: 680fe80b-1b06-4cb0-8b99-08525486082a
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl::m_spUnk
The **IUnknown** pointer of the object supplying the collection.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This smart pointer maintains a reference on the object passed to [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md), ensuring that it remains alive during the lifetime of the enumerator.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)   
 [IEnumOnSTLImpl::Init](../vs140/ienumonstlimpl--init.md)