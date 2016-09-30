---
title: "IView Interface"
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
  - "IView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "views [MFC]"
  - "IView class"
  - "views, classes"
ms.assetid: 9321f299-486e-4551-bee9-d2c4a7b91548
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IView Interface
Implements several methods that [CWinFormsView](../vs140/cwinformsview-class.md) uses to send view notifications to a managed control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IView::OnActivateView](../vs140/iview--onactivateview.md)|Called by MFC when a view is activated or deactivated.|  
|[IView::OnInitialUpdate](../vs140/iview--oninitialupdate.md)|Called by the framework after the view is first attached to the document, but before the view is initially displayed.|  
|[IView::OnUpdate](../vs140/iview--onupdate.md)|Called by MFC after the view's document has been modified; this function allows the view to update its display to reflect modifications.|  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> implements several methods that <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> uses to forward common view notifications to a hosted managed control. These are [OnInitialUpdate](../vs140/iview--oninitialupdate.md), [OnUpdate](../vs140/iview--onupdate.md) and [OnActivateView](../vs140/iview--onactivateview.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is similar to [CView](../vs140/cview-class.md), but is used only with managed views and controls.  
  
 For more information on using Windows Forms, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Requirements  
 Header: afxwinforms.h (defined in assembly atlmfc\lib\mfcmifc80.dll)  
  
## See Also  
 [CWinFormsView Class](../vs140/cwinformsview-class.md)   
 [CView Class](../vs140/cview-class.md)