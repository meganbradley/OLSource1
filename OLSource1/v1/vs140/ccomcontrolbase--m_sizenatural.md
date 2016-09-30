---
title: "CComControlBase::m_sizeNatural"
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
  - "CComControlBase::m_sizeNatural"
  - "m_sizeNatural"
  - "CComControlBase.m_sizeNatural"
  - "ATL::CComControlBase::m_sizeNatural"
  - "ATL.CComControlBase.m_sizeNatural"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_sizeNatural"
ms.assetid: 5711c752-0a69-4872-bef6-544ee525cdf1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComControlBase::m_sizeNatural
The physical size of the control in HIMETRIC units (each unit is 0.01 millimeters).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
  
> [!NOTE]
>  To use this data member within your control class, you must declare it as a data member in your control class. Your control class will not inherit this data member from the base class because it is declared within a union in the base class.  
  
 This size is fixed, while the size in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is scaled by the display.  
  
 You can convert the size to pixels with the global function [AtlHiMetricToPixel](../vs140/atlhimetrictopixel.md).  
  
## Requirements  
 **Header:** atlctl.h  
  
## See Also  
 [CComControlBase Class](../vs140/ccomcontrolbase-class.md)   
 [SIZE](http://msdn.microsoft.com/library/windows/desktop/dd145106)   
 [CComControlBase::m_sizeExtent](../vs140/ccomcontrolbase--m_sizeextent.md)