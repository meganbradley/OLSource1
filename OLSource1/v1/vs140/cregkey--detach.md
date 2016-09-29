---
title: "CRegKey::Detach"
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
  - "ATL::CRegKey::Detach"
  - "ATL.CRegKey.Detach"
  - "CRegKey.Detach"
  - "CRegKey::Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: f95bcef9-e5a8-4db4-a879-49777ea890a3
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::Detach
Call this method to detach the [m_hKey](../vs140/cregkey--m_hkey.md) member handle from the `CRegKey` object and set `m_hKey` to NULL.  
  
## Syntax  
  
```  
  
HKEY Detach( ) throw( );  
  
```  
  
## Return Value  
 The HKEY associated with the `CRegKey` object.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)   
 [CRegKey::Attach](../vs140/cregkey--attach.md)