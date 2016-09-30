---
title: "DDP_PostProcessing"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DDP_PostProcessing"
  - "AFXCTL/DDP_PostProcessing"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_PostProcessing function"
ms.assetid: abafd331-8eec-40d7-b39c-9bcbab2757be
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_PostProcessing
Call this function in your property page's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function, to finish the transfer of property values from the property page to your control when property values are being saved.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
## Remarks  
 This function should be called after all data exchange functions are completed. For example:  
  
 [!code[NVC_MFCAxCtl#15](../vs140/codesnippet/CPP/ddp_postprocessing_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)