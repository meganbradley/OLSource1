---
title: "COleControlContainer::HandleWindowlessMessage"
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
  - "COleControlContainer::HandleWindowslessMessage"
  - "COleControlContainer.HandleWindowlessMessage"
  - "COleControlContainer.HandleWindowslessMessage"
  - "HandleWindowlessMessage"
  - "COleControlContainer::HandleWindowlessMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "HandleWindowlessMessage method"
ms.assetid: b8573232-27dc-4477-a14e-d8c293e70082
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::HandleWindowlessMessage
Processes window messages for windowless controls.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The identifier for the window message, provided by Windows.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Parameter of the message; provided by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Parameter of the message; provided by Windows. Specifies additional message-specific information. The contents of this parameter depend on the value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
 *plResult*  
 Windows result code. Specifies the result of the message processing and depends on the message sent.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 Override this function to customize the handling of windowless control messages.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)