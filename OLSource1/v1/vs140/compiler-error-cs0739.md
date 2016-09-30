---
title: "Compiler Error CS0739"
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
  - "CS0739"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0739"
ms.assetid: c2a83015-401c-4d85-bb19-ed29800904c1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0739
'type name' duplicate TypeForwardedToAttribute.  
  
 An assembly can have no more than one \<xref:System.Runtime.CompilerServices.TypeForwardedToAttribute*> to an external type.  
  
### To correct this error  
  
1.  Locate and remove the duplicate \<xref:System.Runtime.CompilerServices.TypeForwardedToAttribute*>.  
  
## Example  
 The following code generates CS0739:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Runtime.CompilerServices.TypeForwardedToAttribute*>