---
title: "CDC::Attach"
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
  - "CDC::Attach"
  - "CDC.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, initialization"
  - "Attach method [MFC]"
ms.assetid: a5791015-82f0-4f6a-859e-231e7f0c0e06
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::Attach
Use this member function to attach an `hDC` to the `CDC` object.  
  
## Syntax  
  
```  
  
      BOOL Attach(  
   HDC hDC   
);  
```  
  
#### Parameters  
 `hDC`  
 A Windows device context.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The `hDC` is stored in both `m_hDC`, the output device context, and in `m_hAttribDC`, the attribute device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::Detach](../vs140/cdc--detach.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)