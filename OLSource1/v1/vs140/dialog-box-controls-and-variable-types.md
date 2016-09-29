---
title: "Dialog Box Controls and Variable Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog box controls, member variables"
  - "dialog box controls, variable types"
  - "variables, dialog box control member variables"
ms.assetid: f9cd9cea-45a6-4349-8358-e5efbcdcff76
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Dialog Box Controls and Variable Types
You can use the [Add Member Variable Wizard](../vs140/add-member-variable-wizard.md) to add a member variable to a dialog box control created using MFC. The type of control for which you add the member variable determines the options that appear in the dialog box.  
  
 The following table describes all dialog box control types supported in MFC and the [Dialog Editor](../vs140/dialog-editor.md), and their available types and values.  
  
|Control|Control type|Control variable type|Value variable type|Min/max values (value type only)|  
|-------------|------------------|---------------------------|-------------------------|-----------------------------------------|  
|Animation control|SysAnimate32|[CAnimateCtrl](../vs140/canimatectrl-class.md)|None; control only|N/A|  
|Button|BUTTON|[CButton](../vs140/cbutton-class.md)|None; control only|N/A|  
|Check box|CHECK|[CButton](../vs140/cbutton-class.md)|**BOOL**|Min value/Max value|  
|Combo box|COMBOBOX|[CComboBox](../vs140/ccombobox-class.md)|[CString](../vs140/cstringt-class.md)|Max characters|  
|Date time picker control|SysDateTimePick32|[CDateTimeCtrl](../vs140/cdatetimectrl-class.md)|[CTime](../vs140/ctime-class.md)|Min value/max value|  
|Edit box|EDIT|[CEdit](../vs140/cedit-class.md)|`CString`, int, UINT, long, DWORD, float, double, BYTE, short, BOOL, `COleDateTime`, or **COleCurrency**|Min value/max value; some support max characters|  
|Hotkey control|msctls_hotkey32|[CHotKeyCtrl](../vs140/chotkeyctrl-class.md)|None; control only|N/A|  
|List box|LISTBOX|[CListBox](../vs140/clistbox-class.md)|`CString`|Max characters|  
|List control|SysListView32|[CListCtrl](../vs140/clistctrl-class.md)|None; control only|N/A|  
|Month Calendar control|SysMonthCal32|[CMonthCalCtrl](../vs140/cmonthcalctrl-class.md)|`CTime`|Min value/max value|  
|Progress control|msctls_progress32|[CProgressCtrl](../vs140/cprogressctrl-class.md)|None; control only|N/A|  
|Rich Edit 2 control|RichEdit20A|[CRichEditCtrl](../vs140/cricheditctrl-class.md)|`CString`|Max characters|  
|Rich Edit control|RICHEDIT|`CRichEditCtrl`|`CString`|Max characters|  
|Scroll bar (vertical or horizontal|SCROLLBAR|[CScrollBar](../vs140/cscrollbar-class.md)|`int`|Min value/max value|  
|Slider control|msctls_trackbar32|[CSliderCtrl](../vs140/csliderctrl-class.md)|`int`|Min value/max value|  
|Spin control|msctls_updown32|[CSpinButtonCtrl](../vs140/cspinbuttonctrl-class.md)|None; control only|N/A|  
|Tab control|SysTabControl32|[CTabCtrl](../vs140/ctabctrl-class.md)|None; control only|N/A|  
|Tree control|SysTreeView32|[CTreeCtrl](../vs140/ctreectrl-class.md)|None; control only|N/A|  
  
## See Also  
 [Adding a Member Variable](../vs140/adding-a-member-variable---visual-c---.md)