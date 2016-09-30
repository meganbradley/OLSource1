---
title: "CTime::GetYear"
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
  - "CTime::GetYear"
  - "ATL.CTime.GetYear"
  - "GetYear"
  - "CTime.GetYear"
  - "ATL::CTime::GetYear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTime class, extraction"
  - "GetYear method"
ms.assetid: f7f203a7-9356-45ff-9838-5af0480d1f83
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTime::GetYear
Returns the year represented by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns the year, based on local time, in the range January 1,1970, to January 18, 2038 (inclusive).  
  
## Remarks  
 This function calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, which uses an internal statically allocated buffer. The data in this buffer is overwritten because of calls to other <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions.  
  
## Example  
 See the example for [GetDay](../vs140/ctime--getday.md).  
  
## Requirements  
 **Header:** atltime.h  
  
## See Also  
 [CTime Class](../vs140/ctime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTime::CTime](../vs140/ctime--ctime.md)