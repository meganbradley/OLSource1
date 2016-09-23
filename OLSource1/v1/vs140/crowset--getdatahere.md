---
title: "CRowset::GetDataHere"
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
  - CRowset<TAccessor>::GetDataHere
  - CRowset<TAccessor>.GetDataHere
  - CRowset.GetDataHere
  - GetDataHere
  - CRowset::GetDataHere
  - ATL::CRowset::GetDataHere
  - ATL::CRowset<TAccessor>::GetDataHere
  - ATL.CRowset<TAccessor>.GetDataHere
  - ATL.CRowset.GetDataHere
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDataHere method
ms.assetid: 2fe2a987-1c4c-4299-876e-0591caf63af4
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRowset::GetDataHere
Retrieves data from the current row and places it into the specified buffer.  
  
## Syntax  
  
```  
  
      HRESULT GetDataHere(   
   int nAccessor,   
   void* pBuffer    
) throw( );  
```  
  
#### Parameters  
 `nAccessor`  
 [in] The index number of the accessor to use for accessing the data.  
  
 `pBuffer`  
 [out] A buffer into which to place the data for the current record.  
  
## Return Value  
 A standard `HRESULT`.  
  
## Remarks  
 For an example of how to use this function, see the [MultiRead sample](../vs140/visual-c---samples.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CRowset Class](../vs140/crowset-class.md)   
 [CRowset::GetData](../vs140/crowset--getdata.md)