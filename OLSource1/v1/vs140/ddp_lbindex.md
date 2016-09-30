---
title: "DDP_LBIndex"
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
  - "DDP_LBIndex"
  - "AFXCTL/DDP_LBIndex"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DDP_LBIndex function"
ms.assetid: e316d783-df93-4bfa-a3c8-7816b5fb9207
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DDP_LBIndex
Call this function in your property page's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> function to synchronize the value of an integer property with the index of the current selection in a list box on the property page.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object. The framework supplies this object to establish the context of the data exchange, including its direction.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The resource ID of the list box control associated with the control property specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The member variable associated with the property page control specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the property specified by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The property name of the control property to be exchanged with the list box string specified by <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function should be called before the corresponding <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function call.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [DDP_LBString](../vs140/ddp_lbstring.md)   
 [DDP_CBIndex](../vs140/ddp_cbindex.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [DDX_LBIndex](../vs140/ddx_lbindex.md)