---
title: "CDataExchange::PrepareEditCtrl"
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
  - "PrepareEditCtrl"
  - "CDataExchange.PrepareEditCtrl"
  - "CDataExchange::PrepareEditCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDX/DDV, preparing edit controls"
  - "PrepareEditCtrl method"
  - "DDX/DDV"
  - "preparing edit controls for DDX/DDV"
ms.assetid: 3d0f54fc-b3de-4cf9-b06f-efe115a0e6e6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::PrepareEditCtrl
The framework calls this member function to prepare the specified edit control for dialog data exchange (DDX) and validation (DDV).  
  
## Syntax  
  
```  
  
      HWND PrepareEditCtrl(  
   int nIDC   
);  
```  
  
#### Parameters  
 `nIDC`  
 The ID of the edit control to be prepared for DDX or DDV.  
  
## Return Value  
 The `HWND` of the edit control being prepared for DDX or DDV.  
  
## Remarks  
 Use [PrepareCtrl](../vs140/cdataexchange--preparectrl.md) instead for all non-edit controls.  
  
 Preparation consists of two things. First, `PrepareEditCtrl` stores the control's `HWND` in the `CDataExchange` class. The framework uses this handle to restore the focus to the previously focused control in the event of a DDX or DDV failure. Second, `PrepareEditCtrl` sets a flag in the `CDataExchange` class to indicate that the control whose data is being exchanged or validated is an edit control.  
  
 Implementors of custom DDX or DDV routines should call `PrepareEditCtrl` for all edit controls for which they are exchanging data via DDX or validating data via DDV.  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataExchange::Fail](../vs140/cdataexchange--fail.md)