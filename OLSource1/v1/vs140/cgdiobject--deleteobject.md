---
title: "CGdiObject::DeleteObject"
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
  - "CGdiObject.DeleteObject"
  - "DeleteObject"
  - "CGdiObject::DeleteObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteObject method"
  - "CGdiObject class, operations"
ms.assetid: de86208a-d47b-497f-a33b-96e8564dc359
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::DeleteObject
Deletes the attached Windows GDI object from memory by freeing all system storage associated with the Windows GDI object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the GDI object was successfully deleted; otherwise 0.  
  
## Remarks  
 The storage associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object is not affected by this call. An application should not call <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that is currently selected into a device context.  
  
 When a pattern brush is deleted, the bitmap associated with the brush is not deleted. The bitmap must be deleted independently.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::Detach](../vs140/cgdiobject--detach.md)