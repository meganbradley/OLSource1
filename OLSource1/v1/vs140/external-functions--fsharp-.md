---
title: "External Functions (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "extern keyword [F#]"
  - "platform invoke [F#]"
  - "interoperability with native code [F#]"
ms.assetid: 3f314e31-f5d1-4b50-8b5f-2b982ba42245
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# External Functions (F#)
This topic describes F# language support for calling functions in native code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 In the previous syntax, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> represents arguments that are supplied to the \<xref:System.Runtime.InteropServices.DllImportAttribute*> attribute. The first argument is a string that represents the name of the DLL that contains this function, without the .dll extension. Additional arguments can be supplied for any of the public properties of the \<xref:System.Runtime.InteropServices.DllImportAttribute*> class, such as the calling convention.  
  
 Assume you have a native C++ DLL that contains the following exported function.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can call this function from F# by using the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Interoperability with native code is referred to as *platform invoke* and is a feature of the CLR. For more information, see [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258). The information in that section is applicable to F#.  
  
## See Also  
 [Functions (F#)](../vs140/functions--fsharp-.md)