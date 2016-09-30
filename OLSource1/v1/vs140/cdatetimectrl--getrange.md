---
title: "CDateTimeCtrl::GetRange"
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
  - "CDateTimeCtrl.GetRange"
  - "CDateTimeCtrl::GetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRange method"
ms.assetid: afc48ec4-334d-4ede-b56f-39be0e28a0a9
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::GetRange
Retrieves the current minimum and maximum allowed system times for a date and time picker control.  
  
## Syntax  
  
```  
  
      DWORD GetRange(  
   COleDateTime* pMinRange,  
   COleDateTime* pMaxRange   
) const;  
DWORD GetRange(  
   CTime* pMinRange,  
   CTime* pMaxRange   
) const;  
```  
  
#### Parameters  
 `pMinRange`  
 A pointer to a [COleDateTime](../vs140/coledatetime-class.md) object or a [CTime](../vs140/ctime-class.md) object containing the earliest time allowed in the `CDateTimeCtrl` object.  
  
 `pMaxRange`  
 A pointer to a `COleDateTime` object or a `CTime` object containing the latest time allowed in the `CDateTimeCtrl` object.  
  
## Return Value  
 A `DWORD` value containing flags that indicate which ranges are set. If  
  
 `return value & GDTR_MAX` == 0  
  
 then the second parameter is valid. Similarly, if  
  
 `return value & GDTR_MIN` == 0  
  
 then the first parameter is valid.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_GETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761767), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation, you can specify either `COleDateTime` or `CTime` usages.  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#4](../vs140/codesnippet/CPP/cdatetimectrl--getrange_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::SetRange](../vs140/cdatetimectrl--setrange.md)