---
title: "ConvertBSTRToString"
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
  - "ConvertBSTRToString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ConvertBSTRToString function"
ms.assetid: ab6ce555-3d75-4e9c-9cb8-ada6d8ce43b1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ConvertBSTRToString
**Microsoft Specific**  
  
 Converts a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value to a **char \***.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A BSTR variable.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> allocates a string you must delete.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **BSTR text: Test**  
**char \* text: Test**   
## END Microsoft Specific  
  
## Requirements  
 **Header:** comutil.h.  
  
 **Lib:** comsuppw.lib or comsuppwd.lib (see [/Zc:wchar_t (wchar_t Is Native Type)](../vs140/-zc-wchar_t--wchar_t-is-native-type-.md) for more information)  
  
## See Also  
 [Compiler COM Global Functions](../vs140/compiler-com-global-functions.md)