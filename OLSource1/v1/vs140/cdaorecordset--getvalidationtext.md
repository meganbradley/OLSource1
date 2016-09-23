---
title: "CDaoRecordset::GetValidationText"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - GetValidationText
  - CDaoRecordset::GetValidationText
  - CDaoRecordset.GetValidationText
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetValidationText method
  - recordsets, getting validation information
  - CDaoRecordset class, getting validation information
ms.assetid: 336f00bd-688d-4741-a92c-b116a4889281
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDaoRecordset::GetValidationText
Call this member function to retrieve the text of the ValidationText property of the underlying field object.  
  
## Syntax  
  
```  
  
CString GetValidationText( );  
  
```  
  
## Return Value  
 A `CString` object containing the text of the message that is displayed if the value of a field does not satisfy the validation rule of the underlying field object.  
  
## Remarks  
 For related information, see the topic "ValidationText Property" in DAO Help.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoRecordset Class](../vs140/cdaorecordset-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDaoRecordset::GetValidationRule](../vs140/cdaorecordset--getvalidationrule.md)