---
title: "CPaneDialog::HandleInitDialog"
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
  - "CPaneDialog.HandleInitDialog"
  - "CPaneDialog::HandleInitDialog"
  - "HandleInitDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandleInitDialog method"
  - "CPaneDialog::HandleInitDialog"
ms.assetid: 4798d1d2-f1e9-49d2-97eb-18f948077843
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneDialog::HandleInitDialog
Handles the [WM_INITDIALOG](http://msdn.microsoft.com/library/windows/desktop/ms645428) message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Handle to the control that is to receive the default keyboard focus.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies additional initialization data.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if this method is successful; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. In addition, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> sets the keyboard focus to the control specified by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter; <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> prevents setting the default keyboard focus.  
  
## Remarks  
 The framework uses this method to initialize controls and the appearance of a dialog box. The framework calls this method before it displays the dialog box.  
  
## Requirements  
 **Header:** afxpanedialog.h  
  
## See Also  
 [CPaneDialog Class](../vs140/cpanedialog-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)