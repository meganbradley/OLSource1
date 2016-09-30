---
title: "_com_ptr_t::GetActiveObject"
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
  - "_com_ptr_t.GetActiveObject"
  - "_com_ptr_t::GetActiveObject"
  - "GetActiveObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetActiveObject method"
ms.assetid: 2fa94853-0410-4620-91f2-136dae923f9f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_ptr_t::GetActiveObject
**Microsoft Specific**  
  
 Attaches to an existing instance of an object given a **CLSID** or **ProgID**.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The **CLSID** of an object.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A Unicode string that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A multibyte string, using the ANSI code page, that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
## Remarks  
 These member functions call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to retrieve a pointer to a running object that has been registered with OLE and then queries for this smart pointer's interface type. The resulting pointer is then encapsulated within this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. **Release** is called to decrement the reference count for the previously encapsulated pointer. This routine returns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to indicate success or failure.  
  
-   **GetActiveObject(**  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  **)** Attaches to an existing instance of an object given a **CLSID**.  
  
-   **GetActiveObject(**  <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  **)** Attaches to an existing instance of an object given a Unicode string that holds either a **CLSID** (starting with "**{**") or a **ProgID**.  
  
-   **GetActiveObject(**  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  **)** Attaches to an existing instance of an object given a multibyte character string that holds either a **CLSID** (starting with "**{**") or a **ProgID**. Calls [MultiByteToWideChar](http://msdn.microsoft.com/library/windows/desktop/dd319072), which assumes that the string is in the ANSI code page rather than an OEM code page.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_com_ptr_t Class](../vs140/_com_ptr_t-class.md)