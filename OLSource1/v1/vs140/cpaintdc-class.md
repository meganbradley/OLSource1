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
  
```  
class CPaintDC : public CDC  
```  
  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::CPaintDC](#cpaintdc__cpaintdc)|Constructs a `CPaintDC` connected to the specified [CWnd](../vs140/cwnd-class.md).|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::m_ps](#cpaintdc__m_ps)|Contains the [PAINTSTRUCT](../vs140/paintstruct-structure.md) used to paint the client area.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CPaintDC::m_hWnd](#cpaintdc__m_hwnd)|The `HWND` to which this `CPaintDC` object is attached.|  
  
## Remarks  
 It performs a [CWnd::BeginPaint](../vs140/cwnd-class.md#cwnd__beginpaint) at construction time and [CWnd::EndPaint](../vs140/cwnd-class.md#cwnd__endpaint) at destruction time.  
  
 A `CPaintDC` object can only be used when responding to a                 [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message, usually in your `OnPaint` message-handler member function.  
  
 For more information on using `CPaintDC`, see [Device Contexts](../vs140/device-contexts.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CDC](../vs140/cdc-class.md)  
  
 `CPaintDC`  
  
## Requirements  
 **Header:** afxwin.h  
  
##  <a name="cpaintdc__cpaintdc"></a>  CPaintDC::CPaintDC  
 Constructs a `CPaintDC` object, prepares the application window for painting, and stores the [PAINTSTRUCT](../vs140/paintstruct-structure.md) structure in the [m_ps](#cpaintdc__m_ps) member variable.  
  
```  
explicit CPaintDC(    CWnd* pWnd );  
  
```  
  
### Parameters  
 `pWnd`  
 Points to the `CWnd` object to which the `CPaintDC` object belongs.  
  
### Remarks  
 An exception (of type `CResourceException`) is thrown if the Windows                         [GetDC](http://msdn.microsoft.com/library/windows/desktop/dd144871) call fails. A device context may not be available if Windows has already allocated all of its available device contexts. Your application competes for the five common display contexts available at any given time under Windows.  
  
### Example  
 [!code[NVC_MFCDocView#97](../vs140/codesnippet/CPP/cpaintdc-class_1.cpp)]  
  
##  <a name="cpaintdc__m_hwnd"></a>  CPaintDC::m_hWnd  
 The `HWND` to which this `CPaintDC` object is attached.  
  
```  
HWND m_hWnd;  
  
```  
  
### Remarks  
 `m_hWnd` is a protected variable of type `HWND`.  
  
### Example  
 [!code[NVC_MFCDocView#98](../vs140/codesnippet/CPP/cpaintdc-class_2.cpp)]  
  
##  <a name="cpaintdc__m_ps"></a>  CPaintDC::m_ps  
 `m_ps` is a public member variable of type [PAINTSTRUCT](../vs140/paintstruct-structure.md).  
  
```  
PAINTSTRUCT m_ps;  
  
```  
  
### Remarks  
 It is the `PAINTSTRUCT` that is passed to and filled out by [CWnd::BeginPaint](../vs140/cwnd-class.md#cwnd__beginpaint).  
  
 The `PAINTSTRUCT` contains information that the application uses to paint the client area of the window associated with a `CPaintDC` object.  
  
 Note that you can access the device-context handle through the `PAINTSTRUCT`. However, you can access the handle more directly through the `m_hDC` member variable that `CPaintDC` inherits from `CDC`.  
  
### Example  
  See the example for [CPaintDC::m_hWnd](#cpaintdc__m_hwnd).  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)