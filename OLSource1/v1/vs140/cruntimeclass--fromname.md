---
title: "CRuntimeClass::FromName"
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
  - "CRuntimeClass::FromName"
  - "CRuntimeClass.FromName"
  - "FromName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FromName method"
ms.assetid: 513566ec-9d7e-43b5-a46c-2821af3d76c5
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRuntimeClass::FromName
Call this function to retrieve the `CRuntimeClass` structure associated with the familiar name.  
  
## Syntax  
  
```  
  
      static CRuntimeClass* PASCAL FromName(  
   LPCSTR lpszClassName   
);  
static CRuntimeClass* PASCAL FromName(  
   LPCWSTR lpszClassName   
);  
```  
  
#### Parameters  
 `lpszClassName`  
 The familiar name of a class derived from `CObject`.  
  
## Return Value  
 A pointer to a `CRuntimeClass` object, corresponding to the name as passed in `lpszClassName`. The function returns **NULL** if no matching class name was found.  
  
## Example  
 [!code[NVC_MFCCObjectSample#17](../vs140/codesnippet/CPP/cruntimeclass--fromname_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CRuntimeClass Structure](../vs140/cruntimeclass-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CRuntimeClass::m_lpszClassName](../vs140/cruntimeclass--m_lpszclassname.md)