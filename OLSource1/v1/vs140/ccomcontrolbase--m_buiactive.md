---
title: "CComControlBase::m_bUIActive"
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
  - "m_bUIActive"
  - "ATL::CComControlBase::m_bUIActive"
  - "CComControlBase::m_bUIActive"
  - "ATL.CComControlBase.m_bUIActive"
  - "CComControlBase.m_bUIActive"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bUIActive"
ms.assetid: e663a5cd-dd16-429c-8375-6ff827101893
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bUIActive
Flag indicating the control's user interface, such as menus and toolbars, is active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> flag indicates that the control is active, but not that its user interface is active.  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_bInPlaceActive](../vs140/ccomcontrolbase--m_binplaceactive.md)