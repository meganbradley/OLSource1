---
title: "PX_Font"
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
  - "AFXCTL/PX_Font"
  - "PX_Font"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PX_Font function"
ms.assetid: fbf919b7-c239-4e1e-8f26-634f859ffcfe
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# PX_Font
Call this function within your control's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to serialize or initialize a property of type font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the [CPropExchange](../vs140/cpropexchange-class.md) object (typically passed as a parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The name of the property being exchanged.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that contains the font property.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a **FONTDESC** structure containing the values to use in initializing the default state of the font property, in the case where <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **NULL**.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the **IFontDisp** interface of a font to use in initializing the default state of the font property.  
  
## Return Value  
 Nonzero if the exchange was successful; 0 if unsuccessful.  
  
## Remarks  
 The property's value is read from or written to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> reference, when appropriate. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> are specified, they are used for initializing the property's default value, when needed. These values are used if, for any reason, the control's serialization process fails. Typically, you pass **NULL** for <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and the ambient value returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Note that the font object returned by <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> must be released by a call to the **IFontDisp::Release** member function.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [COleControl::DoPropExchange](../vs140/colecontrol--dopropexchange.md)   
 [COleControl::AmbientFont](../vs140/colecontrol--ambientfont.md)