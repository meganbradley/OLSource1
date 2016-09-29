---
title: "CTime::Format"
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
  - "ATL.CTime.Format"
  - "CTime::Format"
  - "CTime.Format"
  - "ATL::CTime::Format"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, conversion"
  - "Format method"
ms.assetid: a1f2be7d-c1fd-4ec6-aa73-dd572da8ccf0
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::Format
Call this member function to create a formatted representation of the date-time value.  
  
## Syntax  
  
```  
CString Format(  
   LPCTSTR pszFormat   
) const;  
CString Format(  
   UINT nFormatID   
) const;  
```  
  
#### Parameters  
 `pszFormat`  
 A formatting string similar to the `printf` formatting string. Formatting codes, preceded by a percent (`%`) sign, are replaced by the corresponding `CTime` component. Other characters in the formatting string are copied unchanged to the returned string. See the run-time function [strftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for a list of formatting codes.  
  
 `nFormatID`  
 The ID of the string that identifies this format.  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) that contains the formatted time.  
  
## Remarks  
 If the status of this `CTime` object is null, the return value is an empty string.  
  
 This method throws an exception if the date-time value to format does not range from midnight, January 1, 1970 through December 31, 3000 Universal Coordinated Time (UTC).  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#149](../vs140/codesnippet/CPP/ctime--format_1.cpp)]  
  
## Requirements  
 Header: atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::FormatGmt](../vs140/ctime--formatgmt.md)