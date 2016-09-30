---
title: "COleControlSite::GetProperty"
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
  - "COleControlSite.GetProperty"
  - "COleControlSite::GetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetProperty method"
  - "COleControlSite class, overridables"
ms.assetid: ad7359d1-cecb-429a-90d1-0248d62f737e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::GetProperty
Gets the control property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the dispatch ID of the property, found on the control's default <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface, to be retrieved.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the type of the property to be retrieved. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Address of the variable that will receive the property value. It must match the type specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The value is returned through <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)