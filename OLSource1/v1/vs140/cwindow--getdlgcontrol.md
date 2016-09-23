---
title: "CWindow::GetDlgControl"
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
  - CWindow::GetDlgControl
  - ATL.CWindow.GetDlgControl
  - CWindow.GetDlgControl
  - GetDlgControl
  - ATL::CWindow::GetDlgControl
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDlgControl method
ms.assetid: c00a4cf5-7bf1-4b49-95d3-e39724d01027
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetDlgControl
Call this function to get a pointer to an interface of an ActiveX control that is hosted by a composite control or a control-hosting dialog.  
  
## Syntax  
  
```  
  
      HRESULT GetDlgControl(  
   int nID,  
   REFIID iid,  
   void** ppCtrl   
) throw();  
```  
  
#### Parameters  
 `nID`  
 [in] The resource ID of the control being retrieved.  
  
 `iid`  
 [in] The ID of the interface you would like to get from the control.  
  
 *ppCtrl*  
 [out] The pointer to the interface.  
  
## Return Value  
 Returns `S_OK` on success or any valid error `HRESULT`. For example, the function returns **E_FAIL** if the control specified by `nID` cannot be found and it returns **E_NOINTERFACE** if the control can be found, but it doesn't support the interface specified by `iid`.  
  
## Remarks  
 Using this pointer, you can call methods on the interface.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)