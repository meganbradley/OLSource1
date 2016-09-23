---
title: "CWindow::SetDlgCtrlID"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL::CWindow::SetDlgCtrlID
  - CWindow.SetDlgCtrlID
  - CWindow::SetDlgCtrlID
  - ATL.CWindow.SetDlgCtrlID
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetDlgCtrlID method
ms.assetid: 09b27282-eaf5-4c21-9aa3-7545d23ffe00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::SetDlgCtrlID
Sets the identifier of the window to the specified value.  
  
## Syntax  
  
```  
  
      int SetDlgCtrlID(  
   int nID   
) throw();  
```  
  
#### Parameters  
 `nID`  
 [in] The new value to set for the window's identifier.  
  
## Return Value  
 If successful, the previous identifier of the window; otherwise 0.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [CWindow::GetDlgCtrlID](../vs140/cwindow--getdlgctrlid.md)