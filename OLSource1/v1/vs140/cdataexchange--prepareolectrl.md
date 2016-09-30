---
title: "CDataExchange::PrepareOleCtrl"
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
  - "CDataExchange::PrepareOleCtrl"
  - "PrepareOleCtrl"
  - "CDataExchange.PrepareOleCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PrepareOleCtrl method"
ms.assetid: d6cc720d-b5ae-4d79-b8f8-6d7bca9b4ffd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDataExchange::PrepareOleCtrl
The framework calls this member function to prepare the specified OLE control for dialog data exchange (DDX) and validation (DDV).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The ID of the OLE control to be prepared for DDX or DDV.  
  
## Return Value  
 A pointer to the OLE control site.  
  
## Remarks  
 Use [PrepareEditCtrl](../vs140/cdataexchange--prepareeditctrl.md) instead for edit controls or [PrepareCtrl](../vs140/cdataexchange--preparectrl.md) for all other non-OLE controls.  
  
 Implementors of custom DDX or DDV routines should call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for all OLE controls for which they are exchanging data via DDX or validating data via DDV.  
  
 For more information on writing your own DDX and DDV routines, see [Technical Note 26](../vs140/tn026--ddx-and-ddv-routines.md). For an overview of DDX and DDV, see [Dialog Data Exchange and Validation](../vs140/dialog-data-exchange-and-validation.md) and [Dialog Box Topics](../vs140/dialog-boxes.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDataExchange Class](../vs140/cdataexchange-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)