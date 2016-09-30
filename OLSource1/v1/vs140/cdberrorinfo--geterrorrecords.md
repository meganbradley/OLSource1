---
title: "CDBErrorInfo::GetErrorRecords"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CDBErrorInfo.GetErrorRecords"
  - "ATL.CDBErrorInfo.GetErrorRecords"
  - "ATL::CDBErrorInfo::GetErrorRecords"
  - "GetErrorRecords"
  - "CDBErrorInfo::GetErrorRecords"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetErrorRecords method"
ms.assetid: 07746774-bcca-4833-8f55-a619e9777c17
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDBErrorInfo::GetErrorRecords
Gets error records for the specified object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *pUnk*  
 [in] Interface to the object for which to get error records.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The IID of the interface associated with the error.  
  
 *pcRecords*  
 [out] A pointer to the (one-based) count of error records.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use the first form of the function if you want to check which interface to get the error information from. Otherwise, use the second form.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDBErrorInfo Class](../vs140/cdberrorinfo-class.md)