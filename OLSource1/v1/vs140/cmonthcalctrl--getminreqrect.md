---
title: "CMonthCalCtrl::GetMinReqRect"
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
  - "CMonthCalCtrl::GetMinReqRect"
  - "GetMinReqRect"
  - "CMonthCalCtrl.GetMinReqRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetMinReqRect method"
  - "CMonthCalCtrl class, attributes"
ms.assetid: d3818ee9-d529-4ad1-ad47-29df02f390ac
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::GetMinReqRect
Retrieves the minimum size required to show a full month in a month calendar control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that will receive bounding rectangle information. This parameter must be a valid address and cannot be **NULL**.  
  
## Return Value  
 If successful, this member function returns nonzero and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> receives the applicable bounding information. If unsuccessful, the member function returns 0.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [MCM_GETMINREQRECT](http://msdn.microsoft.com/library/windows/desktop/bb760978), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::SizeMinReq](../vs140/cmonthcalctrl--sizeminreq.md)