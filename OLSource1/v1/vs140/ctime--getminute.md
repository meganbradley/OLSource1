---
title: "CTime::GetMinute"
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
  - "CTime.GetMinute"
  - "CTime::GetMinute"
  - "ATL::CTime::GetMinute"
  - "ATL.CTime.GetMinute"
  - "GetMinute"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, extraction"
  - "GetMinute method"
ms.assetid: c8ff0ec1-3521-4e49-9887-05f8a77f2c9c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetMinute
Returns the minute represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the minute, based on local time, in the range 0 through 59.  
  
## Remarks  
 This function calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which uses an internal statically allocated buffer. The data in this buffer is overwritten because of calls to other <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions.  
  
## Example  
 See the example for [GetHour](../vs140/ctime--gethour.md).  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)