---
title: "COleControl::GetFont"
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
  - "COleControl::GetFont"
  - "COleControl.GetFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetFont method"
ms.assetid: c7cba46c-ae1a-4941-abd4-8ae24bda1e98
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetFont
Implements the Get function of the stock Font property.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the font dispatch interface of the control's stock Font property.  
  
## Remarks  
 Note that the caller must release the object when finished. Within the implementation of the control, use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to access the control's stock Font object. For more information on using fonts in your control, see the article [ActiveX Controls: Using Fonts in an ActiveX Control](../vs140/mfc-activex-controls--using-fonts.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetFont](../vs140/colecontrol--setfont.md)   
 [COleControl::AmbientFont](../vs140/colecontrol--ambientfont.md)   
 [COleControl::InternalGetFont](../vs140/colecontrol--internalgetfont.md)