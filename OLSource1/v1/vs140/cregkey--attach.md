---
title: "CRegKey::Attach"
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
  - "CRegKey.Attach"
  - "CRegKey::Attach"
  - "ATL::CRegKey::Attach"
  - "ATL.CRegKey.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 02246d9d-4a2a-4542-93bc-7a9d44800013
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::Attach
Call this method to attach an HKEY to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object by setting the [m_hKey](../vs140/cregkey--m_hkey.md) member handle to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The handle of a registry key.  
  
## Remarks  
 **Attach** will assert if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is non-NULL.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::Detach](../vs140/cregkey--detach.md)