---
title: "CDataExchange::Fail"
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
  - "CDataExchange::Fail"
  - "Fail"
  - "CDataExchange.Fail"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDV (dialog data validation) validation failure"
  - "validation failure (DDV)"
  - "failures, dialog data validation (DDV)"
  - "Fail method"
ms.assetid: 2fcac5c6-4642-4d96-bbae-ff165eef2bbf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::Fail
The framework calls this member function when a dialog data validation (DDV) operation fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 **Fail** restores the focus and selection to the control whose validation failed (if there is a control to restore). **Fail** then throws an exception of type [CUserException](../vs140/cuserexception-class.md) to stop the validation process. The exception causes a message box explaining the error to be displayed. After DDV validation fails, the user can reenter data in the offending control.  
  
 Implementors of custom DDV routines can call **Fail** from their routines when a validation fails.  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDataExchange::PrepareCtrl](../vs140/cdataexchange--preparectrl.md)   
 [CDataExchange::PrepareEditCtrl](../vs140/cdataexchange--prepareeditctrl.md)