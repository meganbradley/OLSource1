---
title: "DDP_Check"
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
  - "DDP_Check"
  - "AFXCTL/DDP_Check"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_Check function"
ms.assetid: fe8b35e5-fce7-42ab-b56b-405ae3bb9ab1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_Check
Call this function in your property page's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function to synchronize the value of the property with the associated property page check box control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The resource ID of the check box control associated with the control property specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The member variable associated with the property page control specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the property specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The property name of the control property to be exchanged with the check box control specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function should be called before the corresponding <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_Radio](../vs140/ddp_radio.md)   
 [DDP_Text](../vs140/ddp_text.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [DDX_Check](../vs140/ddx_check.md)