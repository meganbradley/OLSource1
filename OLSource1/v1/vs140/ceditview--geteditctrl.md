---
title: "CEditView::GetEditCtrl"
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
  - "CEditView::GetEditCtrl"
  - "CEditView.GetEditCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEditView class, attributes"
  - "GetEditCtrl method"
ms.assetid: 72169fc2-7207-4023-908b-366faebede3f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEditView::GetEditCtrl
Call <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to get a reference to the edit control used by the edit view.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A reference to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
## Remarks  
 This control is of type [CEdit](../vs140/cedit-class.md), so you can manipulate the Windows edit control directly using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member functions.  
  
> [!CAUTION]
>  Using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object can change the state of the underlying Windows edit control. For example, you should not change the tab settings using the [CEdit::SetTabStops](../vs140/cedit--settabstops.md) function because <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> caches these settings for use both in the edit control and in printing. Instead, use [CEditView::SetTabStops](../vs140/ceditview--settabstops.md).  
  
## Example  
 [!code[NVC_MFCDocView#66](../vs140/codesnippet/CPP/ceditview--geteditctrl_1.cpp)]  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CEditView Class](../vs140/ceditview-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit Class](../vs140/cedit-class.md)   
 [CEditView::SetTabStops](../vs140/ceditview--settabstops.md)