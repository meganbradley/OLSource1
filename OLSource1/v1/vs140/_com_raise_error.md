---
title: "_com_raise_error"
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
  - "_com_raise_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_com_raise_error function"
ms.assetid: a98226c2-c3fe-44f1-8ff5-85863de11cd6
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _com_raise_error
**Microsoft Specific**  
  
 Throws a [_com_error](../vs140/_com_error-class.md) in response to a failure.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> information.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **IErrorInfo** object.  
  
## Remarks  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is defined in comdef.h, can be replaced by a user-written version of the same name and prototype. This could be done if you want to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> but do not want to use C++ exception handling. In that case, a user version of **_com_raise_error** might decide to do a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or display a message box and halt. The user version should not return, though, because the compiler COM support code does not expect it to return.  
  
 You can also use [_set_com_error_handler](../vs140/_set_com_error_handler.md) to replace the default error-handling function.  
  
 By default, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is defined as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## END Microsoft Specific  
  
## Requirements  
 **Header:** comdef.h  
  
 **Lib:** If the “wchar_t is Native Type” compiler option is on, use comsuppw.lib or comsuppwd.lib. If “wchar_t is Native Type” is off, use comsupp.lib. For more information, see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md).  
  
## See Also  
 [Compiler COM Global Functions](../vs140/compiler-com-global-functions.md)   
 [_set_com_error_handler](../vs140/_set_com_error_handler.md)