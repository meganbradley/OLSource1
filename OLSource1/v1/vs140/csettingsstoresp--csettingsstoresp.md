---
title: "CSettingsStoreSP::CSettingsStoreSP"
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
  - "CSettingsStoreSP.CSettingsStoreSP"
  - "CSettingsStoreSP::CSettingsStoreSP"
  - "CSettingsStoreSP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CSettingsStoreSP class, constructor"
ms.assetid: 610e4775-2db3-4da7-ad0a-e4055856651e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CSettingsStoreSP::CSettingsStoreSP
Constructs a [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md) object.  
  
## Syntax  
  
```  
CSettingsStoreSP::CSettingsStoreSP(  
   DWORD dwUserData = 0  
);  
```  
  
#### Parameters  
 [in] `dwUserData`  
 User-defined data that the `CSettingsStoreSP` object stores.  
  
## Remarks  
 The `CSettingsStoreSP` object stores the data from `dwUserData` in the protected member variable `m_dwUserData`.  
  
## Requirements  
 **Header:** afxsettingsstore.h  
  
## See Also  
 [CSettingsStoreSP Class](../vs140/csettingsstoresp-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)