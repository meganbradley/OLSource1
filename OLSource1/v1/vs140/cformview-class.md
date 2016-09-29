---
title: "CFormView Class"
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
  - "CFormView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views, containing controls"
  - "CFormView class"
  - "form views"
ms.assetid: a99ec313-36f0-4f28-9d2b-de11de14ac19
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFormView Class
The base class used for form views.  
  
## Syntax  
  
```  
class CFormView : public CScrollView  
```  
  
## Members  
  
### Protected Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFormView::CFormView](#cformview__cformview)|Constructs a `CFormView` object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFormView::IsInitDlgCompleted](#cformview__isinitdlgcompleted)|Used for synchronization during initialization.|  
  
## Remarks  
 A form view is essentially a view that contains controls. These controls are laid out based on a dialog-template resource. Use `CFormView` if you want forms in your application. These views support scrolling, as needed, using the [CScrollView](../vs140/cscrollview-class.md) functionality.  
  
 When you are [Creating a Forms-Based Application](../vs140/creating-a-forms-based-mfc-application.md), you can base its view class on `CFormView`, making it a forms-based application.  
  
 You can also insert new [Form Topics](../vs140/form-views--mfc-.md) into document-view-based applications. Even if your application did not initially support forms, Visual C++ will add this support when you insert a new form.  
  
 The MFC Application Wizard and the Add Class command are the preferred methods for creating forms-based applications. If you need to create a forms-based application without using these methods, see [Creating a Forms-Based Application](../vs140/creating-a-forms-based-mfc-application.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CView](../vs140/cview-class.md)  
  
 [CScrollView](../vs140/cscrollview-class.md)  
  
 `CFormView`  
  
## Requirements  
 **Header:** afxext.h  
  
##  <a name="cformview__cformview"></a>  CFormView::CFormView  
 Constructs a `CFormView` object.  
  
```  
CFormView(    LPCTSTR lpszTemplateName ); CFormView(    UINT nIDTemplate );  
  
```  
  
### Parameters  
 `lpszTemplateName`  
 Contains a null-terminated string that is the name of a dialog-template resource.  
  
 `nIDTemplate`  
 Contains the ID number of a dialog-template resource.  
  
### Remarks  
 When you create an object of a type derived from `CFormView`, invoke one of the constructors to create the view object and identify the dialog resource on which the view is based. You can identify the resource either by name (pass a string as the argument to the constructor) or by its ID (pass an unsigned integer as the argument).  
  
 The form-view window and child controls are not created until `CWnd::Create` is called. `CWnd::Create` is called by the framework as part of the document and view creation process, which is driven by the document template.  
  
> [!NOTE]
>  Your derived class                             *must* supply its own constructor. In the constructor, invoke the constructor, `CFormView::CFormView`, with the resource name or ID as an argument as shown in the preceding class overview.  
  
### Example  
 [!code[NVC_MFCDocView#90](../vs140/codesnippet/CPP/cformview-class_1.h)]  
  
 [!code[NVC_MFCDocView#91](../vs140/codesnippet/CPP/cformview-class_2.cpp)]  
  
##  <a name="cformview__isinitdlgcompleted"></a>  CFormView::IsInitDlgCompleted  
 Used by MFC to ensure that initialization is completed before performing other operations.  
  
```  
BOOL IsInitDlgCompleted( ) const;  
  
```  
  
### Return Value  
 True if the initialization function for this dialog has completed.  
  
## See Also  
 [MFC Sample SNAPVW](../vs140/visual-c---samples.md)   
 [MFC Sample VIEWEX](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cscrollview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog](../vs140/cdialog-class.md)   
 [CScrollView](../vs140/cscrollview-class.md)   
 [CView::OnUpdate](../vs140/cview-class.md#cview__onupdate)   
 [CView::OnInitialUpdate](../vs140/cview-class.md#cview__oninitialupdate)   
 [CView::OnPrint](../vs140/cview-class.md#cview__onprint)   
 [CWnd::UpdateData](../vs140/cwnd-class.md#cwnd__updatedata)   
 [CScrollView::ResizeParentToFit](../vs140/cscrollview-class.md#cscrollview__resizeparenttofit)