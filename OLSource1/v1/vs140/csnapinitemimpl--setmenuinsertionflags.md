---
title: "CSnapInItemImpl::SetMenuInsertionFlags"
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
  - CSnapInItemImpl.SetMenuInsertionFlags
  - CSnapInItemImpl::SetMenuInsertionFlags
  - SetMenuInsertionFlags
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetMenuInsertionFlags method
ms.assetid: e59a919f-f0e7-4794-98d3-82d781bd841e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CSnapInItemImpl::SetMenuInsertionFlags
Call this function to modify the menu insertion flags, specified by `pInsertionAllowed`, for the snap-in object.  
  
## Syntax  
  
```  
  
      void SetMenuInsertionFlags(  
   bool bBeforeInsertion,  
   long* pInsertionAllowed   
);  
```  
  
#### Parameters  
 *bBeforeInsertion*  
 [in] Nonzero if the function should be called before items are added to the context menu; otherwise 0.  
  
 `pInsertionAllowed`  
 [in, out] Identifies Microsoft Management Console (MMC)-defined, menu-item insertion points that can be used. This can be a combination of the following flags:  
  
-   **CCM_INSERTIONALLOWED_TOP** Items can be inserted at the top of a context menu.  
  
-   **CCM_INSERTIONALLOWED_NEW** Items can be inserted in the Create New submenu.  
  
-   **CCM_INSERTIONALLOWED_TASK** Items can be inserted in the Task submenu.  
  
-   **CCM_INSERTIONALLOWED_VIEW** Items can be inserted in the toolbar view menu or in the View submenu of the result pane context menu.  
  
## Remarks  
 If you are developing a primary snap-in, you can reset any of the insertion flags as a way of restricting the kind of menu items that a third-party extension can add. For example, the primary snap-in can clear the **CCM_INSERTIONALLOWED_NEW** flag to prevent extensions from adding their own Create New menu items.  
  
 You should not attempt to set bits in `pInsertionAllowed` that were originally cleared. Future versions of MMC may use bits not currently defined so you should not change bits that are currently not defined.  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [CSnapInItemImpl Class](../vs140/csnapinitemimpl-class.md)