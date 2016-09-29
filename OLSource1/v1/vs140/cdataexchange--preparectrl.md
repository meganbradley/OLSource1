---
title: "CDataExchange::PrepareCtrl"
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
  - "CDataExchange.PrepareCtrl"
  - "CDataExchange::PrepareCtrl"
  - "PrepareCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "preparing dialog controls for DDX/DDV"
  - "DDX/DDV, preparing controls"
  - "PrepareCtrl method"
  - "DDX/DDV"
ms.assetid: af1394b1-30de-495e-bc6f-0abfa62bd3a6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::PrepareCtrl
The framework calls this member function to prepare the specified control for dialog data exchange (DDX) and validation (DDV).  
  
## Syntax  
  
```  
  
      HWND PrepareCtrl(  
   int nIDC   
);  
```  
  
#### Parameters  
 `nIDC`  
 The ID of the control to be prepared for DDX or DDV.  
  
## Return Value  
 The `HWND` of the control being prepared for DDX or DDV.  
  
## Remarks  
 Use [PrepareEditCtrl](../vs140/cdataexchange--prepareeditctrl.md) instead for edit controls; use this member function for all other controls.  
  
 Preparation consists of storing the control's `HWND` in the `CDataExchange` class. The framework uses this handle to restore the focus to the previously focused control in the event of a DDX or DDV failure.  
  
 Implementors of custom DDX or DDV routines should call `PrepareCtrl` for all non-edit controls for which they are exchanging data via DDX or validating data via DDV.  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataExchange::Fail](../vs140/cdataexchange--fail.md)