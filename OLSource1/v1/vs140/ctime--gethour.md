---
title: "CTime::GetHour"
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
  - "ATL.CTime.GetHour"
  - "CTime.GetHour"
  - "CTime::GetHour"
  - "ATL::CTime::GetHour"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, extraction"
  - "GetHour method"
ms.assetid: 916d0ee0-52e8-44b6-9035-093f1acd4151
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetHour
Returns the hour represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the hour, based on local time, in the range 0 through 23.  
  
## Remarks  
 This function calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which uses an internal statically allocated buffer. The data in this buffer is overwritten because of calls to other <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#156](../vs140/codesnippet/CPP/ctime--gethour_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)