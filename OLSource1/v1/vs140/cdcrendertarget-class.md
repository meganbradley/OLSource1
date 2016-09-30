---
title: "CDCRenderTarget Class"
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
  - "afxrendertarget/CDCRenderTarget"
  - "CDCRenderTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDCRenderTarget class"
ms.assetid: aa8059c9-08e6-49e4-9b8c-00fa54077a61
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDCRenderTarget Class
A wrapper for ID2D1DCRenderTarget.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDCRenderTarget::CDCRenderTarget](#cdcrendertarget__cdcrendertarget)|Constructs a CDCRenderTarget object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDCRenderTarget::Attach](#cdcrendertarget__attach)|Attaches existing render target interface to the object|  
|[CDCRenderTarget::BindDC](#cdcrendertarget__binddc)|Binds the render target to the device context to which it issues drawing commands|  
|[CDCRenderTarget::Create](#cdcrendertarget__create)|Creates a CDCRenderTarget.|  
|[CDCRenderTarget::Detach](#cdcrendertarget__detach)|Detaches render target interface from the object|  
|[CDCRenderTarget::GetDCRenderTarget](#cdcrendertarget__getdcrendertarget)|Returns ID2D1DCRenderTarget interface|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CDCRenderTarget::operator ID2D1DCRenderTarget*](#cdcrendertarget__operator_id2d1dcrendertarget_star)|Returns ID2D1DCRenderTarget interface|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CDCRenderTarget::m_pDCRenderTarget](#cdcrendertarget__m_pdcrendertarget)|A pointer to an ID2D1DCRenderTarget object.|  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CRenderTarget](../vs140/crendertarget-class.md)  
  
 [CDCRenderTarget](../vs140/cdcrendertarget-class.md)  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
##  \<a name="cdcrendertarget__attach">\</a>  CDCRenderTarget::Attach  
 Attaches existing render target interface to the object  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Existing render target interface. Cannot be NULL  
  
##  \<a name="cdcrendertarget__binddc">\</a>  CDCRenderTarget::BindDC  
 Binds the render target to the device context to which it issues drawing commands  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The device context to which the render target issues drawing commands  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The dimensions of the handle to a device context (HDC) to which the render target is bound  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cdcrendertarget__cdcrendertarget">\</a>  CDCRenderTarget::CDCRenderTarget  
 Constructs a CDCRenderTarget object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cdcrendertarget__create">\</a>  CDCRenderTarget::Create  
 Creates a CDCRenderTarget.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The rendering mode, pixel format, remoting options, DPI information, and the minimum DirectX support required for hardware rendering.  
  
### Return Value  
 If the method succeeds, it returns TRUE. Otherwise, it returns FALSE.  
  
##  \<a name="cdcrendertarget__detach">\</a>  CDCRenderTarget::Detach  
 Detaches render target interface from the object  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to detached render target interface.  
  
##  \<a name="cdcrendertarget__getdcrendertarget">\</a>  CDCRenderTarget::GetDCRenderTarget  
 Returns ID2D1DCRenderTarget interface  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1DCRenderTarget interface or NULL if object is not initialized yet.  
  
##  \<a name="cdcrendertarget__m_pdcrendertarget">\</a>  CDCRenderTarget::m_pDCRenderTarget  
 A pointer to an ID2D1DCRenderTarget object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
##  \<a name="cdcrendertarget__operator_id2d1dcrendertarget_star">\</a>  CDCRenderTarget::operator ID2D1DCRenderTarget*  
 Returns ID2D1DCRenderTarget interface  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Pointer to an ID2D1DCRenderTarget interface or NULL if object is not initialized yet.  
  
## See Also  
 [MFC Classes](../vs140/mfc-classes.md)