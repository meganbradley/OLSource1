---
title: "CSettingsStore::CreateKey"
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
  - "CreateKey"
  - "CSettingsStore.CreateKey"
  - "CSettingsStore::CreateKey"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateKey method"
ms.assetid: 1a12c602-38be-4ea3-ab66-a6b18d674851
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStore::CreateKey
Opens a registry key or creates it if it does not exist.  
  
## Syntax  
  
```  
virtual BOOL CreateKey(  
   LPCTSTR pszPath   
);  
```  
  
#### Parameters  
 [in] `pszPath`  
 Specifies the name of a key to be created or opened.  
  
## Return Value  
 0 if successful; otherwise a nonzero value.  
  
## Remarks  
 `CreateKey` uses `m_hKey` as the root of registry inquiries. It searches for `pszPath` as a subkey of `m_hKey`. If the key does not exist, `CreateKey` creates it. Otherwise, it opens the key. `CreateKey` then sets `m_hKey` to the created or opened key.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStore Class](../vs140/csettingsstore-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)