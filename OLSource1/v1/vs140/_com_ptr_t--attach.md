---
title: "_com_ptr_t::Attach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_com_ptr_t::Attach"
  - "_com_ptr_t.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COM interfaces, attach pointer"
  - "Attach method"
ms.assetid: 94c18e0a-06be-4ca7-bdaf-cd54ec0a645e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t::Attach
**Microsoft Specific**  
  
 Encapsulates a raw interface pointer of this smart pointer's type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A raw interface pointer.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If it is **true**, then <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is called. If it is **false**, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object takes ownership of the raw interface pointer without calling <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
  
-   **Attach(**  <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  **)** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not called. The ownership of the interface is passed to this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object. **Release** is called to decrement the reference count for the previously encapsulated pointer.  
  
-   **Attach(**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **)** If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is **true**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called to increment the reference count for the encapsulated interface pointer. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is **false**, this <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object takes ownership of the raw interface pointer without calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>. **Release** is called to decrement the reference count for the previously encapsulated pointer.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)