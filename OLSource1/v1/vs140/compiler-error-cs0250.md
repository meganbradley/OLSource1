---
title: "Compiler Error CS0250"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CS0250"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0250"
ms.assetid: a994f361-6287-4db0-9ce1-e293a8190049
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0250
Do not directly call your base class Finalize method. It is called automatically from your destructor.  
  
 A program cannot attempt to force cleanup of base class resources.  
  
 See [Finalize Methods and Destructors](assetId:///fd376774-1643-499b-869e-9546a3aeea70) for more information.  
  
 The following sample generates CS0250  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>