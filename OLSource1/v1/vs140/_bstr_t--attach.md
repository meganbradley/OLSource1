---
title: "_bstr_t::Attach"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "_bstr_t::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: 8cad867e-40fc-435b-841f-0d412c2f58d3
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _bstr_t::Attach
**Microsoft Specific**  
  
 Links a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> wrapper to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *s*  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be associated with, or assigned to, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> variable.  
  
## Remarks  
 If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> was previously attached to another <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will clean up the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> resource, if no other <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> variables are using the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Example  
 See [_bstr_t::Assign](../vs140/_bstr_t--assign.md) for an example using **Attach**.  
  
 **END Microsoft Specific**  
  
## See Also  
 [_bstr_t Class](../vs140/_bstr_t-class.md)