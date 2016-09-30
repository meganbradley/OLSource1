---
title: "COleControl::OnDoVerb"
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
  - "OnDoVerb"
  - "COleControl::OnDoVerb"
  - "COleControl.OnDoVerb"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDoVerb method"
ms.assetid: 8b495eae-99aa-41cb-8f13-628f3f91c1cf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnDoVerb
Called by the framework when the container calls the **IOleObject::DoVerb** member function.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index of the control verb to be invoked.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the Windows message that caused the verb to be invoked.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The handle to the parent window of the control. If the execution of the verb creates a window (or windows), <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> should be used as the parent.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a [RECT](../vs140/rect-structure.md) structure into which the coordinates of the control, relative to the container, will be copied.  
  
## Return Value  
 Nonzero if call was successful; otherwise 0.  
  
## Remarks  
 The default implementation uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> message map entries to determine the proper function to invoke.  
  
 Override this function to change the default handling of verb.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ON_OLEVERB](../vs140/on_oleverb.md)   
 [ON_STDOLEVERB](../vs140/on_stdoleverb.md)   
 [COleControl::OnEnumVerbs](../vs140/colecontrol--onenumverbs.md)