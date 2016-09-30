---
title: "CAtlPreviewCtrlImpl Class"
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
  - "atlpreviewctrlimpl/ATL::CAtlPreviewCtrlImpl"
  - "CAtlPreviewCtrlImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlPreviewCtrlImpl class"
ms.assetid: 39b3299e-07e4-4abc-9b6e-b54bfa3b0802
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlPreviewCtrlImpl Class
This class is an ATL implementation of a window that is placed on a host window provided by the Shell  for Rich Preview.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the Windows Runtime.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlPreviewCtrlImpl::~CAtlPreviewCtrlImpl](../vs140/catlpreviewctrlimpl--~catlpreviewctrlimpl.md)|Destructs a preview control object.|  
|[CAtlPreviewCtrlImpl::CAtlPreviewCtrlImpl](../vs140/catlpreviewctrlimpl--catlpreviewctrlimpl.md)|Constructs a preview control object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlPreviewCtrlImpl::Create](../vs140/catlpreviewctrlimpl--create.md)|Called by a Rich Preview handler to create the Windows window.|  
|[CAtlPreviewCtrlImpl::Destroy](../vs140/catlpreviewctrlimpl--destroy.md)|Called by a Rich Preview handler when it needs to destroy this control.|  
|[CAtlPreviewCtrlImpl::Focus](../vs140/catlpreviewctrlimpl--focus.md)|Sets input focus to this control.|  
|[CAtlPreviewCtrlImpl::OnPaint](../vs140/catlpreviewctrlimpl--onpaint.md)|Handles the WM_PAINT message.|  
|[CAtlPreviewCtrlImpl::Redraw](../vs140/catlpreviewctrlimpl--redraw.md)|Tells this control to redraw.|  
|[CAtlPreviewCtrlImpl::SetHost](../vs140/catlpreviewctrlimpl--sethost.md)|Sets a new parent for this control.|  
|[CAtlPreviewCtrlImpl::SetPreviewVisuals](../vs140/catlpreviewctrlimpl--setpreviewvisuals.md)|Called by a Rich Preview handler when it needs to set visuals of rich preview content.|  
|[CAtlPreviewCtrlImpl::SetRect](../vs140/catlpreviewctrlimpl--setrect.md)|Sets a new bounding rectangle for this control.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlPreviewCtrlImpl::DoPaint](../vs140/catlpreviewctrlimpl--dopaint.md)|Called by the framework to render the preview.|  
  
### Protected Constants  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlPreviewCtrlImpl::m_plf](../vs140/catlpreviewctrlimpl--m_plf.md)|Font used to display text in the preview window.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CAtlPreviewCtrlImpl::m_clrBack](../vs140/catlpreviewctrlimpl--m_clrback.md)|Background color of the preview window.|  
|[CAtlPreviewCtrlImpl::m_clrText](../vs140/catlpreviewctrlimpl--m_clrtext.md)|Text color of preview window.|  
  
## Remarks  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 [ATL::CWindowImpl\<CAtlPreviewCtrlImpl>](../vs140/cwindowimpl-class.md)  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** atlpreviewctrlimpl.h  
  
##  \<a name="catlpreviewctrlimpl__catlpreviewctrlimpl">\</a>  CAtlPreviewCtrlImpl::CAtlPreviewCtrlImpl  
 Constructs a preview control object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl___dtorcatlpreviewctrlimpl">\</a>  CAtlPreviewCtrlImpl::~CAtlPreviewCtrlImpl  
 Destructs a preview control object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__create">\</a>  CAtlPreviewCtrlImpl::Create  
 Called by a Rich Preview handler to create the Windows window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A handle to the host window supplied by the Shell for Rich Preview.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the window.  
  
### Return Value  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__destroy">\</a>  CAtlPreviewCtrlImpl::Destroy  
 Called by a Rich Preview handler when it needs to destroy this control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__dopaint">\</a>  CAtlPreviewCtrlImpl::DoPaint  
 Called by the framework to render the preview.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A handle to a device context for painting.  
  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__focus">\</a>  CAtlPreviewCtrlImpl::Focus  
 Sets input focus to this control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__m_clrback">\</a>  CAtlPreviewCtrlImpl::m_clrBack  
 Background color of the preview window.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__m_clrtext">\</a>  CAtlPreviewCtrlImpl::m_clrText  
 Text color of the preview window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__m_plf">\</a>  CAtlPreviewCtrlImpl::m_plf  
 Font used to display text in the preview window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__onpaint">\</a>  CAtlPreviewCtrlImpl::OnPaint  
 Handles the WM_PAINT message.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Set to WM_PAINT.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 This parameter is not used.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 When this function returns, it contains <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
### Return Value  
 Always returns 0.  
  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__redraw">\</a>  CAtlPreviewCtrlImpl::Redraw  
 Tells this control to redraw.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__sethost">\</a>  CAtlPreviewCtrlImpl::SetHost  
 Sets a new parent for this control.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A handle to the new parent window.  
  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__setpreviewvisuals">\</a>  CAtlPreviewCtrlImpl::SetPreviewVisuals  
 Called by a Rich Preview handler when it needs to set visuals of rich preview content.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Background color of the preview window.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Text color of the preview window.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Font used to display text in the preview window.  
  
### Remarks  
  
##  \<a name="catlpreviewctrlimpl__setrect">\</a>  CAtlPreviewCtrlImpl::SetRect  
 Sets a new bounding rectangle for this control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Specifies the new size and position of the preview control.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Specifies whether the control should be redrawn.  
  
### Remarks  
  
## See Also  
 [ATL](../vs140/atl-com-desktop-components.md)