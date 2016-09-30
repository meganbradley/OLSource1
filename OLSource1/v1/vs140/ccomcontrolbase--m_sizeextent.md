---
title: "CComControlBase::m_sizeExtent"
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
  - "CComControlBase.m_sizeExtent"
  - "CComControlBase::m_sizeExtent"
  - "m_sizeExtent"
  - "ATL::CComControlBase::m_sizeExtent"
  - "ATL.CComControlBase.m_sizeExtent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_sizeExtent"
ms.assetid: 6465cffb-6bb3-43ec-9dbf-765bc9f88d75
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_sizeExtent
The extent of the control in HIMETRIC units (each unit is 0.01 millimeters) for a particular display.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 This size is scaled by the display. The control's physical size is specified in the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> data member and is fixed.  
  
 You can convert the size to pixels with the global function [AtlHiMetricToPixel](../vs140/atlhimetrictopixel.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106)   
 [CComControlBase::m_sizeNatural](../vs140/ccomcontrolbase--m_sizenatural.md)