---
title: "DDX_MonthCalCtrl"
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
  - "DDX_MonthCalCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX_MonthCalCtrl function"
ms.assetid: f80055a7-99d1-4b99-b13d-9aae3580bcff
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDX_MonthCalCtrl
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function manages the transfer of date data between a month calendar control ([CMonthCalCtrl](../vs140/cmonthcalctrl-class.md)) in a dialog box, form view, or control view object and either a [CTime](../vs140/ctime-class.md) or a [COleDateTime](../vs140/coledatetime-class.md) data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a [CDataExchange](../vs140/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction. You don't need to delete this object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The resource ID of the month calendar control associated with the member variable.  
  
 *value*  
 A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
  
> [!NOTE]
>  The control manages a date value only. The time fields in the time object are set to reflect the creation time of the control window, or whatever time was set in the control with a call to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 When <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called, *value* is set to the current state of the month calendar control.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../vs140/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDX_DateTimeCtrl](../vs140/ddx_datetimectrl.md)   
 [CMonthCalCtrl Class](../vs140/cmonthcalctrl-class.md)   
 [CMonthCalCtrl::GetCurSel](../vs140/cmonthcalctrl--getcursel.md)   
 [CMonthCalCtrl::SetCurSel](../vs140/cmonthcalctrl--setcursel.md)