---
title: "COleControl::AmbientDisplayName"
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
  - "COleControl::AmbientDisplayName"
  - "AmbientDisplayName"
  - "COleControl.AmbientDisplayName"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AmbientDisplayName method"
ms.assetid: cc06acc4-c5a1-4e4b-96da-9cd783999cbc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::AmbientDisplayName
The name the container has assigned to the control can be used in error messages displayed to the user.  
  
## Syntax  
  
```  
  
CString AmbientDisplayName( );  
```  
  
## Return Value  
 The name of the OLE control. The default is a zero-length string.  
  
## Remarks  
 Note that the container is not required to support this property.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)