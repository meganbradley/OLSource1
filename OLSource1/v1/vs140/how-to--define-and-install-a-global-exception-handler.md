---
title: "How to: Define and Install a Global Exception Handler"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "handlers, global"
ms.assetid: dd88a812-3bc7-4ce8-8283-4b674c246534
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define and Install a Global Exception Handler
The following code example demonstrates how unhandled exceptions can be captured. The example form contains a button that, when pressed, performs a null reference, causing an exception to be thrown. This functionality represents a typical code failure. The resulting exception is caught by the application-wide exception handler installed by the main function.  
  
 This is accomplished by binding a delegate to the \<xref:System.Windows.Forms.Application.ThreadException*> event. In this case, subsequent exceptions are then sent to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Exception Handling under /clr](../vs140/exception-handling---c---component-extensions-.md)