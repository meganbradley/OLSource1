---
title: "CComControlBase::m_bInPlaceActive"
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
  - "m_bInPlaceActive"
  - "ATL.CComControlBase.m_bInPlaceActive"
  - "CComControlBase::m_bInPlaceActive"
  - "CComControlBase.m_bInPlaceActive"
  - "ATL::CComControlBase::m_bInPlaceActive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bInPlaceActive"
ms.assetid: e3fc9e79-85e1-4864-9312-ecaf71f10304
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bInPlaceActive
Flag indicating the control is in-place active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This means the control is visible and its window, if any, is visible, but its menus and toolbars may not be active. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> flag indicates the control's user interface, such as menus, is also active.  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_bUIActive](../vs140/ccomcontrolbase--m_buiactive.md)