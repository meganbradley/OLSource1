---
title: "CComControlBase::m_bResizeNatural"
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
  - "CComControlBase::m_bResizeNatural"
  - "ATL::CComControlBase::m_bResizeNatural"
  - "ATL.CComControlBase.m_bResizeNatural"
  - "m_bResizeNatural"
  - "CComControlBase.m_bResizeNatural"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_bResizeNatural"
ms.assetid: b4ba8b98-d9bd-47f4-8925-69597861aee3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_bResizeNatural
Flag indicating the control wants to resize its natural extent (its unscaled physical size) when the container changes the control's display size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 This flag is checked by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and, if **TRUE**, the size passed into <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is assigned to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The size passed into <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is always assigned to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, regardless of the value of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [IOleObjectImpl::SetExtent](../vs140/ioleobjectimpl--setextent.md)   
 [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md)   
 [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md)