---
title: "Implementing CComObjectRootEx"
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
  - "CComObjectRootEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComObjectRoot class, implementing"
  - "CComObjectRootEx class"
ms.assetid: 79630c44-f2df-4e9e-b730-400a0ebfbd2b
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing CComObjectRootEx
[CComObjectRootEx](../vs140/ccomobjectrootex-class.md) is essential; all ATL objects must have one instance of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or [CComObjectRoot](../vs140/ccomobjectroot-class.md) in their inheritance. <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> provides the default <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> mechanism based on COM map entries.  
  
 Through its COM map, an object's interfaces are exposed to a client when the client queries for an interface. The query is performed through <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> only handles interfaces in the COM map table.  
  
 You can enter interfaces into the COM map table with the [COM_INTERFACE_ENTRY](../vs140/com_interface_entry--atl-.md) macro or one of its variants. For example, the following code enters the interfaces <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> into the COM map table:  
  
 [!code[NVC_ATL_COM#1](../vs140/codesnippet/CPP/implementing-ccomobjectrootex_1.h)]  
  
## See Also  
 [Fundamentals of ATL COM Objects](../vs140/fundamentals-of-atl-com-objects.md)   
 [COM Map Macros](../vs140/com-map-macros.md)