---
title: "ON_OLEVERB"
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
  - "ON_OLEVERB"
  - "AFXOLE/ON_OLEVERB"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ON_OLEVERB macro"
ms.assetid: 9e742a83-4a0a-4368-9c26-7b18a08aedfd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ON_OLEVERB
This macro defines a message map entry that maps a custom verb to a specific member function of your control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *idsVerbName*  
 The string resource ID of the verb's name.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The function called by the framework when the verb is invoked.  
  
## Remarks  
 The resource editor can be used to create custom verb names that are added to your string table.  
  
 The function prototype for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is:  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 The values of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> parameters are taken from the corresponding parameters of the **IOleObject::DoVerb** member function.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ON_STDOLEVERB](../vs140/on_stdoleverb.md)