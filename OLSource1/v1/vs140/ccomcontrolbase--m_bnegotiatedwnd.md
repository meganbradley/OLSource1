---
title: "CComControlBase::m_bNegotiatedWnd"
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
  - "CComControlBase.m_bNegotiatedWnd"
  - "ATL.CComControlBase.m_bNegotiatedWnd"
  - "ATL::CComControlBase::m_bNegotiatedWnd"
  - "m_bNegotiatedWnd"
  - "CComControlBase::m_bNegotiatedWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bNegotiatedWnd"
ms.assetid: f7636340-8bed-459d-8465-990754e42800
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bNegotiatedWnd
Flag indicating whether or not the control has negotiated with the container about support for OCX96 control features (such as flicker-free and windowless controls), and whether the control is windowed or windowless.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> flag must be **TRUE** for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer to be valid.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [CComControlBase::m_bWndLess](../vs140/ccomcontrolbase--m_bwndless.md)   
 [CComControlBase::m_spInPlaceSite](../vs140/ccomcontrolbase--m_spinplacesite.md)