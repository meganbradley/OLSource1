---
title: "CRegKey::operator ="
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
  - "CRegKey.operator="
  - "CRegKey::operator="
  - "ATL.CRegKey.operator="
  - "ATL::CRegKey::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator=, registry key"
  - "operator =, registry key"
ms.assetid: bb5dcbe3-3370-4b30-aafb-c46bc2d4ef3d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::operator =
Assignment operator.  
  
## Syntax  
  
```  
  
      CRegKey& operator =(  
   CRegKey& key   
) throw( );  
```  
  
#### Parameters  
 `key`  
 The key to copy.  
  
## Return Value  
 Returns a reference to the new key.  
  
## Remarks  
 This operator detaches `key` from its current object and assigns it to the `CRegKey` object instead.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)