---
title: "COleDateTime::GetAsSystemTime"
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
  - "ATL::COleDateTime::GetAsSystemTime"
  - "COleDateTime.GetAsSystemTime"
  - "ATL.COleDateTime.GetAsSystemTime"
  - "COleDateTime::GetAsSystemTime"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetAsSystemTime method"
ms.assetid: 6f80b751-5d2e-4fd9-a5a6-a87ac9db5bbf
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDateTime::GetAsSystemTime
Call this method to obtain the time in the `COleDateTime` object as a `SYSTEMTIME` data structure.  
  
## Syntax  
  
```  
  
      bool GetAsSystemTime(  
   SYSTEMTIME& sysTime   
) const throw( );  
```  
  
#### Parameters  
 *sysTime*  
 A reference to a [SYSTEMTIME](http://msdn.microsoft.com/library/windows/desktop/ms724950) structure to receive the converted date/time value from the `COleDateTime` object.  
  
## Return Value  
 Returns **true** if successful; **false** if the conversion fails, or if the `COleDateTime` object is **NULL** or invalid.  
  
## Remarks  
 `GetAsSystemTime` stores the resulting time in the referenced *sysTime* object. The `SYSTEMTIME` data structure initialized by this function will have its **wMilliseconds** member set to zero.  
  
 See [GetStatus](../vs140/coledatetime--getstatus.md) for more information on the status information held in a `COleDateTime` object.  
  
## Requirements  
 **Header:** atlcomtime.h  
  
## See Also  
 [COleDateTime Class](../vs140/coledatetime-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)