---
title: "_com_ptr_t::CreateInstance"
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
  - "_com_ptr_t::CreateInstance"
  - "_com_ptr_t.CreateInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateInstance method"
ms.assetid: ab89b0e1-9da3-4784-a079-58b17340f111
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t::CreateInstance
**Microsoft Specific**  
  
 Creates a new instance of an object given a **CLSID** or **ProgID**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The **CLSID** of an object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Unicode string that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A multibyte string, using the ANSI code page, that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Context for running executable code.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The outer unknown for [aggregation](../vs140/aggregation.md).  
  
## Remarks  
 These member functions call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to create a new COM object and then queries for this smart pointer's interface type. The resulting pointer is then encapsulated within this <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object. **Release** is called to decrement the reference count for the previously encapsulated pointer. This routine returns the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to indicate success or failure.  
  
-   **CreateInstance(**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  **)** Creates a new running instance of an object given a **CLSID**.  
  
-   **CreateInstance(**  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  **)** Creates a new running instance of an object given a Unicode string that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
-   **CreateInstance(**  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **,**  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  **)** Creates a new running instance of an object given a multibyte character string that holds either a **CLSID** (starting with "**{**") or a **ProgID**. Calls [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072), which assumes that the string is in the ANSI code page rather than an OEM code page.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)