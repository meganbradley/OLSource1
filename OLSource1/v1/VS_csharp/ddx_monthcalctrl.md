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
The `DDX_MonthCalCtrl` function manages the transfer of date data between a month calendar control ([CMonthCalCtrl](../VS_csharp/cmonthcalctrl-class.md)) in a dialog box, form view, or control view object and either a [CTime](../VS_csharp/ctime-class.md) or a [COleDateTime](../VS_csharp/coledatetime-class.md) data member of the dialog box, form view, or control view object.  
  
## Syntax  
  
```  
  
      void AFXAPI DDX_MonthCalCtrl(  
   CDataExchange* pDX,  
   int nIDC,  
   CTime& value   
);  
void AFXAPI DDX_MonthCalCtrl(  
   CDataExchange* pDX,  
   int nIDC,  
   COleDateTime& value   
);  
```  
  
#### Parameters  
 `pDX`  
 A pointer to a [CDataExchange](../VS_csharp/cdataexchange-class.md) object. The framework supplies this object to establish the context of the data exchange, including its direction. You don't need to delete this object.  
  
 `nIDC`  
 The resource ID of the month calendar control associated with the member variable.  
  
 *value*  
 A reference to a `CTime` or `COleDateTime` member variable of the dialog box, form view, or control view object with which data is exchanged.  
  
## Remarks  
  
> [!NOTE]
>  The control manages a date value only. The time fields in the time object are set to reflect the creation time of the control window, or whatever time was set in the control with a call to `CMonthCalCtrl::SetCurSel`.  
  
 When `DDX_MonthCalCtrl` is called, *value* is set to the current state of the month calendar control.  
  
 For more information about DDX, see [Dialog Data Exchange and Validation](../VS_csharp/dialog-data-exchange-and-validation.md).  
  
## Requirements  
 **Header:** afxdd_.h  
  
## See Also  
 [Standard Dialog Data Exchange Routines](../VS_csharp/standard-dialog-data-exchange-routines.md)   
 [Macros and Globals](../VS_csharp/mfc-macros-and-globals.md)   
 [DDX_DateTimeCtrl](../VS_csharp/ddx_datetimectrl.md)   
 [CMonthCalCtrl Class](../VS_csharp/cmonthcalctrl-class.md)   
 [CMonthCalCtrl::GetCurSel](../Topic/CMonthCalCtrl::GetCurSel.md)   
 [CMonthCalCtrl::SetCurSel](../Topic/CMonthCalCtrl::SetCurSel.md)