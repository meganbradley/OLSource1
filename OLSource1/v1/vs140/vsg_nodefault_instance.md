---
title: "VSG_NODEFAULT_INSTANCE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 19c95b0d-9a4d-441f-9ed7-3acb39e67521
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VSG_NODEFAULT_INSTANCE
Defines by its presence whether a default instance of the [VsgDbg](../vs140/vsgdbg-class.md) class—which provides the programmatic capture interface—is supplied.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Value  
 A preprocessor symbol that by its presence or absence determines whether a default instance of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class is provided. If this symbol is defined, then no default instance of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class is provided; otherwise, a default instance is provided and initialized before your program runs.  
  
 The programmatic capture interface is provided through a pointer that has global scope, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Remarks  
 The default instance is often sufficient, but to use the programmatic capture interface inside a DLL when the D3D device has been created outside that DLL, you must create and manage your own instance of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class. If you are managing your own interface to the programmatic capture API in this way, disable the default instance by defining <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to avoid overhead.  
  
 If the default instance is not disabled, it is automatically initialized before your program runs and is automatically destroyed when your program ends. You do not have to initialize or uninitialize this instance explicitly.  
  
 To disable the default instance, you must define <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> before you include <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in your program.  
  
## Example  
 This example shows how to disable the default instance:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>