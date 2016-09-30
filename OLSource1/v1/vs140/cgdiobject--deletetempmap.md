---
title: "CGdiObject::DeleteTempMap"
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
  - "CGdiObject.DeleteTempMap"
  - "DeleteTempMap"
  - "CGdiObject::DeleteTempMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteTempMap method"
  - "CGdiObject class, operations"
ms.assetid: e420b381-1efc-43f4-8c22-18e4d1a6265e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::DeleteTempMap
Called automatically by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> idle-time handler, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> deletes any temporary <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects created by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> detaches the Windows GDI object attached to a temporary <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object before deleting the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
## Example  
 [!code[NVC_MFCDocView#175](../vs140/codesnippet/CPP/cgdiobject--deletetempmap_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::Detach](../vs140/cgdiobject--detach.md)   
 [CGdiObject::FromHandle](../vs140/cgdiobject--fromhandle.md)