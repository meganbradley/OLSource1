---
title: "CMonthCalCtrl::Create"
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
  - "CMonthCalCtrl.Create"
  - "CMonthCalCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CMonthCalCtrl class, initialization"
ms.assetid: e593b80d-620b-4f40-ac9a-c64c198db7f9
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonthCalCtrl::Create
Creates a month calendar control and attaches it to the `CMonthCalCtrl` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID   
);  
virtual BOOL Create(  
   DWORD dwStyle,  
   const POINT& pt,  
   CWnd* pParentWnd,  
   UINT nID   
);  
```  
  
#### Parameters  
 `dwStyle`  
 Specifies the combination of Windows styles applied to the month calendar control. See [Month Calendar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760919) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about the styles.  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure. Contains the position and size of the month calendar control.  
  
 `pt`  
 A reference to a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that identifies the location of the month calendar control.  
  
 `pParentWnd`  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the month calendar control. It must not be **NULL**.  
  
 `nID`  
 Specifies the month calendar control's control ID.  
  
## Return Value  
 Nonzero if initialization was successful; otherwise 0.  
  
## Remarks  
 Create a month calendar control in two steps:  
  
1.  Call [CMonthCalCtrl](../vs140/cmonthcalctrl-class.md) to construct a `CMonthCalCtrl` object.  
  
2.  Call this member function, which creates a month calendar control and attaches it to the `CMonthCalCtrl` object.  
  
 When you call **Create**, the common controls are initialized. The version of **Create** you call determines how it is sized:  
  
-   To have MFC automatically size the control to one month, call the override that uses the `pt` parameter.  
  
-   To size the control yourself, call the override of this function that uses the `rect` parameter.  
  
## Example  
 [!code[NVC_MFC_CMonthCalCtrl#1](../vs140/codesnippet/CPP/cmonthcalctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonthCalCtrl::CMonthCalCtrl](../vs140/cmonthcalctrl--cmonthcalctrl.md)