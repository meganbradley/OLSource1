---
title: "CCheckListBox::DrawItem"
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
  - "CCheckListBox.DrawItem"
  - "CCheckListBox::DrawItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawItem method"
ms.assetid: ee57edb7-7410-4ecf-9046-22ac3f24d986
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCheckListBox::DrawItem
Called by the framework when a visual aspect of an owner-drawn checklist box changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A long pointer to a [DRAWITEMSTRUCT](../vs140/drawitemstruct-structure.md) structure that contains information about the type of drawing required.  
  
## Remarks  
 The **itemAction** and **itemState** members of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure define the drawing action that is to be performed.  
  
 By default, this function draws a default checkbox list, consisting of a list of strings each with a default-sized checkbox to the left. The checkbox list size is the one specified in [Create](../vs140/cchecklistbox--create.md).  
  
 Override this member function to implement drawing of owner-draw checklist boxes that are not the default, such as checklist boxes with lists that aren't strings, with variable-height items, or with checkboxes that aren't on the left. The application should restore all graphics device interface (GDI) objects selected for the display context supplied in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> before the termination of this member function.  
  
 If checklist box items are not all the same height, the checklist box style (specified in **Create**) must be **LBS_OWNERVARIABLE**, and you must override the [MeasureItem](../vs140/cchecklistbox--measureitem.md) function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCheckListBox Class](../vs140/cchecklistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCheckListBox::Create](../vs140/cchecklistbox--create.md)   
 [CCheckListBox::MeasureItem](../vs140/cchecklistbox--measureitem.md)