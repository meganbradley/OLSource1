---
title: "Compiler Error C2535"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2535"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2535"
ms.assetid: a958f83e-e2bf-4a59-b44b-d406ec325d7e
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2535
'identifier' : member function already defined or declared  
  
 This error could be caused by using the same formal parameter list in more than one definition or declaration of an overloaded function.  
  
 If you get C2535 because of the Dispose function, see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers) for more information.  
  
 If you are compiling an ATL project, see Knowledge Base article Q241852.  
  
 The following sample generates C2535:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>