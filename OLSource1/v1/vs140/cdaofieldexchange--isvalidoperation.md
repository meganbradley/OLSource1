---
title: "CDaoFieldExchange::IsValidOperation"
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
  - "CDaoFieldExchange.IsValidOperation"
  - "CDaoFieldExchange::IsValidOperation"
  - "IsValidOperation"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "custom DFX routines"
  - "DFX (DAO record field exchange), valid operations"
  - "DFX (DAO record field exchange), custom DFX routines"
  - "DFX (DAO record field exchange)"
  - "IsValidOperation method"
  - "valid operations in DAO field exchange"
ms.assetid: 2f213eb8-e59a-42eb-b56f-4c1e5b15d982
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoFieldExchange::IsValidOperation
If you write your own DFX function, call `IsValidOperation` at the beginning of your function to determine whether the current operation can be performed on a particular field data member type (a **CDaoFieldExchange::outputColumn** or a **CDaoFieldExchange::param**).  
  
## Syntax  
  
```  
  
BOOL IsValidOperation( );  
  
```  
  
## Return Value  
 Nonzero if the current operation is appropriate for the type of field being updated.  
  
## Remarks  
 Some of the operations performed by the DFX mechanism apply only to one of the possible field types. Follow the model of the existing DFX functions.  
  
 For additional information on writing custom DFX routines, see [Technical Note 53](../vs140/tn053--custom-dfx-routines-for-dao-database-classes.md).  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoFieldExchange Class](../vs140/cdaofieldexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoFieldExchange::SetFieldType](../vs140/cdaofieldexchange--setfieldtype.md)