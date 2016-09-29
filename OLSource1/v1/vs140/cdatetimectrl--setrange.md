---
title: "CDateTimeCtrl::SetRange"
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
  - "CDateTimeCtrl::SetRange"
  - "CDateTimeCtrl.SetRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRange method"
ms.assetid: a49db990-772c-41c9-b2d3-4373f70d32c9
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::SetRange
Sets the minimum and maximum allowed system times for a date and time picker control.  
  
## Syntax  
  
```  
  
      BOOL SetRange(  
   const COleDateTime* pMinRange,  
   const COleDateTime* pMaxRange   
);  
BOOL SetRange(  
   const CTime* pMinRange,  
   const CTime* pMaxRange   
);  
```  
  
#### Parameters  
 `pMinRange`  
 A pointer to a [COleDateTime](../vs140/coledatetime-class.md) object or a [CTime](../vs140/ctime-class.md) object containing the earliest time allowed in the `CDateTimeCtrl` object.  
  
 `pMaxRange`  
 A pointer to a `COleDateTime` object or a `CTime` object containing the latest time allowed in the `CDateTimeCtrl` object.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [DTM_SETRANGE](http://msdn.microsoft.com/library/windows/desktop/bb761780), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. In MFC's implementation, you can specify either `COleDateTime` or `CTime` usages. If the `COleDateTime` object has a **NULL** status, the range will be removed. If the `CTime` pointer or the `COleDateTime` pointer is **NULL**, the range will be removed.  
  
## Example  
 See the example for [CDateTimeCtrl::GetRange](../vs140/cdatetimectrl--getrange.md).  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDateTimeCtrl::GetRange](../vs140/cdatetimectrl--getrange.md)