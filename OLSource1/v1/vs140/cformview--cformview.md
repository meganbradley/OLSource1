---
title: "CFormView::CFormView"
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
  - "CFormView.CFormView"
  - "CFormView::CFormView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFormView class, construction/destruction"
  - "CFormView class, constructor"
ms.assetid: 90f54454-cd2b-401e-931e-3353e61a5c11
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFormView::CFormView
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog-template resource.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-template resource.  
  
## Remarks  
 When you create an object of a type derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, invoke one of the constructors to create the view object and identify the dialog resource on which the view is based. You can identify the resource either by name (pass a string as the argument to the constructor) or by its ID (pass an unsigned integer as the argument).  
  
 The form-view window and child controls are not created until <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is called. <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is called by the framework as part of the document and view creation process, which is driven by the document template.  
  
> [!NOTE]
>  Your derived class *must* supply its own constructor. In the constructor, invoke the constructor, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, with the resource name or ID as an argument as shown in the preceding class overview.  
  
## Example  
 [!code[NVC_MFCDocView#90](../vs140/codesnippet/CPP/cformview--cformview_1.h)]  
  
 [!code[NVC_MFCDocView#91](../vs140/codesnippet/CPP/cformview--cformview_2.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CFormView Class](../vs140/cformview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)