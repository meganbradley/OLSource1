---
title: "COleDispatchDriver::SetProperty"
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
  - "COleDispatchDriver::SetProperty"
  - "COleDispatchDriver.SetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDispatchDriver class, operations"
  - "SetProperty method"
ms.assetid: 2afb483c-3160-427f-80d6-0f8307a165ef
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDispatchDriver::SetProperty
Sets the OLE object property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the property to be set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the type of the property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 A single parameter of the type specified by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCOleContainer#7](../vs140/codesnippet/CPP/coledispatchdriver--setproperty_1.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [COleDispatchDriver Class](../vs140/coledispatchdriver-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md)   
 [COleDispatchDriver::GetProperty](../vs140/coledispatchdriver--getproperty.md)