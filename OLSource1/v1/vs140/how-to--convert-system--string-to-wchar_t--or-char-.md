---
title: "How to: Convert System::String to wchar_t* or char*"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "get-started-article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "System::String, converting to char or wchar_t"
  - "PtrToStringChars method"
  - "System::String"
  - "wchart type, converting System::String"
  - "char data type, converting System::String to"
ms.assetid: 385da01b-5649-4543-8076-e3e251243ff0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert System::String to wchar_t* or char*
You can use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> in Vcclr.h to convert \<xref:System.String*> to native <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  This always returns a wide Unicode string pointer because CLR strings are internally Unicode. You can then convert from wide as shown in the following example.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Hello**  
**Hello**   
## See Also  
 [Using C++ Interop Features](../vs140/using-c---interop--implicit-pinvoke-.md)