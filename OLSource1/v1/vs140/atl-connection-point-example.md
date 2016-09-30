---
title: "ATL Connection Point Example"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "connection points [C++], examples"
  - "examples [ATL]"
ms.assetid: a49721b7-f308-43de-8868-f662a94bc81a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Connection Point Example
This example shows an object that supports [IPropertyNotifySink](http://msdn.microsoft.com/library/windows/desktop/ms692638) as an outgoing interface:  
  
 [!code[NVC_ATL_Windowing#84](../vs140/codesnippet/CPP/atl-connection-point-example_1.h)]  
  
 When specifying <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> as an outgoing interface, you can use class [IPropertyNotifySinkCP](../vs140/ipropertynotifysinkcp-class.md) instead of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. For example:  
  
 [!code[NVC_ATL_Windowing#85](../vs140/codesnippet/CPP/atl-connection-point-example_2.h)]  
  
## See Also  
 [Connection Point](../vs140/atl-connection-points.md)