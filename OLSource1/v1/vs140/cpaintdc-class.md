---
title: "CPaintDC Class"
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
  - "CPaintDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnPaint handler"
  - "WM_PAINT message"
  - "CPaintDC class"
ms.assetid: 7e245baa-bf9b-403e-a637-7218adf28fab
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaintDC Class
A device-context class derived from [CDC](../vs140/cdc-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::CPaintDC](#cpaintdc__cpaintdc)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> connected to the specified [CWnd](../vs140/cwnd-class.md).|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::m_ps](#cpaintdc__m_ps)|Contains the [PAINTSTRUCT](../vs140/paintstruct-structure.md) used to paint the client area.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::m_hWnd](#cpaintdc__m_hwnd)|The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to which this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object is attached.|  
  
## Remarks  
 It performs a [CWnd::BeginPaint](../vs140/cwnd-class.md#cwnd__beginpaint) at construction time and [CWnd::EndPaint](../vs140/cwnd-class.md#cwnd__endpaint) at destruction time.  
  
 A <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object can only be used when responding to a                 [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message, usually in your <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> message-handler member function.  
  
 For more information on using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDC](../vs140/cdc-class.md)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cpaintdc__cpaintdc">\</a>  CPaintDC::CPaintDC  
 Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object, prepares the application window for painting, and stores the [PAINTSTRUCT](../vs140/paintstruct-structure.md) structure in the [m_ps](#cpaintdc__m_ps) member variable.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Points to the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to which the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object belongs.  
  
### Remarks  
 An exception (of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>) is thrown if the Windows                         [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
### Example  
 [!code[NVC_MFCDocView#97](../vs140/codesnippet/CPP/cpaintdc-class_1.cpp)]  
  
##  \<a name="cpaintdc__m_hwnd">\</a>  CPaintDC::m_hWnd  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> to which this <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object is attached.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is a protected variable of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCDocView#98](../vs140/codesnippet/CPP/cpaintdc-class_2.cpp)]  
  
##  \<a name="cpaintdc__m_ps">\</a>  CPaintDC::m_ps  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is a public member variable of type [PAINTSTRUCT](../vs140/paintstruct-structure.md).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 It is the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> that is passed to and filled out by [CWnd::BeginPaint](../vs140/cwnd-class.md#cwnd__beginpaint).  
  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> contains information that the application uses to paint the client area of the window associated with a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
 Note that you can access the device-context handle through the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. However, you can access the handle more directly through the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> member variable that <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> inherits from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Example  
  See the example for [CPaintDC::m_hWnd](#cpaintdc__m_hwnd).  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)