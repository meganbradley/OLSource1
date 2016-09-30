---
title: "_set_com_error_handler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_set_com_error_handler function"
ms.assetid: 49fe4fca-5e37-4d83-abaf-15be5ce37f94
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _set_com_error_handler
**Microsoft Specific**  
  
 Replaces the default function that is used for COM error-handling.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the replacement function.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Remarks  
 By default, [_com_raise_error](../vs140/_com_raise_error.md) handles all COM errors. You can change this behavior by using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to call your own error-handling function.  
  
 The replacement function must have a signature that is equivalent to that of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Exception raised: Unable to establish the connection!**   
## Requirements  
 **Header:** comdef.h  
  
 **Lib:** If the “wchar_t is Native Type” compiler option is on, use comsuppw.lib or comsuppwd.lib. If “wchar_t is Native Type” is off, use comsupp.lib. For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md).  
  
## See Also  
 [Compiler COM Global Functions](../vs140/compiler-com-global-functions.md)