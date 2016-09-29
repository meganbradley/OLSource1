---
title: "CReBarCtrl::Create"
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
  - "CReBarCtrl.Create"
  - "CReBarCtrl::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, initialization"
  - "Create method [C++]"
ms.assetid: 1b23893b-77d9-43a0-8e07-869cd9ba1e81
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::Create
Creates the rebar control and attaches it to the `CReBarCtrl` object.  
  
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
 Specifies the combination of rebar control styles applied to the control. See [Rebar Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb774377) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for a list of supported styles.  
  
 `rect`  
 A reference to a [CRect](../vs140/crect-class.md) object or [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure, which is the position and size of the rebar control.  
  
 `pParentWnd`  
 A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the rebar control. It must not be **NULL**.  
  
 `nID`  
 Specifies the rebar control's control ID.  
  
## Return Value  
 Nonzero if the object was created successfully; otherwise 0.  
  
## Remarks  
 Create a rebar control in two steps:  
  
1.  Call [CReBarCtrl](../vs140/crebarctrl--crebarctrl.md) to construct a `CReBarCtrl` object.  
  
2.  Call this member function, which creates the Windows rebar control and attaches it to the `CReBarCtrl` object.  
  
 When you call **Create**, the common controls are initialized.  
  
## Example  
 [!code[NVC_MFC_CReBarCtrl#3](../vs140/codesnippet/CPP/crebarctrl--create_1.cpp)]  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::CReBarCtrl](../vs140/crebarctrl--crebarctrl.md)   
 [CReBarCtrl::CreateEx](../vs140/crebarctrl--createex.md)