---
title: "CWnd::BindProperty"
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
  - "BindProperty"
  - "CWnd.BindProperty"
  - "CWnd::BindProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BindProperty method"
  - "CWnd class, data-binding functions"
ms.assetid: bbcdbf16-2158-415a-b121-ee52f1d43366
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::BindProperty
Binds a cursor-bound property on a data-bound control (such as a grid control) to a data-source control and registers that relationship with the MFC binding manager.  
  
## Syntax  
  
```  
  
      void BindProperty(  
   DISPID dwDispId,  
   CWnd * pWndDSC  
);  
```  
  
#### Parameters  
 *dwDispId*  
 Specifies the DISPID of a property on a data-bound control that is to be bound to a data-source control.  
  
 `pWndDSC`  
 Points to the window that hosts the data-source control to which the property will be bound. Call `GetDlgItem` with the resource ID of the DCS's host window to retrieve this pointer.  
  
## Remarks  
 The `CWnd` object on which you call this function must be a data-bound control.  
  
## Example  
 `BindProperty` might be used in the following context:  
  
 [!code[NVC_MFC_AxDataBinding#1](../vs140/codesnippet/CPP/cwnd--bindproperty_1.cpp)]  
[!code[NVC_MFC_AxDataBinding#4](../vs140/codesnippet/CPP/cwnd--bindproperty_2.cpp)]  
[!code[NVC_MFC_AxDataBinding#3](../vs140/codesnippet/CPP/cwnd--bindproperty_3.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::GetDSCCursor](../vs140/cwnd--getdsccursor.md)   
 [CWnd::BindDefaultProperty](../vs140/cwnd--binddefaultproperty.md)