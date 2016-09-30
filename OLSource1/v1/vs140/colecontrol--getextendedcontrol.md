---
title: "COleControl::GetExtendedControl"
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
  - "COleControl::GetExtendedControl"
  - "GetExtendedControl"
  - "COleControl.GetExtendedControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetExtendedControl method"
ms.assetid: 49d97456-2523-42ae-b491-d59d1858cfb0
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetExtendedControl
Obtains a pointer to an object maintained by the container that represents the control with an extended set of properties.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to the container's extended control object. If there is no object available, the value is **NULL**.  
  
 This object may be manipulated through its <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> interface. You can also use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to obtain other available interfaces provided by the object. However, the object is not required to support a specific set of interfaces. Note that relying on the specific features of a container's extended control object limits the portability of your control to other arbitrary containers.  
  
## Remarks  
 The function that calls this function is responsible for releasing the pointer when finished with the object. Note that the container is not required to support this object.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)