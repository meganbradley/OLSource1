---
title: "CDialog::EndDialog"
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
  - "CDialog::EndDialog"
  - "CDialog.EndDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialog class, operations"
  - "EndDialog method"
ms.assetid: 49f28795-6181-488a-869c-a44bbd776af2
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog::EndDialog
Call this member function to terminate a modal dialog box.  
  
## Syntax  
  
```  
  
      void EndDialog(  
   int nResult   
);  
```  
  
#### Parameters  
 `nResult`  
 Contains the value to be returned from the dialog box to the caller of `DoModal`.  
  
## Remarks  
 This member function returns `nResult` as the return value of `DoModal`. You must use the `EndDialog` function to complete processing whenever a modal dialog box is created.  
  
 You can call `EndDialog` at any time, even in [OnInitDialog](../vs140/cdialog--oninitdialog.md), in which case you should close the dialog box before it is shown or before the input focus is set.  
  
 `EndDialog` does not close the dialog box immediately. Instead, it sets a flag that directs the dialog box to close as soon as the current message handler returns.  
  
## Example  
 [!code[NVC_MFCControlLadenDialog#64](../vs140/codesnippet/CPP/cdialog--enddialog_1.cpp)]  
  
 [!code[NVC_MFCControlLadenDialog#65](../vs140/codesnippet/CPP/cdialog--enddialog_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDialog Class](../vs140/cdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::DoModal](../vs140/cdialog--domodal.md)   
 [CDialog::OnOK](../vs140/cdialog--onok.md)   
 [CDialog::OnCancel](../vs140/cdialog--oncancel.md)