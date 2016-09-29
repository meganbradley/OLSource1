---
title: "COleDateTime::m_status"
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
  - "COleDateTime.m_status"
  - "COleDateTime::m_status"
  - "m_status"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDateTime class, data members"
  - "DateTimeStatus method"
  - "m_status"
ms.assetid: 0733a527-2f9a-473c-a66c-9c0a271f89d9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::m_status
Contains the status of this `COleDateTime` object.  
  
## Syntax  
  
```  
  
DateTimeStatus m_status;  
  
```  
  
## Remarks  
 The type of this data member is the enumerated type **DateTimeStatus**, which is defined within the `COleDateTime` class. See [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md) for details.  
  
> [!CAUTION]
>  This data member is for advanced programming situations. You should use the inline member functions [GetStatus](../vs140/coledatetime--getstatus.md) and [SetStatus](../vs140/coledatetime--setstatus.md). See `SetStatus` for further cautions regarding explicitly setting this data member.  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDateTime::GetStatus](../vs140/coledatetime--getstatus.md)   
 [COleDateTime::SetStatus](../vs140/coledatetime--setstatus.md)