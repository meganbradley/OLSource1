---
title: "COleControlSite::SafeSetProperty"
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
  - "COleControlSite::SafeSetProperty"
  - "COleControlSite.SafeSetProperty"
  - "SafeSetProperty"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlSite class, overridables"
  - "SafeSetProperty method"
ms.assetid: 9af45511-6b0a-4e70-9309-fd313efb83cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::SafeSetProperty
Sets the control property specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the dispatch ID of the property or method, found on the control's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface, to be set.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the type of property to be set. For possible values, see the Remarks section for [COleDispatchDriver::InvokeHelper](../vs140/coledispatchdriver--invokehelper.md).  
  
 *...*  
 A single parameter of the type specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
  
> [!NOTE]
>  Unlike <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, if an error is encountered (such as trying to set a nonexistent property), no exception is thrown.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControlSite::SetProperty](../vs140/colecontrolsite--setproperty.md)