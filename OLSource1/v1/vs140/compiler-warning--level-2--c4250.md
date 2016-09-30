---
title: "Compiler Warning (level 2) C4250"
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
  - "C4250"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4250"
ms.assetid: d47f7249-6b5a-414b-b2d4-56e5d246a782
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4250
'class1' : inherits 'class2::member' via dominance  
  
 Two or more members have the same name. The one in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is inherited because it is a base class for the other classes that contained this member.  
  
 To suppress C4250, use the [warning](../vs140/warning.md) pragma.  
  
 Because a virtual base class is shared among multiple derived classes, a name in a derived class dominates a name in a base class. For example, given the following class hierarchy, there are two definitions of func inherited within diamond: the vbc::func() instance through the weak class, and the dominant::func() through the dominant class. An unqualified call of func() through a diamond class object, always calls the dominate::func() instance.  If the weak class were to introduce an instance of func(), neither definition would dominate, and the call would be flagged as ambiguous.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Example  
 The following sample generates C4250.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 This sample shows a more complex situation. The following sample generates C4250.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>