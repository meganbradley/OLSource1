---
title: "Compiler Error C2597"
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
  - "C2597"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2597"
ms.assetid: 2e48127d-e3ff-4a40-8156-2863e45b1a38
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2597
illegal reference to non-static member 'identifier'  
  
 Possible causes:  
  
1.  A nonstatic member is specified in a static member function. To access the nonstatic member, you must pass in or create a local instance of the class and use a member-access operator (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>).  
  
2.  The specified identifier is not a member of a class, structure, or union. Check identifier spelling.  
  
3.  A member access operator refers to a nonmember function.  
  
4.  The following sample generates C2597 and shows how to fix it:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>