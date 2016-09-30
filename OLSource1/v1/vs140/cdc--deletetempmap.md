---
title: "CDC::DeleteTempMap"
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
  - "CDC::DeleteTempMap"
  - "DeleteTempMap"
  - "CDC.DeleteTempMap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DeleteTempMap method"
  - "CDC class, initialization"
ms.assetid: bcca71c0-8444-4c40-bb79-ff079ecf5498
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DeleteTempMap
Called automatically by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> idle-time handler, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> deletes any temporary <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> objects created by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, but does not destroy the device context handles (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>s) temporarily associated with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Detach](../vs140/cdc--detach.md)   
 [CDC::FromHandle](../vs140/cdc--fromhandle.md)   
 [CWinApp::OnIdle](../vs140/cwinapp--onidle.md)