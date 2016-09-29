---
title: "How to: Call Windows APIs (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "API calls"
  - "Windows API, calling"
  - "API calls, platform invoke"
  - "calls, stored procedures"
ms.assetid: 27d75f0a-54ab-4ee1-b91d-43513a19b12d
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call Windows APIs (Visual Basic)
This example defines and calls the `MessageBox` function in user32.dll and then passes a string to it.  
  
## Example  
 [!code[VbVbalrInterop#1](../vs140/codesnippet/VisualBasic/how-to--call-windows-apis--visual-basic-_1.vb)]  
  
## Compiling the Code  
 This example requires:  
  
-   A reference to the <xref:System*> namespace.  
  
## Robust Programming  
 The following conditions may cause an exception:  
  
-   The method is not static, is abstract, or has been previously defined. The parent type is an interface, or the length of *name* or *dllName* is zero. (<xref:System.ArgumentException*>)  
  
-   The *name* or *dllName* is `Nothing`. (<xref:System.ArgumentNullException*>)  
  
-   The containing type has been previously created using `CreateType`. (<xref:System.InvalidOperationException*>)  
  
## See Also  
 [A Closer Look at Platform Invoke](assetId:///ba9dd55b-2eaa-45cd-8afd-75cb8d64d243)   
 [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f)   
 [Consuming Unmanaged DLL Functions](assetId:///eca7606e-ebfb-4f47-b8d9-289903fdc045)   
 [Defining a Method with Reflection Emit](assetId:///84fd3bf6-628f-41aa-83d9-b990cf926e81)   
 [Walkthrough: Calling Windows APIs](../vs140/walkthrough--calling-windows-apis--visual-basic-.md)   
 [COM Interop](../vs140/com-interop--visual-basic-.md)