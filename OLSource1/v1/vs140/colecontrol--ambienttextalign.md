---
title: "COleControl::AmbientTextAlign"
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
  - "COleControl.AmbientTextAlign"
  - "AmbientTextAlign"
  - "COleControl::AmbientTextAlign"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AmbientTextAlign method"
ms.assetid: 3491d85b-60e9-49f9-b027-6a6d8a2b7e1d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::AmbientTextAlign
Determines the ambient text alignment preferred by the control container.  
  
## Syntax  
  
```  
  
short AmbientTextAlign( );  
```  
  
## Return Value  
 The status of the container's ambient TextAlign property. If this property is not supported, this function returns 0.  
  
 The following is a list of valid return values:  
  
|Return value|Meaning|  
|------------------|-------------|  
|0|General alignment (numbers to the right, text to the left).|  
|1|Left justify|  
|2|Center|  
|3|Right justify|  
  
## Remarks  
 This property is available to all embedded controls and is defined by the container. Note that the container is not required to support this property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)