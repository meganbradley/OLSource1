---
title: "CWindowDC Class"
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
  - "CWindowDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "device contexts, window"
  - "screen output classes"
  - "CWindowDC class"
ms.assetid: 876a3641-4cde-471c-b0d1-fe58b32af79c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWindowDC Class
Derived from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CWindowDC::CWindowDC](#cwindowdc__cwindowdc)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CWindowDC::m_hWnd](#cwindowdc__m_hwnd)|The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to which this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is attached.|  
  
## Remarks  
 Calls the Windows function                 [GetWindowDC](http://msdn.microsoft.com/library/windows/desktop/dd144947\(v=vs.85\).aspx)at construction time and                 [ReleaseDC](http://msdn.microsoft.com/library/windows/desktop/dd162920\(v=vs.85\).aspx) at destruction time. This means that a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object accesses the entire screen area of a [CWnd](../vs140/cwnd-class.md) (both client and nonclient areas).  
  
 For more information on using <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDC](../vs140/cdc-class.md)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 Header: afxwin.h  
  
##  \<a name="cwindowdc__cwindowdc">\</a>  CWindowDC::CWindowDC  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object that accesses the entire screen area (both client and nonclient) of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object pointed to by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The window whose client area the device-context object will access.  
  
### Remarks  
 The constructor calls the Windows function                         [GetWindowDC](http://msdn.microsoft.com/library/windows/desktop/dd144947).  
  
 An exception (of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>) is thrown if the Windows <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
### Example  
 [!code[NVC_MFCDocView#188](../vs140/codesnippet/CPP/cwindowdc-class_1.cpp)]  
  
##  \<a name="cwindowdc__m_hwnd">\</a>  CWindowDC::m_hWnd  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> pointer is used to construct the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is a protected variable of type <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CWindowDC::CWindowDC](#cwindowdc__cwindowdc).  
  
## See Also  
 [Base Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC](../vs140/cdc-class.md)