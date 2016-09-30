---
title: "Compiler Error CS1906"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS1906"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1906"
ms.assetid: 1a6abf5c-f673-4256-93ac-313dce50acc0
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1906
Invalid option 'option'; Resource visibility must be either 'public' or 'private'  
  
 This error indicates an invalid [/resource (Embed Resource File to Output)](../vs140/-resource--csharp-compiler-options-.md) or [/linkresource (Link to .NET Framework Resource)](../vs140/-linkresource--csharp-compiler-options-.md) command line option. Check the syntax of the **/resource** or **/linkresource** command line option, and make sure that the accessibility modifier used is either **public** or <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>.