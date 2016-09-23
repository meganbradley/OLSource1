---
title: "CArrayRowset::operator"
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
  - CArrayRowset::operator[]
  - CArrayRowset.operator[]
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator [], arrays
  - [] operator
  - operator[], arrays
ms.assetid: 3bb8c310-cc1e-46e8-9711-9b565488acaa
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CArrayRowset::operator
Provides array-like syntax for accessing a row in the rowset.  
  
## Syntax  
  
```  
  
      TAccessor  
      & operator[](int nRow);  
```  
  
#### Parameters  
 `TAccessor`  
 A templated parameter that specifies the type of accessor stored in the rowset.  
  
 `nRow`  
 [in] Number of the row (array element) you want to access.  
  
## Return Value  
 The contents of the requested row.  
  
## Remarks  
 If `nRow` exceeds the number of rows in the rowset, an exception is thrown.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CArrayRowset Class](../vs140/carrayrowset-class.md)