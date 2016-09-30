---
title: "Bad checksum value, non hex digits or odd number of hex digits"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "bc42033"
  - "vbc42033"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC42033"
ms.assetid: 4575554d-3615-46e4-9c6a-18e9c338e4ed
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bad checksum value, non hex digits or odd number of hex digits
A checksum value contains invalid hexadecimal digits or has an odd number of digits.  
  
 When ASP.NET generates a Visual Basic source file (extension .vb), it calculates a checksum and places it in a hidden source file identified by <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. It is possible for a user generating a .vb file to do this also, but this process is best left to internal use.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42033  
  
### To correct this error  
  
1.  If ASP.NET is generating the Visual Basic source file, restart the project build.  
  
2.  If this warning persists after restarting, reinstall ASP.NET and try the build again.  
  
3.  If the warning still persists, or if you are not using ASP.NET, gather information about the circumstances and notify Microsoft Product Support Services.  
  
## See Also  
 [ASP.NET Overview](assetId:///63389df5-8867-43e0-ad7e-41c19ba98ea4)   
 [Product Support and Accessibility](../vs140/talk-to-us.md)