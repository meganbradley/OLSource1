---
title: "Point of declaration in C++"
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
  - "point of declaration"
ms.assetid: 92ea8707-80cb-497c-b479-f907b8401859
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Point of declaration in C++
A name is considered to be declared immediately after its declarator but before its (optional) initializer. (For more information on declarators, see [Declarators](assetId:///8a7b9b51-92bd-4ac0-b3fe-0c4abe771838).)  
  
 Consider this example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If the point of declaration were *after* the initialization, then the local <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> would be initialized to 7.0, the value of the global variable <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. However, since that is not the case, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is initialized to an undefined value.  
  
## See Also  
 [Scope](../vs140/scope--visual-c---.md)