---
title: "COleControl::OnEdit"
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
  - "OnEdit"
  - "COleControl::OnEdit"
  - "COleControl.OnEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnEdit method"
ms.assetid: e4631397-b23d-4dd4-b0a4-643eb2e4552b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnEdit
Causes the control to be UI activated.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the Windows message that invoked the verb.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to the parent window of the control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the rectangle used by the control in the container.  
  
## Return Value  
 Nonzero if the call is successful; otherwise 0.  
  
## Remarks  
 This has the same effect as invoking the control's <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> verb.  
  
 This function is typically used as the handler function for an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message map entry. This makes an "Edit" verb available on the control's "Object" menu. For example:  
  
 [!code[NVC_MFCAxCtl#5](../vs140/codesnippet/CPP/colecontrol--onedit_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)