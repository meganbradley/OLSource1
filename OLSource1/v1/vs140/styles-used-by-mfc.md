---
title: "Styles Used by MFC"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.styles"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "edit styles [MFC]"
  - "window styles, in MFC"
  - "styles"
  - "frame windows, styles"
  - "message-box styles"
  - "styles, MFC"
  - "buttons, MFC toolbars"
  - "list boxes, styles"
  - "static styles"
  - "scroll-bar styles [MFC]"
  - "combo boxes, styles"
  - "extended window styles"
ms.assetid: d3b9af37-31b5-4c97-a8ad-189fd724b04c
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Styles Used by MFC
Use the following styles when you create the corresponding MFC object. In most cases, these styles are set in the `dwStyle` parameter of the class **Create** function.  
  
### MFC Styles  
  
|Style|Description|  
|-----------|-----------------|  
|[Button styles](../vs140/button-styles.md)|Applies to [CButton Class](../vs140/cbutton-class.md) objects, such as radio buttons, check boxes and pushbuttons. Specify a combination of styles in the `dwStyle` parameter of [CButton::Create](../vs140/cbutton--create.md).|  
|[Combo-box styles](../vs140/combo-box-styles.md)|Applies to [CComboBox Class](../vs140/ccombobox-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CComboBox::Create](../vs140/ccombobox--create.md).|  
|[Edit styles](../vs140/edit-styles.md)|Applies to [CEdit Class](../vs140/cedit-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CEdit::Create](../vs140/cedit--create.md).|  
|[Frame-window styles](../vs140/frame-window-styles--mfc-.md)|Applies to [CFrameWnd Class](../vs140/cframewnd-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CFrameWnd::Create](../vs140/cframewnd--create.md).|  
|[List-box styles](../vs140/list-box-styles.md)|Applies to [CListBox Class](../vs140/clistbox-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CListBox::Create](../vs140/clistbox--create.md).|  
|[Message-box styles](../vs140/message-box-styles.md)|Applies to [AfxMessageBox](../vs140/afxmessagebox.md) items. Specify a combination of styles in the `nType` parameter of `AfxMessageBox`.|  
|[Scroll-bar styles](../vs140/scroll-bar-styles.md)|Applies to [CScrollBar Class](../vs140/cscrollbar-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CScrollBar::Create](../vs140/cscrollbar--create.md).|  
|[Static styles](../vs140/static-styles.md)|Applies to [CStatic Class](../vs140/cstatic-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CStatic::Create](../vs140/cstatic--create.md).|  
|[Window styles](../vs140/window-styles.md)|Applies to [CWnd Class](../vs140/cwnd-class.md) objects. Specify a combination of styles in the `dwStyle` parameter of [CWnd::Create](../vs140/cwnd--create.md) or [CWnd::CreateEx](../vs140/cwnd--createex.md).|  
|[Extended window styles](../vs140/extended-window-styles.md)|Applies to [CWnd Class](../vs140/cwnd-class.md) objects. Specify a combination of styles in the `dwExStyle` parameter of [CWnd::CreateEx](../vs140/cwnd--createex.md).|  
  
## See Also  
 [Class Overview](../vs140/class-library-overview.md)