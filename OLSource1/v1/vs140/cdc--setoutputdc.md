---
title: "CDC::SetOutputDC"
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
  - "SetOutputDC"
  - "CDC::SetOutputDC"
  - "CDC.SetOutputDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, initialization"
  - "SetOutputDC method"
ms.assetid: b7600ced-49fb-4ac0-bc4b-9da02f0ee558
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetOutputDC
Call this member function to set the output device context, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Windows device context.  
  
## Remarks  
 This member function can only be called when a device context has not been attached to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. This member function sets <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> but does not attach the device context to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetAttribDC](../vs140/cdc--setattribdc.md)   
 [CDC::ReleaseAttribDC](../vs140/cdc--releaseattribdc.md)   
 [CDC::ReleaseOutputDC](../vs140/cdc--releaseoutputdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)