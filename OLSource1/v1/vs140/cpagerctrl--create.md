---
title: "CPagerCtrl::Create"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CPagerCtrl::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: a366f2c9-8705-4f16-9726-a49328220182
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPagerCtrl::Create
Creates a pager control with specified styles and attaches it to the current `CPagerCtrl` object.  
  
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
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `dwStyle`|A bitwise combination (OR) of [window styles](../vs140/window-styles.md) and [pager control styles](http://msdn.microsoft.com/library/windows/desktop/bb760859) to be applied to the control.|  
|[in] `rect`|A reference to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that contains the position and size of the control in client coordinates.|  
|[in] `pParentWnd`|A pointer to a [CWnd](../vs140/cwnd-class.md) object that is the parent window of the control. This parameter cannot be `NULL`.|  
|[in] `nID`|The ID of the control.|  
  
## Return Value  
 `true` if this method is successful; otherwise, `false`.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 To create a pager control, declare a `CPagerCtrl` variable, then call the [CPagerCtrl::Create](../vs140/cpagerctrl--create.md) or [CPagerCtrl::CreateEx](../vs140/cpagerctrl--createex.md) method on that variable.  
  
## Example  
 The following example creates a pager control, then uses the [CPagerCtrl::SetChild](../vs140/cpagerctrl--setchild.md) method to associate a very long button control with the pager control. The example then uses the [CPagerCtrl::SetButtonSize](../vs140/cpagerctrl--setbuttonsize.md) method to set the height of the pager control to 20 pixels, and the [CPagerCtrl::SetBorder](../vs140/cpagerctrl--setborder.md) method to set the border thickness to 1 pixel.  
  
 [!code[NVC_MFC_CSplitButton_s2#1](../vs140/codesnippet/CPP/cpagerctrl--create_1.cpp)]
  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859)   
 [Window Styles](../vs140/window-styles.md)