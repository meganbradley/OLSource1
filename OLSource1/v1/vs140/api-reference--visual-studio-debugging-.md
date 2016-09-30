---
title: "API Reference (Visual Studio Debugging)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], API reference"
ms.assetid: e4e429da-3667-41f7-9158-a8207d13e91a
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# API Reference (Visual Studio Debugging)
The reference section includes a conceptual overview of the API, a guide that shows the syntax and usage for all API elements, and an assortment of code examples. All references are listed alphabetically by category.  
  
 The following table shows the common <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> values returned by methods.  
  
|Name|Description|Value|  
|----------|-----------------|-----------|  
|S_OK|Success.|0x00000000|  
|E_UNEXPECTED|Unexpected failure.|0x8000FFFF|  
|E_NOTIMPL|Not implemented.|0x80004001|  
|E_OUTOFMEMORY|Not enough memory to complete the operation.|0x8007000E|  
|E_INVALIDARG|One or more arguments are invalid.|0x80070057|  
|E_NOINTERFACE|No such interface supported.|0x80004002|  
|E_POINTER|Invalid pointer.|0x80004003|  
|E_HANDLE|Invalid handle.|0x80070006|  
|E_ABORT|Operation aborted.|0x80004004|  
|E_FAIL|Unexpected failure.|0x80004005|  
|E_ACCESSDENIED|General access denied error.|0x80070005|  
  
> [!NOTE]
>  When a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] debugging method returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, it is assumed that all out parameter pointers are valid, that is, no validation is conducted on out parameter pointers when <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned.  
  
> [!NOTE]
>  Invalid or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [out] parameters may cause the IDE to crash.  
  
## See Also  
 [Interfaces](../vs140/interfaces--visual-studio-debugging-.md)   
 [Enumerations](../vs140/enumerations--visual-studio-debugging-.md)   
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [Debugging SDK Helpers](../vs140/sdk-helpers-for-debugging.md)   
 [Visual Studio Debugging SDK](../vs140/visual-studio-debugger-extensibility.md)