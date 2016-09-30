---
title: "CHwndRenderTarget Class"
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
  - "CHwndRenderTarget"
  - "afxrendertarget/CHwndRenderTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CHwndRenderTarget class"
ms.assetid: aa65b69f-7202-46ea-af81-ef325da0b840
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHwndRenderTarget Class
A wrapper for ID2D1HwndRenderTarget.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHwndRenderTarget::CHwndRenderTarget](#chwndrendertarget__chwndrendertarget)|Constructs a CHwndRenderTarget object from HWND.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHwndRenderTarget::Attach](#chwndrendertarget__attach)|Attaches existing render target interface to the object|  
|[CHwndRenderTarget::CheckWindowState](#chwndrendertarget__checkwindowstate)|Indicates whether the HWND associated with this render target is occluded.|  
|[CHwndRenderTarget::Create](#chwndrendertarget__create)|Creates a render target associated with the window|  
|[CHwndRenderTarget::Detach](#chwndrendertarget__detach)|Detaches render target interface from the object|  
|[CHwndRenderTarget::GetHwnd](#chwndrendertarget__gethwnd)|Returns the HWND associated with this render target.|  
|[CHwndRenderTarget::GetHwndRenderTarget](#chwndrendertarget__gethwndrendertarget)|Returns ID2D1HwndRenderTarget interface.|  
|[CHwndRenderTarget::ReCreate](#chwndrendertarget__recreate)|Re-creates a render target associated with the window|  
|[CHwndRenderTarget::Resize](#chwndrendertarget__resize)|Changes the size of the render target to the specified pixel size|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CHwndRenderTarget::operator ID2D1HwndRenderTarget*](#chwndrendertarget__operator_id2d1hwndrendertarget_star)|Returns ID2D1HwndRenderTarget interface.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CHwndRenderTarget::m_pHwndRenderTarget](#chwndrendertarget__m_phwndrendertarget)|A pointer to an ID2D1HwndRenderTarget object.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CRenderTarget](../vs140/crendertarget-class.md)  
  
 [CHwndRenderTarget](../vs140/chwndrendertarget-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="chwndrendertarget__attach">\</a>  CHwndRenderTarget::Attach  
 Attaches existing render target interface to the object  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Existing render target interface. Cannot be NULL  
  
##  \<a name="chwndrendertarget__checkwindowstate">\</a>  CHwndRenderTarget::CheckWindowState  
 Indicates whether the HWND associated with this render target is occluded.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A value that indicates whether the HWND associated with this render target is occluded.  
  
##  \<a name="chwndrendertarget__chwndrendertarget">\</a>  CHwndRenderTarget::CHwndRenderTarget  
 Constructs a CHwndRenderTarget object from HWND.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The HWND associated with this render target  
  
##  \<a name="chwndrendertarget__create">\</a>  CHwndRenderTarget::Create  
 Creates a render target associated with the window  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 The HWND associated with this render target  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE  
  
##  \<a name="chwndrendertarget__detach">\</a>  CHwndRenderTarget::Detach  
 Detaches render target interface from the object  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached render target interface.  
  
##  \<a name="chwndrendertarget__gethwnd">\</a>  CHwndRenderTarget::GetHwnd  
 Returns the HWND associated with this render target.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The HWND associated with this render target.  
  
##  \<a name="chwndrendertarget__gethwndrendertarget">\</a>  CHwndRenderTarget::GetHwndRenderTarget  
 Returns ID2D1HwndRenderTarget interface.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1HwndRenderTarget interface or NULL if object is not initialized yet.  
  
##  \<a name="chwndrendertarget__m_phwndrendertarget">\</a>  CHwndRenderTarget::m_pHwndRenderTarget  
 A pointer to an ID2D1HwndRenderTarget object.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="chwndrendertarget__operator_id2d1hwndrendertarget_star">\</a>  CHwndRenderTarget::operator ID2D1HwndRenderTarget*  
 Returns ID2D1HwndRenderTarget interface.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1HwndRenderTarget interface or NULL if object is not initialized yet.  
  
##  \<a name="chwndrendertarget__recreate">\</a>  CHwndRenderTarget::ReCreate  
 Re-creates a render target associated with the window  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The HWND associated with this render target  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="chwndrendertarget__resize">\</a>  CHwndRenderTarget::Resize  
 Changes the size of the render target to the specified pixel size  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 The new size of the render target in device pixels  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)