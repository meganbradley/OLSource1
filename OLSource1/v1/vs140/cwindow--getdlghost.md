---
title: "CWindow::GetDlgHost"
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
  - CWindow::GetDlgHost
  - GetDlgHost
  - CWindow.GetDlgHost
  - ATL::CWindow::GetDlgHost
  - ATL.CWindow.GetDlgHost
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetDlgHost method
ms.assetid: 1a88033e-820c-4b89-b090-d682081b08c2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWindow::GetDlgHost
Retrieves a pointer to an interface to the ATL Control hosting container.  
  
## Syntax  
  
```  
  
      HRESULT GetDlgHost(  
   int nID,  
   REFIID iid,  
   void** ppHost   
) throw();  
```  
  
#### Parameters  
 `nID`  
 [in] The resource ID of the control being retrieved.  
  
 `iid`  
 [in] The ID of the interface you would like to get from the control.  
  
 *ppHost*  
 [out] The pointer to the interface.  
  
## Return Value  
 Returns `S_OK` if the window specified by `iid` is a Control Container, and the requested interface could be retrieved. Returns **E_FAIL** if the window is not a Control Container, or if the interface requested could not be retrieved. If a window with the specified ID could not be found, then the return value is equal to HRESULT_FROM_WIN32(ERROR_CONTROL_ID_NOT_FOUND).  
  
## Remarks  
 Using this pointer, you can call methods on the interface.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CWindow Class](../vs140/cwindow-class.md)   
 [AtlAxGetHost](../vs140/atlaxgethost.md)