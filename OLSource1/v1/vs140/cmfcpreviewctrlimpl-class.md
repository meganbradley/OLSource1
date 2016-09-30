---
title: "CMFCPreviewCtrlImpl Class"
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
  - "CMFCPreviewCtrlImpl"
  - "afxwin/CMFCPreviewCtrlImpl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCPreviewCtrlImpl class"
ms.assetid: 06257fa0-54c9-478d-9d68-c9698c3f93ed
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPreviewCtrlImpl Class
This class implements a window that is placed on a host window provided by the Shell for Rich Preview.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPreviewCtrlImpl::~CMFCPreviewCtrlImpl](#cmfcpreviewctrlimpl__~cmfcpreviewctrlimpl)|Destructs a preview control object.|  
|[CMFCPreviewCtrlImpl::CMFCPreviewCtrlImpl](#cmfcpreviewctrlimpl__cmfcpreviewctrlimpl)|Constructs a preview control object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPreviewCtrlImpl::Create](#cmfcpreviewctrlimpl__create)|Overloaded. Called by a Rich Preview handler to create the Windows window.|  
|[CMFCPreviewCtrlImpl::Destroy](#cmfcpreviewctrlimpl__destroy)|Called by a Rich Preview handler when it needs to destroy this control.|  
|[CMFCPreviewCtrlImpl::Focus](#cmfcpreviewctrlimpl__focus)|Sets input focus to this control.|  
|[CMFCPreviewCtrlImpl::GetDocument](#cmfcpreviewctrlimpl__getdocument)|Returns a document connected to this preview control.|  
|[CMFCPreviewCtrlImpl::Redraw](#cmfcpreviewctrlimpl__redraw)|Tells this control to redraw.|  
|[CMFCPreviewCtrlImpl::SetDocument](#cmfcpreviewctrlimpl__setdocument)|Called by the preview handler to create a relationship between the document implementation and the preview control.|  
|[CMFCPreviewCtrlImpl::SetHost](#cmfcpreviewctrlimpl__sethost)|Sets a new parent for this control.|  
|[CMFCPreviewCtrlImpl::SetPreviewVisuals](#cmfcpreviewctrlimpl__setpreviewvisuals)|Called by a Rich Preview handler when it needs to set visuals of rich preview content.|  
|[CMFCPreviewCtrlImpl::SetRect](#cmfcpreviewctrlimpl__setrect)|Sets a new bounding rectangle for this control.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPreviewCtrlImpl::DoPaint](#cmfcpreviewctrlimpl__dopaint)|Called by the framework to render the preview.|  
  
### Protected Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCPreviewCtrlImpl::m_clrBackColor](#cmfcpreviewctrlimpl__m_clrbackcolor)|Background color of preview window.|  
|[CMFCPreviewCtrlImpl::m_clrTextColor](#cmfcpreviewctrlimpl__m_clrtextcolor)|Text color of preview window.|  
|[CMFCPreviewCtrlImpl::m_font](#cmfcpreviewctrlimpl__m_font)|Font used to display text in the preview window.|  
|[CMFCPreviewCtrlImpl::m_pDocument](#cmfcpreviewctrlimpl__m_pdocument)|A pointer to a document whose content is previewed in the control.|  
  
## Remarks  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CMFCPreviewCtrlImpl](../vs140/cmfcpreviewctrlimpl-class.md)  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cmfcpreviewctrlimpl__cmfcpreviewctrlimpl">\</a>  CMFCPreviewCtrlImpl::CMFCPreviewCtrlImpl  
 Constructs a preview control object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl___dtorcmfcpreviewctrlimpl">\</a>  CMFCPreviewCtrlImpl::~CMFCPreviewCtrlImpl  
 Destructs a preview control object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__create">\</a>  CMFCPreviewCtrlImpl::Create  
 Overloaded. Called by a Rich Preview handler to create the Windows window.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A handle to the host window supplied by the Shell for Rich Preview.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies the initial size and position of the window.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A pointer to a creation context.  
  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if creation succeeded; otherwise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__destroy">\</a>  CMFCPreviewCtrlImpl::Destroy  
 Called by a Rich Preview handler when it needs to destroy this control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__dopaint">\</a>  CMFCPreviewCtrlImpl::DoPaint  
 Called by the framework to render the preview.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 A pointer to a device context for painting.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__focus">\</a>  CMFCPreviewCtrlImpl::Focus  
 Sets input focus to this control.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__getdocument">\</a>  CMFCPreviewCtrlImpl::GetDocument  
 Returns a document connected to this preview control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to a document, whose content is previewed in the control.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__m_clrbackcolor">\</a>  CMFCPreviewCtrlImpl::m_clrBackColor  
 Background color of the preview window.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__m_clrtextcolor">\</a>  CMFCPreviewCtrlImpl::m_clrTextColor  
 Text color of the preview window.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__m_font">\</a>  CMFCPreviewCtrlImpl::m_font  
 Font used to display text in the preview window.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__m_pdocument">\</a>  CMFCPreviewCtrlImpl::m_pDocument  
 A pointer to a document whose content is previewed in the control.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__redraw">\</a>  CMFCPreviewCtrlImpl::Redraw  
 Tells this control to redraw.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__setdocument">\</a>  CMFCPreviewCtrlImpl::SetDocument  
 Called by the preview handler to create a relationship between the document implementation and the preview control.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to the document implementation.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__sethost">\</a>  CMFCPreviewCtrlImpl::SetHost  
 Sets a new parent for this control.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A handle to the new parent window.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__setpreviewvisuals">\</a>  CMFCPreviewCtrlImpl::SetPreviewVisuals  
 Called by a Rich Preview handler when it needs to set visuals of rich preview content.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Background color of preview window.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Text color of preview window.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Font used to display text in the preview window.  
  
### Remarks  
  
##  \<a name="cmfcpreviewctrlimpl__setrect">\</a>  CMFCPreviewCtrlImpl::SetRect  
 Sets a new bounding rectangle for this control.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Specifies the new size and position of the preview control.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Specifies whether the control should be redrawn.  
  
### Remarks  
 Usually a new bounding rectangle is set when the host control is resized.