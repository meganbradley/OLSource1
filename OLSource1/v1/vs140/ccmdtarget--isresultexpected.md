---
title: "CCmdTarget::IsResultExpected"
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
  - "CCmdTarget::IsResultExpected"
  - "IsResultExpected"
  - "CCmdTarget.IsResultExpected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsResultExpected method"
  - "CCmdTarget, attributes"
  - "CCmdTarget"
ms.assetid: f8999cbf-cbc3-447a-9674-e376ad28b0b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CCmdTarget::IsResultExpected
Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to ascertain whether a client expects a return value from its call to an automation function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if an automation function should return a value; otherwise 0.  
  
## Remarks  
 The OLE interface supplies information to MFC about whether the client is using or ignoring the result of a function call, and MFC in turn uses this information to determine the result of a call to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. If production of a return value is time- or resource-intensive, you can increase efficiency by calling this function before computing the return value.  
  
 This function returns 0 only once so that you will get valid return values from other automation functions if you call them from the automation function that the client has called.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returns a nonzero value if called when an automation function call is not in progress.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CCmdTarget Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdTarget::GetIDispatch](../vs140/ccmdtarget--getidispatch.md)   
 [CCmdTarget::EnableAutomation](../vs140/ccmdtarget--enableautomation.md)