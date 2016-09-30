---
title: "CDC::Detach"
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
  - "CDC::Detach"
  - "CDC.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
  - "CDC class, initialization"
ms.assetid: 41500f76-6668-4e7b-bfbc-2c6d93f251cf
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Detach
Call this function to detach <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (the output device context) from the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object and set both <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to **NULL**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A Windows device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Attach](../vs140/cdc--attach.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)