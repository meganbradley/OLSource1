---
title: "CDaoRecordset::m_bCheckCacheForDirtyFields"
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
  - "m_bCheckCacheForDirtyFields"
  - "CDaoRecordset.m_bCheckCacheForDirtyFields"
  - "CDaoRecordset::m_bCheckCacheForDirtyFields"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "recordsets, dirty fields"
  - "m_bCheckCacheForDirtyFields"
  - "recordsets, caching records"
  - "CDaoRecordset class, checking cache for dirty fields"
ms.assetid: 7e87ed8e-0586-4705-b9a9-cd5882779394
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoRecordset::m_bCheckCacheForDirtyFields
Contains a flag indicating whether cached fields are automatically marked as dirty (changed) and Null.  
  
## Remarks  
 The flag defaults to **TRUE**. The setting in this data member controls the entire double-buffering mechanism. If you set the flag to **TRUE**, you can turn off the caching on a field-by-field basis using the DFX mechanism. If you set the flag to **FALSE**, you must call `SetFieldDirty` and `SetFieldNull` yourself.  
  
 Set this data member before calling **Open**. This mechanism is primarily for ease-of-use. Performance may be slower because of the double-buffering of fields as changes are made.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::SetFieldNull](../vs140/cdaorecordset--setfieldnull.md)   
 [CDaoRecordset::IsFieldNull](../vs140/cdaorecordset--isfieldnull.md)   
 [CDaoRecordset::IsFieldDirty](../vs140/cdaorecordset--isfielddirty.md)   
 [CDaoRecordset::SetFieldDirty](../vs140/cdaorecordset--setfielddirty.md)