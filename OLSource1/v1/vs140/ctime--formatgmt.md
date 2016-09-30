---
title: "CTime::FormatGmt"
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
  - "FormatGmt"
  - "ATL.CTime.FormatGmt"
  - "CTime.FormatGmt"
  - "CTime::FormatGmt"
  - "ATL::CTime::FormatGmt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, conversion"
  - "FormatGmt method"
ms.assetid: 4853b29f-fee6-4b61-a8d5-6994bf86ab61
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::FormatGmt
Generates a formatted string that corresponds to this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies a formatting string similar to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> formatting string. See the run-time function [strftime](../vs140/strftime--wcsftime--_strftime_l--_wcsftime_l.md) for details.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The ID of the string that identifies this format.  
  
## Return Value  
 A [CString](../vs140/cstringt-class.md) that contains the formatted time.  
  
## Remarks  
 The time value is not converted and thus reflects UTC.  
  
 This method throws an exception if the date-time value to format does not range from midnight, January 1, 1970 through December 31, 3000 Universal Coordinated Time (UTC).  
  
## Example  
 See the example for [CTime::Format](../vs140/ctime--format.md).  
  
## Requirements  
 Header: atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::Format](../vs140/ctime--format.md)