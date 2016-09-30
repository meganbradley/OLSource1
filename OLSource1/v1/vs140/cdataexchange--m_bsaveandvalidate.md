---
title: "CDataExchange::m_bSaveAndValidate"
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
  - "CDataExchange.m_bSaveAndValidate"
  - "m_bSaveAndValidate"
  - "CDataExchange::m_bSaveAndValidate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bSaveAndValidate"
ms.assetid: 3565c583-ba9d-467c-99ca-03c544fa5c7a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::m_bSaveAndValidate
This flag indicates the direction of a dialog data exchange (DDX) operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The flag is nonzero if the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is being used to move data from the dialog controls to dialog-class data members after the user edits the controls. The flag is zero if the object is being used to initialize dialog controls from dialog-class data members.  
  
 The flag is also nonzero during dialog data validation (DDV).  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)