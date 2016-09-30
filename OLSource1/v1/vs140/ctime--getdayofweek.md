---
title: "CTime::GetDayOfWeek"
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
  - "ATL.CTime.GetDayOfWeek"
  - "CTime.GetDayOfWeek"
  - "GetDayOfWeek"
  - "ATL::CTime::GetDayOfWeek"
  - "CTime::GetDayOfWeek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, extraction"
  - "GetDayOfWeek method"
ms.assetid: a43c6a79-082a-480c-b451-5894e5ff097a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetDayOfWeek
Returns the day of the week represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the day of the week based on local time; 1 = Sunday, 2 = Monday, to 7 = Saturday.  
  
## Remarks  
 This function calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which uses an internal statically allocated buffer. The data in this buffer is overwritten because of calls to other <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions.  
  
## Example  
 [!code[NVC_ATLMFC_Utilities#154](../vs140/codesnippet/CPP/ctime--getdayofweek_1.cpp)]  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)