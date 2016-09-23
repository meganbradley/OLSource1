---
title: "CFrameWndEx::LoadFrame"
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
  - CFrameWndEx.LoadFrame
  - LoadFrame
  - CFrameWndEx::LoadFrame
dev_langs: 
  - C++
helpviewer_keywords: 
  - LoadFrame method
ms.assetid: 3f8d7a45-25d6-43fe-9bdd-b5eb7a99c245
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CFrameWndEx::LoadFrame
This method is called after construction to create the frame window and load its resources.  
  
## Syntax  
  
```  
virtual BOOL LoadFrame(  
   UINT nIDResource,  
   DWORD dwDefaultStyle = WS_OVERLAPPEDWINDOW | FWS_ADDTOTITLE,  
   CWnd* pParentWnd = NULL,  
   CCreateContext* pContext = NULL  
);  
```  
  
#### Parameters  
 [in] `nIDResource`  
 The resource ID that is used to load all frame resources.  
  
 [in] `dwDefaultStyle`  
 The default frame window style.  
  
 [in] `pParentWnd`  
 Pointer to the parent window of the frame.  
  
 [in] `pContext`  
 Pointer to a [CCreateContext](../vs140/ccreatecontext-structure.md) class that is used by the framework during application creation.  
  
## Return Value  
 `TRUE` if the method was successful; otherwise, `FALSE`.  
  
## Remarks  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)