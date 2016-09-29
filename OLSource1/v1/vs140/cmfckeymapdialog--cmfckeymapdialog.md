---
title: "CMFCKeyMapDialog::CMFCKeyMapDialog"
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
  - "CMFCKeyMapDialog"
  - "CMFCKeyMapDialog::CMFCKeyMapDialog"
  - "CMFCKeyMapDialog.CMFCKeyMapDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCKeyMapDialog class, constructor"
ms.assetid: d12e7488-996e-4b43-9b41-e7c29e7617d9
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog::CMFCKeyMapDialog
Constructs a `CMFCKeyMapDialog` object.  
  
## Syntax  
  
```  
CMFCKeyMapDialog(  
   CFrameWnd* pWndParentFrame,  
   BOOL bEnablePrint=FALSE   
);  
```  
  
#### Parameters  
 [in] `pWndParentFrame`  
 A pointer to the parent window of the `CMFCKeyMapDialog` object.  
  
 [in] `bEnablePrint`  
 `TRUE` if the list of accelerator keys can be printed; otherwise, `FALSE`. The default is `FALSE`.  
  
## Remarks  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCKeyMapDialog` class. This example is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#21](../vs140/codesnippet/CPP/cmfckeymapdialog--cmfckeymapdialog_1.cpp)]  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
## See Also  
 [CMFCKeyMapDialog Class](../vs140/cmfckeymapdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)