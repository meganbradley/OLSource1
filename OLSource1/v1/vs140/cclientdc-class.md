---
title: "CClientDC Class"
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
  - "CClientDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CClientDC class"
  - "device contexts, client area"
  - "client-area device context"
  - "CDC class, device contexts for client areas"
ms.assetid: 8a871d6b-06f8-496e-9fa3-9a5780848369
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CClientDC Class
Takes care of calling the Windows functions             [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) at construction time and             [ReleaseDC](http://msdn.microsoft.com/library/windows/desktop/dd162920) at destruction time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CClientDC::CClientDC](#cclientdc__cclientdc)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object connected to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CClientDC::m_hWnd](#cclientdc__m_hwnd)|The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> of the window for which this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is valid.|  
  
## Remarks  
 This means that the device context associated with a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is the client area of a window.  
  
 For more information on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDC](../vs140/cdc-class.md)  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cclientdc__cclientdc">\</a>  CClientDC::CClientDC  
 Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object that accesses the client area of the [CWnd](../vs140/cwnd-class.md) pointed to by <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The window whose client area the device context object will access.  
  
### Remarks  
 The constructor calls the Windows function                         [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871).  
  
 An exception (of type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) is thrown if the Windows <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
### Example  
 [!code[NVC_MFCDocView#42](../vs140/codesnippet/CPP/cclientdc-class_1.cpp)]  
  
##  \<a name="cclientdc__m_hwnd">\</a>  CClientDC::m_hWnd  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> pointer used to construct the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a protected variable.  
  
### Example  
  See the example for [CClientDC::CClientDC](#cclientdc__cclientdc).  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC](../vs140/cdc-class.md)