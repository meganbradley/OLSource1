---
title: "nonextensible Attribute"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "nonextensible"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "nonextensible attribute"
  - "dual interfaces, nonextensible attribute"
ms.assetid: 02a4a18b-ffd3-4d53-8fd1-feb1c05ad5ac
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# nonextensible Attribute
If a dual interface will not be extended at run time (that is, you won't provide methods or properties via **IDispatch::Invoke** that are not available via the vtable), you should apply the **nonextensible** attribute to your interface definition. This attribute provides information to client languages (such as Visual Basic) that can be used to enable full code verification at compile time. If this attribute is not supplied, bugs may remain hidden in the client code until run time.  
  
 For more information on the **nonextensible** attribute and an example, see [nonextensible](../vs140/nonextensible.md).  
  
## See Also  
 [Dual Interfaces and ATL](../vs140/dual-interfaces-and-atl.md)