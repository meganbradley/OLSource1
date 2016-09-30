---
title: "CMFCToolBarButton::OnSize"
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
  - "OnSize"
  - "CMFCToolBarButton.OnSize"
  - "CMFCToolBarButton::OnSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSize method"
ms.assetid: 073cba4c-881b-41b2-b1c5-327a4486a37d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnSize
Called by the framework when the parent toolbar changes its size or position and this change causes the button to change size.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new width of the button.  
  
## Remarks  
 The default implementation of this method does nothing. Override this method to resize the button when the size or position of the parent toolbar changes.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)