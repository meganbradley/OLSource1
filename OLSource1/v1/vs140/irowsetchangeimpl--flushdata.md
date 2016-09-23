---
title: "IRowsetChangeImpl::FlushData"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - IRowsetChangeImpl::FlushData
  - IRowsetChangeImpl.FlushData
  - FlushData
dev_langs: 
  - C++
helpviewer_keywords: 
  - FlushData method
ms.assetid: fd4bc73b-bc25-4aab-90d5-0bed92670c88
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IRowsetChangeImpl::FlushData
Overidden by provider to commit data to its store.  
  
## Syntax  
  
```  
  
      HRESULT FlushData(  
   HROW hRowToFlush,  
   HACCESSOR hAccessorToFlush   
);  
```  
  
#### Parameters  
 *hRowToFlush*  
 [in] Handle to the rows for the data. The type of this row is determined from the *RowClass* template argument of the `IRowsetImpl` class (`CSimpleRow` by default).  
  
 *hAccessorToFlush*  
 [in] Handle to the accessor, which contains binding information and type information in its **PROVIDER_MAP** (see [IAccessorImpl](../vs140/iaccessorimpl-class.md)).  
  
## Return Value  
 A standard `HRESULT`.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [IRowsetChangeImpl Class](../vs140/irowsetchangeimpl-class.md)