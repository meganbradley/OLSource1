---
title: "Compiler Error C2584"
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
  - "C2584"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2584"
ms.assetid: 836e2c0a-86c0-4742-b432-beb0191ad20e
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2584
'Class' : direct base 'Base2' is inaccessible; already a base of 'Base1'  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> already derives directly from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> also derives from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> cannot derive from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> because that would mean inheriting (indirectly) from <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> again, which is not legal because <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is already a direct base class.  
  
## Example  
 The following sample generates C2584.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>