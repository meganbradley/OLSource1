---
title: "CRegKey::CRegKey"
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
  - "ATL.CRegKey.CRegKey"
  - "CRegKey::CRegKey"
  - "ATL::CRegKey::CRegKey"
  - "CRegKey.CRegKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CRegKey class, constructor"
  - "CRegKey constructor"
ms.assetid: 86453ec1-f183-48a2-b482-c52718f928a3
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRegKey::CRegKey
The constructor.  
  
## Syntax  
  
```  
  
      CRegKey( ) throw( );   
CRegKey(  
   CRegKey& key   
) throw( );  
explicit CRegKey(  
   HKEY hKey   
) throw( );  
CRegKey(  
   CAtlTransactionManager* pTM  
) throw( );  
```  
  
#### Parameters  
 `key`  
 A reference to a `CRegKey` object.  
  
 `hKey`  
 A handle to a registry key.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 Creates a new `CRegKey` object. The object can be created from an existing `CRegKey` object, or from a handle to a registry key.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CRegKey Class](../vs140/cregkey-class.md)