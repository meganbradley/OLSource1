---
title: "CPropertySheet::OnInitDialog"
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
  - "CPropertySheet.OnInitDialog"
  - "CPropertySheet::OnInitDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnInitDialog method"
ms.assetid: dd6349fa-db8f-460b-bb13-dad5c734f9e9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::OnInitDialog
Overrides to augment property sheet initialization.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Specifies whether the application has set the input focus to one of the controls in the property sheet. If **OnInitDialog** returns nonzero, Windows sets the input focus to the first control in the property sheet. The application can return 0 only if it has explicitly set the input focus to one of the controls in the property sheet.  
  
## Remarks  
 This member function is called in response to the **WM_INITDIALOG** message. This message is sent to the property sheet during the [Create](../vs140/cpropertysheet--create.md) or [DoModal](../vs140/cpropertysheet--domodal.md) calls, which occur immediately before the property sheet is displayed.  
  
 Override this member function if you need to perform special processing when the property sheet is initialized. In the overridden version, first call the base class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> but disregard its return value. You will normally return **TRUE** from your overridden member function.  
  
 You do not need a message-map entry for this member function.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::OnInitDialog](../vs140/cdialog--oninitdialog.md)