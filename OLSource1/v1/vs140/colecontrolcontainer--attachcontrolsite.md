---
title: "COleControlContainer::AttachControlSite"
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
  - "COleControlContainer.AttachControlSite"
  - "COleControlContainer::AttachControlSite"
  - "AttachControlSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleControlContainer class, overridables"
  - "AttachControlSite method"
ms.assetid: 90a4f70b-0cab-496c-8198-f0aef1ff64f9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::AttachControlSite
Called by the framework to create and attach a control site.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The ID of the control to be attached.  
  
## Remarks  
 Override this function if you want to customize this process.  
  
> [!NOTE]
>  Use the first form of this function if you are statically linking to the MFC library. Use the second form if you are dynamically linking to the MFC library.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)