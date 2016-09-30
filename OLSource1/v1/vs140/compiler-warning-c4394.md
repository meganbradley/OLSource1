---
title: "Compiler Warning C4394"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4394"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4394"
ms.assetid: 5de94de0-17e3-4e7c-92f4-5c3c1b825120
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning C4394
'function' : per-appdomain symbol should not be marked with __declspec(dllexport)  
  
 A function marked with the [appdomain](../vs140/appdomain.md)<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier is compiled to MSIL (not to native), and export tables ([export](../vs140/export.md)<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier) are not supported for managed functions.  
  
 You can declare a managed function to have public accessibility. For more information, see [Type Visibility](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Type_visibility) and [Member visibility](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Member_visibility).  
  
 C4394 is always issued as an error.  You can turn off this warning with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or **/wd**; see [warning](../vs140/warning.md) or [/w, /Wn, /WX, /Wall, /wln, /wdn, /wen, /won (Warning Level)](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) for more information.  
  
## Example  
 The following sample generates C4394.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>