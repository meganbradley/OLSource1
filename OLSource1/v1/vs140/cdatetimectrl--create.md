---
title: "CDateTimeCtrl::Create"
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
  - "CDateTimeCtrl.Create"
  - "CDateTimeCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
  - "CDateTimeCtrl class, initialization"
ms.assetid: d7a0653c-f852-4c70-ba11-5a88adfc3a92
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDateTimeCtrl::Create
Creates the date and time picker control and attaches it to the `CDateTimeCtrl` object.  
  
## Syntax  
  
```  
  
      virtual BOOL Create(  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID   
);  
```  
  
#### Parameters  
 `dwStyle`  
 Specifies the combination of date time control styles. See [Date and Time Picker Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb761728) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about date and time picker styles.  
  
 `rect`  
 A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, which is the position and size of the date and time picker control.  
  
 `pParentWnd`  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the date and time picker control. It must not be **NULL**.  
  
 `nID`  
 Specifies the date and time picker control's control ID.  
  
## Return Value  
 Nonzero if creation was successful; otherwise 0.  
  
## Remarks  
  
### To create a date and time picker control  
  
1.  Call [CDateTimeCtrl](../vs140/cdatetimectrl--cdatetimectrl.md) to construct a `CDateTimeCtrl` object.  
  
2.  Call this member function, which creates the Windows date and time picker control and attaches it to the `CDateTimeCtrl` object.  
  
 When you call **Create**, the common controls are initialized.  
  
## Example  
 [!code[NVC_MFC_CDateTimeCtrl#1](../vs140/codesnippet/CPP/cdatetimectrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxdtctl.h  
  
## See Also  
 [CDateTimeCtrl Class](../vs140/cdatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)