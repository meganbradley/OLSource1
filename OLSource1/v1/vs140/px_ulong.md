---
title: "PX_ULong"
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
  - "PX_ULong"
  - "AFXCTL/PX_ULong"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_ULong function"
ms.assetid: 0d9effeb-9313-48a3-99b5-f4eb7c5c8e12
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_ULong
Call this function within your control's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to serialize or initialize a property of type **ULONG**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Name of the property being exchanged.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Reference to the variable where the property is stored (typically a member variable of your class).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Default value for the property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to the variable referenced by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, as appropriate. If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is specified, it will be used as the property's default value. This value is used if, for any reason, the control's serialization process fails.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)